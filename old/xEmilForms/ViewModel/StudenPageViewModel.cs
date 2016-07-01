using System.Collections.ObjectModel;
using System.Resources;
using Xamarin.Forms;
using xEmilForms.Model;
using xEmilForms.Pages;
using xEmilForms.Services;
using XLabs.Forms.Controls;
using XLabs.Forms.Mvvm;
using XLabs.Ioc;

namespace xEmilForms.ViewModel
{
    [ViewType(typeof(StudentPage))]
    public class StudentPageViewModel : XLabs.Forms.Mvvm.ViewModel
    {
        private ImageButton _facebookImageButton;
        private ObservableCollection<RedditPost> _redditPosts;
        private IRedditService _redditService = Resolver.Resolve<IRedditService>();
        private Image _FloId650x447;

        public ImageButton FacebookImageButton
        {
            get { return _facebookImageButton ?? (_facebookImageButton = new ImageButton()); }
            set { SetProperty(ref _facebookImageButton, value); }
        }

        public ObservableCollection<RedditPost> RedditPosts
        {
            get { return _redditPosts ?? (_redditPosts = new ObservableCollection<RedditPost>()); }
            set { SetProperty(ref _redditPosts, value); }
        }

        public Image FloId650x447
        {
            get
            {
                return _FloId650x447 ?? (_FloId650x447 = new Image()
                {
                    Source = "FloId650x447.png",
                    //ImageUrl = "LINK TO PIC"
                });
            }
            set { SetProperty(ref _FloId650x447, value); }
        }

        public StudentPageViewModel()
        {
            _FloId650x447 = new Image()
            {
                Source = "FloId650x447.png"
            };
        }

        //public Command LoadRedditPostsCommand { get; set; }

        //private void LoadRedditPosts()
        //{
        //    var collectedRedditPosts = _redditService.Get(RedditPosts.Count, 15);
        //    foreach (var redditPost in collectedRedditPosts)
        //    {
        //        RedditPosts.Add(redditPost);
        //    }
        //}
    }
}