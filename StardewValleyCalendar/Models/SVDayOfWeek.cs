using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StardewValleyCalendar.Models
{
    public class SVDayOfWeek
    {
        public string Name { get; set; }
        public List<SVWikiLink> ClosedStores { get; set; }
        public List<SVWikiLink> ClosedStoresOnSunnyDays { get; set; }
        public bool TravelingCartOpen { get; set; }
        public List<Tuple<SVWikiLink, string>> EarlyStoreClosures { get; set; }
    }
}
