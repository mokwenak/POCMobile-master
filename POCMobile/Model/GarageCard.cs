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
