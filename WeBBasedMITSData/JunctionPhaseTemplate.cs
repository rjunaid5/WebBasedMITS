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
    
    public partial class JunctionPhaseTemplate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<decimal> FromLatitude { get; set; }
        public Nullable<decimal> FromLongitude { get; set; }
        public Nullable<int> JunctionListId { get; set; }
        public Nullable<decimal> ToLatitude { get; set; }
        public Nullable<decimal> ToLongitude { get; set; }
        public string Description { get; set; }
    
        public virtual JunctionList JunctionList { get; set; }
    }
}
