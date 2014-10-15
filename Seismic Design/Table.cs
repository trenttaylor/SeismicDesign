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
  public partial class Table : Form
  {
    List<SeismicData.SeismicRecord> m_seismicRecords;

    public Table(List<SeismicData.SeismicRecord> seismicRecords, MainForm mainForm)
    {
      InitializeComponent();
      dgv_table.AutoGenerateColumns = true;
      m_seismicRecords = seismicRecords;
      MdiParent = mainForm;
    }

    private void Table_Load(object sender, EventArgs e)
    {
      dgv_table.DataSource = m_seismicRecords;
      dgv_table.Columns["Time"].DefaultCellStyle.Format = "d MMM yyyy HH:mm:ss.ffff";
    }
  }
}
