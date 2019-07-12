using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StardewValleyCalendar.Models
{
    public class SVWikiLink
    {
        public string Text { get; set; }
        public string URL { get; set; }

        public SVWikiLink(string text, string url)
        {
            Text = text;
            URL = url;
        }
    }
}
