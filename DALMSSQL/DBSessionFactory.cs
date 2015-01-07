using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DALMSSQL
{
    public class DBSessionFactory: IDAL.IDBSessionFactory
    {
        /// <summary>
        /// imporve efficency, share dbsession in threads
        /// </summary>
        /// <returns></returns>
        public IDAL.IDBSession GetDBSession()
        {
            DBSession dbSession = CallContext.GetData(typeof(DBSessionFactory).Name) as DBSession;
            if (dbSession == null)
            {
                dbSession = new DBSession();
                CallContext.SetData(typeof(DBSessionFactory).Name, dbSession);
            }
            return dbSession;
        }
    }
}
