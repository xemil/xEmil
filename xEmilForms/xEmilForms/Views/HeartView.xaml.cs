using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xEmilForms.ViewModels;
using Xamarin.Forms;

namespace xEmilForms.Views
{
    public partial class HeartView : ContentView
    {
        public HeartView()
        {
            InitializeComponent();
            MessagingCenter.Subscribe<ImageCellData>(this, "HeartAnimation", (data =>
            {
                AnimateHeart(data.PostId);
            }));
        }

        private async void AnimateHeart(string postId)
        {
            if (this.ClassId == postId)
            {
               // Animation a = new Animation();
               // a.Add(0, 1, new Animation(f => this.Opacity = f, 0, 1, Easing.SinInOut, null));
               // a.Commit(
               //     owner: this,
               //     name: "DoubleFader",
               //     length: 400,
               //     finished: (x, y) => {
               //     }
               //);
               await this.FadeTo(1,300, Easing.CubicIn);
               await this.FadeTo(0, 300, Easing.CubicOut);
            }
        }
    }
}
