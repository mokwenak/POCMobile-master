using System.Collections.Generic;
using VMS.DataAccess;

namespace POCMobile
{
  public enum ActionCode : int
  {
    Undefined,
    login,
    AddInformation
  };
  public class PostAction
  {
    public ActionCode Code { get; set; }
    public string Url { get; set; }
  }
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

  public enum MapTapMode : int
  {
    Select = 1,
    Add = 2,
  }
  public static class Config
  {
    private static string _appVersionName = string.Empty;
    private static string _appVersionCode = string.Empty;
    private static string _baseServiceUrl;
    //  public static string BASE_SERVICE_URL = "http://10.0.2.2/cpimobile2/api/";

    public static List<GetAction> GetActions;
    public static List<PostAction> PostActions;
    public static List<LookUpAction> SetupActions;

    static Config()
    {
      //_baseServiceUrl = "https://services.arcgisonline.com/ArcGIS/rest/services/World_Imagery/MapServer";

      _baseServiceUrl = "http://localhost:49963/api/";


      //CONFIGURING THE GET ACTIONS
      GetActions = new List<GetAction>();
      GetActions.Add(new GetAction() { Code = ActionCode.login, Url = @"user/login/" });


      //CONFIGURING THE POST ACTIONS
      PostActions = new List<PostAction>();
      PostActions.Add(new PostAction() { Code = ActionCode.AddInformation, Url = @"information/save/" });

     
    }
    public static string ErrServiceCallError;
    public static string ErrMissingAction;


    public static string AppVersionName
    {
      get { return _appVersionName; }
      set { _appVersionName = value; }
    }
    public static string AppVersionCode
    {
      get { return _appVersionCode; }
      set { _appVersionCode = value; }
    }
    public static string BASE_SERVICE_URL
    {
      get
      {
        return _baseServiceUrl;
      }

    }
    public static MapTapMode MapTapMode
    {
      get; set;
    }
  }
  public static class CurrentLocation
  {
    private static double _latitude;
    private static double _logitude;
    private static string _address;
    public static double Latitude
    {
      get { return _latitude; }
      set { _latitude = value; }
    }
    public static double Longitude
    {
      get { return _logitude; }
      set { _logitude = value; }
    }
    public static string Address
    {
      get { return _address; }
      set { _address = value; }
    }
  }
  public static class CurrentUser
  {
    private static string _username;
    public static string UserName
    {
      get { return _username; }
      set { _username = value; }
    }


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


  public static class DigitalGlobe
  {
    public static string UserName { get; set; }
    public static string Password { get; set; }
    public static bool Active { get; set; }
    public static string DFBaseMapUrl { get; set; }

  }
}
