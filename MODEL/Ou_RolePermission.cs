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
    
    public partial class Ou_RolePermission
    {
        public int rpId { get; set; }
        public int rpRId { get; set; }
        public int rpPId { get; set; }
        public bool rpIsDel { get; set; }
        public System.DateTime rpAddTime { get; set; }
    
        public virtual Ou_Permission Ou_Permission { get; set; }
        public virtual Ou_Role Ou_Role { get; set; }
    }
}
