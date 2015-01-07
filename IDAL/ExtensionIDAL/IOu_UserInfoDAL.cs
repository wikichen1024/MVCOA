using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDAL
{
    public partial interface IOu_UserInfoDAL
    {
        MODEL.Ou_UserInfo Login(string loginname);
    }
}
