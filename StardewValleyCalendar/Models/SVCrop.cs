using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StardewValleyCalendar.Models
{
    public class SVCrop
    {
        public SVWikiLink Link { get; set; }
        public List<string> Seasons { get; set; } = new List<string>();
        public int SeedPrice { get; set; }
        public int SellPrice { get; set; }
        public CropSpeedGrid DaysToGrow { get; set; }
        public bool MultipleHarvests { get; set; }
        private SVCropCalculatedValues _CalculatedValues;
        public SVCropCalculatedValues CalculatedValues { get
            {
                if(_CalculatedValues == null)
                {
                    _CalculatedValues = CalculateCropValues(this);
                }
                return _CalculatedValues;
            }
            set
            {
                _CalculatedValues = value;
            }
        }

        public static SVCropCalculatedValues CalculateCropValues(SVCrop crop)
        {
            var values = new SVCropCalculatedValues();

            // Subtract one for the first day of the season
            values.GrowingDays = crop.Seasons.Count * 28 - 1;

            values.MaxHarvests = new CropSpeedGrid()
            {
                Normal = Math.Floor((values.GrowingDays) / crop.DaysToGrow.Normal),
                SpeedGroOrAgriculturalist = Math.Floor((values.GrowingDays) / crop.DaysToGrow.SpeedGroOrAgriculturalist),
                SpeedGroAndAgriculturalist = Math.Floor((values.GrowingDays) / crop.DaysToGrow.SpeedGroAndAgriculturalist),
                Deluxe = Math.Floor((values.GrowingDays) / crop.DaysToGrow.Deluxe),
                DeluxeAndAgriculturalist = Math.Floor((values.GrowingDays) / crop.DaysToGrow.DeluxeAndAgriculturalist),
            };

            values.DaysNeededForAllHarvests = new CropSpeedGrid()
            {
                Normal = values.MaxHarvests.Normal * crop.DaysToGrow.Normal,
                SpeedGroOrAgriculturalist = values.MaxHarvests.SpeedGroOrAgriculturalist * crop.DaysToGrow.SpeedGroOrAgriculturalist,
                SpeedGroAndAgriculturalist = values.MaxHarvests.SpeedGroAndAgriculturalist * crop.DaysToGrow.SpeedGroAndAgriculturalist,
                Deluxe = values.MaxHarvests.Deluxe * crop.DaysToGrow.Deluxe,
                DeluxeAndAgriculturalist = values.MaxHarvests.DeluxeAndAgriculturalist * crop.DaysToGrow.DeluxeAndAgriculturalist,
            };

            values.FirstDayToPlant = new CropSpeedGrid()
            {
                Normal = 27 - values.DaysNeededForAllHarvests.Normal + 1,
                SpeedGroOrAgriculturalist = 27 - values.DaysNeededForAllHarvests.SpeedGroOrAgriculturalist + 1,
                SpeedGroAndAgriculturalist = 27 - values.DaysNeededForAllHarvests.SpeedGroAndAgriculturalist + 1,
                Deluxe = 27 - values.DaysNeededForAllHarvests.Deluxe + 1,
                DeluxeAndAgriculturalist = 27 - values.DaysNeededForAllHarvests.DeluxeAndAgriculturalist + 1,
            };

            values.LastDayToPlant = new CropSpeedGrid()
            {
                Normal = 27 - crop.DaysToGrow.Normal + 1,
                SpeedGroOrAgriculturalist = 27 - crop.DaysToGrow.SpeedGroOrAgriculturalist + 1,
                SpeedGroAndAgriculturalist = 27 - crop.DaysToGrow.SpeedGroAndAgriculturalist + 1,
                Deluxe = 27 - crop.DaysToGrow.Deluxe + 1,
                DeluxeAndAgriculturalist = 27 - crop.DaysToGrow.DeluxeAndAgriculturalist + 1,
            };

            values.GoldPerDay = new CropSpeedGrid()
            {
                Normal = (values.MaxHarvests.Normal * crop.SellPrice - values.MaxHarvests.Normal * crop.SeedPrice) / (values.MaxHarvests.Normal * crop.DaysToGrow.Normal),
                SpeedGroOrAgriculturalist = (values.MaxHarvests.SpeedGroOrAgriculturalist * crop.SellPrice - values.MaxHarvests.SpeedGroOrAgriculturalist * crop.SeedPrice) / (values.MaxHarvests.SpeedGroOrAgriculturalist * crop.DaysToGrow.SpeedGroOrAgriculturalist),
                SpeedGroAndAgriculturalist = (values.MaxHarvests.SpeedGroAndAgriculturalist * crop.SellPrice - values.MaxHarvests.SpeedGroAndAgriculturalist * crop.SeedPrice) / (values.MaxHarvests.SpeedGroAndAgriculturalist * crop.DaysToGrow.SpeedGroAndAgriculturalist),
                Deluxe = (values.MaxHarvests.Deluxe * crop.SellPrice - values.MaxHarvests.Deluxe * crop.SeedPrice) / (values.MaxHarvests.Deluxe * crop.DaysToGrow.Deluxe),
                DeluxeAndAgriculturalist = (values.MaxHarvests.DeluxeAndAgriculturalist * crop.SellPrice - values.MaxHarvests.DeluxeAndAgriculturalist * crop.SeedPrice) / (values.MaxHarvests.DeluxeAndAgriculturalist * crop.DaysToGrow.DeluxeAndAgriculturalist),
            };                

            return values;
        }
    }
}
