using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMS.DataAccess
{

  public enum ActionCode : int
  {
    Undefined,
    login,
    location,
    trip,
    AddInformation
  };

  public class PostObject<T>
  {
    public PostObject()
    {
      Data = default(T);
      PostAction = new PostAction();
    }
    public T Data { get; set; }

    public PostAction PostAction { get; set; }
  }
  public class PostAction
  {
    public ActionCode Code { get; set; }
    public string Url { get; set; }
  }


  public class ResultObj<T>
  {
    public ResultObj()
    {
      Data = default(T);
      isSuccessful = false;
      Error = string.Empty;
      ResultType = ActionCode.Undefined;

    }
    public T Data { get; set; }
    public string Error { get; set; }
    public bool isSuccessful { get; set; }
    public ActionCode ResultType { get; set; }
  }

  public class GetAction
  {
    public ActionCode Code { get; set; }
    public string Url { get; set; }
  }
  public class LookUpAction
  {
    public ActionCode Code { get; set; }
    public string Url { get; set; }
  }

  public class LocationParameters
  {
    public string Latitude { get; set; }
    public string Longtude { get; set; }
    public string status { get; set; }

    public string tripId { get; set; }
  }


}
