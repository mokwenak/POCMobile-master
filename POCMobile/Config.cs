using System.Collections.Generic;

namespace POCMobile
{
  public enum ActionCode : int
  {
    Undefined,
    login,
    location,
    trip,
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

      // _baseServiceUrl = "http://localhost:49963/api/";
      //_baseServiceUrl = "http://10.0.2.2/webapi/api/";
      //_baseServiceUrl = "http://10.131.152.154:8080/cpimobile2/api/";

       _baseServiceUrl = "http://40.84.129.247/vmsapi/api/";
      


      //CONFIGURING THE GET ACTIONS
      GetActions = new List<GetAction>();
      GetActions.Add(new GetAction() { Code = ActionCode.login, Url = @"user/login/" });
     GetActions.Add(new GetAction() { Code = ActionCode.location, Url = @"location/save/" });
      GetActions.Add(new GetAction() { Code = ActionCode.trip, Url = @"trip/get/" });


      //CONFIGURING THE POST ACTIONS
      PostActions = new List<PostAction>();
      //PostActions.Add(new PostAction() { Code = ActionCode.location, Url = @"location/save/" });

     
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
    private static string _latitude;
    private static string _logitude;
    private static string _address;
    public static string Latitude
    {
      get { return _latitude; }
      set { _latitude = value; }
    }
    public static string Longitude
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
  public class LocationParameters
  {
    public string Latitude { get; set; }
    public string Longtude { get; set; }
  }
}
