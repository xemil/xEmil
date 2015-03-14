using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using xEmilForms.Model;
using xEmilForms.Pages;
using xEmilForms.Services;
using XLabs.Forms.Mvvm;
using XLabs.Ioc;

namespace xEmilForms.ViewModel
{

    [ViewType(typeof(RedditPostPage))]
    public class RedditPostViewModel : XLabs.Forms.Mvvm.ViewModel
    {
      
        private IRedditService _redditService = Resolver.Resolve<IRedditService>();

        public string TheTitle = "THE TITLE";
        
        private RedditPost _selectedRedditPost;
        public RedditPost SelectedRedditPost
        {
            get { return _selectedRedditPost; }
            set { this.SetProperty(ref _selectedRedditPost, value); }
        }
       
        private ObservableCollection<RedditPost> _redditPosts;
        public ObservableCollection<RedditPost> RedditPosts
        {
            get { return _redditPosts ?? (_redditPosts = new ObservableCollection<RedditPost>()); }
            set { SetProperty(ref _redditPosts, value); }
        }

        public RedditPostViewModel()
        {
            LoadRedditPostsCommand = new Command(LoadRedditPosts);
            LoadRedditPosts();
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
