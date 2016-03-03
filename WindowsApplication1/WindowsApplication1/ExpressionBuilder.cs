using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class ExpressionBuilder : Form
    {
        private class Item
        {
            public string Name;
            public int Value;
            public Item(string name, int value)
            {
                Name = name; Value = value;
            }
            public override string ToString()
            {
                // Generates the text shown in the combo box
                return Name;
            }
        }
        public ExpressionBuilder()
        {
            InitializeComponent();           
        }

        private void ExpressionBuilder_Load(object sender, EventArgs e)
        {
            #region add items to string combobox
            cmbString.Items.Add(new Item("\"text\""     , 0));
            cmbString.Items.Add(new Item("+"            , 1));
            cmbString.Items.Add(new Item("-"            , 2));
            cmbString.Items.Add(new Item("ASC(expC)"    , 3));
            cmbString.Items.Add(new Item("ALLTRIM(expC)", 4));
            cmbString.Items.Add(new Item("AT(,,)"       , 5));
            cmbString.Items.Add(new Item("ATC(,,)"      , 6));
            cmbString.Items.Add(new Item("CHR(expN)"    , 7));
            cmbString.Items.Add(new Item("CHRTRAN(,,)"  , 8));
            cmbString.Items.Add(new Item("CTOBIN(cstring)", 9));
            cmbString.Items.Add(new Item("CURVAL(,)"      , 10));
            cmbString.Items.Add(new Item("GETPEM(,)"      , 11));
            cmbString.Items.Add(new Item("LEFT(expC,)"    , 12));
            cmbString.Items.Add(new Item("LEN(expC)"      , 13));
            cmbString.Items.Add(new Item("LOWER(expC)"    , 14));
            cmbString.Items.Add(new Item("LTRIM(expC)"    , 15));
            cmbString.Items.Add(new Item("MAX(,)"         , 16));
            cmbString.Items.Add(new Item("OCCURS(,)"      , 17));
            cmbString.Items.Add(new Item("OEMTOANSI()"    , 18));
            cmbString.Items.Add(new Item("OLDVAL(,)"      , 19));
            cmbString.Items.Add(new Item("PADC(expC,)"    , 20));
            cmbString.Items.Add(new Item("PADL(expC,)"    , 21));
            cmbString.Items.Add(new Item("PADR(expC,)"    , 22));
            cmbString.Items.Add(new Item("PEMSTATUS(,,)"  , 23));
            cmbString.Items.Add(new Item("PROPER(expC)"   , 24));
            cmbString.Items.Add(new Item("RAT(,,)"        , 25));
            cmbString.Items.Add(new Item("REPLICATE(,)"   , 26));
            cmbString.Items.Add(new Item("RIGHT(expC,)"   , 27));
            cmbString.Items.Add(new Item("SOUNDEX(expC)"  , 28));
            cmbString.Items.Add(new Item("SPACE(expN)"    , 29));
            cmbString.Items.Add(new Item("STR(expN,,)"    , 30));
            cmbString.Items.Add(new Item("STRTRAN(,,)"    , 31));
            cmbString.Items.Add(new Item("STUFF(,,,)"     , 32));
            cmbString.Items.Add(new Item("SUBSTR(,,)"     , 33));
            cmbString.Items.Add(new Item("TRANSFORM(,)"   , 34));
            cmbString.Items.Add(new Item("TRIM()"         , 35));
            cmbString.Items.Add(new Item("TYPE(expC)"     , 36));
            cmbString.Items.Add(new Item("UPPER(expC)"    , 37));
            cmbString.Items.Add(new Item("$"              , 38));
            cmbString.Items.Add(new Item("AT_C(,,)"       , 39));
            cmbString.Items.Add(new Item("ATCC(,,)"       , 40));
            cmbString.Items.Add(new Item("CHRTRANC(,,)"   , 41));
            cmbString.Items.Add(new Item("LEFTC(expC,)"   , 42));
            cmbString.Items.Add(new Item("LENC(expC)"     , 43));
            cmbString.Items.Add(new Item("RATC(,,)"       , 44));
            cmbString.Items.Add(new Item("RIGHTC(expC,)"  , 45));
            cmbString.Items.Add(new Item("STRCONV(,)"     , 46));
            cmbString.Items.Add(new Item("STUFFC(,,,)"    , 47));
            cmbString.Items.Add(new Item("SUBSTRC(,,)"    , 48));
            #endregion            
            cmbString.SelectedIndex = 0;           

            #region add items to Math combobox
            cmbMath.Items.Add(new Item("^", 0));
            cmbMath.Items.Add(new Item("*", 1));
            cmbMath.Items.Add(new Item("/", 2));
            cmbMath.Items.Add(new Item("+", 3));
            cmbMath.Items.Add(new Item("-", 4));
            cmbMath.Items.Add(new Item("ABS(expN)", 5));
            cmbMath.Items.Add(new Item("ACOS(expN)", 6));
            cmbMath.Items.Add(new Item("ASIN(expN)", 7));
            cmbMath.Items.Add(new Item("ATAN(expN)", 8));
            cmbMath.Items.Add(new Item("ATN2(,)"   , 9));
            cmbMath.Items.Add(new Item("AVG(expN)" , 10));
            cmbMath.Items.Add(new Item("BINTOC(,)" , 11));
            cmbMath.Items.Add(new Item("BITAND(,)",  12));
            cmbMath.Items.Add(new Item("BITCLEAR(,)",13));
            cmbMath.Items.Add(new Item("BITLSHIFT(,)",14));
            cmbMath.Items.Add(new Item("BITRSHIFT(,)",15));
            cmbMath.Items.Add(new Item("BITSET(,)"   ,16));
            cmbMath.Items.Add(new Item("BITTEST(,)"  ,17));
            cmbMath.Items.Add(new Item("BITXOR(,)"   ,18));
            cmbMath.Items.Add(new Item("CEILING(expN)",19));
            cmbMath.Items.Add(new Item("COS(expN)"    ,20));
            cmbMath.Items.Add(new Item("COUNT(expN)"  ,21));
            cmbMath.Items.Add(new Item("DTOR()"       ,22));
            cmbMath.Items.Add(new Item("EXP(expN)"    ,23));
            cmbMath.Items.Add(new Item("FLOOR(expN)"  ,24));
            cmbMath.Items.Add(new Item("FV(,,)"       ,25));
            cmbMath.Items.Add(new Item("INT(expN)"    ,26));
            cmbMath.Items.Add(new Item("LOG(expN)"    ,27));
            cmbMath.Items.Add(new Item("LOG10(expN)"  ,28));
            cmbMath.Items.Add(new Item("MAX(,)"       ,29));
            cmbMath.Items.Add(new Item("MIN(,)"       ,30));
            cmbMath.Items.Add(new Item("MOD(,)"       ,31));
            cmbMath.Items.Add(new Item("MTON()"       ,32));
            cmbMath.Items.Add(new Item("NTOM()"       ,33));
            cmbMath.Items.Add(new Item("PAYMENT(,,)"  ,34));
            cmbMath.Items.Add(new Item("PI()"         ,35));
            cmbMath.Items.Add(new Item("PV(,,)"       ,36));
            cmbMath.Items.Add(new Item("RAND()"       ,37));
            cmbMath.Items.Add(new Item("RECNO()"      ,39));
            cmbMath.Items.Add(new Item("RTOD(expN)"   ,40));
            cmbMath.Items.Add(new Item("SIGN(expN)"   ,41));
            cmbMath.Items.Add(new Item("SIN(expN)"    ,42));
            cmbMath.Items.Add(new Item("SQRT(expN)"   ,43));
            cmbMath.Items.Add(new Item("SUM(expN)"    ,44));
            cmbMath.Items.Add(new Item("TAN(expN)"    ,45));
            cmbMath.Items.Add(new Item("VAL(expC)"    ,46));
            #endregion
            cmbMath.SelectedIndex       =   0;
            //cmbMath.SelectionChangeCommitted +=new EventHandler(cmbMath_SelectionChangeCommitted);

            #region add items to Logical combobox
            cmbLogical.Items.Add(new Item("()", 0));
            cmbLogical.Items.Add(new Item("<" , 1));
            cmbLogical.Items.Add(new Item(">" , 2));
            cmbLogical.Items.Add(new Item("=" , 3));
            cmbLogical.Items.Add(new Item("<>", 4));
            cmbLogical.Items.Add(new Item("<=", 5));
            cmbLogical.Items.Add(new Item(">=", 6));
            cmbLogical.Items.Add(new Item("==", 7));
            cmbLogical.Items.Add(new Item(".T.",8));
            cmbLogical.Items.Add(new Item(".F.",9));
            cmbLogical.Items.Add(new Item(".NULL.",10));
            cmbLogical.Items.Add(new Item("NOT"   ,11));
            cmbLogical.Items.Add(new Item("AND"   ,12));
            cmbLogical.Items.Add(new Item("OR"    ,13));
            cmbLogical.Items.Add(new Item("BETWEEN(,,)",14));
            cmbLogical.Items.Add(new Item("DELETED()"  ,15));
            cmbLogical.Items.Add(new Item("EMPTY(expr)",16));
            cmbLogical.Items.Add(new Item("IIF(,,)"    ,17));
            cmbLogical.Items.Add(new Item("INLIST(,,)" ,18));
            cmbLogical.Items.Add(new Item("NVL(,)"     ,19));
            cmbLogical.Items.Add(new Item("SEEK(,,)"   ,20));
            #endregion
            cmbLogical.SelectedIndex    =   0;

            #region add items to Date combobox
            cmbDate.Items.Add(new Item("{date}"    , 0));
            cmbDate.Items.Add(new Item("CDOW(expD)", 1));
            cmbDate.Items.Add(new Item("CTOD(expC)", 2));
            cmbDate.Items.Add(new Item("CTOT(expC)", 3));
            cmbDate.Items.Add(new Item("DATE()"    , 4));
            cmbDate.Items.Add(new Item("DATETIME()", 5));
            cmbDate.Items.Add(new Item("DAY(expD)" , 6));
            cmbDate.Items.Add(new Item("DMY(expD)" , 7));
            cmbDate.Items.Add(new Item("DOW(expD)" , 8));
            cmbDate.Items.Add(new Item("DTOC(expD)", 9));
            cmbDate.Items.Add(new Item("DTOS(expD)",10));
            cmbDate.Items.Add(new Item("DTOT(expD)",11));
            cmbDate.Items.Add(new Item("GOMONTH(expD,)", 12));
            cmbDate.Items.Add(new Item("HOUR(expD)"    , 13));
            cmbDate.Items.Add(new Item("MAX(,)"        , 14));
            cmbDate.Items.Add(new Item("MDY(expD)"     , 15));
            cmbDate.Items.Add(new Item("MIN(,)"        , 16));
            cmbDate.Items.Add(new Item("MINUTE(expD)"  , 17));
            cmbDate.Items.Add(new Item("MONTH(expD)"   , 18));
            cmbDate.Items.Add(new Item("SEC(expD)"     , 19));
            cmbDate.Items.Add(new Item("SECONDS()"     , 20));
            cmbDate.Items.Add(new Item("TIME()"        , 21));
            cmbDate.Items.Add(new Item("TTOC(expD)"    , 22));
            cmbDate.Items.Add(new Item("TTOD(expC)"    , 23));
            cmbDate.Items.Add(new Item("WEEK(expD)"    , 24));
            cmbDate.Items.Add(new Item("YEAR(expD)"    , 25));
            #endregion
            cmbDate.SelectedIndex       =   0;

            #region Add Columns and Row to listView Variables 
            listView2.View = View.Details;
            listView2.Columns.Add("", 65, HorizontalAlignment.Left);
            listView2.Columns.Add("", 20, HorizontalAlignment.Left);
            listView2.FullRowSelect = true;
            listView2.GridLines = true;

            ListViewItem change1 = new ListViewItem("_alignment");
            change1.SubItems.Add("C");

            ListViewItem change2 = new ListViewItem("_box");
            change2.SubItems.Add("L");

            ListViewItem change3 = new ListViewItem("_indent");
            change3.SubItems.Add("N");

            ListViewItem change4 = new ListViewItem("_lmargin");
            change4.SubItems.Add("N");

            ListViewItem change5 = new ListViewItem("_padvance");
            change5.SubItems.Add("C");

            ListViewItem change6 = new ListViewItem("_pageno");
            change6.SubItems.Add("N");

            ListViewItem change7 = new ListViewItem("_pbpage");
            change7.SubItems.Add("N");

            ListViewItem change8 = new ListViewItem("_pcolno");
            change8.SubItems.Add("N");

            ListViewItem change9 = new ListViewItem("_pcopies");
            change9.SubItems.Add("N");

            ListViewItem change10 = new ListViewItem("_pdriver");
            change10.SubItems.Add("C");

            ListViewItem change11 = new ListViewItem("_pecode");
            change11.SubItems.Add("C");

            ListViewItem change12 = new ListViewItem("_peject");
            change12.SubItems.Add("C");

            ListViewItem change13 = new ListViewItem("_pepage");
            change5.SubItems.Add("N");

            ListViewItem change14 = new ListViewItem("_pform");
            change14.SubItems.Add("C");

            ListViewItem change15 = new ListViewItem("_plength");
            change15.SubItems.Add("N");

            ListViewItem change16 = new ListViewItem("_plineno");
            change16.SubItems.Add("N");

            ListViewItem change17 = new ListViewItem("_ploffset");
            change17.SubItems.Add("N");

            ListViewItem change18 = new ListViewItem("_ppitch");
            change18.SubItems.Add("C");

            ListViewItem change19 = new ListViewItem("_pquality");
            change19.SubItems.Add("L");

            ListViewItem change20 = new ListViewItem("_pscode");
            change20.SubItems.Add("C");

            ListViewItem change21 = new ListViewItem("_pspacing");
            change21.SubItems.Add("N");

            ListViewItem change22 = new ListViewItem("_pwait");
            change22.SubItems.Add("L");

            ListViewItem change23 = new ListViewItem("_rmargin");
            change23.SubItems.Add("N");

            ListViewItem change24 = new ListViewItem("_tabs");
            change24.SubItems.Add("C");

            ListViewItem change25 = new ListViewItem("_wrap");
            change25.SubItems.Add("L");

            ListViewItem change26 = new ListViewItem("_dblclick");
            change26.SubItems.Add("N");

            ListViewItem change27 = new ListViewItem("_calcvalue");
            change27.SubItems.Add("N");

            ListViewItem change28 = new ListViewItem("_calcmem");
            change28.SubItems.Add("N");

            ListViewItem change29 = new ListViewItem("_diarydate");
            change29.SubItems.Add("D");

            ListViewItem change30 = new ListViewItem("_cliptext");
            change30.SubItems.Add("C");

            ListViewItem change31 = new ListViewItem("_text");
            change31.SubItems.Add("N");

            ListViewItem change32 = new ListViewItem("_pretext");
            change32.SubItems.Add("C");

            ListViewItem change33 = new ListViewItem("_tally");
            change33.SubItems.Add("N");

            ListViewItem change34 = new ListViewItem("_curobj");
            change17.SubItems.Add("N");

            ListViewItem change35 = new ListViewItem("_mline");
            change35.SubItems.Add("N");

            ListViewItem change36 = new ListViewItem("_throttle");
            change36.SubItems.Add("N");

            ListViewItem change37 = new ListViewItem("_genmenu");
            change37.SubItems.Add("C");

            ListViewItem change38 = new ListViewItem("_genscrn");
            change38.SubItems.Add("C");

            ListViewItem change39 = new ListViewItem("_gengraph");
            change39.SubItems.Add("C");

            ListViewItem change40 = new ListViewItem("_genpd");
            change40.SubItems.Add("C");

            ListViewItem change41 = new ListViewItem("_pdsetup");
            change41.SubItems.Add("C");

            ListViewItem change42 = new ListViewItem("_genxtab");
            change42.SubItems.Add("C");

            ListViewItem change43 = new ListViewItem("_foxdoc");
            change43.SubItems.Add("C");

            ListViewItem change44 = new ListViewItem("_foxgraph");
            change44.SubItems.Add("C");

            ListViewItem change45 = new ListViewItem("_startup");
            change45.SubItems.Add("C");

            ListViewItem change46 = new ListViewItem("_transport");
            change46.SubItems.Add("C");

            ListViewItem change47 = new ListViewItem("_beautify");
            change47.SubItems.Add("C");

            ListViewItem change48 = new ListViewItem("_dos");
            change48.SubItems.Add("L");

            ListViewItem change49 = new ListViewItem("_mac");
            change38.SubItems.Add("L");

            ListViewItem change50 = new ListViewItem("_unix");
            change50.SubItems.Add("L");

            ListViewItem change51 = new ListViewItem("_windows");
            change51.SubItems.Add("L");

            ListViewItem change52 = new ListViewItem("_spellchk");
            change52.SubItems.Add("C");

            ListViewItem change53 = new ListViewItem("_shell");
            change53.SubItems.Add("C");

            ListViewItem change54 = new ListViewItem("_assist");
            change54.SubItems.Add("C");

            ListViewItem change55 = new ListViewItem("_screen");
            change55.SubItems.Add("O");

            ListViewItem change56 = new ListViewItem("_builder");
            change56.SubItems.Add("C");

            ListViewItem change57 = new ListViewItem("_converter");
            change57.SubItems.Add("C");

            ListViewItem change58 = new ListViewItem("_wizard");
            change58.SubItems.Add("C");

            ListViewItem change59 = new ListViewItem("_triggerlevel");
            change59.SubItems.Add("N");

            ListViewItem change60 = new ListViewItem("_asciicols");
            change60.SubItems.Add("N");

            ListViewItem change61 = new ListViewItem("_asciirows");
            change61.SubItems.Add("N");

            ListViewItem change62 = new ListViewItem("_browser");
            change62.SubItems.Add("C");

            ListViewItem change63 = new ListViewItem("_scctext");
            change63.SubItems.Add("C");

            ListViewItem change64 = new ListViewItem("_coverage");
            change64.SubItems.Add("C");

            ListViewItem change65 = new ListViewItem("_vfp");
            change65.SubItems.Add("O");

            listView2.Items.AddRange(new ListViewItem[] { change1, change2, change3, change4, change5, change6,
                                                          change7, change8, change9, change10, change11, change12,
                                                          change13, change14, change15, change16, change17, 
                                                          change18, change19, change20, change21, change22, 
                                                          change23, change24, change25, change26, change27, 
                                                          change28, change29, change30, change31, change32,
                                                          change33, change34, change35, change36, change37, change38,
                                                          change39, change40, change41, change42, change43, change44,
                                                          change45, change46, change47, change48, change49, change50,
                                                          change51, change52, change53, change54, change55, change56,
                                                          change57, change58, change59, change60, change61, change62,
                                                          change63, change64, change65});
            #endregion           
        }

        private void btnCancel3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView2_DoubleClick(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                ListViewItem item = listView2.SelectedItems[0];
                tbExpression.Text += item.SubItems[0].Text;
            }
            else { 
                tbExpression.Text  =   string.Empty;
            }
        }

        private void cmbMath_SelectionChangeCommitted(object sender, EventArgs e)
        {
           string math          =    cmbMath.SelectedItem.ToString();
           tbExpression.Text    +=   math;
            
        }

        private void cmbString_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string CB_string    =    cmbString.SelectedItem.ToString();
            tbExpression.Text   +=   CB_string;
        }

        private void cmbLogical_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string CB_Logical   =    cmbLogical.SelectedItem.ToString();
            tbExpression.Text   +=   CB_Logical;
        }

        private void cmbDate_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string CB_Date = cmbDate.SelectedItem.ToString();
            tbExpression.Text += CB_Date;
        }

        private void btnOK3_Click(object sender, EventArgs e)
        {

        }
        //private void ExpressionBuilder_Load(object sender, EventArgs e)
        //{
            //cmbString.Items.Add("text");
        //}        
    }
}