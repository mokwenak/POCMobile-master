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
  public partial class Accident
  {
    public long AccidentId { get; set; }
    public long TripId { get; set; }
    public string AccidentDescription { get; set; }
    public string CaseNumber { get; set; }
    public string Comment { get; set; }
    public System.DateTime AccidentDate { get; set; }
    public string AccidentLocation { get; set; }

    public virtual Trip Trip { get; set; }
  }
}
