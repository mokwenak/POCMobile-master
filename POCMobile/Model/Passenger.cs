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
