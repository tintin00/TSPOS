using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

using TS.Fx.Base;
using TS.Biz;

//using IBatisNet.DataMapper;
//using IBatisNet.Common;
//using IBatisNet.Common.Logging;
//using IBatisNet.Common.Logging.Impl;


namespace TS.Test
{
    public partial class Form1 : frmFormBase
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //log.Debug("Hello World!");

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

                dataGridView1.DataSource = dsRes.DtResult;

            }
            catch(Exception ex)
            {
            }
            finally
            {
                dsRes = null;
                dsReq = null;
                ht = null;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DsResponse dsRes = null;
            DsRequest dsReq = new DsRequest();
            Hashtable ht = new Hashtable();

            try
            {
                dsReq = new DsRequest();
                ht = new Hashtable();

                dsReq.CommandId = "POS320401.SetUserInfo";
                dsReq.CommandType = "C";
                dsReq.htParam = ht;

                using (TS.Biz.BizPOS320401 objNTx = new TS.Biz.BizPOS320401())
                {
                    dsRes = objNTx.SetTestTransaction(dsReq);
                }

                dataGridView1.DataSource = dsRes.DtResult;

            }
            catch (Exception ex)
            {
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
