namespace Kalkulator
{
	partial class FormInput
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
			this.btnProses = new System.Windows.Forms.Button();
			this.txtNilaiB = new System.Windows.Forms.TextBox();
			this.txtNilaiA = new System.Windows.Forms.TextBox();
			this.cmbOps = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.OpsLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnProses
			// 
			this.btnProses.Location = new System.Drawing.Point(163, 122);
			this.btnProses.Margin = new System.Windows.Forms.Padding(2);
			this.btnProses.Name = "btnProses";
			this.btnProses.Size = new System.Drawing.Size(58, 31);
			this.btnProses.TabIndex = 13;
			this.btnProses.Text = "Proses";
			this.btnProses.UseVisualStyleBackColor = true;
			this.btnProses.Click += new System.EventHandler(this.btnProses_Click);
			// 
			// txtNilaiB
			// 
			this.txtNilaiB.Location = new System.Drawing.Point(110, 85);
			this.txtNilaiB.Margin = new System.Windows.Forms.Padding(2);
			this.txtNilaiB.Name = "txtNilaiB";
			this.txtNilaiB.Size = new System.Drawing.Size(111, 22);
			this.txtNilaiB.TabIndex = 12;
			this.txtNilaiB.TextChanged += new System.EventHandler(this.txtNilaiB_TextChanged);
			// 
			// txtNilaiA
			// 
			this.txtNilaiA.Location = new System.Drawing.Point(110, 53);
			this.txtNilaiA.Margin = new System.Windows.Forms.Padding(2);
			this.txtNilaiA.Name = "txtNilaiA";
			this.txtNilaiA.Size = new System.Drawing.Size(111, 22);
			this.txtNilaiA.TabIndex = 11;
			this.txtNilaiA.TextChanged += new System.EventHandler(this.FormInput_TextChanged);
			// 
			// cmbOps
			// 
			this.cmbOps.FormattingEnabled = true;
			this.cmbOps.Location = new System.Drawing.Point(110, 11);
			this.cmbOps.Margin = new System.Windows.Forms.Padding(2);
			this.cmbOps.Name = "cmbOps";
			this.cmbOps.Size = new System.Drawing.Size(111, 24);
			this.cmbOps.TabIndex = 10;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(15, 88);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(46, 16);
			this.label3.TabIndex = 9;
			this.label3.Text = "Nilai B";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(15, 56);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(46, 16);
			this.label2.TabIndex = 8;
			this.label2.Text = "Nilai A";
			// 
			// OpsLabel
			// 
			this.OpsLabel.AutoSize = true;
			this.OpsLabel.Location = new System.Drawing.Point(15, 14);
			this.OpsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.OpsLabel.Name = "OpsLabel";
			this.OpsLabel.Size = new System.Drawing.Size(55, 16);
			this.OpsLabel.TabIndex = 7;
			this.OpsLabel.Text = "Operasi";
			// 
			// FormInput
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(232, 164);
			this.Controls.Add(this.btnProses);
			this.Controls.Add(this.txtNilaiB);
			this.Controls.Add(this.txtNilaiA);
			this.Controls.Add(this.cmbOps);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.OpsLabel);
			this.Name = "FormInput";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnProses;
		private System.Windows.Forms.TextBox txtNilaiB;
		private System.Windows.Forms.TextBox txtNilaiA;
		private System.Windows.Forms.ComboBox cmbOps;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label OpsLabel;
	}
}