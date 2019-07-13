using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StardewValleyCalendar.Models
{
    public static class Crops
    {
        public static SVCrop Parsnip = new SVCrop()
        {
            Link = new SVWikiLink("Parsnip", "https://stardewvalleywiki.com/Parsnip"),
            Seasons = new List<string>() { SeasonNames.Spring },
            SeedPrice = 20,
            SellPrice = 35,
            DaysToGrow = new CropSpeedGrid(4),
        };
        public static SVCrop Potato = new SVCrop()
        {
            Link = new SVWikiLink("Potato", "https://stardewvalleywiki.com/Potato"),
            Seasons = new List<string>() { SeasonNames.Spring },
            SeedPrice = 50,
            SellPrice = 80,
            DaysToGrow = new CropSpeedGrid(6),
        };

        public static List<SVCrop> GetSpringCrops()
        {
            return new List<SVCrop>()
            {
                Parsnip,
                Potato,
            };
        }
    }
}
