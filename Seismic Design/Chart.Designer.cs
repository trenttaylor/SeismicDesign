namespace Seismic_Design
{
  partial class Chart
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
      this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
      ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
      this.SuspendLayout();
      // 
      // chart1
      // 
      chartArea1.Name = "ChartArea1";
      this.chart1.ChartAreas.Add(chartArea1);
      this.chart1.Dock = System.Windows.Forms.DockStyle.Top;
      legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
      legend1.Name = "Legend1";
      this.chart1.Legends.Add(legend1);
      this.chart1.Location = new System.Drawing.Point(0, 0);
      this.chart1.Margin = new System.Windows.Forms.Padding(2);
      this.chart1.Name = "chart1";
      this.chart1.Size = new System.Drawing.Size(616, 130);
      this.chart1.TabIndex = 0;
      this.chart1.Text = "chart1";
      title1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
      title1.Name = "Acceleration";
      title1.Text = "Acceleration";
      this.chart1.Titles.Add(title1);
      // 
      // chart2
      // 
      chartArea2.Name = "ChartArea1";
      this.chart2.ChartAreas.Add(chartArea2);
      this.chart2.Dock = System.Windows.Forms.DockStyle.Top;
      legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
      legend2.Name = "Legend1";
      this.chart2.Legends.Add(legend2);
      this.chart2.Location = new System.Drawing.Point(0, 130);
      this.chart2.Margin = new System.Windows.Forms.Padding(2);
      this.chart2.Name = "chart2";
      this.chart2.Size = new System.Drawing.Size(616, 130);
      this.chart2.TabIndex = 1;
      this.chart2.Text = "chart2";
      title2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
      title2.Name = "Title1";
      title2.Text = "Velocity";
      this.chart2.Titles.Add(title2);
      // 
      // chart3
      // 
      chartArea3.Name = "ChartArea1";
      this.chart3.ChartAreas.Add(chartArea3);
      this.chart3.Dock = System.Windows.Forms.DockStyle.Fill;
      legend3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
      legend3.Name = "Legend1";
      this.chart3.Legends.Add(legend3);
      this.chart3.Location = new System.Drawing.Point(0, 260);
      this.chart3.Margin = new System.Windows.Forms.Padding(2);
      this.chart3.Name = "chart3";
      this.chart3.Size = new System.Drawing.Size(616, 171);
      this.chart3.TabIndex = 2;
      this.chart3.Text = "chart3";
      title3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
      title3.Name = "Title1";
      title3.Text = "Displacement";
      this.chart3.Titles.Add(title3);
      // 
      // Chart
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(616, 431);
      this.Controls.Add(this.chart3);
      this.Controls.Add(this.chart2);
      this.Controls.Add(this.chart1);
      this.Margin = new System.Windows.Forms.Padding(2);
      this.Name = "Chart";
      this.Text = "Chart";
      this.ResizeEnd += new System.EventHandler(this.Chart_ResizeEnd);
      this.Resize += new System.EventHandler(this.Chart_Resize);
      ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
  }
}