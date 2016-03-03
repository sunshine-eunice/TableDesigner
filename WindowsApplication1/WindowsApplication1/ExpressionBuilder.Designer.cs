namespace WindowsApplication1
{
    partial class ExpressionBuilder
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnOK3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbLogical = new System.Windows.Forms.ComboBox();
            this.cmbDate = new System.Windows.Forms.ComboBox();
            this.cmbMath = new System.Windows.Forms.ComboBox();
            this.cmbString = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCancel3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tbExpression = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Expression:";
            // 
            // btnOK3
            // 
            this.btnOK3.Location = new System.Drawing.Point(292, 25);
            this.btnOK3.Name = "btnOK3";
            this.btnOK3.Size = new System.Drawing.Size(64, 23);
            this.btnOK3.TabIndex = 2;
            this.btnOK3.Text = "OK";
            this.btnOK3.UseVisualStyleBackColor = true;
            this.btnOK3.Click += new System.EventHandler(this.btnOK3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.cmbLogical);
            this.groupBox1.Controls.Add(this.cmbDate);
            this.groupBox1.Controls.Add(this.cmbMath);
            this.groupBox1.Controls.Add(this.cmbString);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(18, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 111);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Functions";
            // 
            // cmbLogical
            // 
            this.cmbLogical.FormattingEnabled = true;
            this.cmbLogical.Location = new System.Drawing.Point(13, 79);
            this.cmbLogical.Name = "cmbLogical";
            this.cmbLogical.Size = new System.Drawing.Size(98, 21);
            this.cmbLogical.TabIndex = 8;
            this.cmbLogical.SelectionChangeCommitted += new System.EventHandler(this.cmbLogical_SelectionChangeCommitted);
            // 
            // cmbDate
            // 
            this.cmbDate.FormattingEnabled = true;
            this.cmbDate.Location = new System.Drawing.Point(131, 79);
            this.cmbDate.Name = "cmbDate";
            this.cmbDate.Size = new System.Drawing.Size(114, 21);
            this.cmbDate.TabIndex = 7;
            this.cmbDate.SelectionChangeCommitted += new System.EventHandler(this.cmbDate_SelectionChangeCommitted);
            // 
            // cmbMath
            // 
            this.cmbMath.FormattingEnabled = true;
            this.cmbMath.Location = new System.Drawing.Point(131, 41);
            this.cmbMath.Name = "cmbMath";
            this.cmbMath.Size = new System.Drawing.Size(114, 21);
            this.cmbMath.TabIndex = 6;
            this.cmbMath.SelectionChangeCommitted += new System.EventHandler(this.cmbMath_SelectionChangeCommitted);
            // 
            // cmbString
            // 
            this.cmbString.FormattingEnabled = true;
            this.cmbString.Location = new System.Drawing.Point(13, 41);
            this.cmbString.Name = "cmbString";
            this.cmbString.Size = new System.Drawing.Size(98, 21);
            this.cmbString.TabIndex = 5;
            this.cmbString.SelectionChangeCommitted += new System.EventHandler(this.cmbString_SelectionChangeCommitted);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(128, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Math:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Logical:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "String:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Fields:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(165, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Variables:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 302);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "From table:";
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(80, 302);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(77, 21);
            this.comboBox5.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(292, 86);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Verify";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnCancel3
            // 
            this.btnCancel3.Location = new System.Drawing.Point(292, 54);
            this.btnCancel3.Name = "btnCancel3";
            this.btnCancel3.Size = new System.Drawing.Size(64, 23);
            this.btnCancel3.TabIndex = 11;
            this.btnCancel3.Text = "Cancel";
            this.btnCancel3.UseVisualStyleBackColor = true;
            this.btnCancel3.Click += new System.EventHandler(this.btnCancel3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(292, 115);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(64, 23);
            this.button4.TabIndex = 12;
            this.button4.Text = "Options...";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(18, 226);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(139, 69);
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listView2
            // 
            this.listView2.Location = new System.Drawing.Point(168, 226);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(109, 96);
            this.listView2.TabIndex = 14;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.DoubleClick += new System.EventHandler(this.listView2_DoubleClick);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(0, -66);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(247, 60);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = "";
            // 
            // tbExpression
            // 
            this.tbExpression.Location = new System.Drawing.Point(18, 27);
            this.tbExpression.Name = "tbExpression";
            this.tbExpression.Size = new System.Drawing.Size(259, 58);
            this.tbExpression.TabIndex = 15;
            this.tbExpression.Text = "";
            // 
            // ExpressionBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 335);
            this.Controls.Add(this.tbExpression);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnCancel3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOK3);
            this.Controls.Add(this.label1);
            this.Name = "ExpressionBuilder";
            this.Text = "Expression Builder";
            this.Load += new System.EventHandler(this.ExpressionBuilder_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOK3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbLogical;
        private System.Windows.Forms.ComboBox cmbDate;
        private System.Windows.Forms.ComboBox cmbMath;
        private System.Windows.Forms.ComboBox cmbString;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCancel3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox tbExpression;
    }
}