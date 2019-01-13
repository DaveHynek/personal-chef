using PersonalChef.Common;
using System;
using System.ComponentModel.DataAnnotations;

namespace PersonalChef.Data.Models.Recipes
{
    public class MeasurementUnit
    {
        /// <summary>
        /// Create a <see cref="MeasurementUnit"/> from a <see cref="Units"/>.
        /// </summary>
        /// <param name="unit">Unit to convert to a <see cref="MeasurementUnit"/> data object.</param>
        public MeasurementUnit(Units unit)
        {
            Unit = unit;
            Name = Enum.GetName(typeof(Units), unit);
        }

        /// <summary>
        /// Readonly unit ID, based on the <see cref="Units"/> enum.
        /// </summary>
        [Key]
        public Units Unit { get; private set; }

        /// <summary>
        /// Readonly name of the unit, used for providing context in the database table.
        /// </summary>
        [Required]
        [Display(Name = "Unit Name")]
        [StringLength(50)]
        public string Name { get; private set; }
    }
}
