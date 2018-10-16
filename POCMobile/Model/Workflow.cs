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
  public partial class Workflow
  {
    public Workflow()
    {
      this.Trips = new HashSet<Trip>();
    }

    public int WorkflowId { get; set; }
    public string WorkflowName { get; set; }

    public virtual ICollection<Trip> Trips { get; set; }
  }
}
