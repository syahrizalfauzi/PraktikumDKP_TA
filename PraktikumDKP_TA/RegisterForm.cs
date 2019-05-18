using System;
using System.Windows.Forms;

namespace PraktikumDKP_TA
{
	public partial class RegisterForm : Form
	{
		public RegisterForm()
		{
			InitializeComponent();
		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		//Button kembali
		private void button1_Click(object sender, EventArgs e)
		{
			Form1 form1 = new Form1();
			form1.Show();
			this.Hide();
		}

		//Button DAFTAR!
		private void button2_Click(object sender, EventArgs e)
		{
			string username = usernameBox.Text;
			string password = passwordBox.Text;
			string nama = namaBox.Text;
			//Username, password, dan nama tidak boleh kosong
			if (username != "" && password != "" && nama != "")
			{
				//Cek semua akun jika username-nya yang sama
				for (int i = 0; i < Program.akuns.Count; i++)
				{
					//Kalau ada username yang sama
					if (Program.akuns[i].GetUsername() == usernameBox.Text)
					{
						MessageBox.Show("Username sudah diambil", "Pendaftaran gagal!", MessageBoxButtons.OK, MessageBoxIcon.Error);
						break;
					}
					//Kalau tidak ada username yang sama
					else if (i == Program.akuns.Count - 1)
					{
						Program.akuns.Add(new Akun(username, password, nama));
						MessageBox.Show("Pendaftaran sukses!", "Berhasil!", MessageBoxButtons.OK);
						usernameBox.Clear();
						passwordBox.Clear();
						namaBox.Clear();
						break;
					}
				}
			}
			else
			{
				MessageBox.Show("Kolom pendaftaran tidak boleh ada yang kosong", "Pendaftaran gagal!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
