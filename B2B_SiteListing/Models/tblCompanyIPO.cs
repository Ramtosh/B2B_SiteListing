//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace B2B_SiteListing.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblCompanyIPO
    {
        public long Id { get; set; }
        public string IPOName { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public string Ipoexchange { get; set; }
        public string Ipolink { get; set; }
        public string ipodescription { get; set; }
        public Nullable<long> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<long> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<long> CompanyId { get; set; }
    
        public virtual Company Company { get; set; }
        public virtual User User { get; set; }
    }
}
