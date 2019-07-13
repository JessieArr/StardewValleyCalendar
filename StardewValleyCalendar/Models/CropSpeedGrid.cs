using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StardewValleyCalendar.Models
{
    public class CropSpeedGrid
    {
        /// <summary>
        /// No growth speed bonus
        /// </summary>
        public double Normal { get; set; }
        /// <summary>
        /// 10% speed bonus
        /// </summary>
        public double SpeedGroOrAgriculturalist { get; set; }
        /// <summary>
        /// 20% speed bonus
        /// </summary>
        public double SpeedGroAndAgriculturalist { get; set; }
        /// <summary>
        /// 25% speed bonus
        /// </summary>
        public double Deluxe { get; set; }
        /// <summary>
        /// 35% speed bonus
        /// </summary>
        public double DeluxeAndAgriculturalist { get; set; }

        public CropSpeedGrid()
        {

        }

        public CropSpeedGrid(double input)
        {
            Normal = input;
            SpeedGroOrAgriculturalist = Math.Ceiling(input * 0.9);
            SpeedGroAndAgriculturalist = Math.Ceiling(input * 0.8);
            Deluxe = Math.Ceiling(input * 0.75);
            DeluxeAndAgriculturalist = Math.Ceiling(input * 0.65);
        }
    }
}
