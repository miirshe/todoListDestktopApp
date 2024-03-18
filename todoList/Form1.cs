using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace todoList
{
	public partial class TODO : Form
	{
		public TODO()
		{
			InitializeComponent();
		}

		DataTable dataTable = new DataTable();
		bool isEdit= false;
		private void button1_Click(object sender, EventArgs e)
		{
			if (isEdit)
			{
				dataTable.Rows[todoListTable.CurrentCell.RowIndex]["Title"] = txtTitle.Text;
				dataTable.Rows[todoListTable.CurrentCell.RowIndex]["Description"] = txtDesc.Text;

			}
			else
			{
				dataTable.Rows.Add(txtTitle.Text, txtDesc.Text);
			}
			clearData();
		}

		private void TODO_Load(object sender, EventArgs e)
		{
			dataTable.Columns.Add("Title");
			dataTable.Columns.Add("Description");

			todoListTable.DataSource = dataTable;
		
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			try
			{
				dataTable.Rows[todoListTable.CurrentCell.RowIndex].Delete();

			}catch(Exception ex)
			{
				Console.WriteLine("Deletion failed!" + ex);
			}
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			isEdit = true;
			txtTitle.Text = dataTable.Rows[todoListTable.CurrentCell.RowIndex].ItemArray[0].ToString();
			txtDesc.Text = dataTable.Rows[todoListTable.CurrentCell.RowIndex].ItemArray[1].ToString();

		}

		void clearData()
		{
			txtTitle.Text = "";
			txtDesc.Text = "";
		}
	}
}
