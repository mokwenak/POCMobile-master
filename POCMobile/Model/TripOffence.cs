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
  public partial class TripOffence
  {
    public long TripOffenceId { get; set; }
    public long TripId { get; set; }
    public int OffenceTypeId { get; set; }
    public System.DateTime OffenceDate { get; set; }
    public string Comments { get; set; }

    public virtual OffenceType OffenceType { get; set; }
    public virtual Trip Trip { get; set; }
  }
}
