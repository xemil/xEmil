using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace xEmilForms.Cell
{
    class TestCell : ViewCell
    {
        public TestCell()
        {
            View = new StackLayout()
            {
                Children = {new Label()
                {
                    Text = "Test"
                }
                }
            };

        }
    }
}
