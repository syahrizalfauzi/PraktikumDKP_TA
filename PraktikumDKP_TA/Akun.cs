using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraktikumDKP_TA
{
	public class Akun
	{
		private string username, password, nama;
		
		public Akun()
		{
			this.username = "";
			this.password = "";
			this.nama = "";
		}
		public Akun (string username, string password, string nama)
		{
			this.username = username;
			this.password = password;
			this.nama = nama;
		}
		public string GetNama()
		{
			if (nama == null)
				return "";
			else
				return nama;
		}
		public string GetUsername()
		{
			if (username == null)
				return "";
			else
				return username;
		}
		public string GetPassword()
		{
			if (password == null)
				return "";
			else
				return password;
		}
		public void SetPassword(string passwordBaru)
		{
			password = passwordBaru;
		}
		public void SetNama(string namaBaru)
		{
			nama = namaBaru;
		}
	}
}
