using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;

namespace VMS.DataAccess
{
  public class UserManager
  {
    private Vehicle_ManagementEntities Context;

    public UserManager()
    {
      this.Context = new Vehicle_ManagementEntities();
    }
    public UserManager(Vehicle_ManagementEntities context)
    {
      this.Context = context;
    }

    public ResultObj<bool> ValidateUser(string username, string password)
    {
      ResultObj<bool> result = new ResultObj<bool>() { isSuccessful = false, Error = string.Empty };
      MembershipUser u;

      try
      {   ////////////////ASPNET default authentication

        u = Membership.GetUser(username);

        if (Membership.ValidateUser(username, password))
        {

          result.Data = true;
          result.isSuccessful = true;


        }
        else
        {
          result.Data = false;
          result.isSuccessful = false;
        }

        return result;

      }
      catch (Exception ex)
      {
        result.Data = false;
        result.isSuccessful = false;

        return result;
      }

    }
  }
}
