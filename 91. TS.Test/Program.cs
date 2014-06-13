using System;
using System.Collections.Generic;

using System.Windows.Forms;

namespace TS.Test
{
    static class Program
    {
        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary> 
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Global.g_posInfo.USER.INITL_PROGRM_ID = "F";
            //Application.Run(new Form1(Global.START_UP));
            Application.Run(new Form3());
           //공통코드 :
            //POS320301
            //POS320307
          //Application.Run(new OFFICE.POS320211());
       //Application.Run(new SAIL.POS320301());
           

        }
    }
}
