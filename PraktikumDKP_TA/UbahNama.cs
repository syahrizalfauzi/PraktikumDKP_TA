using System;
using System.Windows.Forms;

namespace PraktikumDKP_TA
{
    public partial class UbahNama : Form
    {
        int indexAkun;

        public UbahNama(int indexAkun)
        {
            InitializeComponent();
            this.indexAkun = indexAkun;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            LoginSukses ls = new LoginSukses(Program.akuns[indexAkun].GetNama(), indexAkun);
            ls.Show();
            this.Hide();
        }

        //Method button ubah nama
        private void btnUbahPassword_Click(object sender, EventArgs e)
        {
            string namaBaru = kolomNamaBaru.Text;
            //Set nama akun menjadi namaBaru
            Program.akuns[indexAkun].SetNama(namaBaru);
            MessageBox.Show("Perubahan nama berhasil!", "Sukses!");
            LoginSukses ls = new LoginSukses(Program.akuns[indexAkun].GetNama(), indexAkun);
            ls.Show();
            this.Hide();
        }
    }
}
