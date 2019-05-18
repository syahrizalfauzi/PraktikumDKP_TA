namespace PraktikumDKP_TA
{
	partial class UbahPassword
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
			this.label2 = new System.Windows.Forms.Label();
			this.kolomPasswordLama = new System.Windows.Forms.TextBox();
			this.kolomPasswordBaru = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.kolomPasswordBaruKonf = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnUbahPassword = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(349, 76);
			this.label1.TabIndex = 0;
			this.label1.Text = "Perubahan Password";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 76);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(78, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Password lama";
			// 
			// kolomPasswordLama
			// 
			this.kolomPasswordLama.Location = new System.Drawing.Point(96, 73);
			this.kolomPasswordLama.Name = "kolomPasswordLama";
			this.kolomPasswordLama.Size = new System.Drawing.Size(230, 20);
			this.kolomPasswordLama.TabIndex = 1;
			this.kolomPasswordLama.UseSystemPasswordChar = true;
			// 
			// kolomPasswordBaru
			// 
			this.kolomPasswordBaru.Location = new System.Drawing.Point(96, 99);
			this.kolomPasswordBaru.Name = "kolomPasswordBaru";
			this.kolomPasswordBaru.Size = new System.Drawing.Size(230, 20);
			this.kolomPasswordBaru.TabIndex = 2;
			this.kolomPasswordBaru.UseSystemPasswordChar = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 102);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(77, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Password baru";
			// 
			// kolomPasswordBaruKonf
			// 
			this.kolomPasswordBaruKonf.Location = new System.Drawing.Point(96, 128);
			this.kolomPasswordBaruKonf.Name = "kolomPasswordBaruKonf";
			this.kolomPasswordBaruKonf.Size = new System.Drawing.Size(230, 20);
			this.kolomPasswordBaruKonf.TabIndex = 3;
			this.kolomPasswordBaruKonf.UseSystemPasswordChar = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 128);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(76, 26);
			this.label4.TabIndex = 5;
			this.label4.Text = "Konfirmasi \r\npassword baru";
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(15, 164);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 5;
			this.btnCancel.Text = "<< Kembali";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnUbahPassword
			// 
			this.btnUbahPassword.Location = new System.Drawing.Point(96, 164);
			this.btnUbahPassword.Name = "btnUbahPassword";
			this.btnUbahPassword.Size = new System.Drawing.Size(230, 23);
			this.btnUbahPassword.TabIndex = 4;
			this.btnUbahPassword.Text = "Ubah!";
			this.btnUbahPassword.UseVisualStyleBackColor = true;
			this.btnUbahPassword.Click += new System.EventHandler(this.btnUbahPassword_Click);
			// 
			// UbahPassword
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(349, 199);
			this.Controls.Add(this.btnUbahPassword);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.kolomPasswordBaruKonf);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.kolomPasswordBaru);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.kolomPasswordLama);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "UbahPassword";
			this.Text = "Perubahan Password";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox kolomPasswordLama;
		private System.Windows.Forms.TextBox kolomPasswordBaru;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox kolomPasswordBaruKonf;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnUbahPassword;
	}
}