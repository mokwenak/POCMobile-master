using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace POCMobile.Model
{
  public partial class Driver
  {
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
    public virtual ICollection<Trip> Trips { get; set; }
  }
}
