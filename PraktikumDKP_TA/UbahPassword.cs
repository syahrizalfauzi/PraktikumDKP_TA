using System;
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
            this.Close();
        }

        //Method button ubah password
        private void btnUbahPassword_Click(object sender, EventArgs e)
        {
            string passwordLama, passwordBaru, passwordBaruKonf;
            passwordLama = kolomPasswordLama.Text;
            passwordBaru = kolomPasswordBaru.Text;
            passwordBaruKonf = kolomPasswordBaruKonf.Text;

            //Password lama harus sama dengan password yang sekarang
            if (passwordLama != Program.akuns[indexAkun].GetPassword())
                MessageBox.Show("Password lama salah!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //Password tidak boleh kosong
            else if (passwordBaru == "")
                MessageBox.Show("Password baru tidak boleh kosong!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //Konfirmasi password
            else if (passwordBaruKonf != passwordBaru)
                MessageBox.Show("Konfirmasi password baru tidak sama!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //Password baru tidak boleh sama dengan password lama
            else if (passwordLama == passwordBaru)
                MessageBox.Show("Password baru tidak boleh sama dengan password lama!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (passwordBaru.Length < 6 || passwordBaruKonf.Length < 6)
                MessageBox.Show("Password minimal 6 karakter", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //Kalau kondisi sudah benar semua
            else
            {
                Program.akuns[indexAkun].SetPassword(passwordBaru);
                MessageBox.Show("Perubahan password berhasil!", "Sukses!");
                LoginSukses ls = new LoginSukses(Program.akuns[indexAkun].GetNama(), indexAkun);
                ls.Show();
                this.Close();
            }
        }
    }
}
