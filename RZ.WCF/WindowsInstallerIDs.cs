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
    
    public partial class WindowsInstallerIDs
    {
        public long Id { get; set; }
        public long ProductVersionId { get; set; }
        public Nullable<System.Guid> MSIProductID { get; set; }
        public string MSIVersion { get; set; }
        public string MSIProductName { get; set; }
        public string ARPDisplayName { get; set; }
    
        public virtual ProductVersion ProductVersion { get; set; }
    }
}
