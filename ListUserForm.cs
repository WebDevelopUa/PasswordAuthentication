using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Lab
{
	public class ListUserForm : Form
	{
		private IContainer components;

		private GroupBox groupBox1;

		private DataGridView dataGridViewListUser;

		private Button button1;

		private DataGridViewTextBoxColumn ColumnName;

		private DataGridViewCheckBoxColumn ColumnBlocked;

		private DataGridViewCheckBoxColumn ColumnPwd;

		public ListUserForm()
		{
			this.InitializeComponent();
		}

		public ListUserForm(List<UserAccount> users)
		{
			this.InitializeComponent();
			foreach (UserAccount user in users)
			{
				DataGridViewRowCollection rows = this.dataGridViewListUser.Rows;
				object[] name = new object[] { user.Name, user.isBlocked, user.isPwdOgr };
				rows.Add(name);
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
			this.groupBox1 = new GroupBox();
			this.dataGridViewListUser = new DataGridView();
			this.ColumnName = new DataGridViewTextBoxColumn();
			this.ColumnBlocked = new DataGridViewCheckBoxColumn();
			this.ColumnPwd = new DataGridViewCheckBoxColumn();
			this.button1 = new Button();
			this.groupBox1.SuspendLayout();
			((ISupportInitialize)this.dataGridViewListUser).BeginInit();
			base.SuspendLayout();
			this.groupBox1.Controls.Add(this.dataGridViewListUser);
			this.groupBox1.Location = new Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(566, 325);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Список пользователей";
			this.dataGridViewListUser.AllowUserToAddRows = false;
			this.dataGridViewListUser.AllowUserToDeleteRows = false;
			this.dataGridViewListUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridViewListUser.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridViewListUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			DataGridViewColumnCollection columns = this.dataGridViewListUser.Columns;
			DataGridViewColumn[] columnName = new DataGridViewColumn[] { this.ColumnName, this.ColumnBlocked, this.ColumnPwd };
			columns.AddRange(columnName);
			this.dataGridViewListUser.Location = new Point(6, 25);
			this.dataGridViewListUser.MultiSelect = false;
			this.dataGridViewListUser.Name = "dataGridViewListUser";
			this.dataGridViewListUser.ReadOnly = true;
			this.dataGridViewListUser.RowTemplate.Height = 28;
			this.dataGridViewListUser.Size = new System.Drawing.Size(554, 294);
			this.dataGridViewListUser.TabIndex = 0;
			this.ColumnName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.ColumnName.HeaderText = "Имя";
			this.ColumnName.Name = "ColumnName";
			this.ColumnName.ReadOnly = true;
			this.ColumnName.Width = 65;
			this.ColumnBlocked.HeaderText = "Блокировка";
			this.ColumnBlocked.Name = "ColumnBlocked";
			this.ColumnBlocked.ReadOnly = true;
			this.ColumnPwd.HeaderText = "Ограничение";
			this.ColumnPwd.Name = "ColumnPwd";
			this.ColumnPwd.ReadOnly = true;
			this.button1.AutoSize = true;
			this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.button1.Location = new Point(220, 358);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(134, 35);
			this.button1.TabIndex = 1;
			this.button1.Text = "ОК";
			this.button1.UseVisualStyleBackColor = true;
			base.AcceptButton = this.button1;
			base.AutoScaleDimensions = new SizeF(9f, 20f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(590, 403);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.groupBox1);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.Name = "ListUserForm";
			base.StartPosition = FormStartPosition.CenterParent;
			this.Text = "Зарегистрированные пользователи";
			base.Load += new EventHandler(this.ListUserForm_Load);
			this.groupBox1.ResumeLayout(false);
			((ISupportInitialize)this.dataGridViewListUser).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private void ListUserForm_Load(object sender, EventArgs e)
		{
		}
	}
}