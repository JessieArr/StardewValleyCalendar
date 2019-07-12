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
        private List<SVCalendarDay> CalendarDays { get; set; }

        public CalendarService()
        {
            DaysOfTheWeek = new List<SVDayOfWeek>();
            TimesOfDay = new List<SVTimeOfDay>();
            CalendarDays = new List<SVCalendarDay>();
            InitializeDaysOfTheWeek();
            InitializeTimesOfDay();
            InitializeCalendarDays();
        }

        public List<SVDayOfWeek> GetDaysOfWeek()
        {
            return DaysOfTheWeek;
        }

        public List<SVTimeOfDay> GetTimesOfDay()
        {
            return TimesOfDay;
        }

        public List<SVCalendarDay> GetCalendarDays()
        {
            return CalendarDays;
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
                    Shops.MarniesRanch
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
                },
            });
        }

        private void InitializeCalendarDays()
        {
            CalendarDays.Add(new SVCalendarDay()
            {
                DayOfMonth = 4,
                Birthday = new SVWikiLink("Kent", "https://stardewvalleywiki.com/Kent"),
                Notes = new List<string>() { },
            });
            CalendarDays.Add(new SVCalendarDay()
            {
                DayOfMonth = 13,
                Festival = new SVWikiLink("Egg Festival", "https://stardewvalleywiki.com/Egg_Festival"),
                Notes = new List<string>() {
                    "Strawberry seeds are only sold at the Egg Festival"
                },
            });
            CalendarDays.Add(new SVCalendarDay()
            {
                DayOfMonth = 24,
                Festival = new SVWikiLink("Flower Dance", "https://stardewvalleywiki.com/Flower_Dance"),
                Notes = new List<string>() { },
            });
            CalendarDays.Add(new SVCalendarDay()
            {
                DayOfMonth = 25,
                Notes = new List<string>()
                {
                    "Pam's doctor appointment - Bus doesn't run"
                }
            });
        }
    }
}
