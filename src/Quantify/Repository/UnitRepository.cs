﻿namespace Quantify
{
    /// <summary>
    /// Interface defining the contract for repositories used to get quantity unit data.
    /// </summary>
    /// <typeparam name="TUnit">The type of the unit.</typeparam>
    public interface UnitRepository<TUnit>
    {
        /// <summary>
        /// Get the performance optimized conversion value for a unit.
        /// </summary>
        /// <remarks>
        /// This conversion value is optimized towards greater performance, since the returned value is of the type <see cref="double"/>.
        /// </remarks>
        /// <param name="unit">The unit to get the conversion value for.</param>
        /// <returns>The conversion value for the given unit. Returns <code>null</code> if no data was found for the unit.</returns>
        double? GetUnitConversionValue(TUnit unit);

        /// <summary>
        /// Get the precision optimized conversion value for a unit.
        /// </summary>
        /// <remarks>
        /// This conversion value is optimized towards greater precision, since the returned value is of the type <see cref="decimal"/>.
        /// </remarks>
        /// <param name="unit">The unit to get the conversion value for.</param>
        /// <returns>The conversion value for the given unit. Returns <code>null</code> if no data was found for the unit.</returns>
        decimal? GetPreciseUnitConversionValue(TUnit unit);
    }
}