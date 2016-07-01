using System.Collections.Generic;
using Microsoft.Practices.Unity.ObjectBuilder;
using Prism.Mvvm;
using Prism.Navigation;

namespace xEmilForms.ViewModels
{
    public class ScrollPageViewModel : BindableBase, INavigationAware
    {


        private List<CellData> _cellDataList;

        public List<CellData> CellDataList
        {
            get { return _cellDataList ?? (_cellDataList = new List<CellData>()); }
            set { SetProperty(ref _cellDataList, value); }
        }


        public ScrollPageViewModel()
        {
               CellDataList.Add(new CellData());
        }


        public void OnNavigatedFrom(NavigationParameters parameters)
        {
            throw new System.NotImplementedException();
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            throw new System.NotImplementedException();
        }
    }

    public class CellData
    {
    }
}