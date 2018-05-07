using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Lab
{
	public class NewPasswordForm : Form
	{
		public string newPwd;

		private IContainer components;

		private Button buttonCancel;

		private Button buttonOK;

		private Label label2;

		private TextBox textBoxPwd1;

		private Label label3;

		private TextBox textBoxPwd2;

		public NewPasswordForm()
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
			this.buttonCancel = new Button();
			this.buttonOK = new Button();
			this.label2 = new Label();
			this.textBoxPwd1 = new TextBox();
			this.label3 = new Label();
			this.textBoxPwd2 = new TextBox();
			base.SuspendLayout();
			this.buttonCancel.AutoSize = true;
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new Point(196, 203);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(94, 35);
			this.buttonCancel.TabIndex = 3;
			this.buttonCancel.Text = "Отмена";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonOK.AutoSize = true;
			this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOK.Location = new Point(82, 203);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(94, 35);
			this.buttonOK.TabIndex = 2;
			this.buttonOK.Text = "ОК";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.label2.AutoSize = true;
			this.label2.Location = new Point(26, 23);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(139, 20);
			this.label2.TabIndex = 7;
			this.label2.Text = "Введите пароль:";
			this.textBoxPwd1.Location = new Point(28, 55);
			this.textBoxPwd1.Name = "textBoxPwd1";
			this.textBoxPwd1.PasswordChar = '*';
			this.textBoxPwd1.Size = new System.Drawing.Size(200, 26);
			this.textBoxPwd1.TabIndex = 0;
			this.label3.AutoSize = true;
			this.label3.Location = new Point(26, 98);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(139, 20);
			this.label3.TabIndex = 7;
			this.label3.Text = "Подтверждение:";
			this.textBoxPwd2.Location = new Point(28, 131);
			this.textBoxPwd2.Name = "textBoxPwd2";
			this.textBoxPwd2.PasswordChar = '*';
			this.textBoxPwd2.Size = new System.Drawing.Size(200, 26);
			this.textBoxPwd2.TabIndex = 1;
			base.AcceptButton = this.buttonOK;
			base.AutoScaleDimensions = new SizeF(9f, 20f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.CancelButton = this.buttonCancel;
			base.ClientSize = new System.Drawing.Size(375, 252);
			base.Controls.Add(this.textBoxPwd2);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.textBoxPwd1);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.buttonCancel);
			base.Controls.Add(this.buttonOK);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "NewPasswordForm";
			base.StartPosition = FormStartPosition.CenterParent;
			this.Text = "Создание пароля";
			base.FormClosing += new FormClosingEventHandler(this.NewPasswordForm_FormClosing);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private void NewPasswordForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (base.DialogResult == System.Windows.Forms.DialogResult.OK)
			{
				if (this.textBoxPwd1.Text != this.textBoxPwd2.Text)
				{
					MessageBox.Show("Пароль и подтверждение не совпадают, повторите ввод", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
					e.Cancel = true;
					return;
				}
				this.newPwd = this.textBoxPwd2.Text;
			}
		}
	}
}