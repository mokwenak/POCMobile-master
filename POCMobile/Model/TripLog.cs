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
  public partial class TripLog
  {
    public long TripLogId { get; set; }
    public long TripId { get; set; }
    public string StartPoint { get; set; }
    public string EndPoint { get; set; }
    public int StartOdoMeter { get; set; }
    public int EndOdoMeter { get; set; }
    public System.DateTime TripLogDate { get; set; }

    public virtual Trip Trip { get; set; }
  }
}
