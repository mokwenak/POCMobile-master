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
    
    public partial class Driver
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Driver()
        {
            this.Trips = new HashSet<Trip>();
        }
    
        public long DriverId { get; set; }
        public string DriverIdNumber { get; set; }
        public string EmployeeNumber { get; set; }
        public string FirstName { get; set; }
        public string Initials { get; set; }
        public string Surname { get; set; }
        public string CellNumber { get; set; }
        public string EmergenceContactNo { get; set; }
        public string EmergenceName { get; set; }
        public string LicenseNumber { get; set; }
        public string LicenseCode { get; set; }
        public System.DateTime LicenseIssueDate { get; set; }
        public System.DateTime LicenseExpiryDate { get; set; }
        public string PdpLicenseNumber { get; set; }
        public Nullable<System.DateTime> PdpLicenseDate { get; set; }
        public int OfficeId { get; set; }
        public int StatusId { get; set; }
    
        public virtual Office Office { get; set; }
        public virtual Status Status { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Trip> Trips { get; set; }
    }
}
