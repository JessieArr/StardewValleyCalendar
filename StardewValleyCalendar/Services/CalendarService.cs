using StardewValleyCalendar.Models;
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

        public CalendarService()
        {
            DaysOfTheWeek = new List<SVDayOfWeek>();
            TimesOfDay = new List<SVTimeOfDay>();
            CalendarDaysForSpring = new List<SVCalendarDay>();
            CalendarDaysForSummer = new List<SVCalendarDay>();
            CalendarDaysForFall = new List<SVCalendarDay>();
            CalendarDaysForWinter = new List<SVCalendarDay>();
            InitializeDaysOfTheWeek();
            InitializeTimesOfDay();
            InitializeCalendarDaysForSpring();
            InitializeCalendarDaysForSummer();
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

        private void InitializeDaysOfTheWeek()
        {
            DaysOfTheWeek.Add(new SVDayOfWeek()
            {
                Name = "Monday",
                ClosedStores = new List<SVWikiLink>()
                {
                    Shops.MarniesRanch,
                },
                ClosedStoresOnSunnyDays = new List<SVWikiLink>(),
                EarlyStoreClosures = new List<Tuple<SVWikiLink, string>>() { },
            });
            DaysOfTheWeek.Add(new SVDayOfWeek()
            {
                Name = "Tuesday",
                ClosedStores = new List<SVWikiLink>()
                {
                    Shops.CarpenterShop,
                    Shops.MarniesRanch,
                },
                ClosedStoresOnSunnyDays = new List<SVWikiLink>(),
                EarlyStoreClosures = new List<Tuple<SVWikiLink, string>>() { },
            });
            DaysOfTheWeek.Add(new SVDayOfWeek()
            {
                Name = "Wednesday",
                ClosedStores = new List<SVWikiLink>()
                {
                    Shops.GeneralStore
                },
                ClosedStoresOnSunnyDays = new List<SVWikiLink>(),
                EarlyStoreClosures = new List<Tuple<SVWikiLink, string>>() { },
            });
            DaysOfTheWeek.Add(new SVDayOfWeek()
            {
                Name = "Thursday",
                ClosedStores = new List<SVWikiLink>(),
                ClosedStoresOnSunnyDays = new List<SVWikiLink>(),
                EarlyStoreClosures = new List<Tuple<SVWikiLink, string>>() { },
            });
            DaysOfTheWeek.Add(new SVDayOfWeek()
            {
                Name = "Friday",
                ClosedStores = new List<SVWikiLink>(),
                ClosedStoresOnSunnyDays = new List<SVWikiLink>(),
                EarlyStoreClosures = new List<Tuple<SVWikiLink, string>>()
                {
                    new Tuple<SVWikiLink, string>(Shops.CarpenterShop, "4:00pm")
                },
                TravelingCartOpen = true,
            });
            DaysOfTheWeek.Add(new SVDayOfWeek()
            {
                Name = "Saturday",
                ClosedStores = new List<SVWikiLink>(),
                ClosedStoresOnSunnyDays = new List<SVWikiLink>()
                {
                    Shops.FishShop
                },
                EarlyStoreClosures = new List<Tuple<SVWikiLink, string>>() { },
            });
            DaysOfTheWeek.Add(new SVDayOfWeek()
            {
                Name = "Sunday",
                ClosedStores = new List<SVWikiLink>(),
                ClosedStoresOnSunnyDays = new List<SVWikiLink>(),
                EarlyStoreClosures = new List<Tuple<SVWikiLink, string>>() { },
                TravelingCartOpen = true,
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
    }
}
