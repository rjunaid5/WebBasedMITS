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
    
    public partial class JunctionSpecification
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Setting { get; set; }
        public Nullable<int> JunctionListId { get; set; }
        public string Identifier { get; set; }
    
        public virtual JunctionList JunctionList { get; set; }
    }
}
