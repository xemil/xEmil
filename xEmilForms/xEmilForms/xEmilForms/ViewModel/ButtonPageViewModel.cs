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
    [ViewType(typeof (ButtonPage))]
    public class ButtonPageViewModel : XLabs.Forms.Mvvm.ViewModel
    {
        private ImageButton _facebookImageButton;
        private ObservableCollection<RedditPost> _redditPosts;
        private IRedditService _redditService = Resolver.Resolve<IRedditService>();
        private Image _xEmilImage;

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

        public Image xEmilImage
        {
            get
            {
                return _xEmilImage ?? (_xEmilImage = new Image()
                {
                    Source = "xEmilImage850x718.png",
                    //ImageUrl = "http://i.imgur.com/98skoLT.png"
                });
            }
            set { SetProperty(ref _xEmilImage, value); }
        }

        public ButtonPageViewModel()
        {
            _xEmilImage = new Image()
            {
                Source = "xÉmilButton900x150.png"
            };
        }

        public Command LoadRedditPostsCommand { get; set; }

        private void LoadRedditPosts()
        {
            var collectedRedditPosts = _redditService.Get(RedditPosts.Count, 15);
            foreach (var redditPost in collectedRedditPosts)
            {
                RedditPosts.Add(redditPost);
            }
        }
    }
}