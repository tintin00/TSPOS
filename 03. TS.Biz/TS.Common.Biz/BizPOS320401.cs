using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;

using TS.Fx.Base;
using TS.Fx.Transactions;
using TS.Fx.IBatisNet.Helper;

using TS.Dac;


namespace TS.Biz
{
    public class BizPOS320401 : BizCommon
    {
        public DsResponse SetTestTransaction(DsRequest dsReq)
        {

            try
            {
                DsResponse dsRes = null;
                Hashtable ht = null;


                IBatisNet2Helper.Instance.BeginTransaction();

                using (DacCommon objTx = new DacCommon())
                {
                    ht = new Hashtable();
                    ht.Add("USER_ID", "Test11");
                    dsReq.htParam = ht;

                    dsRes = objTx.CommonTrn(dsReq);

                    dsReq.htParam["USER_ID"] = "Test12";
                    dsRes = objTx.CommonTrn(dsReq);

                    dsReq.htParam["USER_ID"] = "Test11";
                    dsRes = objTx.CommonTrn(dsReq);

                    ;


                }

                IBatisNet2Helper.Instance.CommitTransaction();

                return dsRes;
            }
            catch (Exception ex)
            {
                IBatisNet2Helper.Instance.RollBackTransaction();
                throw ex;
            }

        }
    }
}
