using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;

using TS.Fx.Base;
using TS.Fx.Transactions;
using TS.Fx.IBatisNet.Helper;

using TS.Common.Dac;
using TS.Proc.Dac;


namespace TS.Proc.Biz
{
    public class BizPOS320401Tx : BizBase
    {
        public DataTable SetCommonTx(DsRequest dsR)
        {
            DataTable dtResult = null;
            try
            {
                //IBatisNet2Helper.Instance.BeginTransaction();
                //using (DacCommonTx objTx = new DacCommonTx())
                //{
                //    dtResult = objTx.SetCommonTx(dsR);
                //}
                //IBatisNet2Helper.Instance.CommitTransaction();
                return dtResult;
            }
            catch (Exception ex)
            {
                //IBatisNet2Helper.Instance.RollBackTransaction();
                throw ex;
            }
            finally
            {
                dtResult = null;
            }
        }
    }
}
