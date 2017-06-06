using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComicBookGallery.Models
{
    public class ComicBook
    {
        public int Id { get; set; }
        public string SeriesTitle { get; set; }
        public int IssueNumber { get; set; }
        public string DescriptionHtml { get; internal set; }
        public Artist[] Artist { get; internal set; }

        public DescriptionHtml  { get; set; }
        public Artist[] Artists { get; set; }
        public bool Favorite { get; set; }

        public string DisplayText
        {
            get
            {
            return SeriestTitle + " #" + IssueNumber;
            }
        }

            // series-title-issuenumber.jpg
            public string CoverImageFileName
            {
                get
                {
                return SeriesTitle.Replace(" ", "-")
                    .ToLower() + "-" + IssueNumber + ".jpg";
                }
        }   
    }
}