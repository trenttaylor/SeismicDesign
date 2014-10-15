/* STRUCTURAL DYNAMICS - DYNAMIC RESPONSE ASSIGNMENT
 * Author: Trent Taylor
 * Date: 14 Oct 2014
*/

/*
 * This file creates the seismic data records.
 * 1st- Parse the data based off of file format
 * 2nd- Filter
 * 3rd- Perform the Numeric Integration
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seismic_Design
{
  public class SeismicData
  {
    String m_name;
    String m_filename;
    List<String> m_lines;
    Double m_sampleRate; //samples/sec
    List<SeismicRecord> m_seismicRecords = new List<SeismicRecord>();
    DateTime m_startTime;
    MainForm m_mainForm;

    public SeismicData(String name, MainForm mainForm)
    {
      m_name = name;
      m_filename = name;
      m_mainForm = mainForm;
    }

    public List<SeismicRecord> SeismicRecords
    {
      get { return m_seismicRecords; }
    }

    public string filename
    {
      get { return m_filename; }
      set { m_filename = value; }
    }

    public string name
    {
      get { return m_name; }
      set { m_name = value; }
    }

    public List<String> lines
    {
      get { return m_lines; }
      set { m_lines = value; }
    }

    public DateTime Time
    {
      get { return m_startTime; }
      set { m_startTime = value; }
    }

    public class SeismicRecord
    {
      Double m_acceleration;
      Double m_filteredAcceleration;
      Double m_filteredVelocity;
      Double m_filteredDisplacement;
      DateTime m_time;

      public SeismicRecord(Double acceleration)
      {
        m_acceleration = acceleration;

      }

      public SeismicRecord(Double acceleration, DateTime time)
      {
        m_acceleration = acceleration;
        m_time = time;

      }

      public double Acceleration
      {
        get { return m_acceleration; }
        set { m_acceleration = value; }
      }

      public double FilteredAcceleration
      {
        get { return m_filteredAcceleration; }
        set { m_filteredAcceleration = value; }
      }

      public double Velocity
      {
        get { return m_filteredVelocity; }
        set { m_filteredVelocity = value; }
      }

      public double Displacement
      {
        get { return m_filteredDisplacement; }
        set { m_filteredDisplacement = value; }
      }

      public DateTime Time
      {
        get { return m_time; }
        set { m_time = value; }
      }
    }

    internal bool ProcessInput()
    {
      bool result = false;

      String caseSwitch = Path.GetExtension(m_filename);
      switch (caseSwitch)
      {
        case ".smc":
          ParseSMC();
          result = true;
          break;

        case ".sa":
          ParseSa(m_filename);
          result = true;
          break;

        case ".sa2":
          ParseSa2(m_filename);
          result = true;
          break;

        default:
          throw new Exception("Unknown File Type.");

      }
      return result;
    }

    internal void ParseSMC()
    {
      ClearData();

      //read header data

      List<Int32> integerHeaders = new List<Int32>();
      List<Double> doubleHeaders = new List<Double>();

      System.IO.StreamReader file = new System.IO.StreamReader(m_filename);
      List<String> lines = new List<String>();
      String line;
      DateTime currentTime;
      int i = 0;
      while ((line = file.ReadLine()) != null && lines.Count() <= 26)
      {
        lines.Add(line);
        if (i >= 11 && i <= 16)
        {
          List<String> parse = new List<string>();
          parse.AddRange(line.Split(' ').ToList());
          parse.RemoveAll(x => x == "");
          parse.RemoveAll(x => x == " ");
          integerHeaders.AddRange(parse.Select(int.Parse).ToList());
        }
        if (i >= 17 && i <= 26)
        {
          List<String> parse = new List<string>();
          parse.AddRange(line.Split(' ').ToList());
          parse.RemoveAll(x => x == "");
          parse.RemoveAll(x => x == " ");
          doubleHeaders.AddRange(parse.Select(Double.Parse).ToList());

        }
        i++;
      }

      m_startTime = new DateTime(integerHeaders[1], 1, 1, integerHeaders[3], integerHeaders[4], integerHeaders[5], integerHeaders[6]);
      m_startTime = m_startTime.AddDays(integerHeaders[2] - 1);
      currentTime = m_startTime;
      m_sampleRate = doubleHeaders[1];

      //read acceleration data

      while ((line = file.ReadLine()) != null)
      {
        if (i >= 26 + integerHeaders[15])
        {
          m_seismicRecords.AddRange(Convert10Dig(line, m_sampleRate, currentTime));
          currentTime = currentTime.AddSeconds(8 / m_sampleRate);
        }
        i++;
      }

      m_sampleRate = doubleHeaders[1];

      if (m_seismicRecords.Count != integerHeaders[16])
      {
        throw new Exception("Invalid Record Counts.");
      }
    }

    private void ParseSa(string m_filename)
    {

      ClearData();
      CultureInfo provider = CultureInfo.InvariantCulture;


      //read header data

      System.IO.StreamReader file = new System.IO.StreamReader(m_filename);
      List<String> lines = new List<String>();
      String line;
      line = file.ReadLine();
      DateTime currentTime = DateTime.ParseExact(line, "yyyyMMdd HHmm",provider);
        //new DateTime(line.Substring(0, 4), line.Substring(4, 2), line.Substring(6, 2), line.Substring(9, 2), line.Substring(11, 2),0);
      Double conversionFactor;
      Double.TryParse(file.ReadLine(), out conversionFactor);
      int i = 0;
      while ((line = file.ReadLine()) != null)
      {
        List<String> currentLine = new List<string>();
        currentLine.AddRange(line.Split(' ').ToList());
        currentLine.RemoveAll(x => x.Equals(' '));
        currentLine.RemoveAll(x => x.Equals(""));


        Double timeOffset;
        Double acceleration;
        if (currentLine.Count >= 2)
        {
          Double.TryParse(currentLine[0], out timeOffset);
          Double.TryParse(currentLine[1], out acceleration);
          m_seismicRecords.Add(new SeismicRecord(acceleration * conversionFactor, currentTime.AddSeconds(timeOffset)));
        }
        if (currentLine.Count >= 4)
        {
          Double.TryParse(currentLine[2], out timeOffset);
          Double.TryParse(currentLine[3], out acceleration);
          m_seismicRecords.Add(new SeismicRecord(acceleration * conversionFactor, currentTime.AddSeconds(timeOffset)));
        }
        if (currentLine.Count >= 6)
        {

          Double.TryParse(currentLine[4], out timeOffset);
          Double.TryParse(currentLine[5], out acceleration);
          m_seismicRecords.Add(new SeismicRecord(acceleration * conversionFactor, currentTime.AddSeconds(timeOffset)));
        }
        if (currentLine.Count >= 8)
        {
          Double.TryParse(currentLine[6], out timeOffset);
          Double.TryParse(currentLine[7], out acceleration);
          m_seismicRecords.Add(new SeismicRecord(acceleration * conversionFactor, currentTime.AddSeconds(timeOffset)));
        }
        i++;
      }
    }

    private void ParseSa2(string m_filename)
    {
      ClearData();
      CultureInfo provider = CultureInfo.InvariantCulture;

      //read header data

      System.IO.StreamReader file = new System.IO.StreamReader(m_filename);
      String line = file.ReadLine();
      DateTime currentTime = DateTime.ParseExact(line, "yyyyMMdd HHmm", provider);
      Double conversionFactor;
      Double.TryParse(file.ReadLine(), out m_sampleRate);
      Double.TryParse(file.ReadLine(), out conversionFactor);
      

      int i = 0;
      while ((line = file.ReadLine()) != null)
      {
        List<String> currentLine = new List<string>();
        currentLine.AddRange(line.Split(' ').ToList());
        currentLine.RemoveAll(x => x.Equals(' '));
        currentLine.RemoveAll(x => x.Equals(""));
        

        foreach(string st in currentLine)
        {
          Double acceleration;
          Double.TryParse(st, out acceleration);
          m_seismicRecords.Add(new SeismicRecord(acceleration*conversionFactor, currentTime));
          currentTime = currentTime.AddSeconds(1.0 / m_sampleRate);
        }

        i++;
      }
    }

    private List<SeismicRecord> Convert10Dig(string input, Double sampleRate, DateTime startTime)
    {
      List<SeismicRecord> accelerationRecords = new List<SeismicRecord>();
      DateTime currentTime = startTime;
      List<String> strings = new List<string>();

      for (int i = 0; i < 8; i++)
      {
        strings.Add(input.Substring(i * 10, 10));
      }

      foreach (string columnString in strings)
      {
        Double a, b;
        Double.TryParse(columnString.Substring(0, 5), out a);
        Double.TryParse(columnString.Substring(8, 2), out b);
        Double acc = a * Math.Pow(10, b);
        accelerationRecords.Add(new SeismicRecord(acc, currentTime));
        currentTime = currentTime.AddSeconds(1 / sampleRate);

      }

      return accelerationRecords;
    }

    public void CalculateDVA(Double z, Double w)
    {
      Double average = m_seismicRecords.Average(x => x.Acceleration);

      // non-rigourous filter
      foreach (SeismicRecord sr in m_seismicRecords)
      {
        sr.FilteredAcceleration = sr.Acceleration - average;
      }

      m_seismicRecords[0].Velocity = 0;
      m_seismicRecords[0].Displacement = 0;
      
      // integrate using simpson's rule
      for (int i = 1; i < m_seismicRecords.Count(); i++)
      {
        if (i < m_seismicRecords.Count - 1)
        {
          Double time1 = Convert.ToDouble(m_seismicRecords[i].Time.Ticks);
          Double time2 = Convert.ToDouble(m_seismicRecords[i+1].Time.Ticks);
          Double timediff = time2 - time1;
                    
          Double timestep = m_seismicRecords[i + 1].Time.Subtract(m_seismicRecords[i - 1].Time).Ticks * Math.Pow(10, -7);
          m_seismicRecords[i].Velocity = m_seismicRecords[i - 1].Velocity + ((timestep)/2 / 6) * (m_seismicRecords[i - 1].FilteredAcceleration + 4 * m_seismicRecords[i].FilteredAcceleration + m_seismicRecords[i + 1].FilteredAcceleration);
        }
        else
        {
          Double timestep = m_seismicRecords[i].Time.Subtract(m_seismicRecords[i - 1].Time).Ticks * Math.Pow(10, -7);
          m_seismicRecords[i].Velocity = m_seismicRecords[i - 1].Velocity + (timestep) * (.5) * (m_seismicRecords[i - 1].FilteredAcceleration + m_seismicRecords[i].FilteredAcceleration);
        }
      }

      // integrate using simpson's rule
      for (int i = 1; i < m_seismicRecords.Count(); i++)
      {
        if (i < m_seismicRecords.Count - 1)
        {
          Double timestep = m_seismicRecords[i + 1].Time.Subtract(m_seismicRecords[i - 1].Time).Ticks * Math.Pow(10, -7);
          m_seismicRecords[i].Displacement = m_seismicRecords[i - 1].Displacement + ((timestep)/2 / 6) * (m_seismicRecords[i - 1].Velocity + 4 * m_seismicRecords[i].Velocity + m_seismicRecords[i + 1].Velocity);
        }
        else
        {
          Double timestep = m_seismicRecords[i].Time.Subtract(m_seismicRecords[i - 1].Time).Ticks * Math.Pow(10, -7);
          m_seismicRecords[i].Displacement = m_seismicRecords[i - 1].Displacement + (timestep) * (.5) * (m_seismicRecords[i - 1].Velocity + m_seismicRecords[i].Velocity);
        }
      }
    }

    private void ClearData()
    {
      m_seismicRecords.RemoveAll(x => x.Equals(x));
    }

    public void ShowTable()
    {
      Table accTable = new Table(m_seismicRecords, m_mainForm);
      accTable.Show();
    }
  }
}
