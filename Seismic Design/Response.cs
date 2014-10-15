/* STRUCTURAL DYNAMICS - DYNAMIC RESPONSE ASSIGNMENT
 * Author: Trent Taylor
 * Date: 14 Oct 2014
*/

/*
 * This file calculates the response from the earthquake.
 * 1st- Iteratively calculate the maximum response using newmarks method
 * 2nd- Find Rdmax and store for response spectra
 * 
 * All three response spectra are calculated in one pass through each frequency.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seismic_Design
{
  public class Response
  {
    MainForm m_mainForm;
    List<ResponseSpectrum> m_responseSpectra = new List<ResponseSpectrum>();

    public List<ResponseSpectrum> ResponseSpectra
    {
      get { return m_responseSpectra; }
    }

    public Response(List<SeismicData> seismicData,MainForm mainForm)
    {
      m_mainForm = mainForm;
      foreach (SeismicData sd in seismicData)
      {
        int wMax = 100;
        m_responseSpectra.Add(new ResponseSpectrum(.02, 0,wMax,sd,m_mainForm));
        m_responseSpectra.Add(new ResponseSpectrum(.05, 0,wMax,sd,m_mainForm));
        m_responseSpectra.Add(new ResponseSpectrum(.2,  0,wMax,sd,m_mainForm));
      }
    }

    public class ResponseSpectrum
    {
      List<PointD> m_accelearationResponsePoints = new List<PointD>();
      List<PointD> m_velocityResponsePoints = new List<PointD>();
      List<PointD> m_displacementResponsePoints = new List<PointD>();
      Double m_dampingRatio;

      public List<PointD> AccelerationPoints
      {
        get { return m_accelearationResponsePoints; }
      }

      public List<PointD> VelocityPoints
      {
        get { return m_velocityResponsePoints; }
      }
            
      public List<PointD> DisplacementPoints
      {
        get { return m_displacementResponsePoints; }
      }

      public double zeta
      {
        get { return m_dampingRatio; }
      }

      public ResponseSpectrum(double dampingRatio, int wMin, int wMax, SeismicData seismicData,MainForm mainForm)
      {
        mainForm.UpdateProgress(0);
        mainForm.UpdateStatus("Calculating Response Spectra...");
        m_dampingRatio = dampingRatio;
        int iterations = 0;
        for (double w = wMin; w <= wMax; w += .1)
        {
          List<double> displacementResponse = new List<double>();
          List<double> velocityResponse = new List<double>();
          List<double> accelerationResponse = new List<double>();

          for (int i = 0; i < seismicData.SeismicRecords.Count - 1; i++)
          {
            // CALCULATE DISPLACEMENT RESPONSE USING NEWMARKS METHOD
            displacementResponse.Add(NewmarksMethodDisp(
                                        seismicData.SeismicRecords[i + 1].Acceleration,
                                        seismicData.SeismicRecords[i].Displacement,
                                        seismicData.SeismicRecords[i].Velocity,
                                        seismicData.SeismicRecords[i].Acceleration,
                                        (seismicData.SeismicRecords[i + 1].Time.Subtract(seismicData.SeismicRecords[i].Time)).Ticks * Math.Pow(10, -7),
                                        dampingRatio,
                                        w));
            // CALCULATE VELOCITY RESPONSE USING NEWMARKS METHOD
            velocityResponse.Add(NewmarksMethodVel(
                                        seismicData.SeismicRecords[i + 1].Acceleration,
                                        seismicData.SeismicRecords[i].Displacement,
                                        seismicData.SeismicRecords[i].Velocity,
                                        seismicData.SeismicRecords[i].Acceleration,
                                        (seismicData.SeismicRecords[i + 1].Time.Subtract(seismicData.SeismicRecords[i].Time)).Ticks * Math.Pow(10, -7),
                                        dampingRatio,
                                        w)); ;
            //CALCULATE ACCELERATION RESPONSE USING NEWMARKS METHOD
            accelerationResponse.Add(NewmarksMethodAcc(
                                        seismicData.SeismicRecords[i + 1].Acceleration,
                                        seismicData.SeismicRecords[i].Displacement,
                                        seismicData.SeismicRecords[i].Velocity,
                                        seismicData.SeismicRecords[i].Acceleration,
                                        (seismicData.SeismicRecords[i + 1].Time.Subtract(seismicData.SeismicRecords[i].Time)).Ticks * Math.Pow(10, -7),
                                        dampingRatio,
                                        w,
                                        displacementResponse.Last()));
          }

          //Take the maximum and remove any negative values
          m_displacementResponsePoints.Add(new PointD(w, displacementResponse.Max()));
          m_velocityResponsePoints.Add(new PointD(w, velocityResponse.Max()));
          m_accelearationResponsePoints.Add(new PointD(w, accelerationResponse.Max()));

          m_velocityResponsePoints.RemoveAll(x => x.X <= 0);
          m_displacementResponsePoints.RemoveAll(x => x.X <= 0);
          m_accelearationResponsePoints.RemoveAll(x => x.X <= 0);

          iterations++;
          mainForm.UpdateProgress(Convert.ToDouble(iterations) / Convert.ToDouble(((wMax - wMin) * (seismicData.SeismicRecords.Count))));


        }
        mainForm.UpdateStatus("Calculating Response Spectra...DONE!");
      }

      private double NewmarksMethodAcc(Double An1, Double Dn, Double Vn, Double An, Double dt, Double z, Double w, Double Dn1)
      {
        return (Dn1 - Dn) * (4 / (dt * dt)) - (Vn * 4 / dt) - An;
      }

      private double NewmarksMethodVel(Double An1, Double Dn, Double Vn, Double An, Double dt, Double z, Double w)
      {
        return Vn + (An + An1) * (dt / 2);
      }
      public double NewmarksMethodDisp(Double An1, Double Dn, Double Vn, Double An, Double dt, Double z, Double w)
      {
        return (An1 / 4 + Dn * (1 / (dt*dt) + (z * w) / dt) + Vn * (1 / dt + (z * w) / 2) + An / 4) / (Math.Pow(w, 2) / 4 + (z * w) / dt + 1 / Math.Pow(dt, 2));
      }



    }
  }
}
