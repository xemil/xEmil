
using xEmilForms.ViewModel;

namespace xEmilForms.Pages
{
    public partial class RedditPostPage : ContentPage
    {
        
        public RedditPostPage()
        {
            InitializeComponent();
            BindingContext = new RedditPostViewModel();
        }
    }
}
