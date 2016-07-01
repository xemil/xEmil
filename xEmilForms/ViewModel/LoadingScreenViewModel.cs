using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace xEmilForms.ViewModel
{
    class LoadingScreenViewModel : XLabs.Forms.Mvvm.ViewModel
    {

        public LoadingScreenViewModel()
        {
            App.GoToFBPage();
        }
        
        private Boolean _isLoading;

        public Boolean IsLoading
        {

            get { return _isLoading; }
            set { SetProperty(ref _isLoading, value); }
        }


        private StackLayout _baseLayout;

        public StackLayout BaseLayout
        {

            get
            {
                return _baseLayout ?? (_baseLayout = new StackLayout()
                {
                    VerticalOptions = LayoutOptions.CenterAndExpand,
                    HorizontalOptions = LayoutOptions.CenterAndExpand,
                    Opacity = 0.5,
                });
            }
            set { SetProperty(ref _baseLayout, value); }
        }




		

		


		


    }
}
