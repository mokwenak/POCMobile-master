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

        public bool ValidateUser(string username,string password)
        {
            MembershipUser u;         

            try
            {   ////////////////ASPNET default authentication

                u = Membership.GetUser(username);

                if (Membership.ValidateUser(username, password))
                {
                    return true;

                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                return false;
            }

        }
    }
}
