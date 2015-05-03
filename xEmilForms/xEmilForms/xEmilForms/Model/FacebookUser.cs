using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using xEmilForms.Model;
using xEmilForms.Pages;
using xEmilForms.ViewModel;
using XLabs.Data;
using XLabs.Forms.Controls;
using XLabs.Forms.Services;
using XLabs.Ioc;
using XLabs.Platform.Services;

namespace xEmilForms.Helpers
{
    public class FacebookUser : ObservableObject, ISelectedFacebookUser
    {

        private string _id;
        public string Id
        {
            get { return _id ?? (_id = "notSet"); }
            set { SetProperty(ref _id, value); }
        }

        private string _firstName;
        public string FirstName
        {
            get { return _firstName ?? (_firstName = "notSet"); }
            set { SetProperty(ref _firstName, value); }
        }

        private string _gender;
        public string Gender
        {
            get { return _gender ?? (_gender = "notSet"); }
            set { SetProperty(ref _gender, value); }
        }

        private string _lastName;
        public string LastName
        {
            get { return _lastName ?? (_lastName = "notSet"); }
            set { SetProperty(ref _lastName, value); }
        }

        private Uri _link;
        public Uri Link
        {
            get { return _link; }
            set { SetProperty(ref _link, value); }
        }

        private string _locale;
        public string Locale
        {
            get { return _locale ?? (_locale = "notSet"); }
            set { SetProperty(ref _locale, value); }
        }

        private string _name;
        public string Name
        {
            get { return _name ?? (_name = "notSet"); }
            set { SetProperty(ref _name, value); }
        }

        private Image _profileImage;
        public Image ProfileImage
        {
            get { return _profileImage; }
            set { SetProperty(ref _profileImage, value); }
        }

        private ObservableCollection<FacebookUser> _friendList;
        public ObservableCollection<FacebookUser> FriendList
        {
            get { return _friendList ?? (_friendList = new ObservableCollection<FacebookUser>()); }
            set { SetProperty(ref _friendList, value); }
        }

        private Command<FacebookUser> _clickedCommand;

        public Command<FacebookUser> ClickedCommand
        {

            get
            {
                return _clickedCommand ?? (_clickedCommand = new Command<FacebookUser>(OnImageListClick));
            }
            set { SetProperty(ref _clickedCommand, value); }
        }

        private void OnImageListClick(FacebookUser _commandParameter)
        {
            if( _commandParameter != null)
            {
                Resolver.Resolve<IDependencyContainer>().Register<ISelectedFacebookUser>(resolver => _commandParameter);
            }
            System.Diagnostics.Debug.WriteLine("CommandParameter: " + _commandParameter.LastName);
            //var navigation = Resolver.Resolve<INavigationService>();
            //navigation.NavigateTo<SelectedUserViewModel>();
            App.Current.MainPage = new NavigationPage(new SelectedUserPage());
        }

    }
}
