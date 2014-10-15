namespace Seismic_Design
{
  partial class Table
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
      this.dgv_table = new System.Windows.Forms.DataGridView();
      ((System.ComponentModel.ISupportInitialize)(this.dgv_table)).BeginInit();
      this.SuspendLayout();
      // 
      // dgv_table
      // 
      this.dgv_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgv_table.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dgv_table.Location = new System.Drawing.Point(0, 0);
      this.dgv_table.Name = "dgv_table";
      this.dgv_table.Size = new System.Drawing.Size(701, 501);
      this.dgv_table.TabIndex = 0;
      // 
      // Table
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(701, 501);
      this.Controls.Add(this.dgv_table);
      this.Name = "Table";
      this.Text = "Table";
      this.Load += new System.EventHandler(this.Table_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dgv_table)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView dgv_table;

  }
}