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
    
    public partial class ClassificationAlarm
    {
        public int Id { get; set; }
        public string CameraId { get; set; }
        public Nullable<System.DateTime> DateTime { get; set; }
        public string AlarmCode { get; set; }
        public string UnreadAlarm { get; set; }
        public Nullable<int> CameraListId { get; set; }
    
        public virtual ClassificationCameraList ClassificationCameraList { get; set; }
    }
}