//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MODEL
{
    using System;
    using System.Collections.Generic;
    
    public partial class WF_BillFlowNode
    {
        public WF_BillFlowNode()
        {
            this.WF_BillFlowNodeRemark = new HashSet<WF_BillFlowNodeRemark>();
        }
    
        public int BillFlowNodeID { get; set; }
        public Nullable<int> WorkFlowNodeID { get; set; }
        public Nullable<int> NodeStateID { get; set; }
        public Nullable<int> WorkFlowID { get; set; }
        public Nullable<int> BillID { get; set; }
    
        public virtual WF_WorkFlowNode WF_WorkFlowNode { get; set; }
        public virtual WF_NodeState WF_NodeState { get; set; }
        public virtual WF_WorkFlow WF_WorkFlow { get; set; }
        public virtual ICollection<WF_BillFlowNodeRemark> WF_BillFlowNodeRemark { get; set; }
    }
}
