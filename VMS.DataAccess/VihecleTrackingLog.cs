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
    
    public partial class VihecleTrackingLog
    {
        public int TripLogId { get; set; }
        public Nullable<int> TripId { get; set; }
        public string Latitud { get; set; }
        public string Longitude { get; set; }
        public string TripLogStatus { get; set; }
        public Nullable<System.DateTime> LogDate { get; set; }
    }
}