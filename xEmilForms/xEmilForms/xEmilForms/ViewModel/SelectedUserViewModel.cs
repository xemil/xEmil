using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using xEmilForms.Helpers;
using xEmilForms.Model;
using XLabs.Ioc;
using XLabs.Platform.Device;
using XLabs.Platform.Services.Geolocation;

namespace xEmilForms.ViewModel
{
    class SelectedUserViewModel : XLabs.Forms.Mvvm.ViewModel
    {


        public SelectedUserViewModel()
        {
            //var selectedUser = Resolver.Resolve<ISelectedFacebookUser>();
            //SelectedFacebookUser = (FacebookUser) selectedUser;

            SetGpsValuesTask();
        }

        private FacebookUser _selectedFacebookUser;

        public FacebookUser SelectedFacebookUser
        {

            get { return _selectedFacebookUser; }
            set { SetProperty(ref _selectedFacebookUser, value); }
        }

        private string _lat;

        public string Lat
        {

            get
            {
                return _lat ?? (_lat = "");
            }
            set { SetProperty(ref _lat, value); }
        }


        private string _lng;

        public string Lng
        {

            get
            {
                return _lng ?? (_lng = "");
            }
            set { SetProperty(ref _lng, value); }
        }

        private Task SetGpsValuesTask()
        {
          
                Lat = "Started";
                Lng = "Started";
                var geo = Resolver.Resolve<IGeolocator>();
            var i = 0;
                var av = geo.IsGeolocationAvailable;
                var ab = geo.IsGeolocationEnabled;
            var task = geo.GetPositionAsync(new CancellationToken()).ContinueWith(task1 =>
            {
                Lat = task1.Result.Latitude.ToString();
                Lng = task1.Result.Longitude.ToString();
            });

            return task;
        }


		

		
		

		



		

		


    }
}
