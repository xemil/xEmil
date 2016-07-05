using Prism.Commands;
using Prism.Mvvm;
using xEmilForms.Helpers;

namespace xEmilForms.ViewModels
{
    public abstract class CellData : BindableBase
    {
        private bool _hasHeartedPost = false;
        private string _likedButtonImageUrl = UrlHelper._blackHeart;
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
        public ImageCellData()
        {
            TypeId = 0;
        }

        public string ImageUrl { get; set; }

        public DelegateCommand HeartButtonClickedCommand
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    HasHeartedPost = !HasHeartedPost;
                    LikedButtonImageUrl = HasHeartedPost ? UrlHelper._redHeart : UrlHelper._blackHeart;
                });
            }
        }
    }
}