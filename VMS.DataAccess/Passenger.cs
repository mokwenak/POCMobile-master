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
    
    public partial class Passenger
    {
        public long PassengerId { get; set; }
        public long TripId { get; set; }
        public string PassengerIdNo { get; set; }
        public string PassengerFirstName { get; set; }
        public string PassengerSurname { get; set; }
        public string Reason { get; set; }
    
        public virtual Trip Trip { get; set; }
    }
}
