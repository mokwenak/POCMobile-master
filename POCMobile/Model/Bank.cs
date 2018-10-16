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
  public partial class Bank
  {
   
    public Bank()
    {
      this.GarageCards = new HashSet<GarageCard>();
    }

    public int BankId { get; set; }
    public string BankDescription { get; set; }
    
    public virtual ICollection<GarageCard> GarageCards { get; set; }
  }
}
