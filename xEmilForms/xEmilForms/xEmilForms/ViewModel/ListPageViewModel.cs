using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using xEmilForms.Model;
using xEmilForms.Services;

namespace xEmilForms.ViewModel
{
    class ListPageViewModel : XLabs.Forms.Mvvm.ViewModel
    {
        private ObservableCollection<RedditPost> _labelList;

        public ObservableCollection<RedditPost> LabelList
        {
            get { return _labelList ?? (_labelList = new ObservableCollection<Label>()); }
            set { SetProperty(ref _labelList, value); }
        }

        private Command _loadList;

        public Command LoadListCommand
        {
            get { return _loadList ?? (_loadList = new Command(async () => await FillList())); }
        }

        private async Task FillList()
        {
                _labelList = IRedditService
        }
    }
}
