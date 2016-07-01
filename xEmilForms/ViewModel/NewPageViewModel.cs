using System;
using System.Windows.Input;
using Xamarin.Forms;
using XLabs.Ioc;
using XLabs.Platform.Device;
using XLabs.Platform.Services.Geolocation;
using XLabs.Sample.ViewModel;
using PositionExtensions = XLabs.Platform.PositionExtensions;

namespace xEmilForms.ViewModel
{
	//[ViewType(typeof(NewPageView))] can specify this
	/// <summary>
	/// Class NewPageViewModel.
	/// </summary>
	public class NewPageViewModel : GeolocatorViewModel
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="NewPageViewModel"/> class.
		/// </summary>
		public NewPageViewModel ()
		{
			NewPage =@"This page was created by the view factory and binded to the viewmodel and injected a navigation context using the following code:
						ViewFactory.Register<NewPageView,NewPageViewModel> ();
						We can also navigate to this page from any view model using the following code: 
						await Navigation.PushAsync<NewPageViewModel>() ";
		    
            CurrentBingUri = PositionExtensions.ToBingMaps()

		}

		/// <summary>
		/// The _new page
		/// </summary>
		private string _newPage =string.Empty;
		/// <summary>
		/// Gets or sets the new page.
		/// </summary>
		/// <value>The new page.</value>
		public string NewPage
		{
			get
			{
				return _newPage;
			}
			set
						
			{
				this.SetProperty(ref _newPage, value);
			}
		}

		/// <summary>
		/// The _page title
		/// </summary>
		private string _pageTitle ="New Page";
		/// <summary>
		/// Gets or sets the page title.
		/// </summary>
		/// <value>The page title.</value>
		public string PageTitle
		{
			get
			{
				return _pageTitle;
			}
			set
			{
				this.SetProperty(ref _pageTitle, value);
			}
		}

	  
        private ICommand _getGMapsUri;

	    public ICommand GetGMapsUri
	    {
	        get
	        {
	            return _getGMapsUri ?? (_getGMapsUri = new Command(async () =>
	            {
	                PositionExtensions.ToGoogleMaps(new Position()
	                {
	                    Latitude = PositionLatitude;
	                })
	            }))
	        }
	        set;
	    }
	}
}

