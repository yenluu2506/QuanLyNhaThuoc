//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HieuThuoc.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Payment
    {
        public long ID { get; set; }
        public Nullable<decimal> Payprices { get; set; }
        public Nullable<long> OrderID { get; set; }
    
        public virtual Order Order { get; set; }
    }
}
