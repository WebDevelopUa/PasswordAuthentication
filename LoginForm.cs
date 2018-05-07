using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Lab
{
	public class LoginForm : Form
	{
		public string userName;

		public string userPwd;

		private IContainer components;

		private Label label1;

		private TextBox textBoxName;

		private Label labelPassword;

		private TextBox textBoxPassword;

		private Button buttonOK;

		private Button buttonCancel;

		public LoginForm()
		{
			this.InitializeComponent();
		}

		private void buttonOK_Click(object sender, EventArgs e)
		{
			this.userName = this.textBoxName.Text;
			this.userPwd = this.textBoxPassword.Text;
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
			this.label1 = new Label();
			this.textBoxName = new TextBox();
			this.labelPassword = new Label();
			this.textBoxPassword = new TextBox();
			this.buttonOK = new Button();
			this.buttonCancel = new Button();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Location = new Point(21, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(113, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Введите имя:";
			this.textBoxName.Location = new Point(25, 58);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(243, 26);
			this.textBoxName.TabIndex = 0;
			this.labelPassword.AutoSize = true;
			this.labelPassword.Location = new Point(21, 106);
			this.labelPassword.Name = "labelPassword";
			this.labelPassword.Size = new System.Drawing.Size(139, 20);
			this.labelPassword.TabIndex = 2;
			this.labelPassword.Text = "Введите пароль:";
			this.textBoxPassword.Location = new Point(25, 139);
			this.textBoxPassword.Name = "textBoxPassword";
			this.textBoxPassword.PasswordChar = '*';
			this.textBoxPassword.Size = new System.Drawing.Size(243, 26);
			this.textBoxPassword.TabIndex = 1;
			this.buttonOK.AutoSize = true;
			this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOK.Location = new Point(86, 217);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(95, 30);
			this.buttonOK.TabIndex = 2;
			this.buttonOK.Text = "ОК";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new EventHandler(this.buttonOK_Click);
			this.buttonCancel.AutoSize = true;
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new Point(199, 217);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(95, 30);
			this.buttonCancel.TabIndex = 3;
			this.buttonCancel.Text = "Отмена";
			this.buttonCancel.UseVisualStyleBackColor = true;
			base.AcceptButton = this.buttonOK;
			base.AutoScaleDimensions = new SizeF(9f, 20f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.CancelButton = this.buttonCancel;
			base.ClientSize = new System.Drawing.Size(381, 260);
			base.Controls.Add(this.buttonCancel);
			base.Controls.Add(this.buttonOK);
			base.Controls.Add(this.textBoxPassword);
			base.Controls.Add(this.labelPassword);
			base.Controls.Add(this.textBoxName);
			base.Controls.Add(this.label1);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "LoginForm";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Вход в систему";
			base.ResumeLayout(false);
			base.PerformLayout();
		}
	}
}