using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDAL
{
    /// <summary>
    /// super interface, containing all interface accesses
    /// </summary>
    public partial interface IDBSession
    {
        int SaveChanges();
        
    }
}
