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
    
    public partial class WF_WorkFlow
    {
        public WF_WorkFlow()
        {
            this.Bill_Leave = new HashSet<Bill_Leave>();
            this.WF_BillFlowNode = new HashSet<WF_BillFlowNode>();
            this.WF_WorkFlowNode = new HashSet<WF_WorkFlowNode>();
        }
    
        public int WorkFlowID { get; set; }
        public string WorkFlowName { get; set; }
    
        public virtual ICollection<Bill_Leave> Bill_Leave { get; set; }
        public virtual ICollection<WF_BillFlowNode> WF_BillFlowNode { get; set; }
        public virtual ICollection<WF_WorkFlowNode> WF_WorkFlowNode { get; set; }
    }
}
