namespace Seismic_Design
{
  partial class frm_dataWizard
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
      System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
      this.btn_createProj = new System.Windows.Forms.Button();
      this.btn_deleteSource = new System.Windows.Forms.Button();
      this.btn_addSource = new System.Windows.Forms.Button();
      this.lv_sourceFiles = new System.Windows.Forms.ListView();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.tb_projectName = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.tb_sourceFile = new System.Windows.Forms.TextBox();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // btn_createProj
      // 
      this.btn_createProj.Location = new System.Drawing.Point(237, 261);
      this.btn_createProj.Name = "btn_createProj";
      this.btn_createProj.Size = new System.Drawing.Size(95, 23);
      this.btn_createProj.TabIndex = 1;
      this.btn_createProj.Text = "Create Project";
      this.btn_createProj.UseVisualStyleBackColor = true;
      this.btn_createProj.Click += new System.EventHandler(this.btn_createProj_Click);
      // 
      // btn_deleteSource
      // 
      this.btn_deleteSource.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
      this.btn_deleteSource.Location = new System.Drawing.Point(296, 49);
      this.btn_deleteSource.Name = "btn_deleteSource";
      this.btn_deleteSource.Size = new System.Drawing.Size(24, 24);
      this.btn_deleteSource.TabIndex = 3;
      this.btn_deleteSource.Text = "-";
      this.btn_deleteSource.UseVisualStyleBackColor = true;
      this.btn_deleteSource.Click += new System.EventHandler(this.btn_deleteSource_Click);
      // 
      // btn_addSource
      // 
      this.btn_addSource.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
      this.btn_addSource.Location = new System.Drawing.Point(296, 19);
      this.btn_addSource.Name = "btn_addSource";
      this.btn_addSource.Size = new System.Drawing.Size(24, 24);
      this.btn_addSource.TabIndex = 2;
      this.btn_addSource.Text = "+";
      this.btn_addSource.UseVisualStyleBackColor = true;
      this.btn_addSource.Click += new System.EventHandler(this.btn_addSource_Click);
      // 
      // lv_sourceFiles
      // 
      this.lv_sourceFiles.GridLines = true;
      this.lv_sourceFiles.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
      this.lv_sourceFiles.Location = new System.Drawing.Point(7, 19);
      this.lv_sourceFiles.Name = "lv_sourceFiles";
      this.lv_sourceFiles.OwnerDraw = true;
      this.lv_sourceFiles.Size = new System.Drawing.Size(283, 178);
      this.lv_sourceFiles.TabIndex = 4;
      this.lv_sourceFiles.UseCompatibleStateImageBehavior = false;
      this.lv_sourceFiles.View = System.Windows.Forms.View.Details;
      this.lv_sourceFiles.Visible = false;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.tb_sourceFile);
      this.groupBox1.Controls.Add(this.btn_deleteSource);
      this.groupBox1.Controls.Add(this.lv_sourceFiles);
      this.groupBox1.Controls.Add(this.btn_addSource);
      this.groupBox1.Location = new System.Drawing.Point(6, 55);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(325, 200);
      this.groupBox1.TabIndex = 5;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Add Seismic Data";
      // 
      // tb_projectName
      // 
      this.tb_projectName.Location = new System.Drawing.Point(14, 29);
      this.tb_projectName.Name = "tb_projectName";
      this.tb_projectName.Size = new System.Drawing.Size(318, 20);
      this.tb_projectName.TabIndex = 6;
      this.tb_projectName.TextChanged += new System.EventHandler(this.tb_projectName_TextChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(13, 13);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(71, 13);
      this.label1.TabIndex = 7;
      this.label1.Text = "Project Name";
      // 
      // openFileDialog1
      // 
      this.openFileDialog1.FileName = "openFileDialog1";
      // 
      // tb_sourceFile
      // 
      this.tb_sourceFile.Location = new System.Drawing.Point(7, 20);
      this.tb_sourceFile.Name = "tb_sourceFile";
      this.tb_sourceFile.Size = new System.Drawing.Size(283, 20);
      this.tb_sourceFile.TabIndex = 5;
      // 
      // frm_dataWizard
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(343, 296);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.tb_projectName);
      this.Controls.Add(this.btn_createProj);
      this.Controls.Add(this.groupBox1);
      this.Margin = new System.Windows.Forms.Padding(2);
      this.MaximumSize = new System.Drawing.Size(359, 335);
      this.MinimumSize = new System.Drawing.Size(359, 335);
      this.Name = "frm_dataWizard";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "DataWizard";
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btn_createProj;
    private System.Windows.Forms.Button btn_addSource;
    private System.Windows.Forms.Button btn_deleteSource;
    private System.Windows.Forms.ListView lv_sourceFiles;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TextBox tb_projectName;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.OpenFileDialog openFileDialog1;
    private System.Windows.Forms.TextBox tb_sourceFile;


  }
}