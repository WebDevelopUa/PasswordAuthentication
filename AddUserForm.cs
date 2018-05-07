using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Lab
{
	public class AddUserForm : Form
	{
		private IContainer components;

		private Label label1;

		private TextBox textBoxName;

		private CheckBox checkBoxBlock;

		private CheckBox checkBoxPwd;

		private Button buttonCancel;

		private Button buttonOK;

		public string userName;

		public bool userBlocked;

		public bool userPwdOgr;

		public AddUserForm()
		{
			this.InitializeComponent();
		}

		private void buttonOK_Click(object sender, EventArgs e)
		{
			this.userName = this.textBoxName.Text;
			this.userBlocked = this.checkBoxBlock.Checked;
			this.userPwdOgr = this.checkBoxPwd.Checked;
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
			this.checkBoxBlock = new CheckBox();
			this.checkBoxPwd = new CheckBox();
			this.buttonCancel = new Button();
			this.buttonOK = new Button();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Location = new Point(34, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(213, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Имя нового пользователя:";
			this.textBoxName.Location = new Point(39, 58);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(320, 26);
			this.textBoxName.TabIndex = 0;
			this.checkBoxBlock.AutoSize = true;
			this.checkBoxBlock.Location = new Point(39, 111);
			this.checkBoxBlock.Name = "checkBoxBlock";
			this.checkBoxBlock.Size = new System.Drawing.Size(128, 24);
			this.checkBoxBlock.TabIndex = 1;
			this.checkBoxBlock.Text = "блокировка ";
			this.checkBoxBlock.UseVisualStyleBackColor = true;
			this.checkBoxPwd.AutoSize = true;
			this.checkBoxPwd.Location = new Point(39, 152);
			this.checkBoxPwd.Name = "checkBoxPwd";
			this.checkBoxPwd.Size = new System.Drawing.Size(218, 24);
			this.checkBoxPwd.TabIndex = 2;
			this.checkBoxPwd.Text = "парольное ограничение";
			this.checkBoxPwd.UseVisualStyleBackColor = true;
			this.buttonCancel.AutoSize = true;
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new Point(231, 228);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(94, 35);
			this.buttonCancel.TabIndex = 4;
			this.buttonCancel.Text = "Отмена";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonOK.AutoSize = true;
			this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOK.Location = new Point(118, 228);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(94, 35);
			this.buttonOK.TabIndex = 3;
			this.buttonOK.Text = "ОК";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new EventHandler(this.buttonOK_Click);
			base.AcceptButton = this.buttonOK;
			base.AutoScaleDimensions = new SizeF(9f, 20f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.CancelButton = this.buttonCancel;
			base.ClientSize = new System.Drawing.Size(448, 272);
			base.Controls.Add(this.buttonCancel);
			base.Controls.Add(this.buttonOK);
			base.Controls.Add(this.checkBoxPwd);
			base.Controls.Add(this.checkBoxBlock);
			base.Controls.Add(this.textBoxName);
			base.Controls.Add(this.label1);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "AddUserForm";
			base.StartPosition = FormStartPosition.CenterParent;
			this.Text = "Добавление пользователя";
			base.ResumeLayout(false);
			base.PerformLayout();
		}
	}
}