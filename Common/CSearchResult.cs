using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AASDSearch.Common
{
    public enum SearchResulttype
    {
        None = 0,
        Web,
        News,
        Video,
        Image,
    }

    public class CSearchResultImage
    {
        public String MediaUrl {get; set;}
        public String ContentType {get; set;}
        public Int32? Width { get; set; }
        public Int32? Height { get; set; }
        public Int64? FileSize { get; set; }
    }

    public class CSearchResult
    {
        public Guid ID { get; set; }
        public String Title { get; set; }
        public SearchResulttype Type { get; set; }
        public String Description { get; set; }
        public String DisplayUrl { get; set; }
        public String Url { get; set; }
        public String Source { get; set; }
        public Int32? RunTime { get; set; }
        public DateTime? Date { get; set; }
        public CSearchResultImage Image { get; set; }
        public CSearchResultImage Thumbnail { get; set; }
     }
}
