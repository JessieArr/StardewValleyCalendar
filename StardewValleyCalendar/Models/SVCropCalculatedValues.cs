using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StardewValleyCalendar.Models
{
    public class SVCropCalculatedValues
    {
        public double GrowingDays { get; set; }
        public CropSpeedGrid DaysNeededForAllHarvests { get; set; }
        public CropSpeedGrid MaxHarvests { get; set; }
        public CropSpeedGrid GoldPerDay { get; set; }
        public CropSpeedGrid FirstDayToPlant { get; set; }
        public CropSpeedGrid LastDayToPlant { get; set; }

    }
}
