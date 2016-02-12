using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;

namespace WindowsApplication1
{
    public partial class Form1 : Form 
    {
        public Form1()
        {
            InitializeComponent();       
        }
        DataTable dt = new DataTable();
        //int i;
      
        public string textName { get; set; }
        public string Cmbtype { get; set; }
        public int PWidth { get; set; }
        public int Decimal { get; set; }
        public string Index { get; set; }
        public bool checkboxNull { get; set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            //dataGridView1.ReadOnly = true;
            foreach (DataGridViewColumn col in dataGridView1.Columns) {
               dt.Columns.Add(col.Name);
                col.DataPropertyName = col.Name;                
            }

            DGViewName.MaxInputLength = 10;

            DGViewType.DefaultCellStyle.NullValue = "==Select==";
            DGViewType.Items.Add("Character");
            DGViewType.Items.Add("Currency");
            DGViewType.Items.Add("Numeric");
            DGViewType.Items.Add("Float");
            DGViewType.Items.Add("Date");
            DGViewType.Items.Add("DateTime");
            DGViewType.Items.Add("Double");
            DGViewType.Items.Add("Integer");
            DGViewType.Items.Add("Logical");
            DGViewType.Items.Add("Memo");
            DGViewType.Items.Add("General");
            DGViewType.Items.Add("Character (binary)");
            DGViewType.Items.Add("Memo (binary)");

            DGViewIndex.DefaultCellStyle.NullValue = "==Select==";
            DGViewIndex.Items.Add("None");
            DGViewIndex.Items.Add("Ascending");
            DGViewIndex.Items.Add("Descending");

            dt.Columns.Add("NULL",typeof(Boolean));

            dt.Columns["NULL"].DefaultValue = false;
            dt.Columns["DGViewWidth"].DefaultValue = 0;
            //DGViewNull.FalseValue = false;
            //this.dataGridView1.Columns["DGViewNull"].DefaultCellStyle.NullValue = false;
            //dataGridView1.Columns["DGViewNull"].DefaultCellStyle.NullValue = false;

            DataRow drLocal = null;
            foreach (DataGridViewRow dr in dataGridView1.Rows)
             {
                drLocal = dt.NewRow();
                drLocal["DGViewName"] = dr.Cells["DGViewName"].Value;
                drLocal["DGViewType"] = dr.Cells["DGViewType"].Value;
                drLocal["DGViewWidth"] = dr.Cells["DGViewWidth"].Value;
                drLocal["DGViewDecimal"] = dr.Cells["DGViewDecimal"].Value;
                drLocal["DGViewIndex"] = dr.Cells["DGViewIndex"].Value;
               // drLocal["DGViewNull"] = dr.Cells["DGViewNull"].Value;         
                //dr.Cells["DGViewNull"].Value = false;
                dt.Rows.Add(drLocal);
                //dataGridView1.DataSource = dt;             
             }
                dataGridView1.DataSource = dt;  
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {        
                dataGridView1.ReadOnly  =   false;
                dt.Rows.Add("NewFld","Character","10","0","","False");
                dataGridView1.DataSource = dt;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                dt.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                Application.Exit();
            }
            else
            {
                DialogResult resultCancel = MessageBox.Show("Discard Structure Changes?", "Name", MessageBoxButtons.YesNo);
                if ((resultCancel == DialogResult.Yes && dataGridView1.Rows.Count != 0))
                {
                    Application.Exit();
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            StringBuilder s = new StringBuilder();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    if (row.IsNewRow)
                        continue;

                    string header = dataGridView1.Columns[i].HeaderText;
                    string cellText = row.Cells[i].Value.ToString();
                    // MessageBox.Show(header +": "+cellText);
                    s.AppendLine(header + ": " + cellText);
                }
            }
            MessageBox.Show(s.ToString());         
        }
    } 
 }