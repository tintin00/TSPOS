using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using TS.Fx.Transactions;

namespace TS.Fx.Base
{
    public class BizBase : ComponentBase
    {

        private bool disposed = false;

        protected override void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    // Release managed resources.
                }
                // Release unmanaged resources.
                // Set large fields to null.
                // Call Dispose on your base class.
                disposed = true;
            }
            base.Dispose(disposing);
        }
    }
}
