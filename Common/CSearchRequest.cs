using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AASDSearch.Common
{
    public class CSearchRequest: System.ComponentModel.INotifyPropertyChanged
    {
        protected string _searchString;

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public string SearchString 
        {
            get { return _searchString; }

            set
            {
                _searchString = value;
                OnPropertyChanged("SearchString");
            }
        }



        public void OnPropertyChanged(string name)
        {
            System.ComponentModel.PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(name));
        }
    }
}
