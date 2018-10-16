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
  public partial class Vehicle
  { 
    public Vehicle()
    {
      this.GarageCards = new HashSet<GarageCard>();
      this.VehicleMaintenances = new HashSet<VehicleMaintenance>();
    }

    public long VehicleId { get; set; }
    public string RegistrationNumber { get; set; }
    public int VehicleModelId { get; set; }
    public string VINNumber { get; set; }
    public string VehicleYear { get; set; }
    public int EngineCapacityId { get; set; }
    public System.DateTime DiscRenewalDate { get; set; }
    public int ServiceInterval { get; set; }
    public int StatusId { get; set; }
    public string VehicleCondition { get; set; }
    public int SupplyTypeId { get; set; }
    public int FuelTypeId { get; set; }
    public int VehicleTypeId { get; set; }
    public int LastServiceOdoMeter { get; set; }
    public int CurrentOdoMeter { get; set; }

    public virtual EngineCapicity EngineCapicity { get; set; }
    public virtual FuelType FuelType { get; set; }
    public virtual ICollection<GarageCard> GarageCards { get; set; }
    public virtual Status Status { get; set; }
    public virtual SupplyType SupplyType { get; set; }
    public virtual ICollection<VehicleMaintenance> VehicleMaintenances { get; set; }
    public virtual VehicleModel VehicleModel { get; set; }
    public virtual VehicleType VehicleType { get; set; }
  }
}
