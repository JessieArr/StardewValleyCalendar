using StardewValleyCalendar.Models;
using System;
using Xunit;

namespace StardewValleyCalendar.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Parsnips()
        {
            Assert.Equal(27, Crops.Parsnip.CalculatedValues.GrowingDays);

            Assert.Equal(6, Crops.Parsnip.CalculatedValues.MaxHarvests.Normal);
            Assert.Equal(6, Crops.Parsnip.CalculatedValues.MaxHarvests.SpeedGroOrAgriculturalist);
            Assert.Equal(6, Crops.Parsnip.CalculatedValues.MaxHarvests.SpeedGroAndAgriculturalist);
            Assert.Equal(9, Crops.Parsnip.CalculatedValues.MaxHarvests.Deluxe);
            Assert.Equal(9, Crops.Parsnip.CalculatedValues.MaxHarvests.DeluxeAndAgriculturalist);

            Assert.Equal(24, Crops.Parsnip.CalculatedValues.DaysNeededForAllHarvests.Normal);
            Assert.Equal(24, Crops.Parsnip.CalculatedValues.DaysNeededForAllHarvests.SpeedGroOrAgriculturalist);
            Assert.Equal(24, Crops.Parsnip.CalculatedValues.DaysNeededForAllHarvests.SpeedGroAndAgriculturalist);
            Assert.Equal(27, Crops.Parsnip.CalculatedValues.DaysNeededForAllHarvests.Deluxe);
            Assert.Equal(27, Crops.Parsnip.CalculatedValues.DaysNeededForAllHarvests.DeluxeAndAgriculturalist);

            Assert.Equal(4, Crops.Parsnip.CalculatedValues.FirstDayToPlant.Normal);
            Assert.Equal(4, Crops.Parsnip.CalculatedValues.FirstDayToPlant.SpeedGroOrAgriculturalist);
            Assert.Equal(4, Crops.Parsnip.CalculatedValues.FirstDayToPlant.SpeedGroAndAgriculturalist);
            Assert.Equal(1, Crops.Parsnip.CalculatedValues.FirstDayToPlant.Deluxe);
            Assert.Equal(1, Crops.Parsnip.CalculatedValues.FirstDayToPlant.DeluxeAndAgriculturalist);

            Assert.Equal(24, Crops.Parsnip.CalculatedValues.LastDayToPlant.Normal);
            Assert.Equal(24, Crops.Parsnip.CalculatedValues.LastDayToPlant.SpeedGroOrAgriculturalist);
            Assert.Equal(24, Crops.Parsnip.CalculatedValues.LastDayToPlant.SpeedGroAndAgriculturalist);
            Assert.Equal(25, Crops.Parsnip.CalculatedValues.LastDayToPlant.Deluxe);
            Assert.Equal(25, Crops.Parsnip.CalculatedValues.LastDayToPlant.DeluxeAndAgriculturalist);

            Assert.Equal(3.75, Crops.Parsnip.CalculatedValues.GoldPerDay.Normal);
            Assert.Equal(3.75, Crops.Parsnip.CalculatedValues.GoldPerDay.SpeedGroOrAgriculturalist);
            Assert.Equal(3.75, Crops.Parsnip.CalculatedValues.GoldPerDay.SpeedGroAndAgriculturalist);
            Assert.Equal(5, Crops.Parsnip.CalculatedValues.GoldPerDay.Deluxe);
            Assert.Equal(5, Crops.Parsnip.CalculatedValues.GoldPerDay.DeluxeAndAgriculturalist);
        }

        [Fact]
        public void Potatos()
        {
            Assert.Equal(27, Crops.Potato.CalculatedValues.GrowingDays);

            Assert.Equal(4, Crops.Potato.CalculatedValues.MaxHarvests.Normal);
            Assert.Equal(4, Crops.Potato.CalculatedValues.MaxHarvests.SpeedGroOrAgriculturalist);
            Assert.Equal(5, Crops.Potato.CalculatedValues.MaxHarvests.SpeedGroAndAgriculturalist);
            Assert.Equal(5, Crops.Potato.CalculatedValues.MaxHarvests.Deluxe);
            Assert.Equal(6, Crops.Potato.CalculatedValues.MaxHarvests.DeluxeAndAgriculturalist);

            Assert.Equal(24, Crops.Potato.CalculatedValues.DaysNeededForAllHarvests.Normal);
            Assert.Equal(24, Crops.Potato.CalculatedValues.DaysNeededForAllHarvests.SpeedGroOrAgriculturalist);
            Assert.Equal(25, Crops.Potato.CalculatedValues.DaysNeededForAllHarvests.SpeedGroAndAgriculturalist);
            Assert.Equal(25, Crops.Potato.CalculatedValues.DaysNeededForAllHarvests.Deluxe);
            Assert.Equal(24, Crops.Potato.CalculatedValues.DaysNeededForAllHarvests.DeluxeAndAgriculturalist);

            Assert.Equal(4, Crops.Potato.CalculatedValues.FirstDayToPlant.Normal);
            Assert.Equal(4, Crops.Potato.CalculatedValues.FirstDayToPlant.SpeedGroOrAgriculturalist);
            Assert.Equal(3, Crops.Potato.CalculatedValues.FirstDayToPlant.SpeedGroAndAgriculturalist);
            Assert.Equal(3, Crops.Potato.CalculatedValues.FirstDayToPlant.Deluxe);
            Assert.Equal(4, Crops.Potato.CalculatedValues.FirstDayToPlant.DeluxeAndAgriculturalist);

            Assert.Equal(22, Crops.Potato.CalculatedValues.LastDayToPlant.Normal);
            Assert.Equal(22, Crops.Potato.CalculatedValues.LastDayToPlant.SpeedGroOrAgriculturalist);
            Assert.Equal(23, Crops.Potato.CalculatedValues.LastDayToPlant.SpeedGroAndAgriculturalist);
            Assert.Equal(23, Crops.Potato.CalculatedValues.LastDayToPlant.Deluxe);
            Assert.Equal(24, Crops.Potato.CalculatedValues.LastDayToPlant.DeluxeAndAgriculturalist);

            Assert.Equal(5, Crops.Potato.CalculatedValues.GoldPerDay.Normal);
            Assert.Equal(5, Crops.Potato.CalculatedValues.GoldPerDay.SpeedGroOrAgriculturalist);
            Assert.Equal(6, Crops.Potato.CalculatedValues.GoldPerDay.SpeedGroAndAgriculturalist);
            Assert.Equal(6, Crops.Potato.CalculatedValues.GoldPerDay.Deluxe);
            Assert.Equal(7.5, Crops.Potato.CalculatedValues.GoldPerDay.DeluxeAndAgriculturalist);
        }

        [Fact]
        public void GreenBeans()
        {
            Assert.Equal(27, Crops.GreenBean.CalculatedValues.GrowingDays);

            Assert.Equal(6, Crops.GreenBean.CalculatedValues.MaxHarvests.Normal);
            Assert.Equal(7, Crops.GreenBean.CalculatedValues.MaxHarvests.SpeedGroOrAgriculturalist);
            Assert.Equal(7, Crops.GreenBean.CalculatedValues.MaxHarvests.SpeedGroAndAgriculturalist);
            Assert.Equal(7, Crops.GreenBean.CalculatedValues.MaxHarvests.Deluxe);
            Assert.Equal(7, Crops.GreenBean.CalculatedValues.MaxHarvests.DeluxeAndAgriculturalist);

            Assert.Equal(25, Crops.GreenBean.CalculatedValues.DaysNeededForAllHarvests.Normal);
            Assert.Equal(27, Crops.GreenBean.CalculatedValues.DaysNeededForAllHarvests.SpeedGroOrAgriculturalist);
            Assert.Equal(26, Crops.GreenBean.CalculatedValues.DaysNeededForAllHarvests.SpeedGroAndAgriculturalist);
            Assert.Equal(26, Crops.GreenBean.CalculatedValues.DaysNeededForAllHarvests.Deluxe);
            Assert.Equal(25, Crops.GreenBean.CalculatedValues.DaysNeededForAllHarvests.DeluxeAndAgriculturalist);

            Assert.Equal(3, Crops.GreenBean.CalculatedValues.FirstDayToPlant.Normal);
            Assert.Equal(1, Crops.GreenBean.CalculatedValues.FirstDayToPlant.SpeedGroOrAgriculturalist);
            Assert.Equal(2, Crops.GreenBean.CalculatedValues.FirstDayToPlant.SpeedGroAndAgriculturalist);
            Assert.Equal(2, Crops.GreenBean.CalculatedValues.FirstDayToPlant.Deluxe);
            Assert.Equal(3, Crops.GreenBean.CalculatedValues.FirstDayToPlant.DeluxeAndAgriculturalist);

            Assert.Equal(18, Crops.GreenBean.CalculatedValues.LastDayToPlant.Normal);
            Assert.Equal(19, Crops.GreenBean.CalculatedValues.LastDayToPlant.SpeedGroOrAgriculturalist);
            Assert.Equal(20, Crops.GreenBean.CalculatedValues.LastDayToPlant.SpeedGroAndAgriculturalist);
            Assert.Equal(20, Crops.GreenBean.CalculatedValues.LastDayToPlant.Deluxe);
            Assert.Equal(21, Crops.GreenBean.CalculatedValues.LastDayToPlant.DeluxeAndAgriculturalist);

            Assert.Equal(7.2, Crops.GreenBean.CalculatedValues.GoldPerDay.Normal);
            Assert.Equal(8.15, Crops.GreenBean.CalculatedValues.GoldPerDay.SpeedGroOrAgriculturalist, 2);
            Assert.Equal(8.46, Crops.GreenBean.CalculatedValues.GoldPerDay.SpeedGroAndAgriculturalist, 2);
            Assert.Equal(8.46, Crops.GreenBean.CalculatedValues.GoldPerDay.Deluxe, 2);
            Assert.Equal(8.8, Crops.GreenBean.CalculatedValues.GoldPerDay.DeluxeAndAgriculturalist);
        }

        [Fact]
        public void CoffeeBeans()
        {
            Assert.Equal(55, Crops.CoffeeBean.CalculatedValues.GrowingDays);

            Assert.Equal(23, Crops.CoffeeBean.CalculatedValues.MaxHarvests.Normal);
            Assert.Equal(24, Crops.CoffeeBean.CalculatedValues.MaxHarvests.SpeedGroOrAgriculturalist);
            Assert.Equal(24, Crops.CoffeeBean.CalculatedValues.MaxHarvests.SpeedGroAndAgriculturalist);
            Assert.Equal(24, Crops.CoffeeBean.CalculatedValues.MaxHarvests.Deluxe);
            Assert.Equal(25, Crops.CoffeeBean.CalculatedValues.MaxHarvests.DeluxeAndAgriculturalist);

            Assert.Equal(54, Crops.CoffeeBean.CalculatedValues.DaysNeededForAllHarvests.Normal);
            Assert.Equal(55, Crops.CoffeeBean.CalculatedValues.DaysNeededForAllHarvests.SpeedGroOrAgriculturalist);
            Assert.Equal(54, Crops.CoffeeBean.CalculatedValues.DaysNeededForAllHarvests.SpeedGroAndAgriculturalist);
            Assert.Equal(54, Crops.CoffeeBean.CalculatedValues.DaysNeededForAllHarvests.Deluxe);
            Assert.Equal(55, Crops.CoffeeBean.CalculatedValues.DaysNeededForAllHarvests.DeluxeAndAgriculturalist);

            Assert.Equal(2, Crops.CoffeeBean.CalculatedValues.FirstDayToPlant.Normal);
            Assert.Equal(1, Crops.CoffeeBean.CalculatedValues.FirstDayToPlant.SpeedGroOrAgriculturalist);
            Assert.Equal(2, Crops.CoffeeBean.CalculatedValues.FirstDayToPlant.SpeedGroAndAgriculturalist);
            Assert.Equal(2, Crops.CoffeeBean.CalculatedValues.FirstDayToPlant.Deluxe);
            Assert.Equal(1, Crops.CoffeeBean.CalculatedValues.FirstDayToPlant.DeluxeAndAgriculturalist);

            Assert.Equal(18, Crops.CoffeeBean.CalculatedValues.LastDayToPlant.Normal);
            Assert.Equal(19, Crops.CoffeeBean.CalculatedValues.LastDayToPlant.SpeedGroOrAgriculturalist);
            Assert.Equal(20, Crops.CoffeeBean.CalculatedValues.LastDayToPlant.SpeedGroAndAgriculturalist);
            Assert.Equal(20, Crops.CoffeeBean.CalculatedValues.LastDayToPlant.Deluxe);
            Assert.Equal(21, Crops.CoffeeBean.CalculatedValues.LastDayToPlant.DeluxeAndAgriculturalist);

            Assert.Equal(-20.74, Crops.CoffeeBean.CalculatedValues.GoldPerDay.Normal, 2);
            Assert.Equal(-19.27, Crops.CoffeeBean.CalculatedValues.GoldPerDay.SpeedGroOrAgriculturalist, 2);
            Assert.Equal(-19.63, Crops.CoffeeBean.CalculatedValues.GoldPerDay.SpeedGroAndAgriculturalist, 2);
            Assert.Equal(-19.63, Crops.CoffeeBean.CalculatedValues.GoldPerDay.Deluxe, 2);
            Assert.Equal(-18.18, Crops.CoffeeBean.CalculatedValues.GoldPerDay.DeluxeAndAgriculturalist, 2);
        }
    }
}
