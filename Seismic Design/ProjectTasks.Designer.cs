namespace Seismic_Design
{
  partial class ProjectTasks
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
      this.btn_calculate = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.btn_displayDVA = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.btn_exportDVA = new System.Windows.Forms.Button();
      this.label4 = new System.Windows.Forms.Label();
      this.btn_calculateResponse = new System.Windows.Forms.Button();
      this.label5 = new System.Windows.Forms.Label();
      this.btn_displayResponse = new System.Windows.Forms.Button();
      this.label6 = new System.Windows.Forms.Label();
      this.btn_exportResponse = new System.Windows.Forms.Button();
      this.label7 = new System.Windows.Forms.Label();
      this.btn_closeProject = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btn_calculate
      // 
      this.btn_calculate.Location = new System.Drawing.Point(13, 13);
      this.btn_calculate.Name = "btn_calculate";
      this.btn_calculate.Size = new System.Drawing.Size(116, 23);
      this.btn_calculate.TabIndex = 0;
      this.btn_calculate.Text = "Perform Calculations";
      this.btn_calculate.UseVisualStyleBackColor = true;
      this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(135, 18);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(295, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Perform integrations to calculate velocities and accelerations.";
      // 
      // btn_displayDVA
      // 
      this.btn_displayDVA.Location = new System.Drawing.Point(13, 43);
      this.btn_displayDVA.Name = "btn_displayDVA";
      this.btn_displayDVA.Size = new System.Drawing.Size(116, 23);
      this.btn_displayDVA.TabIndex = 2;
      this.btn_displayDVA.Text = "Display DVA";
      this.btn_displayDVA.UseVisualStyleBackColor = true;
      this.btn_displayDVA.Click += new System.EventHandler(this.btn_displayDVA_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(135, 48);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(261, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "Display displacement, velocity, and acceleration plots.";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(135, 77);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(304, 13);
      this.label3.TabIndex = 5;
      this.label3.Text = "Export displacement, velocity, and acceleration data to csv file.";
      // 
      // btn_exportDVA
      // 
      this.btn_exportDVA.Location = new System.Drawing.Point(13, 72);
      this.btn_exportDVA.Name = "btn_exportDVA";
      this.btn_exportDVA.Size = new System.Drawing.Size(116, 23);
      this.btn_exportDVA.TabIndex = 4;
      this.btn_exportDVA.Text = "Export DVA";
      this.btn_exportDVA.UseVisualStyleBackColor = true;
      this.btn_exportDVA.Click += new System.EventHandler(this.btn_exportDVA_Click);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(135, 127);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(138, 13);
      this.label4.TabIndex = 7;
      this.label4.Text = "Calculate response spectra.";
      // 
      // btn_calculateResponse
      // 
      this.btn_calculateResponse.Location = new System.Drawing.Point(13, 122);
      this.btn_calculateResponse.Name = "btn_calculateResponse";
      this.btn_calculateResponse.Size = new System.Drawing.Size(116, 23);
      this.btn_calculateResponse.TabIndex = 6;
      this.btn_calculateResponse.Text = "Calculate Response";
      this.btn_calculateResponse.UseVisualStyleBackColor = true;
      this.btn_calculateResponse.Click += new System.EventHandler(this.btn_calculateResponse_Click);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(135, 156);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(128, 13);
      this.label5.TabIndex = 9;
      this.label5.Text = "Display response spectra.";
      // 
      // btn_displayResponse
      // 
      this.btn_displayResponse.Location = new System.Drawing.Point(13, 151);
      this.btn_displayResponse.Name = "btn_displayResponse";
      this.btn_displayResponse.Size = new System.Drawing.Size(116, 23);
      this.btn_displayResponse.TabIndex = 8;
      this.btn_displayResponse.Text = "Display Response";
      this.btn_displayResponse.UseVisualStyleBackColor = true;
      this.btn_displayResponse.Click += new System.EventHandler(this.btn_displayResponse_Click);
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(135, 185);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(124, 13);
      this.label6.TabIndex = 11;
      this.label6.Text = "Export response spectra.";
      // 
      // btn_exportResponse
      // 
      this.btn_exportResponse.Location = new System.Drawing.Point(13, 180);
      this.btn_exportResponse.Name = "btn_exportResponse";
      this.btn_exportResponse.Size = new System.Drawing.Size(116, 23);
      this.btn_exportResponse.TabIndex = 10;
      this.btn_exportResponse.Text = "Export Response";
      this.btn_exportResponse.UseVisualStyleBackColor = true;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(135, 238);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(89, 13);
      this.label7.TabIndex = 13;
      this.label7.Text = "Close the project.";
      // 
      // btn_closeProject
      // 
      this.btn_closeProject.Location = new System.Drawing.Point(13, 233);
      this.btn_closeProject.Name = "btn_closeProject";
      this.btn_closeProject.Size = new System.Drawing.Size(116, 23);
      this.btn_closeProject.TabIndex = 12;
      this.btn_closeProject.Text = "Close Project";
      this.btn_closeProject.UseVisualStyleBackColor = true;
      // 
      // ProjectTasks
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(486, 286);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.btn_closeProject);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.btn_exportResponse);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.btn_displayResponse);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.btn_calculateResponse);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.btn_exportDVA);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.btn_displayDVA);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btn_calculate);
      this.Name = "ProjectTasks";
      this.Text = "ProjectTasks";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btn_calculate;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btn_displayDVA;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button btn_exportDVA;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button btn_calculateResponse;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Button btn_displayResponse;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Button btn_exportResponse;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Button btn_closeProject;
  }
}