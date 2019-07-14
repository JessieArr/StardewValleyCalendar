using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StardewValleyCalendar.Models
{
    public class SVCalendarDay
    {
        public int DayOfMonth { get; set; }
        public SVPerson Birthday { get; set; }
        public SVWikiLink Festival { get; set; }
        public SVWikiLink NightMarket { get; set; }
        public List<string> Notes { get; set; } = new List<string>();

        public List<SVCrop> FirstDayToPlant { get; set; } = new List<SVCrop>();
        public List<SVCrop> FirstDayToPlantTen { get; set; } = new List<SVCrop>();
        public List<SVCrop> FirstDayToPlantTwenty { get; set; } = new List<SVCrop>();
        public List<SVCrop> FirstDayToPlantTwentyFive { get; set; } = new List<SVCrop>();
        public List<SVCrop> FirstDayToPlantThirtyFive { get; set; } = new List<SVCrop>();

        public List<SVCrop> LastDayToPlant { get; set; } = new List<SVCrop>();
        public List<SVCrop> LastDayToPlantTen { get; set; } = new List<SVCrop>();
        public List<SVCrop> LastDayToPlantTwenty { get; set; } = new List<SVCrop>();
        public List<SVCrop> LastDayToPlantTwentyFive { get; set; } = new List<SVCrop>();
        public List<SVCrop> LastDayToPlantThirtyFive { get; set; } = new List<SVCrop>();
    }
}
