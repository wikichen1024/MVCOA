 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLLA
{
	public partial class Bill_LeaveDAL : BaseBLL<MODEL.Bill_Leave>,IBLL.IBill_LeaveBLL
    {
	   public override void SetDAL()
		{
			idal = DBSession.IBill_LeaveDAL;
		}
    }
	public partial class Ou_DepartmentDAL : BaseBLL<MODEL.Ou_Department>,IBLL.IOu_DepartmentBLL
    {
	   public override void SetDAL()
		{
			idal = DBSession.IOu_DepartmentDAL;
		}
    }
	public partial class Ou_PermissionDAL : BaseBLL<MODEL.Ou_Permission>,IBLL.IOu_PermissionBLL
    {
	   public override void SetDAL()
		{
			idal = DBSession.IOu_PermissionDAL;
		}
    }
	public partial class Ou_RoleDAL : BaseBLL<MODEL.Ou_Role>,IBLL.IOu_RoleBLL
    {
	   public override void SetDAL()
		{
			idal = DBSession.IOu_RoleDAL;
		}
    }
	public partial class Ou_RolePermissionDAL : BaseBLL<MODEL.Ou_RolePermission>,IBLL.IOu_RolePermissionBLL
    {
	   public override void SetDAL()
		{
			idal = DBSession.IOu_RolePermissionDAL;
		}
    }
	public partial class Ou_UserInfoDAL : BaseBLL<MODEL.Ou_UserInfo>,IBLL.IOu_UserInfoBLL
    {
	   public override void SetDAL()
		{
			idal = DBSession.IOu_UserInfoDAL;
		}
    }
	public partial class Ou_UserRoleDAL : BaseBLL<MODEL.Ou_UserRole>,IBLL.IOu_UserRoleBLL
    {
	   public override void SetDAL()
		{
			idal = DBSession.IOu_UserRoleDAL;
		}
    }
	public partial class Ou_UserVipPermissionDAL : BaseBLL<MODEL.Ou_UserVipPermission>,IBLL.IOu_UserVipPermissionBLL
    {
	   public override void SetDAL()
		{
			idal = DBSession.IOu_UserVipPermissionDAL;
		}
    }
	public partial class WF_AutoTransactNodeDAL : BaseBLL<MODEL.WF_AutoTransactNode>,IBLL.IWF_AutoTransactNodeBLL
    {
	   public override void SetDAL()
		{
			idal = DBSession.IWF_AutoTransactNodeDAL;
		}
    }
	public partial class WF_BillFlowNodeDAL : BaseBLL<MODEL.WF_BillFlowNode>,IBLL.IWF_BillFlowNodeBLL
    {
	   public override void SetDAL()
		{
			idal = DBSession.IWF_BillFlowNodeDAL;
		}
    }
	public partial class WF_BillFlowNodeRemarkDAL : BaseBLL<MODEL.WF_BillFlowNodeRemark>,IBLL.IWF_BillFlowNodeRemarkBLL
    {
	   public override void SetDAL()
		{
			idal = DBSession.IWF_BillFlowNodeRemarkDAL;
		}
    }
	public partial class WF_BillStateDAL : BaseBLL<MODEL.WF_BillState>,IBLL.IWF_BillStateBLL
    {
	   public override void SetDAL()
		{
			idal = DBSession.IWF_BillStateDAL;
		}
    }
	public partial class WF_NodeDAL : BaseBLL<MODEL.WF_Node>,IBLL.IWF_NodeBLL
    {
	   public override void SetDAL()
		{
			idal = DBSession.IWF_NodeDAL;
		}
    }
	public partial class WF_NodeStateDAL : BaseBLL<MODEL.WF_NodeState>,IBLL.IWF_NodeStateBLL
    {
	   public override void SetDAL()
		{
			idal = DBSession.IWF_NodeStateDAL;
		}
    }
	public partial class WF_WorkFlowDAL : BaseBLL<MODEL.WF_WorkFlow>,IBLL.IWF_WorkFlowBLL
    {
	   public override void SetDAL()
		{
			idal = DBSession.IWF_WorkFlowDAL;
		}
    }
	public partial class WF_WorkFlowNodeDAL : BaseBLL<MODEL.WF_WorkFlowNode>,IBLL.IWF_WorkFlowNodeBLL
    {
	   public override void SetDAL()
		{
			idal = DBSession.IWF_WorkFlowNodeDAL;
		}
    }
}