//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WeBBasedMITSData
{
    using System;
    using System.Collections.Generic;
    
    public partial class JunctionVARevisedAlarm
    {
        public int Id { get; set; }
        public Nullable<int> JunctionListId { get; set; }
        public Nullable<int> CompanyProfileId { get; set; }
        public Nullable<System.DateTime> DateAdded { get; set; }
        public string PhaseNo { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
        public string FaultyType { get; set; }
        public string Status { get; set; }
        public string Details { get; set; }
    }
}
