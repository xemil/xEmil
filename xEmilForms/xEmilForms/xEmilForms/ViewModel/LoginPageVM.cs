using System.Collections.ObjectModel;
using xEmilForms.Model;
using xEmilForms.Services;
using XLabs.Forms.Controls;
using XLabs.Forms.Mvvm;
using XLabs.Ioc;

namespace xEmilForms.ViewModel
{
    [ViewType(typeof (LoadPageViewModel))]
    public class LoadPageViewModel : XLabs.Forms.Mvvm.ViewModel
    {
        private ImageButton _facebookImageButton;

        private ObservableCollection<RedditPost> _redditPosts;
        private IRedditService _redditService = Resolver.Resolve<IRedditService>();

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