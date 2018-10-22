using Android.App;
using Android.Content;
using Android.Locations;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Views;
using Android.Widget;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using POCMobile.Model;
using POCMobile.Services;
using System;
using System.Linq;

namespace POCMobile.Fragments
{
  public class fragMap : Android.Support.V4.App.Fragment, ILocationListener, IServiceDeletegate<object>
  {
    bool zoomtoLocation = false;
    LocationManager locMgr;
    string locationProvider;

    Context _Context;

    //MapView _mapView;
    MainActivity _mainActivity;
    //FragLocationDialog _dialogLocation;
    //FloatingActionButton _flbtnAdd;
    //FloatingActionButton _flbtrack;

    Button btnStart;
    Button btnSearch;

    EditText txtRefNo;
    bool isLoggin = false;
    //Esri.ArcGISRuntime.Mapping.Map _map;
    //GraphicsOverlay _graphicOverlay;
    public fragMap()
    {

    }

    public override void OnCreate(Bundle savedInstanceState)
    {
      base.OnCreate(savedInstanceState);

      InitializeLocationManager();

      _mainActivity = (MainActivity)this.Activity;


      this._Context = _mainActivity.BaseContext;
      // Create your fragment here
    }

    public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
    {
      // Use this to return your custom view for this Fragment
      // return inflater.Inflate(Resource.Layout.YourFragment, container, false);

      View view = inflater.Inflate(Resource.Layout.uiMap, container, false);



      btnStart = view.FindViewById<Button>(Resource.Id.btnStart);
      btnStart.Click += BtnStart_Click;

      txtRefNo = view.FindViewById<EditText>(Resource.Id.txtRefNo);

      btnSearch = view.FindViewById<Button>(Resource.Id.btnSearch);
      btnSearch.Click += BtnSearch_Click;
      
      //_mapView = view.FindViewById<MapView>(Resource.Id.MyMapView);

      //this._flbtnAdd = view.FindViewById(Resource.Id.flbtnAdd) as FloatingActionButton;
      //this._flbtnAdd.Click += _flbtnAdd_Click;

      //this._mainActivity = (MainActivity)this.Activity;

      //this._mainActivity.SetToolBarTitle("Welcomes " + CurrentUser.UserName);

      //this._flbtrack = view.FindViewById(Resource.Id.flblocation) as FloatingActionButton;
      //this._flbtrack.Click += (o, e) => {

      //  zoomtoLocation = !zoomtoLocation;
      //  if (zoomtoLocation)
      //  {
      //    //_mapView.SetViewpointScaleAsync(2150);
      //    GetCurrentLcoation();
      //  }
      //};

      return view;


    }

    private void BtnSearch_Click(object sender, EventArgs e)
    {
      if (txtRefNo.Text != string.Empty)
      {
        GetAction action = Config.GetActions.Where(o => o.Code == ActionCode.trip).SingleOrDefault();


        object[] param = new[] { txtRefNo.Text };


        _service = new POCService();

        Console.WriteLine("BtnLogin Calling the service");
        _service.GetPost(this, action, param);
      }else
      {
        ShowToastMessage("Enter Trip Reference Number");
      }
    }

    private void BtnStart_Click(object sender, EventArgs e)
    {
      if (btnStart.Text.ToLower() == "start")
      {
        isLoggin = true;
        btnStart.Text = "Stop";
        UpdateLocation("1");
      }else if(btnStart.Text.ToLower()=="stop")
      {
        isLoggin = false;
        btnStart.Text = "Start";
        StopUpdateLocation();
      }
    }

    public override void OnActivityCreated(Bundle savedInstanceState)
    {
      base.OnActivityCreated(savedInstanceState);
      //Initialize();
      //GetCurrentLcoation();

    }

    //private void _flbtnAdd_Click(object sender, EventArgs e)
    //{
    //  Config.MapTapMode = MapTapMode.Add;
    //  fragHome fragement = new fragHome();
    //  var trans = FragmentManager.BeginTransaction();
    //  //trans.SetCustomAnimations(Resource.Animation.gla_there_come, Resource.Animation.gla_there_gone);
    //  fragement.Show(trans, "add");
    //}



    private void ShowToastMessage(string toastMessage)
    {
      Toast toast = Toast.MakeText(this.Context, toastMessage, ToastLength.Short);
      toast.SetGravity(GravityFlags.Top | GravityFlags.CenterHorizontal, 0, 250);
      TextView v = (TextView)toast.View.FindViewById(Android.Resource.Id.Message);
      v.SetTextColor(Android.Graphics.Color.White);
      toast.View.SetBackgroundColor(Android.Graphics.Color.Black);

      toast.Show();
    }

