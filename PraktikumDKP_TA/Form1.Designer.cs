namespace PraktikumDKP_TA
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
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.usernameBox = new System.Windows.Forms.TextBox();
			this.passwordBox = new System.Windows.Forms.TextBox();
			this.buttonLogin = new System.Windows.Forms.Button();
			this.buttonDaftar = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(515, 92);
			this.label1.TabIndex = 0;
			this.label1.Text = "TUGAS AKHIR PRAKTIKUM DKP\r\nmade by : Muhammad Syahrizal Fauzi";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(36, 91);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(97, 24);
			this.label2.TabIndex = 1;
			this.label2.Text = "Username";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(36, 128);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(92, 24);
			this.label3.TabIndex = 2;
			this.label3.Text = "Password";
			// 
			// usernameBox
			// 
			this.usernameBox.Location = new System.Drawing.Point(163, 95);
			this.usernameBox.Name = "usernameBox";
			this.usernameBox.Size = new System.Drawing.Size(310, 20);
			this.usernameBox.TabIndex = 1;
			// 
			// passwordBox
			// 
			this.passwordBox.Location = new System.Drawing.Point(163, 133);
			this.passwordBox.Name = "passwordBox";
			this.passwordBox.Size = new System.Drawing.Size(310, 20);
			this.passwordBox.TabIndex = 2;
			this.passwordBox.UseSystemPasswordChar = true;
			// 
			// buttonLogin
			// 
			this.buttonLogin.Location = new System.Drawing.Point(271, 164);
			this.buttonLogin.Name = "buttonLogin";
			this.buttonLogin.Size = new System.Drawing.Size(202, 34);
			this.buttonLogin.TabIndex = 3;
			this.buttonLogin.Text = "LOGIN";
			this.buttonLogin.UseVisualStyleBackColor = true;
			this.buttonLogin.Click += new System.EventHandler(this.button1_Click);
			// 
			// buttonDaftar
			// 
			this.buttonDaftar.Location = new System.Drawing.Point(163, 164);
			this.buttonDaftar.Name = "buttonDaftar";
			this.buttonDaftar.Size = new System.Drawing.Size(102, 34);
			this.buttonDaftar.TabIndex = 4;
			this.buttonDaftar.Text = "DAFTAR";
			this.buttonDaftar.UseVisualStyleBackColor = true;
			this.buttonDaftar.Click += new System.EventHandler(this.button2_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(37, 172);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(104, 26);
			this.label4.TabIndex = 7;
			this.label4.Text = "Belum punya akun? \r\nSilahkan daftar dulu";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(515, 224);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.buttonDaftar);
			this.Controls.Add(this.buttonLogin);
			this.Controls.Add(this.passwordBox);
			this.Controls.Add(this.usernameBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Tugas Akhir-nya Rizal";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox usernameBox;
		private System.Windows.Forms.TextBox passwordBox;
		private System.Windows.Forms.Button buttonLogin;
		private System.Windows.Forms.Button buttonDaftar;
		private System.Windows.Forms.Label label4;
	}
}

