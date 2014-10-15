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
  public partial class MainForm : Form
  {

    Project m_project;

    public MainForm()
    {
      InitializeComponent();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
      newProject();
    }

    private void btn_newProject_Click(object sender, EventArgs e)
    {
      newProject();
    }

    private void btn_closeProject_Click(object sender, EventArgs e)
    {
      newProject();
    }

    private void newProject()
    {
      frm_dataWizard dataWizard = new frm_dataWizard(this);
      dataWizard.Show();

    }

    public Project project
    {
      get { return m_project; }
      set { m_project = value; }
    }

    public void UpdateStatus(string status)
    {
      ts_statusLabel.Text = status;
    }

    private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
    {
      return;
    }

    private void btn_process_Click(object sender, EventArgs e)
    {
      project.ProcessInputData(); 

      UpdateStatus("File Read in Complete");
    }

    private void btn_showTable_Click(object sender, EventArgs e)
    {
      project.ShowTable();
    }

    public void UpdateProgress(double progress)
    {
      toolStripProgressBar1.Value = Convert.ToInt32(progress * 100);
      Application.DoEvents();
    }



  }
}
