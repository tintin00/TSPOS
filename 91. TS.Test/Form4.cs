using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DevExpress.XtraEditors;
using DevExpress.XtraTreeList;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;


namespace TS.Test
{
    public partial class Form4 : xfmFormBase
    {
        public Form4()
        {
            InitializeComponent();
        }


        private void Form4_Load(object sender, EventArgs e)
        {
            //자식 폼 다시 초기화 하기
            //this.Padding = new System.Windows.Forms.Padding(0);     // 폼 페딩

            //CommonFunc.frmParent = this.ParentForm;


        }  
    }
}