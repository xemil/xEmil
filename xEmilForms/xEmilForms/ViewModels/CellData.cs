using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using xEmilForms.Helpers;
using Xamarin.Forms;
using XLabs.Ioc;

namespace xEmilForms.ViewModels
{
    public abstract class CellData : BindableBase
    {
        private bool _hasHeartedPost = false;
        private string _likedButtonImageUrl = UrlHelper._blackHeart;

        public CellData()
        {
        }

        public int TypeId { get; set; }

        public string LikedButtonImageUrl
        {
            get { return _likedButtonImageUrl; }
            set
            {
                if (_likedButtonImageUrl == value) return;
                SetProperty(ref _likedButtonImageUrl, value);
            }
        }

        public bool HasHeartedPost
        {
            get { return _hasHeartedPost; }
            set
            {
                if (_hasHeartedPost == value) return;
                SetProperty(ref _hasHeartedPost, value);
            }
        }
    }


    public class ImageCellData : CellData
    {
        public ImageCellData(string id)
        {
            PostId = id;
            TypeId = 0;
        }

        public string PostId { get; set; }

        public string ImageUrl { get; set; }

        public DelegateCommand HeartButtonClickedCommand
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    HasHeartedPost = !HasHeartedPost;
                    LikedButtonImageUrl = HasHeartedPost ? UrlHelper._redHeart : UrlHelper._blackHeart;
                    MessagingCenter.Send<ImageCellData>(this, "HeartAnimation");
                });
            }
        }
    }
}