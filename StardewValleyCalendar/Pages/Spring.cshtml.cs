using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StardewValleyCalendar.Models;
using StardewValleyCalendar.Services;

namespace StardewValleyCalendar.Pages
{
    public class SpringModel : PageModel
    {
        private CalendarService _CalendarService;

        public List<int> Days;
        public List<SVDayOfWeek> DaysOfTheWeek;
        public List<SVTimeOfDay> TimesOfDay;
        public List<SVCalendarDay> CalendarDays;
        public SVWikiLink TravelingCart;
        public SVBundle SeasonalForagingBundle;
        public SVBundle SeasonalCropsBundle;

        public List<SVCrop> CropsInSeason;
        public List<SeasonReminder> Reminders;

        public string NextSeason = SeasonNames.Summer;

        public SpringModel()
        {
            _CalendarService = new CalendarService();
            TravelingCart = Shops.TravelingCart;
            DaysOfTheWeek = _CalendarService.GetDaysOfWeek();
            TimesOfDay = _CalendarService.GetTimesOfDay();
            CalendarDays = _CalendarService.GetCalendarDaysForSpring();
            CropsInSeason = Crops.GetSpringCrops();
            SeasonalForagingBundle = Bundles.SpringForagingBundle;
            SeasonalCropsBundle = Bundles.SpringCropsBundle;
            Reminders = _CalendarService.GetRemindersForSpring();
        }

        public void OnGet()
        {
            Days = new List<int>();
            for (var i = 1; i < 29; i++)
            {
                Days.Add(i);
            }
        }
    }
}