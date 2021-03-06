﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MITSDatabaseEntities : DbContext
    {
        public MITSDatabaseEntities()
            : base("name=MITSDatabaseEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<C__RefactorLog> C__RefactorLog { get; set; }
        public virtual DbSet<ActivityLog> ActivityLogs { get; set; }
        public virtual DbSet<ApplyNewStreetLight> ApplyNewStreetLights { get; set; }
        public virtual DbSet<ApplyNewStreetLightImg> ApplyNewStreetLightImgs { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<ClassificationAlarm> ClassificationAlarms { get; set; }
        public virtual DbSet<ClassificationCameraList> ClassificationCameraLists { get; set; }
        public virtual DbSet<ClassificationData> ClassificationDatas { get; set; }
        public virtual DbSet<ClientAdminUser> ClientAdminUsers { get; set; }
        public virtual DbSet<CompanyProfile> CompanyProfiles { get; set; }
        public virtual DbSet<ControllerClockSetting> ControllerClockSettings { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<GreenTimeArchive> GreenTimeArchives { get; set; }
        public virtual DbSet<GroupDetail> GroupDetails { get; set; }
        public virtual DbSet<GroupEnableDetail> GroupEnableDetails { get; set; }
        public virtual DbSet<JunctionAlarm> JunctionAlarms { get; set; }
        public virtual DbSet<JunctionAPUFirmware> JunctionAPUFirmwares { get; set; }
        public virtual DbSet<JunctionFeature> JunctionFeatures { get; set; }
        public virtual DbSet<JunctionList> JunctionLists { get; set; }
        public virtual DbSet<JunctionMonitoringString> JunctionMonitoringStrings { get; set; }
        public virtual DbSet<JunctionMultiplanTimeSetting> JunctionMultiplanTimeSettings { get; set; }
        public virtual DbSet<JunctionPhaseTemplate> JunctionPhaseTemplates { get; set; }
        public virtual DbSet<JunctionPhasingFlow> JunctionPhasingFlows { get; set; }
        public virtual DbSet<JunctionSpecification> JunctionSpecifications { get; set; }
        public virtual DbSet<JunctionVARevisedAlarm> JunctionVARevisedAlarms { get; set; }
        public virtual DbSet<JunctionVaTimeSetting> JunctionVaTimeSettings { get; set; }
        public virtual DbSet<LiveCctv> LiveCctvs { get; set; }
        public virtual DbSet<LoopDetail> LoopDetails { get; set; }
        public virtual DbSet<LoopEnableDetail> LoopEnableDetails { get; set; }
        public virtual DbSet<PersonInCharge> PersonInCharges { get; set; }
        public virtual DbSet<State> States { get; set; }
        public virtual DbSet<StreetLightComplaintImg> StreetLightComplaintImgs { get; set; }
        public virtual DbSet<StreetLightComplaint> StreetLightComplaints { get; set; }
        public virtual DbSet<StreetLightListOfName> StreetLightListOfNames { get; set; }
        public virtual DbSet<StreetLightLogin> StreetLightLogins { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<tblAlarm> tblAlarms { get; set; }
        public virtual DbSet<tblGreenTime> tblGreenTimes { get; set; }
        public virtual DbSet<tblJunctionSetting> tblJunctionSettings { get; set; }
        public virtual DbSet<tblMonitoring> tblMonitorings { get; set; }
        public virtual DbSet<tblProduct> tblProducts { get; set; }
        public virtual DbSet<tblSale> tblSales { get; set; }
        public virtual DbSet<Telegram> Telegrams { get; set; }
        public virtual DbSet<Todo> Todos { get; set; }
        public virtual DbSet<TrafficLightComplaintImg> TrafficLightComplaintImgs { get; set; }
        public virtual DbSet<TrafficLightComplaint> TrafficLightComplaints { get; set; }
        public virtual DbSet<VaIntelligent> VaIntelligents { get; set; }
        public virtual DbSet<VaIntelligentSetting> VaIntelligentSettings { get; set; }
        public virtual DbSet<VehicleCountArchive> VehicleCountArchives { get; set; }
    }
}
