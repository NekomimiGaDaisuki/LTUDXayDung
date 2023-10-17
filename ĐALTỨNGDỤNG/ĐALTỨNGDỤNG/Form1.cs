using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Microsoft.Office.Interop.Excel;

namespace ĐALTỨNGDỤNG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string accessConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\DA LTUD\nl.accdb;Persist Security Info=False;";
            System.Data.DataTable dataTable = new System.Data.DataTable();


            using (OleDbConnection connection = new OleDbConnection(accessConnectionString))
            {
                connection.Open();


                string query = "SELECT * FROM [noi luc cot]";
                OleDbCommand command = new OleDbCommand(query, connection);
                OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                adapter.Fill(dataTable);
            }


            gr.DataSource = dataTable;
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Khởi tạo một ứng dụng Excel mới
            var excelApp = new Microsoft.Office.Interop.Excel.Application();
            excelApp.Visible = true;

            // Tạo một workbook mới
            var workbook = excelApp.Workbooks.Add(Type.Missing);
            var worksheet = (Worksheet)workbook.ActiveSheet;

            // Xuất dữ liệu từ DataGridView vào Excel
            for (int row = 0; row < gr.Rows.Count; row++)
            {
                for (int col = 0; col < gr.Columns.Count; col++)
                {
                    worksheet.Cells[row + 1, col + 1] = gr.Rows[row].Cells[col].Value;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
