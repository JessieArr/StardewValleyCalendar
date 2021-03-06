﻿using StardewValleyCalendar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StardewValleyCalendar.Services
{
    public class CalendarService
    {
        private List<SVDayOfWeek> DaysOfTheWeek { get; set; }
        private List<SVTimeOfDay> TimesOfDay { get; set; }
        private List<SVCalendarDay> CalendarDaysForSpring { get; set; }
        private List<SVCalendarDay> CalendarDaysForSummer{ get; set; }
        private List<SVCalendarDay> CalendarDaysForFall { get; set; }
        private List<SVCalendarDay> CalendarDaysForWinter { get; set; }
        private List<SeasonReminder> SpringReminders { get; set; }
        private List<SeasonReminder> SummerReminders { get; set; }
        private List<SeasonReminder> FallReminders { get; set; }
        private List<SeasonReminder> WinterReminders { get; set; }

        public CalendarService()
        {
            DaysOfTheWeek = new List<SVDayOfWeek>();
            TimesOfDay = new List<SVTimeOfDay>();
            CalendarDaysForSpring = new List<SVCalendarDay>();
            CalendarDaysForSummer = new List<SVCalendarDay>();
            CalendarDaysForFall = new List<SVCalendarDay>();
            CalendarDaysForWinter = new List<SVCalendarDay>();

            SpringReminders = new List<SeasonReminder>();
            SummerReminders = new List<SeasonReminder>();
            FallReminders = new List<SeasonReminder>();
            WinterReminders = new List<SeasonReminder>();

            InitializeDaysOfTheWeek();
            InitializeTimesOfDay();

            InitializeCalendarDaysForSpring();
            InitializeCalendarDaysForSummer();
            InitializeCalendarDaysForFall();
            InitializeCalendarDaysForWinter();

            InitializeRemindersForSpring();
            InitializeRemindersForSummer();
            InitializeRemindersForFall();
            InitializeRemindersForWinter();
        }

        public List<SVDayOfWeek> GetDaysOfWeek()
        {
            return DaysOfTheWeek;
        }

        public List<SVTimeOfDay> GetTimesOfDay()
        {
            return TimesOfDay;
        }

        public List<SVCalendarDay> GetCalendarDaysForSpring()
        {
            return CalendarDaysForSpring;
        }

        public List<SVCalendarDay> GetCalendarDaysForSummer()
        {
            return CalendarDaysForSummer;
        }

        public List<SVCalendarDay> GetCalendarDaysForFall()
        {
            return CalendarDaysForFall;
        }

        public List<SVCalendarDay> GetCalendarDaysForWinter()
        {
            return CalendarDaysForWinter;
        }

        public List<SeasonReminder> GetRemindersForSpring()
        {
            return SpringReminders;
        }

        public List<SeasonReminder> GetRemindersForSummer()
        {
            return SummerReminders;
        }

        public List<SeasonReminder> GetRemindersForFall()
        {
            return FallReminders;
        }

        public List<SeasonReminder> GetRemindersForWinter()
        {
            return WinterReminders;
        }

        private void InitializeDaysOfTheWeek()
        {
            DaysOfTheWeek.Add(new SVDayOfWeek()
            {
                Name = "Monday",
                ClosedStores = new List<SVWikiLink>()
                {
                    Shops.MarniesRanch,
                },
            });
            DaysOfTheWeek.Add(new SVDayOfWeek()
            {
                Name = "Tuesday",
                ClosedStores = new List<SVWikiLink>()
                {
                    Shops.CarpenterShop,
                    Shops.MarniesRanch,
                },
            });
            DaysOfTheWeek.Add(new SVDayOfWeek()
            {
                Name = "Wednesday",
                ClosedStores = new List<SVWikiLink>()
                {
                    Shops.GeneralStore
                },
                QueenOfSauceRerun = true,
            });
            DaysOfTheWeek.Add(new SVDayOfWeek()
            {
                Name = "Thursday",
            });
            DaysOfTheWeek.Add(new SVDayOfWeek()
            {
                Name = "Friday",
                ClosedStoresAfterCommunityCenter = new List<SVWikiLink>()
                {
                    Shops.CarpenterShop
                },
                EarlyStoreClosures = new List<Tuple<SVWikiLink, string>>()
                {
                    new Tuple<SVWikiLink, string>(Shops.Blacksmith, "4:00pm")
                },
                TravelingCartOpen = true,
            });
            DaysOfTheWeek.Add(new SVDayOfWeek()
            {
                Name = "Saturday",
                ClosedStoresOnSunnyDays = new List<SVWikiLink>()
                {
                    Shops.FishShop
                },
            });
            DaysOfTheWeek.Add(new SVDayOfWeek()
            {
                Name = "Sunday",
                TravelingCartOpen = true,
                QueenOfSauceNewRecipe = true,
            });
        }

        private void InitializeTimesOfDay()
        {
            TimesOfDay.Add(new SVTimeOfDay()
            {
                Time = "6am",
                StoresOpeningAtTime = new List<SVWikiLink>()
                {
                    Shops.TravelingCart,
                    Shops.WizardsTower,
                },
                StoresClosingAtTime = new List<SVWikiLink>(),
            });
            TimesOfDay.Add(new SVTimeOfDay()
            {
                Time = "8am",
                StoresOpeningAtTime = new List<SVWikiLink>()
                {
                    Shops.Museum,
                },
                StoresClosingAtTime = new List<SVWikiLink>(),
            });
            TimesOfDay.Add(new SVTimeOfDay()
            {
                Time = "9am",
                StoresOpeningAtTime = new List<SVWikiLink>()
                {
                    Shops.Blacksmith,
                    Shops.CarpenterShop,
                    Shops.GeneralStore,
                    Shops.FishShop,
                    Shops.JojaMart,
                    Shops.MarniesRanch,
                    Shops.Oasis,
                },
                StoresClosingAtTime = new List<SVWikiLink>(),
            });
            TimesOfDay.Add(new SVTimeOfDay()
            {
                Time = "12pm",
                StoresOpeningAtTime = new List<SVWikiLink>()
                {
                    Shops.Saloon,
                },
                StoresClosingAtTime = new List<SVWikiLink>(),
            });
            TimesOfDay.Add(new SVTimeOfDay()
            {
                Time = "2pm",
                StoresOpeningAtTime = new List<SVWikiLink>() {
                    Shops.AdventurersGuild,
                },
                StoresClosingAtTime = new List<SVWikiLink>() { },
            });
            TimesOfDay.Add(new SVTimeOfDay()
            {
                Time = "3pm",
                StoresOpeningAtTime = new List<SVWikiLink>() { },
                StoresClosingAtTime = new List<SVWikiLink>()
                {
                    Shops.Clinic,
                },
            });
            TimesOfDay.Add(new SVTimeOfDay()
            {
                Time = "4pm",
                StoresOpeningAtTime = new List<SVWikiLink>() { },
                StoresClosingAtTime = new List<SVWikiLink>()
                {
                    Shops.Blacksmith,
                    Shops.MarniesRanch,
                },
            });
            TimesOfDay.Add(new SVTimeOfDay()
            {
                Time = "5pm",
                StoresOpeningAtTime = new List<SVWikiLink>() { },
                StoresClosingAtTime = new List<SVWikiLink>()
                {
                    Shops.BusStop,
                    Shops.CarpenterShop,
                    Shops.FishShop,
                    Shops.GeneralStore,
                },
            });
            TimesOfDay.Add(new SVTimeOfDay()
            {
                Time = "6pm",
                StoresOpeningAtTime = new List<SVWikiLink>() { },
                StoresClosingAtTime = new List<SVWikiLink>()
                {
                    Shops.Museum,
                },
            });
            TimesOfDay.Add(new SVTimeOfDay()
            {
                Time = "8pm",
                StoresOpeningAtTime = new List<SVWikiLink>() { },
                StoresClosingAtTime = new List<SVWikiLink>()
                {
                    Shops.TravelingCart,
                },
            });
            TimesOfDay.Add(new SVTimeOfDay()
            {
                Time = "10pm",
                StoresOpeningAtTime = new List<SVWikiLink>() { },
                StoresClosingAtTime = new List<SVWikiLink>()
                {
                    Shops.AdventurersGuild,
                },
            });
            TimesOfDay.Add(new SVTimeOfDay()
            {
                Time = "11pm",
                StoresOpeningAtTime = new List<SVWikiLink>() { },
                StoresClosingAtTime = new List<SVWikiLink>()
                {
                    Shops.JojaMart,
                    Shops.WizardsTower,
                },
            });
            TimesOfDay.Add(new SVTimeOfDay()
            {
                Time = "12am",
                StoresOpeningAtTime = new List<SVWikiLink>() { },
                StoresClosingAtTime = new List<SVWikiLink>()
                {
                    Shops.Saloon,
                    Shops.Oasis
                },
            });
        }

        private void InitializeCalendarDaysForSpring()
        {
            var days = new Dictionary<int, SVCalendarDay>();
            for(var i = 1; i < 29; i++)
            {
                days.Add(i, new SVCalendarDay()
                {
                    DayOfMonth = i,
                });
            }

            days[4].Birthday = People.Kent;
            days[7].Birthday = People.Lewis;
            days[10].Birthday = People.Vincent;
            days[14].Birthday = People.Haley;
            days[18].Birthday = People.Pam;
            days[20].Birthday = People.Shane;
            days[26].Birthday = People.Pierre;
            days[27].Birthday = People.Emily;

            days[13].Festival = new SVWikiLink("Egg Festival", "https://stardewvalleywiki.com/Egg_Festival");
            days[24].Festival = new SVWikiLink("Flower Dance", "https://stardewvalleywiki.com/Flower_Dance");

            days[13].Notes.Add("Strawberry seeds are only sold at the Egg Festival");
            days[15].Notes.Add("Salmonberry season");
            days[16].Notes.Add("Salmonberry season");
            days[17].Notes.Add("Salmonberry season");
            days[18].Notes.Add("Salmonberry season");
            days[25].Notes.Add("Pam's doctor appointment - Bus doesn't run");

            var crops = Crops.GetSpringCrops();

            foreach(var crop in crops)
            {
                days[(int)crop.CalculatedValues.FirstDayToPlant.Normal].FirstDayToPlant.Add(crop);
                days[(int)crop.CalculatedValues.FirstDayToPlant.SpeedGroOrAgriculturalist].FirstDayToPlantTen.Add(crop);
                days[(int)crop.CalculatedValues.FirstDayToPlant.SpeedGroAndAgriculturalist].FirstDayToPlantTwenty.Add(crop);
                days[(int)crop.CalculatedValues.FirstDayToPlant.Deluxe].FirstDayToPlantTwentyFive.Add(crop);
                days[(int)crop.CalculatedValues.FirstDayToPlant.DeluxeAndAgriculturalist].FirstDayToPlantThirtyFive.Add(crop);

                days[(int)crop.CalculatedValues.LastDayToPlant.Normal].LastDayToPlant.Add(crop);
                days[(int)crop.CalculatedValues.LastDayToPlant.SpeedGroOrAgriculturalist].LastDayToPlantTen.Add(crop);
                days[(int)crop.CalculatedValues.LastDayToPlant.SpeedGroAndAgriculturalist].LastDayToPlantTwenty.Add(crop);
                days[(int)crop.CalculatedValues.LastDayToPlant.Deluxe].LastDayToPlantTwentyFive.Add(crop);
                days[(int)crop.CalculatedValues.LastDayToPlant.DeluxeAndAgriculturalist].LastDayToPlantThirtyFive.Add(crop);

            }

            CalendarDaysForSpring = days.Select(x => x.Value).ToList();
        }

        private void InitializeCalendarDaysForSummer()
        {
            var days = new Dictionary<int, SVCalendarDay>();
            for (var i = 1; i < 29; i++)
            {
                days.Add(i, new SVCalendarDay()
                {
                    DayOfMonth = i,
                });
            }

            days[4].Birthday = People.Jas;
            days[8].Birthday = People.Gus;
            days[10].Birthday = People.Maru;
            days[13].Birthday = People.Alex;
            days[17].Birthday = People.Sam;
            days[19].Birthday = People.Demetrius;
            days[22].Birthday = People.Dwarf;
            days[24].Birthday = People.Willy;

            days[11].Festival = new SVWikiLink("Luau", "https://stardewvalleywiki.com/Luau");
            days[28].Festival = new SVWikiLink("Dance of the Moonlight Jellies", "https://stardewvalleywiki.com/Dance_of_the_Moonlight_Jellies");

            days[12].Notes.Add("Extra forageables at the beach");
            days[13].Notes.Add("Extra forageables at the beach");
            days[14].Notes.Add("Extra forageables at the beach");
            days[18].Notes.Add("Robin's doctor appointment - Carpenter Shop Closed");

            var crops = Crops.GetSummerCrops();

            foreach (var crop in crops)
            {
                days[(int)crop.CalculatedValues.FirstDayToPlant.Normal].FirstDayToPlant.Add(crop);
                days[(int)crop.CalculatedValues.FirstDayToPlant.SpeedGroOrAgriculturalist].FirstDayToPlantTen.Add(crop);
                days[(int)crop.CalculatedValues.FirstDayToPlant.SpeedGroAndAgriculturalist].FirstDayToPlantTwenty.Add(crop);
                days[(int)crop.CalculatedValues.FirstDayToPlant.Deluxe].FirstDayToPlantTwentyFive.Add(crop);
                days[(int)crop.CalculatedValues.FirstDayToPlant.DeluxeAndAgriculturalist].FirstDayToPlantThirtyFive.Add(crop);

                days[(int)crop.CalculatedValues.LastDayToPlant.Normal].LastDayToPlant.Add(crop);
                days[(int)crop.CalculatedValues.LastDayToPlant.SpeedGroOrAgriculturalist].LastDayToPlantTen.Add(crop);
                days[(int)crop.CalculatedValues.LastDayToPlant.SpeedGroAndAgriculturalist].LastDayToPlantTwenty.Add(crop);
                days[(int)crop.CalculatedValues.LastDayToPlant.Deluxe].LastDayToPlantTwentyFive.Add(crop);
                days[(int)crop.CalculatedValues.LastDayToPlant.DeluxeAndAgriculturalist].LastDayToPlantThirtyFive.Add(crop);

            }

            CalendarDaysForSummer = days.Select(x => x.Value).ToList();
        }

        private void InitializeCalendarDaysForFall()
        {
            var days = new Dictionary<int, SVCalendarDay>();
            for (var i = 1; i < 29; i++)
            {
                days.Add(i, new SVCalendarDay()
                {
                    DayOfMonth = i,
                });
            }

            days[2].Birthday = People.Penny;
            days[5].Birthday = People.Elliott;
            days[11].Birthday = People.Jodi;
            days[13].Birthday = People.Abigail;
            days[15].Birthday = People.Sandy;
            days[18].Birthday = People.Marnie;
            days[21].Birthday = People.Robin;
            days[24].Birthday = People.George;

            days[16].Festival = new SVWikiLink("Stardew Valley Fair", "https://stardewvalleywiki.com/Stardew_Valley_Fair");
            days[27].Festival = new SVWikiLink("Spirit's Eve", "https://stardewvalleywiki.com/Spirit%27s_Eve");

            days[8].Notes.Add("Blackberry Season");
            days[9].Notes.Add("Blackberry Season");
            days[10].Notes.Add("Blackberry Season");
            days[11].Notes.Add("Blackberry Season");
            days[16].Notes.Add("Blacksmith closes at 10:30am");
            days[28].Notes.Add("Reminder: Krobus' birthday is on Winter 1st");

            var crops = Crops.GetFallCrops();

            foreach (var crop in crops)
            {
                days[(int)crop.CalculatedValues.FirstDayToPlant.Normal].FirstDayToPlant.Add(crop);
                days[(int)crop.CalculatedValues.FirstDayToPlant.SpeedGroOrAgriculturalist].FirstDayToPlantTen.Add(crop);
                days[(int)crop.CalculatedValues.FirstDayToPlant.SpeedGroAndAgriculturalist].FirstDayToPlantTwenty.Add(crop);
                days[(int)crop.CalculatedValues.FirstDayToPlant.Deluxe].FirstDayToPlantTwentyFive.Add(crop);
                days[(int)crop.CalculatedValues.FirstDayToPlant.DeluxeAndAgriculturalist].FirstDayToPlantThirtyFive.Add(crop);

                days[(int)crop.CalculatedValues.LastDayToPlant.Normal].LastDayToPlant.Add(crop);
                days[(int)crop.CalculatedValues.LastDayToPlant.SpeedGroOrAgriculturalist].LastDayToPlantTen.Add(crop);
                days[(int)crop.CalculatedValues.LastDayToPlant.SpeedGroAndAgriculturalist].LastDayToPlantTwenty.Add(crop);
                days[(int)crop.CalculatedValues.LastDayToPlant.Deluxe].LastDayToPlantTwentyFive.Add(crop);
                days[(int)crop.CalculatedValues.LastDayToPlant.DeluxeAndAgriculturalist].LastDayToPlantThirtyFive.Add(crop);
            }

            CalendarDaysForFall = days.Select(x => x.Value).ToList();
        }

        private void InitializeCalendarDaysForWinter()
        {
            var days = new Dictionary<int, SVCalendarDay>();
            for (var i = 1; i < 29; i++)
            {
                days.Add(i, new SVCalendarDay()
                {
                    DayOfMonth = i,
                });
            }

            days[1].Birthday = People.Krobus;
            days[3].Birthday = People.Linus;
            days[7].Birthday = People.Caroline;
            days[10].Birthday = People.Sebastian;
            days[14].Birthday = People.Harvey;
            days[17].Birthday = People.Wizard;
            days[20].Birthday = People.Evelyn;
            days[23].Birthday = People.Leah;
            days[26].Birthday = People.Clint;

            days[8].Festival = new SVWikiLink("Festival of Ice", "https://stardewvalleywiki.com/Festival_of_Ice");
            days[15].NightMarket = new SVWikiLink("Night Market", "https://stardewvalleywiki.com/Night_Market");
            days[16].NightMarket = new SVWikiLink("Night Market", "https://stardewvalleywiki.com/Night_Market");
            days[17].NightMarket = new SVWikiLink("Night Market", "https://stardewvalleywiki.com/Night_Market");
            days[25].Festival = new SVWikiLink("Feast of the Winter Star", "https://stardewvalleywiki.com/Feast_of_the_Winter_Star");

            days[15].Notes.Add("Submarine Ride has unique fish");
            days[16].Notes.Add("Submarine Ride has unique fish");
            days[17].Notes.Add("Submarine Ride has unique fish");

            CalendarDaysForWinter = days.Select(x => x.Value).ToList();
        }

        private void InitializeRemindersForSpring()
        {
            SpringReminders.Add(new SeasonReminder()
            {
                ItemDescription = "Morel",
                Bundle = Bundles.ExoticForagingBundle
            });
            SpringReminders.Add(new SeasonReminder()
            {
                ItemDescription = "5x Gold Quality Parsnip",
                Bundle = Bundles.QualityCropsBundle
            });
            SpringReminders.Add(new SeasonReminder()
            {
                ItemDescription = "Catfish",
                Bundle = Bundles.RiverFishBundle
            });
            SpringReminders.Add(new SeasonReminder()
            {
                ItemDescription = "Sardine",
                Bundle = Bundles.OceanFishBundle
            });
            SpringReminders.Add(new SeasonReminder()
            {
                ItemDescription = "Eel",
                Bundle = Bundles.NightFishingBundle
            });
        }

        private void InitializeRemindersForSummer()
        {
            SummerReminders.Add(new SeasonReminder()
            {
                ItemDescription = "Sunfish",
                Bundle = Bundles.RiverFishBundle
            });
            SummerReminders.Add(new SeasonReminder()
            {
                ItemDescription = "Sturgeon",
                Bundle = Bundles.LakeFishBundle
            });
            SummerReminders.Add(new SeasonReminder()
            {
                ItemDescription = "Tuna",
                Bundle = Bundles.OceanFishBundle
            });
            SummerReminders.Add(new SeasonReminder()
            {
                ItemDescription = "Pufferfish",
                Bundle = Bundles.SpecialtyFishBundle
            });
            SummerReminders.Add(new SeasonReminder()
            {
                ItemDescription = "Poppy",
                Bundle = Bundles.ChefsBundle
            });
            SummerReminders.Add(new SeasonReminder()
            {
                ItemDescription = "Fiddlehead Fern",
                Bundle = Bundles.ChefsBundle
            });
            SummerReminders.Add(new SeasonReminder()
            {
                ItemDescription = "Red Cabbage",
                Bundle = Bundles.DyeBundle
            });
            SummerReminders.Add(new SeasonReminder()
            {
                ItemDescription = "Apple x3",
                Bundle = Bundles.FodderBundle
            });
            SummerReminders.Add(new SeasonReminder()
            {
                ItemDescription = "Pomegranate",
                Bundle = Bundles.EnchantersBundle
            });
        }

        private void InitializeRemindersForFall()
        {
            FallReminders.Add(new SeasonReminder()
            {
                ItemDescription = "Catfish",
                Bundle = Bundles.RiverFishBundle
            });
            FallReminders.Add(new SeasonReminder()
            {
                ItemDescription = "Shad",
                Bundle = Bundles.RiverFishBundle
            });
            FallReminders.Add(new SeasonReminder()
            {
                ItemDescription = "Red Snapper",
                Bundle = Bundles.OceanFishBundle
            });
            FallReminders.Add(new SeasonReminder()
            {
                ItemDescription = "Tilapia",
                Bundle = Bundles.OceanFishBundle
            });
            FallReminders.Add(new SeasonReminder()
            {
                ItemDescription = "Walleye",
                Bundle = Bundles.NightFishingBundle
            });
            FallReminders.Add(new SeasonReminder()
            {
                ItemDescription = "Eel",
                Bundle = Bundles.NightFishingBundle
            });
            FallReminders.Add(new SeasonReminder()
            {
                ItemDescription = "Sunflower",
                Bundle = Bundles.DyeBundle
            });
            FallReminders.Add(new SeasonReminder()
            {
                ItemDescription = "Wheat x 10",
                Bundle = Bundles.FodderBundle
            });
        }

        private void InitializeRemindersForWinter()
        {
            WinterReminders.Add(new SeasonReminder()
            {
                ItemDescription = "Tiger Trout",
                Bundle = Bundles.RiverFishBundle
            });
            WinterReminders.Add(new SeasonReminder()
            {
                ItemDescription = "Sturgeon",
                Bundle = Bundles.LakeFishBundle
            });
            WinterReminders.Add(new SeasonReminder()
            {
                ItemDescription = "Tuna",
                Bundle = Bundles.OceanFishBundle
            });
            WinterReminders.Add(new SeasonReminder()
            {
                ItemDescription = "Nautilus Shell",
                Bundle = Bundles.FieldResearchBundle
            });
        }
    }
}
