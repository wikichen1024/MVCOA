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
    
    public partial class WF_Node
    {
        public WF_Node()
        {
            this.WF_WorkFlowNode = new HashSet<WF_WorkFlowNode>();
        }
    
        public int NodeID { get; set; }
        public string NodeName { get; set; }
    
        public virtual ICollection<WF_WorkFlowNode> WF_WorkFlowNode { get; set; }
    }
}
