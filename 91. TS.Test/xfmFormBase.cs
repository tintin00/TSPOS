using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DevExpress.XtraEditors;

using TS.Fx.Base;


namespace TS.Test
{
    public partial class xfmFormBase : DevExpress.XtraEditors.XtraForm
    {
        public xfmFormBase()
        {
            InitializeComponent();
        }


        private void xfmFormBase_Load(object sender, EventArgs e)
        {
            //자식 폼 다시 초기화 하기
            //this.Padding = new System.Windows.Forms.Padding(0);     // 폼 페딩

            //CommonFunc.frmParent = this.ParentForm;


        }  
    }
}