    //private void GetCurrentLcoation()
    //{

    //  Criteria locationCriteria = new Criteria();
    //  locationCriteria.Accuracy = Accuracy.Fine;
    //  locationCriteria.PowerRequirement = Power.Low;

    //  if (locMgr == null)
    //  {
    //    locMgr = _mainActivity.GetSystemService(Context.LocationService) as LocationManager;
    //  }

    //  locationProvider = locMgr.GetBestProvider(locationCriteria, true);
    //  if (locationProvider != null)
    //  {

    //    locMgr.RequestLocationUpdates(locationProvider, 2000, 1, this);
    //  }
    //  else
    //  {
    //    this._dialogLocation = new Fragments.FragLocationDialog();

    //    //var trans = FragmentManager.BeginTransaction();               
    //    //this._dialogLocation.Show(trans, "location");
    //    Toast.MakeText(this.Context, "No location providers available", ToastLength.Long).Show();
    //  }

    //}
    POCService _service;
    
    public void OnLocationChanged(Location location)
    {
      CurrentLocation.Latitude = location.Latitude;
      CurrentLocation.Longitude = location.Longitude;

      if (isLoggin)
        UpdateLocation("2");
    }

    public void UpdateLocation(string status)
    {
      if (isLoggin)
      {
        if (status == "3")
          CurrentLocation.Latitude += 0.00001;
       
        GetAction action = Config.GetActions.Where(o => o.Code == ActionCode.location).SingleOrDefault();


        object[] param = new[] {  CurrentLocation.Latitude.ToString(), CurrentLocation.Longitude.ToString(),status,txtRefNo.Text };


        _service = new POCService();

        Console.WriteLine("BtnLogin Calling the service");
        _service.GetPost(this, action, param);
      }
    }
    public void StopUpdateLocation()
    {
     

        GetAction action = Config.GetActions.Where(o => o.Code == ActionCode.location).SingleOrDefault();


        object[] param = new[] { CurrentLocation.Latitude.ToString(), CurrentLocation.Longitude.ToString(), "3", txtRefNo.Text };


        _service = new POCService();

        Console.WriteLine("BtnLogin Calling the service");
        _service.GetPost(this, action, param);
      
    }

    public void OnProviderDisabled(string provider)
    {

    }

    public void OnProviderEnabled(string provider)
    {

    }

    public void OnStatusChanged(string provider, [GeneratedEnum] Availability status, Bundle extras)
    {

    }


    private void InitializeApp()
    {
      //ArcGISRuntimeEnvironment.SetLicense("runtimelite,1000,rud8694580570,none,NKMFA0PL4SP2F5KHT113");

    }
    private void InitializeLocationManager()
    {

      Criteria locationCriteria = new Criteria();
      locationCriteria.Accuracy = Accuracy.Fine;
      locationCriteria.PowerRequirement = Power.Low;

      if (locMgr == null)
      {
        locMgr = this.Context.GetSystemService(Context.LocationService) as LocationManager;
      }

      locationProvider = locMgr.GetBestProvider(locationCriteria, true);
      if (locationProvider != null)
      {

        locMgr.RequestLocationUpdates(locationProvider, 2000, 1, this);
      }
    }



    public void HandleServiceResults(object resultRootObject, bool isSuccessfull, ActionCode resultType, string message)
    {
      _mainActivity = (MainActivity)this.Activity;

      if (resultRootObject != null)
      {
        JsonSerializerSettings serSettings = new JsonSerializerSettings();
        serSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
        if (resultType == ActionCode.location)
        {
          var resultObj = JsonConvert.DeserializeObject<ResultObj<bool>>(resultRootObject.ToString(), serSettings);

          if (resultObj.isSuccessful)
          {

            if (resultObj.Data == true)
            {
            }

          }         
        }

        else if( resultType== ActionCode.trip)
        {

          var resultObj = JsonConvert.DeserializeObject<ResultObj<bool>>(resultRootObject.ToString(), serSettings);

          if (resultObj.isSuccessful)
          {

            if (resultObj.Data == true)
            {
              _mainActivity.RunOnUiThread(() =>
              {
                btnStart.Enabled = true;
                ShowToastMessage("found start a trip");
              });
            }
            else
            {
              btnStart.Enabled = false;
              ShowToastMessage("Trip was not found");
            }

          }
        }
      }
      
    }
  }
}
