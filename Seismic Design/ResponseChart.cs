using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Seismic_Design
{
  public partial class ResponseChart : Form
  {
    public ResponseChart(MainForm mainForm)
    {
      InitializeComponent();
      MdiParent = mainForm;
    }

    public void AddResponses(List<Response.ResponseSpectrum> responseSpectra)
    {

      foreach (Response.ResponseSpectrum rs in responseSpectra)
      {
        Series series1 = new Series();
        series1.ChartType = SeriesChartType.FastLine;
        series1.XValueType = ChartValueType.Double;
        series1.YValueType = ChartValueType.Double;
        rs.DisplacementPoints.ForEach(x => series1.Points.AddXY(x.X, x.Y));
        series1.LegendText = "Displacement ζ=" + rs.zeta.ToString();

        chart1.ChartAreas[0].AxisX.IsLogarithmic = true;
        chart1.Series.Add(series1);

        Series series2 = new Series();
        series2.ChartType = SeriesChartType.FastLine;
        rs.VelocityPoints.ForEach(x => series2.Points.AddXY(x.X, x.Y));
        series2.LegendText = "Velocity ζ=" + rs.zeta.ToString();

        chart2.ChartAreas[0].AxisX.IsLogarithmic = true;
        chart2.Series.Add(series2);

        Series series3 = new Series();
        series3.ChartType = SeriesChartType.FastLine;
        rs.AccelerationPoints.ForEach(x => series3.Points.AddXY(x.X, x.Y));
        series3.LegendText = "Acceleration ζ=" + rs.zeta.ToString();

        chart3.ChartAreas[0].AxisX.IsLogarithmic = true;
        chart3.Series.Add(series3);

      }
    }
  }
}
