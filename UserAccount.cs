using System;
using System.Runtime.CompilerServices;

namespace Lab
{
	public class UserAccount
	{
		public bool isBlocked
		{
			get;
			set;
		}

		public bool isPwdOgr
		{
			get;
			set;
		}

		public string Name
		{
			get;
			set;
		}

		public string Password
		{
			get;
			set;
		}

		public UserAccount(string n, string p, bool fb, bool fp)
		{
			this.Name = n;
			this.Password = p;
			this.isBlocked = fb;
			this.isPwdOgr = fp;
		}

		public static bool checkPassword(string pwd)
		{
			for (int i = 0; i < pwd.Length; i++)
			{
				if (!char.IsLetter(pwd[i]) && pwd[i] != '-' && pwd[i] != '+' && pwd[i] != '*' && pwd[i] != '/' && pwd[i] != '%')
				{
					return false;
				}
			}
			return true;
		}
	}
}