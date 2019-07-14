using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StardewValleyCalendar.Models
{
    public static class Crops
    {
        public static SVCrop Amaranth = new SVCrop()
        {
            Link = new SVWikiLink("Amaranth", "https://stardewvalleywiki.com/Amaranth"),
            Seasons = new List<string>() { SeasonNames.Fall },
            SeedPrice = 70,
            SellPrice = 150,
            DaysToGrow = new CropSpeedGrid(7),
        };
        public static SVCrop Artichoke = new SVCrop()
        {
            Link = new SVWikiLink("Artichoke", "https://stardewvalleywiki.com/Artichoke"),
            Seasons = new List<string>() { SeasonNames.Fall },
            SeedPrice = 30,
            SellPrice = 160,
            DaysToGrow = new CropSpeedGrid(8),
        };
        public static SVCrop Beet = new SVCrop()
        {
            Link = new SVWikiLink("Beet", "https://stardewvalleywiki.com/Beet"),
            Seasons = new List<string>() { SeasonNames.Fall },
            SeedPrice = 20,
            SellPrice = 100,
            DaysToGrow = new CropSpeedGrid(6),
        };
        public static SVCrop Blueberry = new SVCrop()
        {
            Link = new SVWikiLink("Blueberry", "https://stardewvalleywiki.com/Blueberry"),
            Seasons = new List<string>() { SeasonNames.Summer },
            SeedPrice = 80,
            SellPrice = 50,
            DaysToGrow = new CropSpeedGrid(13),
            MultipleHarvests = true,
            DaysToReGrow = 4,
            NumberPerHarvest = 3,
        };
        public static SVCrop BlueJazz = new SVCrop()
        {
            Link = new SVWikiLink("Blue Jazz", "https://stardewvalleywiki.com/Blue_Jazz"),
            Seasons = new List<string>() { SeasonNames.Spring },
            SeedPrice = 30,
            SellPrice = 50,
            DaysToGrow = new CropSpeedGrid(7),
        };
        public static SVCrop BokChoy = new SVCrop()
        {
            Link = new SVWikiLink("Bok Choy", "https://stardewvalleywiki.com/Bok_Choy"),
            Seasons = new List<string>() { SeasonNames.Fall },
            SeedPrice = 50,
            SellPrice = 80,
            DaysToGrow = new CropSpeedGrid(4),
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
            NumberPerHarvest = 4,
            DaysToGrow = new CropSpeedGrid(10),
            MultipleHarvests = true,
            DaysToReGrow = 2,
        };
        public static SVCrop Corn = new SVCrop()
        {
            Link = new SVWikiLink("Corn", "https://stardewvalleywiki.com/Corn"),
            Seasons = new List<string>() { SeasonNames.Summer, SeasonNames.Fall },
            SeedPrice = 150,
            SellPrice = 50,
            DaysToGrow = new CropSpeedGrid(14),
            MultipleHarvests = true,
            DaysToReGrow = 4,
        };
        public static SVCrop Cranberries = new SVCrop()
        {
            Link = new SVWikiLink("Cranberries", "https://stardewvalleywiki.com/Cranberries"),
            Seasons = new List<string>() { SeasonNames.Fall },
            SeedPrice = 240,
            SellPrice = 75,
            DaysToGrow = new CropSpeedGrid(7),
            MultipleHarvests = true,
            NumberPerHarvest = 2,
            DaysToReGrow = 5,
        };
        public static SVCrop Eggplant = new SVCrop()
        {
            Link = new SVWikiLink("Eggplant", "https://stardewvalleywiki.com/Eggplant"),
            Seasons = new List<string>() { SeasonNames.Fall },
            SeedPrice = 20,
            SellPrice = 60,
            DaysToGrow = new CropSpeedGrid(5),
            MultipleHarvests = true,
            DaysToReGrow = 5,
        };
        public static SVCrop FairyRose = new SVCrop()
        {
            Link = new SVWikiLink("Fairy Rose", "https://stardewvalleywiki.com/Fairy_Rose"),
            Seasons = new List<string>() { SeasonNames.Fall },
            SeedPrice = 200,
            SellPrice = 290,
            DaysToGrow = new CropSpeedGrid(12),
        };
        public static SVCrop Garlic = new SVCrop()
        {
            Link = new SVWikiLink("Garlic", "https://stardewvalleywiki.com/Garlic"),
            Seasons = new List<string>() { SeasonNames.Spring },
            SeedPrice = 40,
            SellPrice = 60,
            DaysToGrow = new CropSpeedGrid(4),
        };
        public static SVCrop Grape = new SVCrop()
        {
            Link = new SVWikiLink("Grape", "https://stardewvalleywiki.com/Grape"),
            Seasons = new List<string>() { SeasonNames.Fall },
            SeedPrice = 60,
            SellPrice = 60,
            DaysToGrow = new CropSpeedGrid(5),
            MultipleHarvests = true,
            DaysToReGrow = 3,
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
        public static SVCrop Hops = new SVCrop()
        {
            Link = new SVWikiLink("Hops", "https://stardewvalleywiki.com/Hops"),
            Seasons = new List<string>() { SeasonNames.Summer },
            SeedPrice = 60,
            SellPrice = 25,
            DaysToGrow = new CropSpeedGrid(11),
            MultipleHarvests = true,
            DaysToReGrow = 1,
        };
        public static SVCrop HotPepper = new SVCrop()
        {
            Link = new SVWikiLink("Hot Pepper", "https://stardewvalleywiki.com/Hot_Pepper"),
            Seasons = new List<string>() { SeasonNames.Summer },
            SeedPrice = 40,
            SellPrice = 40,
            DaysToGrow = new CropSpeedGrid(5),
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
        public static SVCrop Melon = new SVCrop()
        {
            Link = new SVWikiLink("Melon", "https://stardewvalleywiki.com/Melon"),
            Seasons = new List<string>() { SeasonNames.Summer },
            SeedPrice = 80,
            SellPrice = 250,
            DaysToGrow = new CropSpeedGrid(12),
        };
        public static SVCrop Parsnip = new SVCrop()
        {
            Link = new SVWikiLink("Parsnip", "https://stardewvalleywiki.com/Parsnip"),
            Seasons = new List<string>() { SeasonNames.Spring },
            SeedPrice = 20,
            SellPrice = 35,
            DaysToGrow = new CropSpeedGrid(4),
        };
        public static SVCrop Poppy = new SVCrop()
        {
            Link = new SVWikiLink("Poppy", "https://stardewvalleywiki.com/Poppy"),
            Seasons = new List<string>() { SeasonNames.Summer },
            SeedPrice = 100,
            SellPrice = 140,
            DaysToGrow = new CropSpeedGrid(7),
        };
        public static SVCrop Potato = new SVCrop()
        {
            Link = new SVWikiLink("Potato", "https://stardewvalleywiki.com/Potato"),
            Seasons = new List<string>() { SeasonNames.Spring },
            SeedPrice = 50,
            SellPrice = 80,
            DaysToGrow = new CropSpeedGrid(6),
        };
        public static SVCrop Pumpkin = new SVCrop()
        {
            Link = new SVWikiLink("Pumpkin", "https://stardewvalleywiki.com/Pumpkin"),
            Seasons = new List<string>() { SeasonNames.Fall },
            SeedPrice = 100,
            SellPrice = 320,
            DaysToGrow = new CropSpeedGrid(13),
        };
        public static SVCrop Radish = new SVCrop()
        {
            Link = new SVWikiLink("Radish", "https://stardewvalleywiki.com/Radish"),
            Seasons = new List<string>() { SeasonNames.Summer },
            SeedPrice = 40,
            SellPrice = 90,
            DaysToGrow = new CropSpeedGrid(6),
        };
        public static SVCrop RedCabbage = new SVCrop()
        {
            Link = new SVWikiLink("Red Cabbage", "https://stardewvalleywiki.com/Red_Cabbage"),
            Seasons = new List<string>() { SeasonNames.Summer },
            SeedPrice = 100,
            SellPrice = 260,
            DaysToGrow = new CropSpeedGrid(9),
        };
        public static SVCrop Rhubarb = new SVCrop()
        {
            Link = new SVWikiLink("Rhubarb", "https://stardewvalleywiki.com/Rhubarb"),
            Seasons = new List<string>() { SeasonNames.Spring },
            SeedPrice = 100,
            SellPrice = 220,
            DaysToGrow = new CropSpeedGrid(13),
        };
        public static SVCrop Starfruit = new SVCrop()
        {
            Link = new SVWikiLink("Starfruit", "https://stardewvalleywiki.com/Starfruit"),
            Seasons = new List<string>() { SeasonNames.Summer },
            SeedPrice = 400,
            SellPrice = 750,
            DaysToGrow = new CropSpeedGrid(13),
        };
        public static SVCrop Strawberry = new SVCrop()
        {
            Link = new SVWikiLink("Strawberry", "https://stardewvalleywiki.com/Strawberry"),
            Seasons = new List<string>() { SeasonNames.Spring },
            SeedPrice = 100,
            SellPrice = 120,
            DaysToGrow = new CropSpeedGrid(8),
            MultipleHarvests = true,
            DaysToReGrow = 4,
        };
        public static SVCrop SummerSpangle = new SVCrop()
        {
            Link = new SVWikiLink("Summer Spangle", "https://stardewvalleywiki.com/Summer_Spangle"),
            Seasons = new List<string>() { SeasonNames.Summer },
            SeedPrice = 50,
            SellPrice = 90,
            DaysToGrow = new CropSpeedGrid(8),
        };
        public static SVCrop Sunflower = new SVCrop()
        {
            Link = new SVWikiLink("Sunflower", "https://stardewvalleywiki.com/Sunflower"),
            Seasons = new List<string>() { SeasonNames.Summer, SeasonNames.Fall },
            SeedPrice = 200,
            SellPrice = 80,
            DaysToGrow = new CropSpeedGrid(8),
        };
        public static SVCrop SweetGemBerry = new SVCrop()
        {
            Link = new SVWikiLink("Sweet Gem Berry", "https://stardewvalleywiki.com/Sweet_Gem_Berry"),
            Seasons = new List<string>() { SeasonNames.Fall },
            SeedPrice = 1000,
            SellPrice = 3000,
            DaysToGrow = new CropSpeedGrid(24),
        };
        public static SVCrop Tomato = new SVCrop()
        {
            Link = new SVWikiLink("Tomato", "https://stardewvalleywiki.com/Tomato"),
            Seasons = new List<string>() { SeasonNames.Summer },
            SeedPrice = 50,
            SellPrice = 60,
            DaysToGrow = new CropSpeedGrid(11),
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
        public static SVCrop Wheat = new SVCrop()
        {
            Link = new SVWikiLink("Wheat", "https://stardewvalleywiki.com/Wheat"),
            Seasons = new List<string>() { SeasonNames.Summer, SeasonNames.Fall },
            SeedPrice = 10,
            SellPrice = 25,
            DaysToGrow = new CropSpeedGrid(4),
        };
        public static SVCrop Yam = new SVCrop()
        {
            Link = new SVWikiLink("Yam", "https://stardewvalleywiki.com/Yam"),
            Seasons = new List<string>() { SeasonNames.Fall },
            SeedPrice = 60,
            SellPrice = 160,
            DaysToGrow = new CropSpeedGrid(10),
        };

        public static List<SVCrop> GetSpringCrops()
        {
            return new List<SVCrop>()
            {
                BlueJazz,
                Cauliflower,
                CoffeeBean,
                Garlic,
                GreenBean,
                Kale,
                Parsnip,
                Potato,
                Rhubarb,
                Strawberry,
                Tulip,
            };
        }

        public static List<SVCrop> GetSummerCrops()
        {
            return new List<SVCrop>()
            {
                Blueberry,
                CoffeeBean,
                Corn,
                Hops,
                HotPepper,
                Melon,
                Poppy,
                Radish,
                Starfruit,
                SummerSpangle,
                Sunflower,
                Tomato,
                Wheat,
            };
        }

        public static List<SVCrop> GetFallCrops()
        {
            return new List<SVCrop>()
            {
                Amaranth,
                Artichoke,
                Beet,
                BokChoy,
                Corn,
                Cranberries,
                Eggplant,
                FairyRose,
                Grape,
                Pumpkin,
                Sunflower,
                SweetGemBerry,
                Wheat,
                Yam,
            };
        }
    }
}
