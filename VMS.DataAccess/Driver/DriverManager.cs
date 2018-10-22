using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMS.DataAccess
{
  public class DriverManager
  {

    private Vehicle_ManagementEntities Context;

    public DriverManager()
    {
      this.Context = new Vehicle_ManagementEntities();
    }

 

  }
}
