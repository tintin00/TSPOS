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
    public class BizCommon : BizBase
    {
        public DsResponse CommonTrn(DsRequest dsReq)
        {
            DsResponse dsRes = null;


            using (DacCommon objTrn = new DacCommon())
            {

                dsRes = objTrn.CommonTrn(dsReq);
            }

            return dsRes;
        }
    }
}
