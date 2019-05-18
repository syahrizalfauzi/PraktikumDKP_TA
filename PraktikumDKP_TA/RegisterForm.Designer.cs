namespace PraktikumDKP_TA
{
	partial class RegisterForm
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
			this.namaBox = new System.Windows.Forms.TextBox();
			this.buttonKembali = new System.Windows.Forms.Button();
			this.buttonDaftar = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.passwordBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(347, 55);
			this.label1.TabIndex = 0;
			this.label1.Text = "Pendaftaran Akun";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.label2.Location = new System.Drawing.Point(23, 55);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Username";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.label3.Location = new System.Drawing.Point(23, 107);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Password";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// usernameBox
			// 
			this.usernameBox.Location = new System.Drawing.Point(98, 52);
			this.usernameBox.Name = "usernameBox";
			this.usernameBox.Size = new System.Drawing.Size(225, 20);
			this.usernameBox.TabIndex = 1;
			// 
			// namaBox
			// 
			this.namaBox.Location = new System.Drawing.Point(98, 78);
			this.namaBox.Name = "namaBox";
			this.namaBox.Size = new System.Drawing.Size(225, 20);
			this.namaBox.TabIndex = 2;
			// 
			// buttonKembali
			// 
			this.buttonKembali.Location = new System.Drawing.Point(26, 141);
			this.buttonKembali.Name = "buttonKembali";
			this.buttonKembali.Size = new System.Drawing.Size(75, 23);
			this.buttonKembali.TabIndex = 5;
			this.buttonKembali.Text = "<< Kembali";
			this.buttonKembali.UseVisualStyleBackColor = true;
			this.buttonKembali.Click += new System.EventHandler(this.button1_Click);
			// 
			// buttonDaftar
			// 
			this.buttonDaftar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.buttonDaftar.Location = new System.Drawing.Point(107, 141);
			this.buttonDaftar.Name = "buttonDaftar";
			this.buttonDaftar.Size = new System.Drawing.Size(216, 23);
			this.buttonDaftar.TabIndex = 4;
			this.buttonDaftar.Text = "DAFTAR!";
			this.buttonDaftar.UseVisualStyleBackColor = true;
			this.buttonDaftar.Click += new System.EventHandler(this.button2_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.label4.Location = new System.Drawing.Point(23, 81);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(35, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Nama";
			// 
			// passwordBox
			// 
			this.passwordBox.Location = new System.Drawing.Point(98, 104);
			this.passwordBox.Name = "passwordBox";
			this.passwordBox.Size = new System.Drawing.Size(225, 20);
			this.passwordBox.TabIndex = 3;
			this.passwordBox.UseSystemPasswordChar = true;
			// 
			// RegisterForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(347, 183);
			this.Controls.Add(this.passwordBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.buttonDaftar);
			this.Controls.Add(this.buttonKembali);
			this.Controls.Add(this.namaBox);
			this.Controls.Add(this.usernameBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "RegisterForm";
			this.Text = "Daftar Akun";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox usernameBox;
		private System.Windows.Forms.TextBox namaBox;
		private System.Windows.Forms.Button buttonKembali;
		private System.Windows.Forms.Button buttonDaftar;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox passwordBox;
	}
}