using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PraktikumDKP_TA
{
	public partial class UbahPassword : Form
	{
		int indexAkun;

		public UbahPassword(int indexAkun)
		{
			InitializeComponent();
			this.indexAkun = indexAkun;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			LoginSukses ls = new LoginSukses(Program.akuns[indexAkun].GetNama(), indexAkun);
			ls.Show();
			this.Hide();
		}

		private void btnUbahPassword_Click(object sender, EventArgs e)
		{
			string passwordLama, passwordBaru, passwordBaruKonf;
			passwordLama = kolomPasswordLama.Text;
			passwordBaru = kolomPasswordBaru.Text;
			passwordBaruKonf = kolomPasswordBaruKonf.Text;
			if (passwordLama != Program.akuns[indexAkun].GetPassword())
				MessageBox.Show("Password lama salah!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
			//else if (passwordLama == "")
			//	MessageBox.Show("Password lama salah!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
			else if (passwordBaru == "")
				MessageBox.Show("Password baru tidak boleh kosong!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
			else if (passwordBaruKonf != passwordBaru)
				MessageBox.Show("Konfirmasi password baru tidak sama!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
			else if (passwordLama == passwordBaru)
				MessageBox.Show("Password baru tidak boleh sama dengan password lama!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
			else
			{
				Program.akuns[indexAkun].SetPassword(passwordBaru);
				MessageBox.Show("Perubahan password berhasil!", "Sukses!");
				LoginSukses ls = new LoginSukses(Program.akuns[indexAkun].GetNama(), indexAkun);
				ls.Show();
				this.Hide();
			}
		}
	}
}
