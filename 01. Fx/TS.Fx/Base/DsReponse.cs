using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using System.Collections;

using TS.Fx.Transactions;

namespace TS.Fx.Base
{
    public class DsResponse
    {

        public DsRequest dsReq { get; set; }
        public object objResult { get; set; }
        private DataTable dtResult;
        public int dtRowCount { get; set; }

        public DataTable DtResult
        {
            get { return this.dtResult; }
            set
            {
                this.dtResult = value;
                if (value == null)
                    this.dtRowCount = (int)0;
                else
                    this.dtRowCount = value.Rows.Count;
            }
        }

        


        // Methods
        public DsResponse()
        {
        }
        public DsResponse(DsRequest dsReq)
        {
            this.dsReq = dsReq;
        }

    }
}
