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
  public  class User
  {
    public long UserId { get; set; }
    public System.Guid AspnetUserId { get; set; }
    public string UserName { get; set; }
    public string Surname { get; set; }
    public string FirstName { get; set; }
    public string EmployeeNumber { get; set; }
    public int StatusId { get; set; }
    public string EmailAddress { get; set; }
    public string ContactNumber { get; set; }
    public int OfficeId { get; set; }

    public virtual aspnet_Users aspnet_Users { get; set; }
    public virtual Office Office { get; set; }
    public virtual Status Status { get; set; }
  }
}
