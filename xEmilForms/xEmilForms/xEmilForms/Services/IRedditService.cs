using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xEmilForms.Model;

namespace xEmilForms.Services
{
    /// <summary>
    /// Interface IRedditService    
    /// </summary>
    public interface IRedditService
    {
        IEnumerable<RedditPost> Get(int skip, int take);

    }
}
