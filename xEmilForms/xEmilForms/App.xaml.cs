using Prism.Unity;
using xEmilForms.Views;

namespace xEmilForms
{
    public partial class App : PrismApplication
    {
        protected override void OnInitialized()
        {
            InitializeComponent();
            MainPage = new ScrollPage();
            //NavigationService.Navigate("ScrollPage");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<ScrollPage>();
        }
    }
}
