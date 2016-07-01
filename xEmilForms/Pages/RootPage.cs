using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using xEmilForms.Model;
using xEmilForms.ViewModel;


namespace xEmilForms.Pages
{
    public class RootPage : MasterDetailPage
    {
        private MenuPage menuPage;
        public NavigationPage RootNavigationPage;
        public RootPage()
        {
            menuPage = new MenuPage();
            menuPage.Menu.ItemSelected += (sender, e) => NavigateTo(e.SelectedItem as ListMenuItem);
            RootNavigationPage = new NavigationPage(ViewFactory.CreatePage<FacebookViewModel, Page>() as Page)
            {
                BarBackgroundColor = Color.FromHex("#B455B6"),
            };
            Master = menuPage;
            Detail = RootNavigationPage;
        }

        private void NavigateTo(ListMenuItem menu)
        {
            if (menu == null)
                return;


            //CREATE PAGE
            var type = menu.TargetType;
            Page displayPage = ViewFactory.CreatePage<FacebookViewModel, Page>() as Page;
            RootNavigationPage = new NavigationPage(displayPage);
            Detail = RootNavigationPage;
            menuPage.Menu.SelectedItem = null;
            IsPresented = false;
        }

    }
}
