using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Xml;

using IBatisNet.DataMapper;
using IBatisNet.DataMapper.Configuration;
using IBatisNet.Common.Utilities;

using TS.Fx.Transactions;

namespace TS.Fx.IBatisNet.Helper
{
    public class IBatisNet2Helper : ComponentBase
    {
        private static object syncLock = new object();
        private static ISqlMapper mapper = null;
        public static string conBase = "F";
        public static ISqlMapper Instance
        {
            get
            {
                try
                {
                    XmlDocument sqlMapConfig = new XmlDocument();
                    if (mapper == null)
                    {
                        lock (syncLock)
                        {
                            if (mapper == null)
                            {
                                DomSqlMapBuilder dom = new DomSqlMapBuilder();
#if DEBUG
                                //if (Global.g_posInfo.USER.INITL_PROGRM_ID.ToString() == Global.POS_KIND_OFFICE)//사무실(후방) 로컬
                                //    sqlMapConfig = Resources.GetEmbeddedResourceAsXmlDocument("KPTR.BIZ.Config.SqlMapLocal.config, KPTR.BIZ");
                                //else
                                //    sqlMapConfig = Resources.GetEmbeddedResourceAsXmlDocument("KPTR.BIZ.Config.SqlMap.config, KPTR.BIZ");
                                //sqlMapConfig = Resources.GetEmbeddedResourceAsXmlDocument("TS.Fx.iBatis.Config.SqlMap.config, TS.Fx.iBatis");
#else
                               //sqlMapConfig = Resources.GetEmbeddedResourceAsXmlDocument("KPTR.BIZ.Config.SqlMap.config, KPTR.BIZ");
                                //if (Global.g_posInfo.USER.INITL_PROGRM_ID.ToString() == Global.POS_KIND_OFFICE)//사무실(후방) 로컬
                                //    sqlMapConfig = Resources.GetEmbeddedResourceAsXmlDocument("KPTR.BIZ.Config.SqlMapLocal.config, KPTR.BIZ");
                                //else
                                //sqlMapConfig = Resources.GetEmbeddedResourceAsXmlDocument("TS.Fx.IBatisNet.Config.SqlMap.config, TS.Fx.IBatisNet");
#endif
                                sqlMapConfig = Resources.GetEmbeddedResourceAsXmlDocument("TS.Fx.IBatisNet.Config.SqlMap.config, TS.Fx.IBatisNet");
                                mapper = dom.Configure(sqlMapConfig);
                            }
                        }
                    }

                    return mapper;
                }
                catch (Exception ex)
                {
                    string strex = ex.Message;
                    throw;
                }
            }
        }
    }
}
