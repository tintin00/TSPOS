using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Collections;

using TS.Fx.Transactions;

namespace TS.Fx.Base
{
    public class DsRequest
    {

        public string CommandId = string.Empty;
        public string CommandType = string.Empty;
        public Hashtable htParam = null;


        // Methods
        public DsRequest()
        {
        }

        public DsRequest(string Id, string Type, Hashtable ht)
        {
            this.CommandId = Id;
            this.CommandType = Type;
            this.htParam = ht;
        }


    }
}
