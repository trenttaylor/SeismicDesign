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
  public partial class frm_dataWizard : Form
  {
    List<SeismicData> seismicDatas = new List<SeismicData>();
    String projectName = "";
    private MainForm mainForm;

    public frm_dataWizard(MainForm mainForm)
    {
      InitializeComponent();
      this.mainForm = mainForm;
      this.MdiParent = mainForm;

      ColumnHeader columnHeader1 = new ColumnHeader();
      columnHeader1.Text = "File Name";
      this.lv_sourceFiles.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
    }

    private void btn_createProj_Click(object sender, EventArgs e)
    {
      mainForm.UpdateStatus("Project Created");
      mainForm.project = new Project(projectName, seismicDatas,mainForm);
      mainForm.project.ProcessInputData();
      this.Close();
    }

    private void btn_addSource_Click(object sender, EventArgs e)
    {
      mainForm.UpdateStatus("Adding File");
      openFileDialog1.ShowDialog();

      tb_sourceFile.Text = openFileDialog1.FileName.ToString();

      seismicDatas.Add(new SeismicData(tb_sourceFile.Text,mainForm));

      //lv_sourceFiles.Items.Add(new ListViewItem(openFileDialog1.FileName.ToString()));

      mainForm.UpdateStatus("(1) File Added");

      mainForm.Text = "Seismic Analysis - " + projectName;

    }

    private void btn_deleteSource_Click(object sender, EventArgs e)
    {
      lv_sourceFiles.Items.RemoveAt(lv_sourceFiles.SelectedIndices[0]);
    }

    private void tb_projectName_TextChanged(object sender, EventArgs e)
    {
      projectName = tb_projectName.Text;
    }
  }
}
