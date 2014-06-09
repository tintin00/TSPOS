using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;

using TS.Fx.Base;
using TS.Fx.Transactions;

using TS.Common.Dac;
using TS.Proc.Dac;


namespace TS.Proc.Biz
{
    public class BizPOS320401NTx : BizBase
    {
        public DataTable GetCommonNTx(DsRequest dsR)
        {
            DataTable dtResult = null;

            using (DacPOS320401NTx objNTx = new DacPOS320401NTx())
            {
                dtResult = objNTx.GetCommonNTx(dsR);
            }

            return dtResult;
        }
    }
}
