using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StardewValleyCalendar.Models
{
    public class SVTimeOfDay
    {
        public string Time { get; set; }
        public List<SVWikiLink> StoresOpeningAtTime { get; set; }
        public List<SVWikiLink> StoresClosingAtTime { get; set; }
    }
}
