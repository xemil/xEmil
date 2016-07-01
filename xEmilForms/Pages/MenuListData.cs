using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xEmilForms.Model;


namespace xEmilForms.Pages
{
    using System;
    using Xamarin.Forms;
    using System.Collections.Generic;


        public class MenuListData : List<ListMenuItem>
        {
            public MenuListData()
            {
                this.Add(new ListMenuItem()
                {
                    Title = "Pear",
                    IconSource = "pear.png",
                    TargetType = 1

                });

                this.Add(new ListMenuItem()
                {
                    Title = "Banana",
                    IconSource = "banana.png",
                    TargetType = 2
                });

                this.Add(new ListMenuItem()
                {
                    Title = "Mellon",
                    IconSource = "mellon.png",
                    TargetType = 3
                });

                this.Add(new ListMenuItem()
                {
                    Title = "Drink",
                    IconSource = "glass.png",
                    TargetType = 4
                });
            }
        }
    
}
