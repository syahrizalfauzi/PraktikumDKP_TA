namespace PraktikumDKP_TA
{
	partial class UbahNama
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
			this.kolomNamaBaru = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnUbahPassword = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(349, 60);
			this.label1.TabIndex = 1;
			this.label1.Text = "Perubahan Nama";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// kolomNamaBaru
			// 
			this.kolomNamaBaru.Location = new System.Drawing.Point(14, 87);
			this.kolomNamaBaru.Name = "kolomNamaBaru";
			this.kolomNamaBaru.Size = new System.Drawing.Size(323, 20);
			this.kolomNamaBaru.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Dock = System.Windows.Forms.DockStyle.Top;
			this.label2.Location = new System.Drawing.Point(0, 60);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(349, 24);
			this.label2.TabIndex = 8;
			this.label2.Text = "Nama baru";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnUbahPassword
			// 
			this.btnUbahPassword.Location = new System.Drawing.Point(95, 123);
			this.btnUbahPassword.Name = "btnUbahPassword";
			this.btnUbahPassword.Size = new System.Drawing.Size(242, 23);
			this.btnUbahPassword.TabIndex = 2;
			this.btnUbahPassword.Text = "Ubah!";
			this.btnUbahPassword.UseVisualStyleBackColor = true;
			this.btnUbahPassword.Click += new System.EventHandler(this.btnUbahPassword_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(14, 123);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 3;
			this.btnCancel.Text = "<< Kembali";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
			// 
			// UbahNama
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(349, 162);
			this.Controls.Add(this.btnUbahPassword);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.kolomNamaBaru);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "UbahNama";
			this.Text = "Perubahan Nama";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox kolomNamaBaru;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnUbahPassword;
		private System.Windows.Forms.Button btnCancel;
	}
}