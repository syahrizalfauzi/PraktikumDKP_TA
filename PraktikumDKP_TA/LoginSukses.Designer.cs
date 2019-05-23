namespace PraktikumDKP_TA
{
	partial class LoginSukses
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
			this.labelNama = new System.Windows.Forms.Label();
			this.buttonSelesai = new System.Windows.Forms.Button();
			this.buttonKembali = new System.Windows.Forms.Button();
			this.btnUbahPassword = new System.Windows.Forms.Button();
			this.btnUbahNama = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// labelNama
			// 
			this.labelNama.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelNama.Location = new System.Drawing.Point(0, 0);
			this.labelNama.Name = "labelNama";
			this.labelNama.Size = new System.Drawing.Size(334, 123);
			this.labelNama.TabIndex = 0;
			this.labelNama.Text = "Selamat Datang\r\nnama!\r\nUsername anda : username";
			this.labelNama.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelNama.Click += new System.EventHandler(this.labelNama_Click);
			// 
			// buttonSelesai
			// 
			this.buttonSelesai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.buttonSelesai.Location = new System.Drawing.Point(197, 126);
			this.buttonSelesai.Name = "buttonSelesai";
			this.buttonSelesai.Size = new System.Drawing.Size(92, 33);
			this.buttonSelesai.TabIndex = 4;
			this.buttonSelesai.Text = "Selesai";
			this.buttonSelesai.UseVisualStyleBackColor = true;
			this.buttonSelesai.Click += new System.EventHandler(this.buttonSelesai_Click);
			// 
			// buttonKembali
			// 
			this.buttonKembali.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.buttonKembali.Location = new System.Drawing.Point(40, 126);
			this.buttonKembali.Name = "buttonKembali";
			this.buttonKembali.Size = new System.Drawing.Size(92, 33);
			this.buttonKembali.TabIndex = 1;
			this.buttonKembali.Text = "Log out";
			this.buttonKembali.UseVisualStyleBackColor = true;
			this.buttonKembali.Click += new System.EventHandler(this.buttonKembali_Click);
			// 
			// btnUbahPassword
			// 
			this.btnUbahPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.btnUbahPassword.Location = new System.Drawing.Point(40, 174);
			this.btnUbahPassword.Name = "btnUbahPassword";
			this.btnUbahPassword.Size = new System.Drawing.Size(117, 33);
			this.btnUbahPassword.TabIndex = 2;
			this.btnUbahPassword.Text = "Ubah password";
			this.btnUbahPassword.UseVisualStyleBackColor = true;
			this.btnUbahPassword.Click += new System.EventHandler(this.btnUbahPassword_Click);
			// 
			// btnUbahNama
			// 
			this.btnUbahNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.btnUbahNama.Location = new System.Drawing.Point(172, 174);
			this.btnUbahNama.Name = "btnUbahNama";
			this.btnUbahNama.Size = new System.Drawing.Size(117, 33);
			this.btnUbahNama.TabIndex = 3;
			this.btnUbahNama.Text = "Ubah nama";
			this.btnUbahNama.UseVisualStyleBackColor = true;
			this.btnUbahNama.Click += new System.EventHandler(this.btnUbahNama_Click);
			// 
			// LoginSukses
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(334, 219);
			this.Controls.Add(this.btnUbahNama);
			this.Controls.Add(this.btnUbahPassword);
			this.Controls.Add(this.buttonKembali);
			this.Controls.Add(this.buttonSelesai);
			this.Controls.Add(this.labelNama);
			this.MaximizeBox = false;
			this.Name = "LoginSukses";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login Sukses";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label labelNama;
		private System.Windows.Forms.Button buttonSelesai;
		private System.Windows.Forms.Button buttonKembali;
		private System.Windows.Forms.Button btnUbahPassword;
		private System.Windows.Forms.Button btnUbahNama;
	}
}