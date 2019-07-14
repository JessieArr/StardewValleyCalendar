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
    public class FallModel : PageModel
    {
        private CalendarService _CalendarService;

        public List<int> Days;
        public List<SVDayOfWeek> DaysOfTheWeek;
        public List<SVTimeOfDay> TimesOfDay;
        public List<SVCalendarDay> CalendarDays;
        public SVWikiLink TravelingCart;
        public SVBundle SeasonalForagingBundle;

        public List<SVCrop> CropsInSeason;
        public List<SeasonReminder> Reminders;

        public string PreviousSeason = SeasonNames.Summer;

        public FallModel()
        {
            _CalendarService = new CalendarService();
            TravelingCart = Shops.TravelingCart;
            DaysOfTheWeek = _CalendarService.GetDaysOfWeek();
            TimesOfDay = _CalendarService.GetTimesOfDay();
            CalendarDays = _CalendarService.GetCalendarDaysForFall();
            CropsInSeason = Crops.GetFallCrops();
            SeasonalForagingBundle = Bundles.FallForagingBundle;
            Reminders = _CalendarService.GetRemindersForFall();
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