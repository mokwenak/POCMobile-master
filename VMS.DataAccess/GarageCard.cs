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
    
    public partial class GarageCard
    {
        public long GarageCardId { get; set; }
        public string CardNumber { get; set; }
        public int BankId { get; set; }
        public System.DateTime ExpireDate { get; set; }
        public System.DateTime ReceivedDate { get; set; }
        public System.DateTime ReturnDate { get; set; }
        public long VehicleId { get; set; }
    
        public virtual Bank Bank { get; set; }
        public virtual Vehicle Vehicle { get; set; }
    }
}
