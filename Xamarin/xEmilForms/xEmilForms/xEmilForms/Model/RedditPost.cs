using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XLabs.Data;

namespace xEmilForms.Model
{
    public class RedditPost : ObservableObject
    {
        private string _header;
        private string _description;
        private Uri _imageUri;

        public string Header
        {
            get { return _header; }
            set { SetProperty(ref _header, value); }
        }

        public string Description
        {
            get { return _description; }
            set { SetProperty(ref _description, value); }
        }

        public Uri ImageUri
        {
            get { return _imageUri; }
            set { SetProperty(ref _imageUri, value); }
        }
    }
}
