using System.Collections.Generic;
using xEmilForms.Model;

namespace xEmilForms.Services
{
    /// <summary>
    ///     Interface IRedditService
    /// </summary>
    public interface IRedditService
    {
        IEnumerable<RedditPost> Get(int skip, int take);
    }
}