//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RS.DataAccessLayer.entitydata
{
    using System;
    using System.Collections.Generic;
    
    public partial class RS_News
    {
        public int NewsId { get; set; }
        public Nullable<int> Newstype { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string Photo { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public bool IsFeatured { get; set; }
        public string Location { get; set; }
        public string District { get; set; }
    }
}
