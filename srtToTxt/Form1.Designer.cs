namespace srtToTxt
{
  partial class Form1
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
      this.label1 = new System.Windows.Forms.Label();
      this.lblFileSorgente = new System.Windows.Forms.Label();
      this.btnConverti = new System.Windows.Forms.Button();
      this.txtRich = new System.Windows.Forms.RichTextBox();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(50, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Sorgente";
      // 
      // lblFileSorgente
      // 
      this.lblFileSorgente.AutoSize = true;
      this.lblFileSorgente.BackColor = System.Drawing.Color.Silver;
      this.lblFileSorgente.Location = new System.Drawing.Point(12, 32);
      this.lblFileSorgente.Name = "lblFileSorgente";
      this.lblFileSorgente.Size = new System.Drawing.Size(99, 13);
      this.lblFileSorgente.TabIndex = 2;
      this.lblFileSorgente.Text = "Drag & Drop il file qui";
      // 
      // btnConverti
      // 
      this.btnConverti.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnConverti.Location = new System.Drawing.Point(696, 9);
      this.btnConverti.Name = "btnConverti";
      this.btnConverti.Size = new System.Drawing.Size(271, 50);
      this.btnConverti.TabIndex = 3;
      this.btnConverti.Text = "Converti";
      this.btnConverti.UseVisualStyleBackColor = true;
      this.btnConverti.Click += new System.EventHandler(this.button1_Click);
      // 
      // txtRich
      // 
      this.txtRich.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtRich.Location = new System.Drawing.Point(12, 77);
      this.txtRich.Name = "txtRich";
      this.txtRich.Size = new System.Drawing.Size(955, 590);
      this.txtRich.TabIndex = 4;
      this.txtRich.Text = "";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(979, 679);
      this.Controls.Add(this.txtRich);
      this.Controls.Add(this.btnConverti);
      this.Controls.Add(this.lblFileSorgente);
      this.Controls.Add(this.label1);
      this.Name = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label lblFileSorgente;
    private System.Windows.Forms.Button btnConverti;
    private System.Windows.Forms.RichTextBox txtRich;
  }
}

