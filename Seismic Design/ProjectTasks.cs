using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seismic_Design
{
  public partial class ProjectTasks : Form
  {
    Project m_project;
    MainForm m_mainForm;
    ResponseChart responseChart;

    public ProjectTasks(Project project, MainForm mainForm)
    {
      m_project = project;
      InitializeComponent();
      m_mainForm = mainForm;
      m_mainForm = mainForm;
      this.MdiParent = mainForm;
      
    }
    
    private void btn_calculate_Click(object sender, EventArgs e)
    {
      m_project.ProcessDVA(.9, 1.0);
    }

    private void btn_displayDVA_Click(object sender, EventArgs e)
    {
      m_project.ShowChart();
    }

    private void btn_exportDVA_Click(object sender, EventArgs e)
    {

    }

    private void btn_calculateResponse_Click(object sender, EventArgs e)
    {
      responseChart = new ResponseChart(m_mainForm);
      List<Response> newResponses = new List<Response>();
      newResponses.Add(new Response(m_project.SeismicDatas, m_mainForm));

      newResponses.ForEach(x => responseChart.AddResponses(x.ResponseSpectra));
    }

    private void btn_displayResponse_Click(object sender, EventArgs e)
    {
      responseChart.Show();
    }
  }
}
