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
    
    public partial class StreetLightComplaintImg
    {
        public int StreetLightComplaintImgID { get; set; }
        public string ImgPath { get; set; }
        public Nullable<int> StreetLightNameListID { get; set; }
        public Nullable<int> StreetLightComplaintID { get; set; }
    
        public virtual StreetLightComplaint StreetLightComplaint { get; set; }
        public virtual StreetLightListOfName StreetLightListOfName { get; set; }
    }
}