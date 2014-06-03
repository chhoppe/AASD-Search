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
        protected string _language;

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public CSearchRequest()
        {
            loadDefaultSetting();  
        }
        #region Properties
        public string SearchString 
        {
            get { return _searchString; }

            set
            {
                _searchString = value;
                OnPropertyChanged("SearchString");
            }
        }
        public string Language
        {
            get { return _language; }

            set
            {
                _language = value;
                OnPropertyChanged("Language");
            }
        }
        #endregion Properties
        #region Private methods
        private void loadDefaultSetting()
        {
            _language = "de-de";
            _searchString = "";
        }
        #endregion Private methods
        public void OnPropertyChanged(string name)
        {
            System.ComponentModel.PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(name));
        }
    }
}
