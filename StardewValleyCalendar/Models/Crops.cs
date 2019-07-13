using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StardewValleyCalendar.Models
{
    public static class Crops
    {
        public static SVCrop BlueJazz = new SVCrop()
        {
            Link = new SVWikiLink("Blue Jazz", "https://stardewvalleywiki.com/Blue_Jazz"),
            Seasons = new List<string>() { SeasonNames.Spring },
            SeedPrice = 30,
            SellPrice = 50,
            DaysToGrow = new CropSpeedGrid(7),
        };
        public static SVCrop Cauliflower = new SVCrop()
        {
            Link = new SVWikiLink("Cauliflower", "https://stardewvalleywiki.com/Cauliflower"),
            Seasons = new List<string>() { SeasonNames.Spring },
            SeedPrice = 80,
            SellPrice = 175,
            DaysToGrow = new CropSpeedGrid(12),
        };
        public static SVCrop CoffeeBean = new SVCrop()
        {
            Link = new SVWikiLink("Coffee Bean", "https://stardewvalleywiki.com/Coffee_Bean"),
            Seasons = new List<string>() { SeasonNames.Spring, SeasonNames.Summer },
            SeedPrice = 2500,
            SellPrice = 15,
            DaysToGrow = new CropSpeedGrid(10),
            MultipleHarvests = true,
            DaysToReGrow = 2,
        };
        public static SVCrop Garlic = new SVCrop()
        {
            Link = new SVWikiLink("Garlic", "https://stardewvalleywiki.com/Garlic"),
            Seasons = new List<string>() { SeasonNames.Spring },
            SeedPrice = 40,
            SellPrice = 60,
            DaysToGrow = new CropSpeedGrid(4),
        };
        public static SVCrop GreenBean = new SVCrop()
        {
            Link = new SVWikiLink("Green Bean", "https://stardewvalleywiki.com/Green_Bean"),
            Seasons = new List<string>() { SeasonNames.Spring },
            SeedPrice = 60,
            SellPrice = 40,
            DaysToGrow = new CropSpeedGrid(10),
            MultipleHarvests = true,
            DaysToReGrow = 3,
        };
        public static SVCrop Kale = new SVCrop()
        {
            Link = new SVWikiLink("Kale", "https://stardewvalleywiki.com/Kale"),
            Seasons = new List<string>() { SeasonNames.Spring },
            SeedPrice = 70,
            SellPrice = 110,
            DaysToGrow = new CropSpeedGrid(6),
        };
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
        public static SVCrop Rhubarb = new SVCrop()
        {
            Link = new SVWikiLink("Rhubarb", "https://stardewvalleywiki.com/Rhubarb"),
            Seasons = new List<string>() { SeasonNames.Spring },
            SeedPrice = 100,
            SellPrice = 220,
            DaysToGrow = new CropSpeedGrid(13),
        };
        public static SVCrop Strawberry = new SVCrop()
        {
            Link = new SVWikiLink("Strawberry", "https://stardewvalleywiki.com/Strawberry"),
            Seasons = new List<string>() { SeasonNames.Spring },
            SeedPrice = 100,
            SellPrice = 120,
            DaysToGrow = new CropSpeedGrid(13),
            MultipleHarvests = true,
            DaysToReGrow = 4,
        };
        public static SVCrop Tulip = new SVCrop()
        {
            Link = new SVWikiLink("Tulip", "https://stardewvalleywiki.com/Tulip"),
            Seasons = new List<string>() { SeasonNames.Spring },
            SeedPrice = 20,
            SellPrice = 30,
            DaysToGrow = new CropSpeedGrid(6),
        };

        public static List<SVCrop> GetSpringCrops()
        {
            return new List<SVCrop>()
            {
                BlueJazz,
                Cauliflower,
                Garlic,
                Kale,
                Parsnip,
                Potato,
                Rhubarb,
                Tulip,
            };
        }
    }
}
