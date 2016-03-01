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
            cmbString.SelectedIndexChanged +=new EventHandler(cmbString_SelectedIndexChanged);

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
            cmbMath.SelectedIndex   =   0;
        }

        private void cmbString_SelectedIndexChanged(object sender, EventArgs e) {  
            
        }
        //private void ExpressionBuilder_Load(object sender, EventArgs e)
        //{
            //cmbString.Items.Add("text");
        //}        
    }
}