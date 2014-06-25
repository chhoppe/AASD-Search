using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AASDSearch.Common
{
    /// <summary>
    /// This is a Search Request, all settings, keywords, context and results of one search is handeled by it
    /// </summary>
    public class CSearchRequest: System.ComponentModel.INotifyPropertyChanged
    {
        protected string _searchString;
        protected string _language;
        protected bool _gotError;
        protected string _errorMsg;
        protected Guid _UserID;
        protected SearchResultType _searchtype;
        protected List<CSearchResult> _searchResults;

        /// <summary>
        /// Event to signal a change in one of the properties
        /// </summary>
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// basic constructor
        /// </summary>
        public CSearchRequest()
        {
            loadDefaultSetting();  
        }

        /// <summary>
        /// constructor which sets searchsting and language
        /// </summary>
        /// <param name="searchstring">searchstring containing keywords to search</param>
        /// <param name="language">the language to search in</param>
        public CSearchRequest(string searchstring, string language)
            : this()
        {
            SearchString = searchstring;
            Language = language;
        }

        #region Properties
        /// <summary>
        /// searchstring containing keywords to search for (user input)
        /// </summary>
        public string SearchString 
        {
            get { return _searchString; }

            set
            {
                _searchString = value;
                OnPropertyChanged("SearchString");
            }
        }
        /// <summary>
        /// the language to search in (get from user)
        /// </summary>
        public string Language
        {
            get { return _language; }

            set
            {
                _language = value;
                OnPropertyChanged("Language");
            }
        }
        /// <summary>
        /// the Searchtype of the search (Web, Image, Video)
        /// </summary>
        public SearchResultType Searchtype
        {
            get { return _searchtype; }

            set
            {
                _searchtype = value;
                OnPropertyChanged("Searchtype");
            }
        }
        /// <summary>
        /// errormessage when encountering an error somewhere
        /// </summary>
        public string ErrorMsg
        {
            get { return _errorMsg; }

            set
            {
                _errorMsg = String.Format("{0}{1}{2}", value, Environment.NewLine, _errorMsg);
                OnPropertyChanged("ErrorMsg");
            }
        }
        /// <summary>
        /// Signal that an error occured
        /// </summary>
        public bool GotError
        {
            get { return _gotError; }

            set
            {
                _gotError = value;
                OnPropertyChanged("GotError");
            }
        }
        /// <summary>
        /// User ID of the user doing the search (not yet used)
        /// </summary>
        public Guid UserID
        {
            get { return _UserID; }

            set
            {
                _UserID = value;
                OnPropertyChanged("UserID");
            }
        }
        /// <summary>
        /// List of all Results for the search
        /// </summary>
        public List<CSearchResult> SearchResults
        {
            get { return _searchResults; }
        }
        #endregion Properties
        #region Private methods
        /// <summary>
        /// load default settings, used after initializing
        /// </summary>
        private void loadDefaultSetting()
        {
            _language = "en-us";
            _searchString = "";
            _searchtype = SearchResultType.Web;
            if (_searchResults == null)
                _searchResults = new List<CSearchResult>();
            else
                _searchResults.Clear();
            _errorMsg = "";
            _gotError = false;
        }
        #endregion Private methods
        /// <summary>
        /// Method to fire event if Property changes
        /// </summary>
        /// <param name="name"></param>
        private void OnPropertyChanged(string name)
        {
            System.ComponentModel.PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(name));
        }
    }
}
