using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Lab
{
	public class EditUserForm : Form
	{
		private IContainer components;

		private Label label1;

		private TextBox textBoxName;

		private CheckBox checkBoxBlock;

		private CheckBox checkBoxPwd;

		private Button buttonNext;

		private Button buttonBack;

		private Button buttonClose;

		private Button buttonSave;

		private List<UserAccount> users;

		private int pos;

		public EditUserForm()
		{
			this.InitializeComponent();
		}

		public EditUserForm(List<UserAccount> us)
		{
			this.InitializeComponent();
			this.users = us;
		}

		private void buttonBack_Click(object sender, EventArgs e)
		{
			if (this.pos > 0)
			{
				this.pos--;
				this.FillData();
			}
		}

		private void buttonNext_Click(object sender, EventArgs e)
		{
			if (this.pos < this.users.Count - 1)
			{
				this.pos++;
				this.FillData();
			}
		}

		private void buttonSave_Click(object sender, EventArgs e)
		{
			this.users[this.pos].Name = this.textBoxName.Text;
			this.users[this.pos].isBlocked = this.checkBoxBlock.Checked;
			this.users[this.pos].isPwdOgr = this.checkBoxPwd.Checked;
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void EditUserForm_Load(object sender, EventArgs e)
		{
			this.FillData();
		}

		private void FillData()
		{
			this.textBoxName.Text = this.users[this.pos].Name;
			this.checkBoxBlock.Checked = this.users[this.pos].isBlocked;
			this.checkBoxPwd.Checked = this.users[this.pos].isPwdOgr;
		}

		private void InitializeComponent()
		{
			this.label1 = new Label();
			this.textBoxName = new TextBox();
			this.checkBoxBlock = new CheckBox();
			this.checkBoxPwd = new CheckBox();
			this.buttonNext = new Button();
			this.buttonBack = new Button();
			this.buttonClose = new Button();
			this.buttonSave = new Button();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Location = new Point(34, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(157, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Имя пользователя:";
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
			this.buttonNext.AutoSize = true;
			this.buttonNext.Location = new Point(170, 208);
			this.buttonNext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonNext.Name = "buttonNext";
			this.buttonNext.Size = new System.Drawing.Size(112, 35);
			this.buttonNext.TabIndex = 4;
			this.buttonNext.Text = "Вперед";
			this.buttonNext.UseVisualStyleBackColor = true;
			this.buttonNext.Click += new EventHandler(this.buttonNext_Click);
			this.buttonBack.AutoSize = true;
			this.buttonBack.Location = new Point(38, 208);
			this.buttonBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonBack.Name = "buttonBack";
			this.buttonBack.Size = new System.Drawing.Size(112, 35);
			this.buttonBack.TabIndex = 3;
			this.buttonBack.Text = "Назад";
			this.buttonBack.UseVisualStyleBackColor = true;
			this.buttonBack.Click += new EventHandler(this.buttonBack_Click);
			this.buttonClose.AutoSize = true;
			this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonClose.Location = new Point(247, 272);
			this.buttonClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new System.Drawing.Size(112, 35);
			this.buttonClose.TabIndex = 5;
			this.buttonClose.Text = "Закрыть";
			this.buttonClose.UseVisualStyleBackColor = true;
			this.buttonSave.AutoSize = true;
			this.buttonSave.Location = new Point(39, 265);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(186, 42);
			this.buttonSave.TabIndex = 6;
			this.buttonSave.Text = "Сохранить изменения";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new EventHandler(this.buttonSave_Click);
			base.AutoScaleDimensions = new SizeF(9f, 20f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.CancelButton = this.buttonClose;
			base.ClientSize = new System.Drawing.Size(373, 332);
			base.Controls.Add(this.buttonSave);
			base.Controls.Add(this.buttonClose);
			base.Controls.Add(this.buttonBack);
			base.Controls.Add(this.buttonNext);
			base.Controls.Add(this.checkBoxPwd);
			base.Controls.Add(this.checkBoxBlock);
			base.Controls.Add(this.textBoxName);
			base.Controls.Add(this.label1);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "EditUserForm";
			base.StartPosition = FormStartPosition.CenterParent;
			this.Text = "Редактирование пользователей";
			base.Load += new EventHandler(this.EditUserForm_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}
	}
}