

namespace xEmilForms.Pages
{
    public partial class ButtonPage : ContentPage
    {
        public ButtonPage()
        {
            InitializeComponent();
            BindingContext = new ButtonPageViewModel();
        }
    }
}
