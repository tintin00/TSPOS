using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

using TS.Fx.Base;


//using IBatisNet.DataMapper;
//using IBatisNet.Common;
//using IBatisNet.Common.Logging;
//using IBatisNet.Common.Logging.Impl;

//1. Log4Net 네임스페이스를 using한여 Log4Net을 사용 할 수 있도록 한다..
//using log4net;
//using log4net.Config;




namespace TS.Test
{
    public partial class frmFormBase : Form
    {

        //private static readonly ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);


        public frmFormBase()
        {
            InitializeComponent();

            // 2. 어플리케이션 초기 구동시 Log4Net이 참조할 환경 설정파일을 Log4Net이 알 수 있도록 한다. 
            //    한번만 실행하여 설정 파일이 메모리에 로드되도록하면 됨.
            //XmlConfigurator.Configure();  // <- Application base 디렉토리의  Window1.exe.config 파일을 읽어들일 때.
            //XmlConfigurator.Configure(new System.IO.FileInfo("log4net.xml")); // <- Application base 디렉토리의 log4net.xml을 읽어들일 때. 


        }

    }
}
