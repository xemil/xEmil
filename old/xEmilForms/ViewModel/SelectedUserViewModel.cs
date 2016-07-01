using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;
using xEmilForms.Helpers;
using xEmilForms.Model;
using XLabs.Ioc;
using XLabs.Platform.Device;
using XLabs.Platform.Services.Geolocation;

namespace xEmilForms.ViewModel
{
    class SelectedUserViewModel : XLabs.Forms.Mvvm.ViewModel
    {

        private CancellationTokenSource _cancellationTokenSource;

        private IGeolocator _geolocator;

        public IGeolocator Geolocator
        {

            get { return _geolocator ?? (_geolocator = DependencyService.Get<IGeolocator>()); }
         
        }
    
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

        private async Task SetGpsValuesTask()
        {
           _cancellationTokenSource = new CancellationTokenSource(); 
            
            await 
            Geolocator.GetPositionAsync(10000, _cancellationTokenSource.Token, true).ContinueWith(task1 =>
            {
                Lat = task1.Result.Latitude.ToString();
                Lng = task1.Result.Longitude.ToString();
            });
        }


		

		
		

		



		

		


    }
}
