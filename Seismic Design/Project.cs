using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seismic_Design
{
  public class Project
  {

    private string m_projectName;
    private List<SeismicData> m_seismicDatas;
    private List<Double> m_accelerationRecords=new List<Double>();
    private MainForm m_mainForm;

    public Project(string projectName, List<SeismicData> seismicDatas)
    {
      this.m_projectName = projectName;
      this.m_seismicDatas = seismicDatas;
    }

    public Project(string projectName, List<SeismicData> seismicDatas, MainForm mainForm)
    {
      // TODO: Complete member initialization
      m_projectName = projectName;
      m_seismicDatas = seismicDatas;
      m_mainForm = mainForm;
    }

    public List<SeismicData> SeismicDatas
    {
      get { return m_seismicDatas; }
    }

    internal string Name
    {
      get { return m_projectName;}
    }

    internal void ProcessInputData()
    {
      m_seismicDatas.ForEach(x => x.ProcessInput());
      ProjectTasks projTasks = new ProjectTasks(this,m_mainForm);
      projTasks.Show();
    }


    internal void ShowTable()
    {
      m_seismicDatas.ForEach(x=>x.ShowTable());
    }

    internal void ProcessDVA(Double z, Double w)
    {
      m_seismicDatas.ForEach(x => x.CalculateDVA(z, w));
    }

    internal void ShowChart()
    {
      m_seismicDatas.ForEach(x => { Chart newchart = new Chart(x.SeismicRecords, m_mainForm); newchart.Show(); });
    }
  }
}

