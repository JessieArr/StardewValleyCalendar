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
        public int NumberPerHarvest { get; set; } = 1;
        public CropSpeedGrid DaysToGrow { get; set; }
        public int DaysToReGrow { get; set; }
        public bool MultipleHarvests { get; set; }
        private SVCropCalculatedValues _CalculatedValues;
        public SVCropCalculatedValues CalculatedValues { get
            {
                if(_CalculatedValues == null)
                {
                    if (MultipleHarvests)
                    {
                        _CalculatedValues = CalculateCropValuesMultipleHarvests(this);
                    }
                    else
                    {
                        _CalculatedValues = CalculateCropValues(this);
                    }
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

            values.MaxHarvests = CalculateMaxHarvests(crop);
            values.DaysNeededForAllHarvests = CalculateDaysNeededForAllHarvests(crop, values.MaxHarvests);
            values.FirstDayToPlant = CalculateFirstDayToPlant(crop, values.DaysNeededForAllHarvests);
            values.LastDayToPlant = CalculateLastDayToPlant(crop);
            values.GoldPerDay = CalculateGoldPerDay(crop, values.MaxHarvests);

            return values;
        }

        public static SVCropCalculatedValues CalculateCropValuesMultipleHarvests(SVCrop crop)
        {
            var values = new SVCropCalculatedValues();

            // Subtract one for the first day of the season
            values.GrowingDays = crop.Seasons.Count * 28 - 1;

            values.MaxHarvests = CalculateMaxHarvestsWithRegrowth(crop);

            values.DaysNeededForAllHarvests = CalculateDaysNeededForAllHarvestsWithRegrowth(crop, values.MaxHarvests);
            values.FirstDayToPlant = CalculateFirstDayToPlant(crop, values.DaysNeededForAllHarvests);
            values.LastDayToPlant = CalculateLastDayToPlant(crop);
            values.GoldPerDay = CalculateGoldPerDayWithRegrowth(crop, values.MaxHarvests);

            return values;
        }

        public static CropSpeedGrid CalculateMaxHarvests(SVCrop crop)
        {
            var growingDays = crop.Seasons.Count * 28 - 1;

            var grid = new CropSpeedGrid()
            {
                Normal = Math.Floor(growingDays / crop.DaysToGrow.Normal),
                SpeedGroOrAgriculturalist = Math.Floor(growingDays / crop.DaysToGrow.SpeedGroOrAgriculturalist),
                SpeedGroAndAgriculturalist = Math.Floor(growingDays / crop.DaysToGrow.SpeedGroAndAgriculturalist),
                Deluxe = Math.Floor(growingDays / crop.DaysToGrow.Deluxe),
                DeluxeAndAgriculturalist = Math.Floor(growingDays / crop.DaysToGrow.DeluxeAndAgriculturalist),
            };

            return grid;
        }

        public static CropSpeedGrid CalculateDaysNeededForAllHarvests(SVCrop crop, CropSpeedGrid maxHarvests)
        {
            var grid = new CropSpeedGrid()
            {
                Normal = maxHarvests.Normal * crop.DaysToGrow.Normal,
                SpeedGroOrAgriculturalist = maxHarvests.SpeedGroOrAgriculturalist * crop.DaysToGrow.SpeedGroOrAgriculturalist,
                SpeedGroAndAgriculturalist = maxHarvests.SpeedGroAndAgriculturalist * crop.DaysToGrow.SpeedGroAndAgriculturalist,
                Deluxe = maxHarvests.Deluxe * crop.DaysToGrow.Deluxe,
                DeluxeAndAgriculturalist = maxHarvests.DeluxeAndAgriculturalist * crop.DaysToGrow.DeluxeAndAgriculturalist,
            };

            return grid;
        }

        public static CropSpeedGrid CalculateFirstDayToPlant(SVCrop crop, CropSpeedGrid daysNeededForAllHarvests)
        {
            var growingDays = crop.Seasons.Count * 28 - 1;

            var grid = new CropSpeedGrid()
            {
                Normal = growingDays - daysNeededForAllHarvests.Normal + 1,
                SpeedGroOrAgriculturalist = growingDays - daysNeededForAllHarvests.SpeedGroOrAgriculturalist + 1,
                SpeedGroAndAgriculturalist = growingDays - daysNeededForAllHarvests.SpeedGroAndAgriculturalist + 1,
                Deluxe = growingDays - daysNeededForAllHarvests.Deluxe + 1,
                DeluxeAndAgriculturalist = growingDays - daysNeededForAllHarvests.DeluxeAndAgriculturalist + 1,
            };

            return grid;
        }

        public static CropSpeedGrid CalculateLastDayToPlant(SVCrop crop)
        {
            var grid = new CropSpeedGrid()
            {
                Normal = 27 - crop.DaysToGrow.Normal + 1,
                SpeedGroOrAgriculturalist = 27 - crop.DaysToGrow.SpeedGroOrAgriculturalist + 1,
                SpeedGroAndAgriculturalist = 27 - crop.DaysToGrow.SpeedGroAndAgriculturalist + 1,
                Deluxe = 27 - crop.DaysToGrow.Deluxe + 1,
                DeluxeAndAgriculturalist = 27 - crop.DaysToGrow.DeluxeAndAgriculturalist + 1,
            };

            return grid;
        }

        public static CropSpeedGrid CalculateGoldPerDay(SVCrop crop, CropSpeedGrid maxHarvests)
        {
            var grid = new CropSpeedGrid()
            {
                Normal = (maxHarvests.Normal * crop.SellPrice * crop.NumberPerHarvest - maxHarvests.Normal * crop.SeedPrice) / (maxHarvests.Normal * crop.DaysToGrow.Normal),
                SpeedGroOrAgriculturalist = (maxHarvests.SpeedGroOrAgriculturalist * crop.SellPrice * crop.NumberPerHarvest - maxHarvests.SpeedGroOrAgriculturalist * crop.SeedPrice) / (maxHarvests.SpeedGroOrAgriculturalist * crop.DaysToGrow.SpeedGroOrAgriculturalist),
                SpeedGroAndAgriculturalist = (maxHarvests.SpeedGroAndAgriculturalist * crop.SellPrice * crop.NumberPerHarvest - maxHarvests.SpeedGroAndAgriculturalist * crop.SeedPrice) / (maxHarvests.SpeedGroAndAgriculturalist * crop.DaysToGrow.SpeedGroAndAgriculturalist),
                Deluxe = (maxHarvests.Deluxe * crop.SellPrice * crop.NumberPerHarvest - maxHarvests.Deluxe * crop.SeedPrice) / (maxHarvests.Deluxe * crop.DaysToGrow.Deluxe),
                DeluxeAndAgriculturalist = (maxHarvests.DeluxeAndAgriculturalist * crop.SellPrice * crop.NumberPerHarvest - maxHarvests.DeluxeAndAgriculturalist * crop.SeedPrice) / (maxHarvests.DeluxeAndAgriculturalist * crop.DaysToGrow.DeluxeAndAgriculturalist),
            };

            return grid;
        }

        public static CropSpeedGrid CalculateMaxHarvestsWithRegrowth(SVCrop crop)
        {
            var growingDays = crop.Seasons.Count * 28 - 1;

            var grid = new CropSpeedGrid()
            {
                Normal = Math.Floor((growingDays - crop.DaysToGrow.Normal) / crop.DaysToReGrow) + 1,
                SpeedGroOrAgriculturalist = Math.Floor((growingDays - crop.DaysToGrow.SpeedGroOrAgriculturalist) / crop.DaysToReGrow) + 1,
                SpeedGroAndAgriculturalist = Math.Floor((growingDays - crop.DaysToGrow.SpeedGroAndAgriculturalist) / crop.DaysToReGrow) + 1,
                Deluxe = Math.Floor((growingDays - crop.DaysToGrow.Deluxe) / crop.DaysToReGrow) + 1,
                DeluxeAndAgriculturalist = Math.Floor((growingDays - crop.DaysToGrow.DeluxeAndAgriculturalist) / crop.DaysToReGrow) + 1,
            };

            return grid;
        }

        public static CropSpeedGrid CalculateDaysNeededForAllHarvestsWithRegrowth(SVCrop crop, CropSpeedGrid maxHarvests)
        {
            var grid = new CropSpeedGrid()
            {
                Normal = crop.DaysToGrow.Normal + ((maxHarvests.Normal - 1) * crop.DaysToReGrow),
                SpeedGroOrAgriculturalist = crop.DaysToGrow.SpeedGroOrAgriculturalist + ((maxHarvests.SpeedGroOrAgriculturalist - 1) * crop.DaysToReGrow),
                SpeedGroAndAgriculturalist = crop.DaysToGrow.SpeedGroAndAgriculturalist + ((maxHarvests.SpeedGroAndAgriculturalist - 1) * crop.DaysToReGrow),
                Deluxe = crop.DaysToGrow.Deluxe + ((maxHarvests.Deluxe - 1) * crop.DaysToReGrow),
                DeluxeAndAgriculturalist = crop.DaysToGrow.DeluxeAndAgriculturalist + ((maxHarvests.DeluxeAndAgriculturalist - 1) * crop.DaysToReGrow),
            };

            return grid;
        }

        public static CropSpeedGrid CalculateGoldPerDayWithRegrowth(SVCrop crop, CropSpeedGrid maxHarvests)
        {
            var grid = new CropSpeedGrid()
            {
                Normal = (maxHarvests.Normal * crop.SellPrice * crop.NumberPerHarvest - crop.SeedPrice) 
                    / ((maxHarvests.Normal - 1) * crop.DaysToReGrow + crop.DaysToGrow.Normal),
                SpeedGroOrAgriculturalist = (maxHarvests.SpeedGroOrAgriculturalist * crop.SellPrice * crop.NumberPerHarvest - crop.SeedPrice) 
                    / ((maxHarvests.SpeedGroOrAgriculturalist - 1) * crop.DaysToReGrow + crop.DaysToGrow.SpeedGroOrAgriculturalist),
                SpeedGroAndAgriculturalist = (maxHarvests.SpeedGroAndAgriculturalist * crop.SellPrice * crop.NumberPerHarvest - crop.SeedPrice) 
                    / ((maxHarvests.SpeedGroAndAgriculturalist - 1) * crop.DaysToReGrow + crop.DaysToGrow.SpeedGroAndAgriculturalist),
                Deluxe = (maxHarvests.Deluxe * crop.SellPrice * crop.NumberPerHarvest - crop.SeedPrice) 
                    / ((maxHarvests.Deluxe - 1) * crop.DaysToReGrow + crop.DaysToGrow.Deluxe),
                DeluxeAndAgriculturalist = (maxHarvests.DeluxeAndAgriculturalist * crop.SellPrice * crop.NumberPerHarvest - crop.SeedPrice) 
                    / ((maxHarvests.DeluxeAndAgriculturalist - 1) * crop.DaysToReGrow + crop.DaysToGrow.DeluxeAndAgriculturalist),
            };

            return grid;
        }
    }
}
