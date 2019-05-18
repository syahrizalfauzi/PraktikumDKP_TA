using System;
using System.Windows.Forms;

namespace PraktikumDKP_TA
{
	public partial class LoginSukses : Form
	{
		int indexAkun;

		public LoginSukses(string nama, int indexAkun)
		{
			InitializeComponent();
			this.indexAkun = indexAkun;
			labelNama.Text = "Selamat Datang!\n" + nama + "!";
		}

		private void buttonSelesai_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void buttonKembali_Click(object sender, EventArgs e)
		{
			Form1 form1 = new Form1();
			form1.Show();
			this.Hide();
		}

		private void labelNama_Click(object sender, EventArgs e)
		{

		}

		private void btnUbahPassword_Click(object sender, EventArgs e)
		{
			UbahPassword up = new UbahPassword(indexAkun);
			up.Show();
			this.Hide();
		}

		private void btnUbahNama_Click(object sender, EventArgs e)
		{
			UbahNama un = new UbahNama(indexAkun);
			un.Show();
			this.Hide();
		}
	}
}
