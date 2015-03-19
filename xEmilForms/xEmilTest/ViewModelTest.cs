using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using xEmilForms.ViewModel; 
namespace xEmilTest
{
    [TestClass]
    public class ViewModelTest
    {
        [TestMethod]
        public void ViewModelNullTest1(ButtonPageViewModel vm)
        {
            if (vm == null || vm.RedditPosts.Count <= 0)
            {
                new AssertFailedException("Button VM = 0 || Reddistpostcount <= 0");
            }
            
        }
    }
}
