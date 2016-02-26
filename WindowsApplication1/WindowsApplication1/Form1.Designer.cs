namespace WindowsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnDel2 = new System.Windows.Forms.Button();
            this.btnInsert2 = new System.Windows.Forms.Button();
            this.btnCancel2 = new System.Windows.Forms.Button();
            this.btnOK2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewNumericUpDownColumn1 = new DataGridViewNumericUpDownElements.DataGridViewNumericUpDownColumn();
            this.dataGridViewNumericUpDownColumn2 = new DataGridViewNumericUpDownElements.DataGridViewNumericUpDownColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGViewName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGViewType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.DGViewWidth = new DataGridViewNumericUpDownElements.DataGridViewNumericUpDownColumn();
            this.DGViewDecimal = new DataGridViewNumericUpDownElements.DataGridViewNumericUpDownColumn();
            this.DGViewIndex = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.DGView2Order = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.DGView2Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGView2Type = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.DGView2Expression = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGView2Expression_btn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DGView2Filter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGView2Filter_btn = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGViewName,
            this.DGViewType,
            this.DGViewWidth,
            this.DGViewDecimal,
            this.DGViewIndex});
            this.dataGridView1.Location = new System.Drawing.Point(57, 14);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(586, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(5, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(788, 220);
            this.tabControl1.TabIndex = 5;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnDel);
            this.tabPage1.Controls.Add(this.btnInsert);
            this.tabPage1.Controls.Add(this.btnCancel);
            this.tabPage1.Controls.Add(this.btnOK);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(780, 194);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Fields";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(680, 124);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 27);
            this.btnDel.TabIndex = 8;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(680, 95);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 27);
            this.btnInsert.TabIndex = 7;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(680, 43);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 27);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(680, 14);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 27);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnDel2);
            this.tabPage2.Controls.Add(this.btnInsert2);
            this.tabPage2.Controls.Add(this.btnCancel2);
            this.tabPage2.Controls.Add(this.btnOK2);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(780, 194);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Indexes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnDel2
            // 
            this.btnDel2.Location = new System.Drawing.Point(676, 130);
            this.btnDel2.Name = "btnDel2";
            this.btnDel2.Size = new System.Drawing.Size(75, 27);
            this.btnDel2.TabIndex = 12;
            this.btnDel2.Text = "Delete";
            this.btnDel2.UseVisualStyleBackColor = true;
            // 
            // btnInsert2
            // 
            this.btnInsert2.Location = new System.Drawing.Point(676, 101);
            this.btnInsert2.Name = "btnInsert2";
            this.btnInsert2.Size = new System.Drawing.Size(75, 27);
            this.btnInsert2.TabIndex = 11;
            this.btnInsert2.Text = "Insert";
            this.btnInsert2.UseVisualStyleBackColor = true;
            // 
            // btnCancel2
            // 
            this.btnCancel2.Location = new System.Drawing.Point(676, 49);
            this.btnCancel2.Name = "btnCancel2";
            this.btnCancel2.Size = new System.Drawing.Size(75, 27);
            this.btnCancel2.TabIndex = 10;
            this.btnCancel2.Text = "Cancel";
            this.btnCancel2.UseVisualStyleBackColor = true;
            // 
            // btnOK2
            // 
            this.btnOK2.Location = new System.Drawing.Point(676, 20);
            this.btnOK2.Name = "btnOK2";
            this.btnOK2.Size = new System.Drawing.Size(75, 27);
            this.btnOK2.TabIndex = 9;
            this.btnOK2.Text = "OK";
            this.btnOK2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGView2Order,
            this.DGView2Name,
            this.DGView2Type,
            this.DGView2Expression,
            this.DGView2Expression_btn,
            this.DGView2Filter,
            this.DGView2Filter_btn});
            this.dataGridView2.Location = new System.Drawing.Point(97, 20);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(514, 150);
            this.dataGridView2.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 120;
            // 
            // dataGridViewNumericUpDownColumn1
            // 
            this.dataGridViewNumericUpDownColumn1.HeaderText = "Width";
            this.dataGridViewNumericUpDownColumn1.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.dataGridViewNumericUpDownColumn1.Name = "dataGridViewNumericUpDownColumn1";
            // 
            // dataGridViewNumericUpDownColumn2
            // 
            this.dataGridViewNumericUpDownColumn2.HeaderText = "Decimal";
            this.dataGridViewNumericUpDownColumn2.Name = "dataGridViewNumericUpDownColumn2";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Expression";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 70;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Filter";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // DGViewName
            // 
            this.DGViewName.HeaderText = "Name";
            this.DGViewName.Name = "DGViewName";
            this.DGViewName.Width = 120;
            // 
            // DGViewType
            // 
            this.DGViewType.HeaderText = "Type";
            this.DGViewType.Name = "DGViewType";
            // 
            // DGViewWidth
            // 
            this.DGViewWidth.HeaderText = "Width";
            this.DGViewWidth.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.DGViewWidth.Name = "DGViewWidth";
            this.DGViewWidth.Width = 60;
            // 
            // DGViewDecimal
            // 
            this.DGViewDecimal.HeaderText = "Decimal";
            this.DGViewDecimal.Name = "DGViewDecimal";
            this.DGViewDecimal.Width = 60;
            // 
            // DGViewIndex
            // 
            this.DGViewIndex.HeaderText = "Index";
            this.DGViewIndex.Name = "DGViewIndex";
            // 
            // DGView2Order
            // 
            this.DGView2Order.HeaderText = "Order";
            this.DGView2Order.Name = "DGView2Order";
            this.DGView2Order.Width = 80;
            // 
            // DGView2Name
            // 
            this.DGView2Name.HeaderText = "Name";
            this.DGView2Name.Name = "DGView2Name";
            this.DGView2Name.ReadOnly = true;
            // 
            // DGView2Type
            // 
            this.DGView2Type.HeaderText = "Type";
            this.DGView2Type.Name = "DGView2Type";
            this.DGView2Type.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DGView2Type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DGView2Type.Width = 75;
            // 
            // DGView2Expression
            // 
            this.DGView2Expression.HeaderText = "Expression";
            this.DGView2Expression.Name = "DGView2Expression";
            this.DGView2Expression.Width = 70;
            // 
            // DGView2Expression_btn
            // 
            this.DGView2Expression_btn.HeaderText = "";
            this.DGView2Expression_btn.Name = "DGView2Expression_btn";
            this.DGView2Expression_btn.ReadOnly = true;
            this.DGView2Expression_btn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DGView2Expression_btn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DGView2Expression_btn.Width = 20;
            // 
            // DGView2Filter
            // 
            this.DGView2Filter.HeaderText = "Filter";
            this.DGView2Filter.Name = "DGView2Filter";
            // 
            // DGView2Filter_btn
            // 
            this.DGView2Filter_btn.HeaderText = "";
            this.DGView2Filter_btn.Name = "DGView2Filter_btn";
            this.DGView2Filter_btn.Width = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 234);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Table Designer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnDel2;
        private System.Windows.Forms.Button btnInsert2;
        private System.Windows.Forms.Button btnCancel2;
        private System.Windows.Forms.Button btnOK2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewNumericUpDownElements.DataGridViewNumericUpDownColumn dataGridViewNumericUpDownColumn1;
        private DataGridViewNumericUpDownElements.DataGridViewNumericUpDownColumn dataGridViewNumericUpDownColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGViewName;
        private System.Windows.Forms.DataGridViewComboBoxColumn DGViewType;
        private DataGridViewNumericUpDownElements.DataGridViewNumericUpDownColumn DGViewWidth;
        private DataGridViewNumericUpDownElements.DataGridViewNumericUpDownColumn DGViewDecimal;
        private System.Windows.Forms.DataGridViewComboBoxColumn DGViewIndex;
        private System.Windows.Forms.DataGridViewComboBoxColumn DGView2Order;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGView2Name;
        private System.Windows.Forms.DataGridViewComboBoxColumn DGView2Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGView2Expression;
        private System.Windows.Forms.DataGridViewButtonColumn DGView2Expression_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGView2Filter;
        private System.Windows.Forms.DataGridViewButtonColumn DGView2Filter_btn;
    }
}