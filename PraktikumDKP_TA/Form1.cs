using System;
using System.Windows.Forms;

namespace PraktikumDKP_TA
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            Program.akuns.Add(new Akun("user", "pass", "Admin"));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //Button Login
        private void button1_Click(object sender, EventArgs e)
        {
            string username, password;
            username = usernameBox.Text;
            password = passwordBox.Text;

            //Username & password harus tidak kosong
            if (username != "" && password != "")
            {
                //Cek ada akun atau tidak
                for (int i = 0; i < Program.akuns.Count; i++)
                {
                    //Username & password benar
                    if (Program.akuns[i].GetUsername() == username && Program.akuns[i].GetPassword() == password)
                    {
                        LoginSukses ls = new LoginSukses(Program.akuns[i].GetNama(), i);
                        ls.Show();
                        this.Hide();
                        break;
                    }
                    //Username benar, password salah
                    else if (Program.akuns[i].GetUsername() == username && Program.akuns[i].GetPassword() != password)
                    {
                        MessageBox.Show("Mohon cek username dan password anda", "Identitas Salah!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    //Username & password salah
                    else if (i == Program.akuns.Count - 1 && Program.akuns[i].GetUsername() != username && Program.akuns[i].GetPassword() != password)
                    {
                        MessageBox.Show("Tidak ada akun yang menggunakan username ini", "Login Gagal!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Username dan password kosong", "Login Gagal!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Button Daftar
        private void button2_Click(object sender, EventArgs e)
        {
            RegisterForm rf = new RegisterForm();
			rf.Show();
			this.Hide();
		}
    }
}
