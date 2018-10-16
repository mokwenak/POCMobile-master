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
  public partial class Trip
  {
    public Trip()
    {
      this.Accidents = new HashSet<Accident>();
      this.Passengers = new HashSet<Passenger>();
      this.TripLogs = new HashSet<TripLog>();
      this.TripOffences = new HashSet<TripOffence>();
    }

    public long TripId { get; set; }
    public Nullable<int> WorkflowId { get; set; }
    public string ProjectName { get; set; }
    public string TripDescription { get; set; }
    public System.DateTime TripDate { get; set; }
    public string StartPoint { get; set; }
    public string EndPoint { get; set; }
    public Nullable<int> VehicleTypeId { get; set; }
    public string AuthirisedBy { get; set; }
    public Nullable<long> VehicleId { get; set; }
    public long DriverId { get; set; }
    public Nullable<long> CoDriverId { get; set; }
    public Nullable<long> GarageCardId { get; set; }
    public Nullable<int> EndOdoMeter { get; set; }
    public System.DateTime EstimatedReturnDate { get; set; }
    public Nullable<decimal> FuelLiters { get; set; }
    public Nullable<int> StartOdoMeter { get; set; }
    public Nullable<decimal> FuelCost { get; set; }
    public string PreInspector { get; set; }
    public string PreInspectionComments { get; set; }
    public string PostInspector { get; set; }
    public string PostInspectionComments { get; set; }
    public Nullable<System.DateTime> ActualReturnDate { get; set; }

    public virtual ICollection<Accident> Accidents { get; set; }
    public virtual Driver Driver { get; set; }
    public virtual ICollection<Passenger> Passengers { get; set; }
    public virtual ICollection<TripLog> TripLogs { get; set; }
    public virtual ICollection<TripOffence> TripOffences { get; set; }
    public virtual VehicleType VehicleType { get; set; }
    public virtual Workflow Workflow { get; set; }
  }
}
