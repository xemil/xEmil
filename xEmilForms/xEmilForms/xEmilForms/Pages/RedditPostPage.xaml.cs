
using xEmilForms.ViewModel;

namespace xEmilForms.Pages
{
    public partial class RedditPostPage : XLabs.Forms.Mvvm.BaseView
    {
        
        public RedditPostPage()
        {
            InitializeComponent();
            BindingContext = new RedditPostViewModel();
        }
    }
}
