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
    
    public partial class LiveCctv
    {
        public int Id { get; set; }
        public Nullable<int> JunctionListId { get; set; }
        public Nullable<int> CompanyProfileId { get; set; }
        public string CameraName { get; set; }
        public Nullable<int> JunctionId { get; set; }
        public string Url { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<bool> HasCctv { get; set; }
    }
}
