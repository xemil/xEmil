using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xEmilForms.Helpers;

namespace xEmilForms.Services
{
    public interface IFacebookService
    {
        Task SetLoggedInFacebookUserTask(FacebookUser fb);
        Task SetProfilePictureTask(FacebookUser fb);

    }
}
