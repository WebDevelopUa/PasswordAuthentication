using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Lab
{
	public class ChangePasswordForm : Form
	{
		private IContainer components;

		private Button buttonCancel;

		private Button buttonOK;

		private Label label1;

		private TextBox textBoxPwdOld;

		private Label label2;

		private TextBox textBoxPwdNew;

		private Label label3;

		private TextBox textBoxPwdNew1;

		public string oldPassword;

		public string newPassword;

		public ChangePasswordForm()
		{
			this.InitializeComponent();
		}

		private void ChangePasswordForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (base.DialogResult == System.Windows.Forms.DialogResult.OK)
			{
				if (this.textBoxPwdNew.Text == this.textBoxPwdNew1.Text)
				{
					this.newPassword = this.textBoxPwdNew.Text;
					this.oldPassword = this.textBoxPwdOld.Text;
					return;
				}
				e.Cancel = true;
				MessageBox.Show("Новый пароль и подтверждение не совпадают, повторите ввод", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
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
			this.label1 = new Label();
			this.textBoxPwdOld = new TextBox();
			this.label2 = new Label();
			this.textBoxPwdNew = new TextBox();
			this.label3 = new Label();
			this.textBoxPwdNew1 = new TextBox();
			base.SuspendLayout();
			this.buttonCancel.AutoSize = true;
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new Point(194, 271);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(94, 35);
			this.buttonCancel.TabIndex = 4;
			this.buttonCancel.Text = "Отмена";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonOK.AutoSize = true;
			this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOK.Location = new Point(80, 271);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(94, 35);
			this.buttonOK.TabIndex = 3;
			this.buttonOK.Text = "ОК";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.label1.AutoSize = true;
			this.label1.Location = new Point(28, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(130, 20);
			this.label1.TabIndex = 7;
			this.label1.Text = "Старый пароль:";
			this.textBoxPwdOld.Location = new Point(33, 52);
			this.textBoxPwdOld.Name = "textBoxPwdOld";
			this.textBoxPwdOld.PasswordChar = '*';
			this.textBoxPwdOld.Size = new System.Drawing.Size(200, 26);
			this.textBoxPwdOld.TabIndex = 0;
			this.label2.AutoSize = true;
			this.label2.Location = new Point(28, 88);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(122, 20);
			this.label2.TabIndex = 7;
			this.label2.Text = "Новый пароль:";
			this.textBoxPwdNew.Location = new Point(33, 118);
			this.textBoxPwdNew.Name = "textBoxPwdNew";
			this.textBoxPwdNew.PasswordChar = '*';
			this.textBoxPwdNew.Size = new System.Drawing.Size(200, 26);
			this.textBoxPwdNew.TabIndex = 1;
			this.label3.AutoSize = true;
			this.label3.Location = new Point(28, 163);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(139, 20);
			this.label3.TabIndex = 7;
			this.label3.Text = "Подтверждение:";
			this.textBoxPwdNew1.Location = new Point(33, 195);
			this.textBoxPwdNew1.Name = "textBoxPwdNew1";
			this.textBoxPwdNew1.PasswordChar = '*';
			this.textBoxPwdNew1.Size = new System.Drawing.Size(200, 26);
			this.textBoxPwdNew1.TabIndex = 2;
			base.AcceptButton = this.buttonOK;
			base.AutoScaleDimensions = new SizeF(9f, 20f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.CancelButton = this.buttonCancel;
			base.ClientSize = new System.Drawing.Size(375, 312);
			base.Controls.Add(this.textBoxPwdNew1);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.textBoxPwdNew);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.textBoxPwdOld);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.buttonCancel);
			base.Controls.Add(this.buttonOK);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "ChangePasswordForm";
			base.StartPosition = FormStartPosition.CenterParent;
			this.Text = "Смена пароля";
			base.FormClosing += new FormClosingEventHandler(this.ChangePasswordForm_FormClosing);
			base.ResumeLayout(false);
			base.PerformLayout();
		}
	}
}