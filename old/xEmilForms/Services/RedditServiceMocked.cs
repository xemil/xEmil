using System;
using System.Collections.Generic;
using System.Linq;
using xEmilForms.Model;

namespace xEmilForms.Services
{
    public class RedditServiceMocked : IRedditService
    {
        private static readonly List<RedditPost> _redditPosts = new List<RedditPost>
        {
            new RedditPost
            {
                Header = "Header1",
                Description = "Description1",
                ImageUri = new Uri("http://xamarin.com/content/images/pages/forms/example-app.png")
            },
            new RedditPost
            {
                Header = "Header2",
                Description = "Description2",
                ImageUri = new Uri("http://xamarin.com/content/images/pages/forms/example-app.png")
            },
            new RedditPost
            {
                Header = "Header3",
                Description = "Description3",
                ImageUri = new Uri("http://xamarin.com/content/images/pages/forms/example-app.png")
            },
            new RedditPost
            {
                Header = "Header4",
                Description = "Description4",
                ImageUri = new Uri("http://xamarin.com/content/images/pages/forms/example-app.png")
            },
            new RedditPost
            {
                Header = "Header5",
                Description = "Description5",
                ImageUri = new Uri("http://xamarin.com/content/images/pages/forms/example-app.png")
            },
            new RedditPost
            {
                Header = "Header6",
                Description = "Description6",
                ImageUri = new Uri("http://xamarin.com/content/images/pages/forms/example-app.png")
            },
            new RedditPost
            {
                Description = "DISC INF",
                Header = "HEADER INF",
                ImageUri = new Uri("http://xamarin.com/content/images/pages/forms/example-app.png")
            },
            new RedditPost
            {
                Description = "DISC INF",
                Header = "HEADER INF",
                ImageUri = new Uri("http://xamarin.com/content/images/pages/forms/example-app.png")
            },
            new RedditPost
            {
                Description = "DISC INF",
                Header = "HEADER INF",
                ImageUri = new Uri("http://xamarin.com/content/images/pages/forms/example-app.png")
            },
            new RedditPost
            {
                Description = "DISC INF",
                Header = "HEADER INF",
                ImageUri = new Uri("http://xamarin.com/content/images/pages/forms/example-app.png")
            },
            new RedditPost
            {
                Description = "DISC INF",
                Header = "HEADER INF",
                ImageUri = new Uri("http://xamarin.com/content/images/pages/forms/example-app.png")
            },
            new RedditPost
            {
                Description = "DISC INF",
                Header = "HEADER INF",
                ImageUri = new Uri("http://xamarin.com/content/images/pages/forms/example-app.png")
            },
            new RedditPost
            {
                Description = "DISC INF",
                Header = "HEADER INF",
                ImageUri = new Uri("http://xamarin.com/content/images/pages/forms/example-app.png")
            },
            new RedditPost
            {
                Description = "DISC INF",
                Header = "HEADER INF",
                ImageUri = new Uri("http://xamarin.com/content/images/pages/forms/example-app.png")
            },
            new RedditPost
            {
                Description = "DISC INF",
                Header = "HEADER INF",
                ImageUri = new Uri("http://xamarin.com/content/images/pages/forms/example-app.png")
            },
            new RedditPost
            {
                Description = "DISC INF",
                Header = "HEADER INF",
                ImageUri = new Uri("http://xamarin.com/content/images/pages/forms/example-app.png")
            },
            new RedditPost
            {
                Description = "DISC INF",
                Header = "HEADER INF",
                ImageUri = new Uri("http://xamarin.com/content/images/pages/forms/example-app.png")
            },
            new RedditPost
            {
                Description = "DISC INF",
                Header = "HEADER INF",
                ImageUri = new Uri("http://xamarin.com/content/images/pages/forms/example-app.png")
            },
            new RedditPost
            {
                Description = "DISC INF",
                Header = "HEADER INF",
                ImageUri = new Uri("http://xamarin.com/content/images/pages/forms/example-app.png")
            },
            new RedditPost
            {
                Description = "DISC INF",
                Header = "HEADER INF",
                ImageUri = new Uri("http://xamarin.com/content/images/pages/forms/example-app.png")
            },
            new RedditPost
            {
                Description = "DISC INF",
                Header = "HEADER INF",
                ImageUri = new Uri("http://xamarin.com/content/images/pages/forms/example-app.png")
            },
            new RedditPost
            {
                Description = "DISC INF",
                Header = "HEADER INF",
                ImageUri = new Uri("http://xamarin.com/content/images/pages/forms/example-app.png")
            },
            new RedditPost
            {
                Description = "DISC INF",
                Header = "HEADER INF",
                ImageUri = new Uri("http://xamarin.com/content/images/pages/forms/example-app.png")
            },
        };

        public IEnumerable<RedditPost> Get(int skip, int take)
        {
            return _redditPosts.Skip(skip).Take(take);
        }
    }
}