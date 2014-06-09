using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TS.Fx.Transactions
{

    /// <summary>
    /// 클래스 명 : ComponentBase
    /// 작성 목적 : Transaction 제어를 위한 Base class
    /// 작  성  자 : 
    /// 최초작성일 :
    /// 변경  내용 :
    /// 변  경  자 :
    /// 변  경  일 : 
    /// </summary>
    public class ComponentBase : IDisposable
    {

        // Methods
        protected ComponentBase()
        {
        }

        private bool disposed = false;

        //Implement IDisposable.
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    // Free other state (managed objects).
                }
                // Free your own state (unmanaged objects).
                // Set large fields to null.
                disposed = true;
            }
        }

        // Use C# destructor syntax for finalization code.
        ~ComponentBase()
        {
            // Simply call Dispose(false).
            Dispose(false);
        }

    }
}

