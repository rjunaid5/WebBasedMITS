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
    
    public partial class JunctionList
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public JunctionList()
        {
            this.ControllerClockSettings = new HashSet<ControllerClockSetting>();
            this.GreenTimeArchives = new HashSet<GreenTimeArchive>();
            this.GroupEnableDetails = new HashSet<GroupEnableDetail>();
            this.JunctionAlarms = new HashSet<JunctionAlarm>();
            this.JunctionAPUFirmwares = new HashSet<JunctionAPUFirmware>();
            this.JunctionMultiplanTimeSettings = new HashSet<JunctionMultiplanTimeSetting>();
            this.JunctionPhaseTemplates = new HashSet<JunctionPhaseTemplate>();
            this.JunctionSpecifications = new HashSet<JunctionSpecification>();
            this.LoopEnableDetails = new HashSet<LoopEnableDetail>();
            this.Telegrams = new HashSet<Telegram>();
        }
    
        public int Id { get; set; }
        public Nullable<int> CompanyProfileId { get; set; }
        public string District { get; set; }
        public Nullable<int> StateId { get; set; }
        public string JunctionId { get; set; }
        public Nullable<decimal> Latitude { get; set; }
        public Nullable<decimal> Longitude { get; set; }
        public string DeveloperName { get; set; }
        public string JunctionIp { get; set; }
        public string Name { get; set; }
        public string JunctionShortName { get; set; }
        public string JunctionFeatureId { get; set; }
        public Nullable<bool> HasCctv { get; set; }
        public string WebApiLink { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<System.DateTime> DateDeleted { get; set; }
        public Nullable<System.DateTime> DateAdded { get; set; }
        public string CctvWebLink { get; set; }
        public string JunctionStatus { get; set; }
        public Nullable<decimal> CenterLatitude { get; set; }
        public Nullable<decimal> CenterLogitude { get; set; }
        public Nullable<bool> HasClassification { get; set; }
        public string IotDeviceName { get; set; }
    
        public virtual CompanyProfile CompanyProfile { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ControllerClockSetting> ControllerClockSettings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GreenTimeArchive> GreenTimeArchives { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GroupEnableDetail> GroupEnableDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JunctionAlarm> JunctionAlarms { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JunctionAPUFirmware> JunctionAPUFirmwares { get; set; }
        public virtual State State { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JunctionMultiplanTimeSetting> JunctionMultiplanTimeSettings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JunctionPhaseTemplate> JunctionPhaseTemplates { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JunctionSpecification> JunctionSpecifications { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoopEnableDetail> LoopEnableDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Telegram> Telegrams { get; set; }
    }
}
