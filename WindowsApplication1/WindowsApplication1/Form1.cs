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
        DataTable dt2 = new DataTable();
        //int i, j;
      
        public string textName { get; set; }
        public string Cmbtype { get; set; }
        public int PWidth { get; set; }
        public int Decimal { get; set; }
        public string Index { get; set; }
        public bool checkboxNull { get; set; }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            //dataGridView1.ReadOnly = true;

            #region ///adding of columns from datagridview1 to dataset dt
            foreach (DataGridViewColumn col in dataGridView1.Columns) {
               dt.Columns.Add(col.Name);
                col.DataPropertyName = col.Name;
            }
            #endregion


            #region ///adding of columns from datagridview2 to dataset dt
            foreach (DataGridViewColumn col1 in dataGridView2.Columns)
            {
                dt2.Columns.Add(col1.Name);
                col1.DataPropertyName = col1.Name;
            }
            #endregion

            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.CellValueChanged +=new DataGridViewCellEventHandler(dataGridView1_CellValueChanged);
            
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

            DGView2Order.Items.Add("Ascending");
            DGView2Order.Items.Add("Descending");

            DGView2Type.Items.Add("Candidate");
            DGView2Type.Items.Add("Unique");
            DGView2Type.Items.Add("Regular");

            dt.Columns.Add("NULL",typeof(Boolean));

            dt.Columns["NULL"].DefaultValue         =   false;
            
            
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

              //  var gd1 = (from a in dataGridView1.Rows.Cast<DataGridViewRow>()
         //select new { Column1 = a.Cells["Column1"].Value.ToString() }).tolist();

                //loop dg1 and save it to datagridview2
               
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

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e) {
           string str = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            if (dataGridView1.Columns[e.ColumnIndex].Name  ==  "DGViewType") {   
                      //str = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                      if (str == "Date")    {
                         //dataGridView1.Columns["DGViewWidth"].ReadOnly = true;
                         // dataGridView1.Columns["DGViewWidth"].Frozen = true;
                         //dataGridView1.Columns["DGViewDecimal"].ReadOnly = true;   
                          DataGridViewCell cell = dataGridView1.Rows[e.RowIndex].Cells[3];
                          dataGridView1.CurrentCell = cell;
                          dataGridView1.CurrentCell.ReadOnly = true;
                          dataGridView1.BeginEdit(true);
                          dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Red;

                          DataGridViewCell cell1 = dataGridView1.Rows[e.RowIndex].Cells[2];
                          dataGridView1.CurrentCell = cell1;
                          dataGridView1.CurrentCell.ReadOnly = true;
                          dataGridView1.BeginEdit(true);
                          //dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Red;
                      }      
                }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "DGViewIndex")
            {
                if (str == "Ascending" || str == "Descending") {
                    if (dataGridView1.SelectedCells.Count > 0)
                    {
                        int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;

                        DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];

                        string a = Convert.ToString(selectedRow.Cells["DGViewName"].Value);
                        string b = Convert.ToString(selectedRow.Cells["DGViewIndex"].Value);
                        dt2.Rows.Add(b, a, "Regular", a,"");
                        dataGridView2.DataSource = dt2;
                    }

                }
                 }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "DGViewName") {
                  string sub = str.Substring(0);
                if (sub == "") {
                    MessageBox.Show("Error name!");
                }             
            }           
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Columns[e.ColumnIndex].Name == "DGView2Expression_btn")
            {
                //Write here your code...
                MessageBox.Show("You Have Selected " + (e.RowIndex + 1).ToString() + " Row Button");
            }
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
 
    } 
 }