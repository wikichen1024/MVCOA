using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALMSSQL
{
   public partial class Ou_UserInfoDAL:IDAL.IOu_UserInfoDAL
    {
        public MODEL.Ou_UserInfo Login(string loginname)
        {
            return base.GetListBy(u => u.uLoginName == loginname).FirstOrDefault();
        }

      
    }
}
