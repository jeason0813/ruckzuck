//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RuckZuck_WCF
{
    using System;
    using System.Collections.Generic;
    
    public partial class v_SWVersionsLatest
    {
        public long Id { get; set; }
        public string ProductName { get; set; }
        public string Version { get; set; }
        public string Manufacturer { get; set; }
        public string ShortName { get; set; }
        public Nullable<bool> IsLatest { get; set; }
        public Nullable<System.DateTime> LastModified { get; set; }
        public string ProductDescription { get; set; }
        public string ProjectURL { get; set; }
        public string Category { get; set; }
        public Nullable<long> Downloads { get; set; }
        public Nullable<long> Success { get; set; }
        public Nullable<long> Failures { get; set; }
    }
}
