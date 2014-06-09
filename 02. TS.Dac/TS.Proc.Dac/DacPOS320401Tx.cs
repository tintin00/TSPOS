using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;

using TS.Fx.Base;
using TS.Fx.Transactions;
using TS.Fx.IBatisNet.Helper;


using TS.Proc.Dac;


namespace TS.Proc.Dac
{
    public class DacPOS320401Tx : DacBase
    {
        public DsResponse SetCommonTx(DsRequest dsR)
        {
            DsResponse dsRes = null;

            try
            {
                dsRes.dtResult = IBatisNet2Helper.Instance.QueryForDataTable("POS320401.GetUserInfo", dsR.htParam);
                dsRes.objResult = dsRes.dtResult.Rows.Count;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }

            return dsRes;
        }
    }
}
