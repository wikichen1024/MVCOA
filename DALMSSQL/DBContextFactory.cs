using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Runtime.Remoting.Messaging;

namespace DALMSSQL
{
    public class DBContextFactory:IDAL.IDBContextFactory
    {
        public DbContext GetDbContext()
        {
            DbContext dbContext = CallContext.GetData(typeof(DBContextFactory).Name) as DbContext;
            if (dbContext==null)
            {
                dbContext = new MODEL.OuOAEntities();
                CallContext.SetData(typeof(DBContextFactory).Name, dbContext);
            }
            return dbContext;
        }
    }
}
