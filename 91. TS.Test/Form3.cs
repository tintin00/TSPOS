using System;
using System.Collections;
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

using TS.Fx.Base;
using TS.Biz;

namespace TS.Test
{
    public partial class Form3 : xfmFormBase
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = null;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DsResponse dsRes = null;
            DsRequest dsReq = new DsRequest();
            Hashtable ht = new Hashtable();

            try
            {
                dsReq = new DsRequest();
                ht = new Hashtable();

                dsReq.CommandId = "POS320401.GetUserInfo";
                dsReq.CommandType = "R";
                dsReq.htParam = ht;

                using (TS.Biz.BizPOS320401 objNTx = new TS.Biz.BizPOS320401())
                {
                    dsRes = objNTx.CommonTrn(dsReq);
                }

                gridControl1.DataSource = dsRes.DtResult;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dsRes = null;
                dsReq = null;
                ht = null;
            }
        }


    }
}
