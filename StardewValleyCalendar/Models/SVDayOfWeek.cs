using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StardewValleyCalendar.Models
{
    public class SVDayOfWeek
    {
        public string Name { get; set; }
        public List<SVWikiLink> ClosedStores { get; set; } = new List<SVWikiLink>();
        public List<SVWikiLink> ClosedStoresAfterCommunityCenter { get; set; } = new List<SVWikiLink>();
        public List<SVWikiLink> ClosedStoresOnSunnyDays { get; set; } = new List<SVWikiLink>();
        public bool TravelingCartOpen { get; set; }
        public bool QueenOfSauceNewRecipe { get; set; }
        public bool QueenOfSauceRerun { get; set; }
        public List<Tuple<SVWikiLink, string>> EarlyStoreClosures { get; set; } = new List<Tuple<SVWikiLink, string>>();
    }
}
