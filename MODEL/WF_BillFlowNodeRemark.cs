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
    
    public partial class WF_BillFlowNodeRemark
    {
        public int BillFlowNodeRemarkID { get; set; }
        public Nullable<int> BillFlowNodeID { get; set; }
        public Nullable<int> TransactorID { get; set; }
        public string Transactor { get; set; }
        public Nullable<System.DateTime> TransactorDate { get; set; }
        public string TransactorOperation { get; set; }
        public string TransactorRemark { get; set; }
    
        public virtual WF_BillFlowNode WF_BillFlowNode { get; set; }
    }
}
