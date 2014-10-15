namespace Seismic_Design
{
  partial class MainForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
      this.ts_statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
      this.toolStrip1 = new System.Windows.Forms.ToolStrip();
      this.btn_newProject = new System.Windows.Forms.ToolStripButton();
      this.btn_closeProject = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.btn_process = new System.Windows.Forms.ToolStripButton();
      this.btn_showTable = new System.Windows.Forms.ToolStripButton();
      this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
      this.statusStrip1.SuspendLayout();
      this.toolStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // statusStrip1
      // 
      this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.ts_statusLabel});
      this.statusStrip1.Location = new System.Drawing.Point(0, 462);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new System.Drawing.Size(839, 22);
      this.statusStrip1.TabIndex = 1;
      this.statusStrip1.Text = "statusStrip1";
      // 
      // toolStripProgressBar1
      // 
      this.toolStripProgressBar1.Name = "toolStripProgressBar1";
      this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
      this.toolStripProgressBar1.Step = 1;
      // 
      // ts_statusLabel
      // 
      this.ts_statusLabel.Name = "ts_statusLabel";
      this.ts_statusLabel.Size = new System.Drawing.Size(0, 17);
      // 
      // toolStrip1
      // 
      this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_newProject,
            this.btn_closeProject,
            this.toolStripSeparator1,
            this.btn_process,
            this.btn_showTable,
            this.toolStripButton2});
      this.toolStrip1.Location = new System.Drawing.Point(0, 0);
      this.toolStrip1.Name = "toolStrip1";
      this.toolStrip1.Size = new System.Drawing.Size(839, 25);
      this.toolStrip1.TabIndex = 3;
      this.toolStrip1.Text = "toolStrip1";
      // 
      // btn_newProject
      // 
      this.btn_newProject.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.btn_newProject.Image = global::Seismic_Design.Properties.Resources.add;
      this.btn_newProject.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btn_newProject.Name = "btn_newProject";
      this.btn_newProject.Size = new System.Drawing.Size(23, 22);
      this.btn_newProject.Text = "toolStripButton1";
      this.btn_newProject.Click += new System.EventHandler(this.btn_newProject_Click);
      // 
      // btn_closeProject
      // 
      this.btn_closeProject.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.btn_closeProject.Image = global::Seismic_Design.Properties.Resources.delete;
      this.btn_closeProject.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btn_closeProject.Name = "btn_closeProject";
      this.btn_closeProject.Size = new System.Drawing.Size(23, 22);
      this.btn_closeProject.Text = "toolStripButton2";
      this.btn_closeProject.Click += new System.EventHandler(this.btn_closeProject_Click);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
      // 
      // btn_process
      // 
      this.btn_process.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.btn_process.Image = global::Seismic_Design.Properties.Resources.right;
      this.btn_process.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btn_process.Name = "btn_process";
      this.btn_process.Size = new System.Drawing.Size(23, 22);
      this.btn_process.Text = "toolStripButton1";
      this.btn_process.Click += new System.EventHandler(this.btn_process_Click);
      // 
      // btn_showTable
      // 
      this.btn_showTable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.btn_showTable.Image = ((System.Drawing.Image)(resources.GetObject("btn_showTable.Image")));
      this.btn_showTable.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btn_showTable.Name = "btn_showTable";
      this.btn_showTable.Size = new System.Drawing.Size(23, 22);
      this.btn_showTable.Text = "toolStripButton1";
      this.btn_showTable.Click += new System.EventHandler(this.btn_showTable_Click);
      // 
      // toolStripButton2
      // 
      this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
      this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButton2.Name = "toolStripButton2";
      this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
      this.toolStripButton2.Text = "toolStripButton2";
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ClientSize = new System.Drawing.Size(839, 484);
      this.Controls.Add(this.toolStrip1);
      this.Controls.Add(this.statusStrip1);
      this.IsMdiContainer = true;
      this.Margin = new System.Windows.Forms.Padding(2);
      this.Name = "MainForm";
      this.Text = "Seismic Analysis";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
      this.Load += new System.EventHandler(this.MainForm_Load);
      this.statusStrip1.ResumeLayout(false);
      this.statusStrip1.PerformLayout();
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
    private System.Windows.Forms.ToolStripStatusLabel ts_statusLabel;
    private System.Windows.Forms.ToolStrip toolStrip1;
    private System.Windows.Forms.ToolStripButton btn_newProject;
    private System.Windows.Forms.ToolStripButton btn_closeProject;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripButton btn_process;
    private System.Windows.Forms.ToolStripButton btn_showTable;
    private System.Windows.Forms.ToolStripButton toolStripButton2;
  }
}

