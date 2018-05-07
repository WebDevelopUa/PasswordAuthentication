using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Lab
{
	public class MainForm : Form
	{
		private const string fileName = "users.txt";

		private List<UserAccount> users = new List<UserAccount>();

		private UserAccount user;

		private IContainer components;

		private ToolStripContainer toolStripContainer1;

		private MenuStrip menuStrip1;

		private ToolStripMenuItem файлToolStripMenuItem;

		private ToolStripMenuItem справкаToolStripMenuItem;

		private ToolStripMenuItem оПрограммеToolStripMenuItem;

		private StatusStrip statusStrip1;

		private ToolStripStatusLabel toolStripStatusLabelSost;

		private ToolStripMenuItem файлToolStripMenuItem1;

		private ToolStripMenuItem выходToolStripMenuItem1;

		private ToolStripMenuItem изменитьПарольToolStripMenuItem;

		private ToolStripMenuItem списокПользователейToolStripMenuItem;

		private ToolStripMenuItem добавитьПользователяToolStripMenuItem;

		private ToolStripMenuItem редактированиеПользователяToolStripMenuItem;

		private ToolStripSeparator toolStripSeparator1;

		public MainForm()
		{
			this.InitializeComponent();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.toolStripContainer1 = new ToolStripContainer();
			this.statusStrip1 = new StatusStrip();
			this.toolStripStatusLabelSost = new ToolStripStatusLabel();
			this.menuStrip1 = new MenuStrip();
			this.файлToolStripMenuItem1 = new ToolStripMenuItem();
			this.выходToolStripMenuItem1 = new ToolStripMenuItem();
			this.файлToolStripMenuItem = new ToolStripMenuItem();
			this.изменитьПарольToolStripMenuItem = new ToolStripMenuItem();
			this.toolStripSeparator1 = new ToolStripSeparator();
			this.списокПользователейToolStripMenuItem = new ToolStripMenuItem();
			this.редактированиеПользователяToolStripMenuItem = new ToolStripMenuItem();
			this.добавитьПользователяToolStripMenuItem = new ToolStripMenuItem();
			this.справкаToolStripMenuItem = new ToolStripMenuItem();
			this.оПрограммеToolStripMenuItem = new ToolStripMenuItem();
			this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
			this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
			this.toolStripContainer1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			base.SuspendLayout();
			this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.statusStrip1);
			this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(698, 392);
			this.toolStripContainer1.Dock = DockStyle.Fill;
			this.toolStripContainer1.Location = new Point(0, 0);
			this.toolStripContainer1.Name = "toolStripContainer1";
			this.toolStripContainer1.Size = new System.Drawing.Size(698, 455);
			this.toolStripContainer1.TabIndex = 0;
			this.toolStripContainer1.Text = "toolStripContainer1";
			this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip1);
			this.statusStrip1.Dock = DockStyle.None;
			this.statusStrip1.Items.AddRange(new ToolStripItem[] { this.toolStripStatusLabelSost });
			this.statusStrip1.Location = new Point(0, 0);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(698, 30);
			this.statusStrip1.TabIndex = 0;
			this.toolStripStatusLabelSost.Name = "toolStripStatusLabelSost";
			this.toolStripStatusLabelSost.Size = new System.Drawing.Size(178, 25);
			this.toolStripStatusLabelSost.Text = "Нет аутентификации";
			this.menuStrip1.Dock = DockStyle.None;
			ToolStripItemCollection items = this.menuStrip1.Items;
			ToolStripItem[] toolStripItemArray = new ToolStripItem[] { this.файлToolStripMenuItem1, this.файлToolStripMenuItem, this.справкаToolStripMenuItem };
			items.AddRange(toolStripItemArray);
			this.menuStrip1.Location = new Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(698, 33);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			this.файлToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { this.выходToolStripMenuItem1 });
			this.файлToolStripMenuItem1.Name = "файлToolStripMenuItem1";
			this.файлToolStripMenuItem1.Size = new System.Drawing.Size(65, 29);
			this.файлToolStripMenuItem1.Text = "&Файл";
			this.выходToolStripMenuItem1.Name = "выходToolStripMenuItem1";
			this.выходToolStripMenuItem1.Size = new System.Drawing.Size(136, 30);
			this.выходToolStripMenuItem1.Text = "&Выход";
			this.выходToolStripMenuItem1.Click += new EventHandler(this.выходToolStripMenuItem1_Click);
			ToolStripItemCollection dropDownItems = this.файлToolStripMenuItem.DropDownItems;
			ToolStripItem[] toolStripItemArray1 = new ToolStripItem[] { this.изменитьПарольToolStripMenuItem, this.toolStripSeparator1, this.списокПользователейToolStripMenuItem, this.редактированиеПользователяToolStripMenuItem, this.добавитьПользователяToolStripMenuItem };
			dropDownItems.AddRange(toolStripItemArray1);
			this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
			this.файлToolStripMenuItem.Size = new System.Drawing.Size(112, 29);
			this.файлToolStripMenuItem.Text = "&Настройки";
			this.изменитьПарольToolStripMenuItem.Name = "изменитьПарольToolStripMenuItem";
			this.изменитьПарольToolStripMenuItem.Size = new System.Drawing.Size(344, 30);
			this.изменитьПарольToolStripMenuItem.Text = "Изменить пароль";
			this.изменитьПарольToolStripMenuItem.Click += new EventHandler(this.изменитьПарольToolStripMenuItem_Click);
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(341, 6);
			this.списокПользователейToolStripMenuItem.Name = "списокПользователейToolStripMenuItem";
			this.списокПользователейToolStripMenuItem.Size = new System.Drawing.Size(344, 30);
			this.списокПользователейToolStripMenuItem.Text = "Список пользователей";
			this.списокПользователейToolStripMenuItem.Click += new EventHandler(this.списокПользователейToolStripMenuItem_Click);
			this.редактированиеПользователяToolStripMenuItem.Name = "редактированиеПользователяToolStripMenuItem";
			this.редактированиеПользователяToolStripMenuItem.Size = new System.Drawing.Size(344, 30);
			this.редактированиеПользователяToolStripMenuItem.Text = "Редактирование пользователей";
			this.редактированиеПользователяToolStripMenuItem.Click += new EventHandler(this.редактированиеПользователяToolStripMenuItem_Click);
			this.добавитьПользователяToolStripMenuItem.Name = "добавитьПользователяToolStripMenuItem";
			this.добавитьПользователяToolStripMenuItem.Size = new System.Drawing.Size(344, 30);
			this.добавитьПользователяToolStripMenuItem.Text = "Добавить пользователя";
			this.добавитьПользователяToolStripMenuItem.Click += new EventHandler(this.добавитьПользователяToolStripMenuItem_Click);
			this.справкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { this.оПрограммеToolStripMenuItem });
			this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
			this.справкаToolStripMenuItem.Size = new System.Drawing.Size(93, 29);
			this.справкаToolStripMenuItem.Text = "&Справка";
			this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
			this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(197, 30);
			this.оПрограммеToolStripMenuItem.Text = "&О программе";
			this.оПрограммеToolStripMenuItem.Click += new EventHandler(this.оПрограммеToolStripMenuItem_Click);
			base.AutoScaleDimensions = new SizeF(9f, 20f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(698, 455);
			base.Controls.Add(this.toolStripContainer1);
			base.MainMenuStrip = this.menuStrip1;
			base.Name = "MainForm";
			this.Text = "Парольная аутентификация";
			base.FormClosing += new FormClosingEventHandler(this.MainForm_FormClosing);
			base.Load += new EventHandler(this.MainForm_Load);
			this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
			this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
			this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
			this.toolStripContainer1.TopToolStripPanel.PerformLayout();
			this.toolStripContainer1.ResumeLayout(false);
			this.toolStripContainer1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			base.ResumeLayout(false);
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			BinaryWriter binaryWriter = null;
			try
			{
				binaryWriter = new BinaryWriter(File.Open("users.txt", FileMode.OpenOrCreate, FileAccess.Write));
				foreach (UserAccount user in this.users)
				{
					binaryWriter.Write(user.Name);
					binaryWriter.Write(user.Password);
					binaryWriter.Write(user.isBlocked);
					binaryWriter.Write(user.isPwdOgr);
				}
				binaryWriter.Close();
			}
			catch
			{
				if (binaryWriter != null)
				{
					binaryWriter.Close();
				}
			}
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			BinaryReader binaryReader = null;
			if (!File.Exists("users.txt"))
			{
				this.users.Add(new UserAccount("ADMIN", "", false, false));
			}
			else
			{
				try
				{
					binaryReader = new BinaryReader(File.Open("users.txt", FileMode.OpenOrCreate, FileAccess.Read));
					while (binaryReader.BaseStream.Position != binaryReader.BaseStream.Length)
					{
						this.users.Add(new UserAccount(binaryReader.ReadString(), binaryReader.ReadString(), binaryReader.ReadBoolean(), binaryReader.ReadBoolean()));
					}
					binaryReader.Close();
				}
				catch (Exception exception)
				{
					MessageBox.Show("Ошибка при чтении аккаунтов из файла");
					if (binaryReader != null)
					{
						binaryReader.Close();
					}
					base.Close();
					return;
				}
			}
			this.user = null;
			LoginForm loginForm = new LoginForm();
			int num = 0;
			bool flag = false;
			bool flag1 = false;
			while (true)
			{
				if (loginForm.ShowDialog() != System.Windows.Forms.DialogResult.OK)
				{
					base.Close();
					return;
				}
				else
				{
					flag = false;
					flag1 = false;
					foreach (UserAccount user in this.users)
					{
						this.user = user;
						if (this.user.Name == loginForm.userName && (this.user.Password == loginForm.userPwd || this.user.Password == ""))
						{
							flag = true;
							flag1 = true;
							break;
						}
						else if (!(this.user.Name == loginForm.userName) || !this.user.isBlocked)
						{
							if (!(this.user.Name == loginForm.userName) || !(this.user.Password != loginForm.userPwd))
							{
								continue;
							}
							flag = true;
							int num1 = num + 1;
							num = num1;
							if (num1 != 3)
							{
								MessageBox.Show("Введен неверный пароль, повторите ввод", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
								break;
							}
							else
							{
								MessageBox.Show("Вы трехкратно ввели неверный пароль, работа будет завершена", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
								break;
							}
						}
						else
						{
							flag = true;
							break;
						}
					}
					if (flag && this.user.isBlocked)
					{
						MessageBox.Show(string.Concat("Пользователь ", this.user.Name, " заблокирован"), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
					}
					else if (flag)
					{
						if (flag && num == 3)
						{
							break;
						}
						if (flag && flag1)
						{
							this.toolStripStatusLabelSost.Text = string.Concat("Зарегистрирован: ", loginForm.userName);
							if (loginForm.userName == "ADMIN")
							{
								break;
							}
							this.toolStripSeparator1.Visible = false;
							this.списокПользователейToolStripMenuItem.Visible = false;
							this.добавитьПользователяToolStripMenuItem.Visible = false;
							this.редактированиеПользователяToolStripMenuItem.Visible = false;
							break;
						}
					}
					else
					{
						MessageBox.Show(string.Concat("Не найден пользователь с именем ", loginForm.userName, ". Повторите ввод"), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
						num = 0;
					}
				}
			}
			if (!flag || !flag1)
			{
				base.Close();
			}
			if (this.user.Password == "")
			{
				NewPasswordForm newPasswordForm = new NewPasswordForm();
				if (newPasswordForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
				{
					if (this.user.isPwdOgr)
					{
						if (UserAccount.checkPassword(newPasswordForm.newPwd))
						{
							this.user.Password = newPasswordForm.newPwd;
							return;
						}
						MessageBox.Show("Пароль не удовлетворяет требованиям!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
						return;
					}
					this.user.Password = newPasswordForm.newPwd;
				}
			}
		}

		private void выходToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		private void добавитьПользователяToolStripMenuItem_Click(object sender, EventArgs e)
		{
			while (true)
			{
				bool flag = true;
				AddUserForm addUserForm = new AddUserForm();
				if (addUserForm.ShowDialog() != System.Windows.Forms.DialogResult.OK)
				{
					break;
				}
				foreach (UserAccount user in this.users)
				{
					if (user.Name != addUserForm.userName)
					{
						continue;
					}
					MessageBox.Show(string.Concat("Пользователь ", addUserForm.userName, " уже существует, введите другое имя"), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
					flag = false;
					break;
				}
				if (flag)
				{
					this.users.Add(new UserAccount(addUserForm.userName, "", addUserForm.userBlocked, addUserForm.userPwdOgr));
					break;
				}
			}
		}

		private void изменитьПарольToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ChangePasswordForm changePasswordForm = new ChangePasswordForm();
			if (changePasswordForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				if (this.user.Password == changePasswordForm.oldPassword)
				{
					if (!this.user.isPwdOgr)
					{
						this.user.Password = changePasswordForm.newPassword;
						return;
					}
					if (UserAccount.checkPassword(changePasswordForm.newPassword))
					{
						this.user.Password = changePasswordForm.newPassword;
						return;
					}
					MessageBox.Show("Пароль не удовлетворяет требованиям!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
					return;
				}
				MessageBox.Show("Ошибка при вводе старого пароля, пароль не изменен", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
		{
			(new AboutForm()).ShowDialog();
		}

		private void редактированиеПользователяToolStripMenuItem_Click(object sender, EventArgs e)
		{
			(new EditUserForm(this.users)).ShowDialog();
		}

		private void списокПользователейToolStripMenuItem_Click(object sender, EventArgs e)
		{
			(new ListUserForm(this.users)).ShowDialog();
		}
	}
}