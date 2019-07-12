using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StardewValleyCalendar.Models
{
    public class SVCalendarDay
    {
        public int DayOfMonth { get; set; }
        public SVWikiLink Birthday { get; set; }
        public SVWikiLink Festival { get; set; }
        public List<string> Notes { get; set; }
    }
}
