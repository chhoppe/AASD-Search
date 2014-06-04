﻿using System;
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
        protected bool _gotError;
        protected string _errorMsg;
        protected Guid _UserID;
        protected List<CSearchResult> _searchResults;


        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public CSearchRequest()
        {
            loadDefaultSetting();  
        }

        public CSearchRequest(string searchstring, string language)
        {
            SearchString = searchstring;
            Language = language;
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
        public string ErrorMsg
        {
            get { return _errorMsg; }

            set
            {
                _errorMsg = String.Format("{0}{1}{2}", value, Environment.NewLine, _errorMsg);
                OnPropertyChanged("ErrorMsg");
            }
        }
        public bool GotError
        {
            get { return _gotError; }

            set
            {
                _gotError = value;
                OnPropertyChanged("GotError");
            }
        }
        public Guid UserID
        {
            get { return _UserID; }

            set
            {
                _UserID = value;
                OnPropertyChanged("UserID");
            }
        }
        public List<CSearchResult> SearchResults
        {
            get { return _searchResults; }
        }
        #endregion Properties
        #region Private methods
        private void loadDefaultSetting()
        {
            _language = "en-us";
            _searchString = "";
            if (_searchResults == null)
                _searchResults = new List<CSearchResult>();
            else
                _searchResults.Clear();
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
