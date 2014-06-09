using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;

using TS.Fx.Base;
using TS.Fx.Transactions;
using TS.Fx.IBatisNet.Helper;

namespace TS.Dac
{
    public class DacCommon : DacBase
    {
        public DsResponse CommonTrn(DsRequest dsReq)
        {
            DsResponse dsRes = new DsResponse(dsReq);

            switch (dsReq.CommandType)
            {
                case "C":
                    dsRes.objResult = IBatisNet2Helper.Instance.Insert(dsReq.CommandId, dsReq.htParam);
                    break;

                case "U" :
                    dsRes.objResult = IBatisNet2Helper.Instance.Update(dsReq.CommandId, dsReq.htParam);
                    break;

                case "D":
                    dsRes.objResult = IBatisNet2Helper.Instance.Delete(dsReq.CommandId, dsReq.htParam);
                    break;
                case "SP":
                    ;
                    break;
                case null:
                case "":
                case "R":
                default:
                    dsRes.DtResult = IBatisNet2Helper.Instance.QueryForDataTable(dsReq.CommandId, dsReq.htParam);
                    break;
            }

            return dsRes;
        }
    }
}
