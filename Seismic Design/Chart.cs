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
  public partial class Chart : Form
  {
    public Chart(List<SeismicData.SeismicRecord> list, MainForm mainForm)
    {
      InitializeComponent();
      MdiParent = mainForm;

      //actual acceleration
      Series series1 = new Series();
      series1.XValueType = ChartValueType.DateTime;
      series1.ChartType = SeriesChartType.FastLine;
      series1.LegendText = "Acceleration";

      list.ForEach(x => series1.Points.AddXY(x.Time, x.Acceleration));
      chart1.ChartAreas[0].AxisX.LabelStyle.Format = "HH:mm:ss";
      chart1.Series.Add(series1);

      //filtered acceleration
      Series series2 = new Series();
      series2.XValueType = ChartValueType.DateTime;
      series2.ChartType = SeriesChartType.FastLine;
      series2.LegendText = "Filtered Acceleration";

      list.ForEach(x => series2.Points.AddXY(x.Time, x.FilteredAcceleration));

      // velocity
      chart1.Series.Add(series2);

      Series series3 = new Series();
      series3.XValueType = ChartValueType.DateTime;
      series3.ChartType = SeriesChartType.FastLine;
      series3.LegendText = "Velocity";

      list.ForEach(x => series3.Points.AddXY(x.Time, x.Velocity));
      chart2.ChartAreas[0].AxisX.LabelStyle.Format = "HH:mm:ss";
      chart2.Series.Add(series3);

      //displacement
      Series series4 = new Series();
      series4.XValueType = ChartValueType.DateTime;
      series4.ChartType = SeriesChartType.FastLine;
      series4.LegendText = "Displacement";

      list.ForEach(x => series4.Points.AddXY(x.Time, x.Displacement));
      chart3.ChartAreas[0].AxisX.LabelStyle.Format = "HH:mm:ss";
      chart3.Series.Add(series4);

      }

    private List<PointD> ConvertToPoints(List<SeismicData.SeismicRecord> list)
    {

      List<PointD> points = new List<PointD>();
      
      foreach (SeismicData.SeismicRecord sr in list)
      {
        points.Add(new PointD(sr.Time.Hour*3600+sr.Time.Minute*60+sr.Time.Second+sr.Time.Millisecond*.001, sr.Displacement));
      }

      return points;
    }

    private void Chart_ResizeEnd(object sender, EventArgs e)
    {
      chart1.Height = this.Height / 3;
      chart2.Height = this.Height / 3;
    }

    FormWindowState LastWindowState = FormWindowState.Minimized;

    private void Chart_Resize(object sender, EventArgs e)
    {
      // When window state changes
      if (WindowState != LastWindowState)
      {
        LastWindowState = WindowState;

        if (WindowState == FormWindowState.Maximized)
        {

          chart1.Height = this.Height / 3;
          chart2.Height = this.Height / 3;
        }
        if (WindowState == FormWindowState.Normal)
        {

          chart1.Height = this.Height / 3;
          chart2.Height = this.Height / 3;
        }
      }
    }    
  }
}
