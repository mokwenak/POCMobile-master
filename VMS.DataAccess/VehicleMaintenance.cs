//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VMS.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class VehicleMaintenance
    {
        public long VehicleMaintenanceId { get; set; }
        public long VehicleId { get; set; }
        public int ServiceTypeId { get; set; }
        public int OdoMeter { get; set; }
        public System.DateTime ServiceDate { get; set; }
        public string Comments { get; set; }
    
        public virtual ServiceType ServiceType { get; set; }
        public virtual Vehicle Vehicle { get; set; }
    }
}
