﻿using System;

namespace Quantify
{
    internal class PreciseValueConverter<TValue, TUnit> : ValueConverter<TValue, TUnit>
    {
        private readonly UnitRepository<TUnit> unitRepository;
        private readonly ValueCalculator<TValue> valueCalculator;

        public PreciseValueConverter(UnitRepository<TUnit> unitRepository, ValueCalculator<TValue> valueCalculator)
        {
            this.unitRepository = unitRepository ?? throw new ArgumentNullException(nameof(unitRepository));
            this.valueCalculator = valueCalculator ?? throw new ArgumentNullException(nameof(valueCalculator));
        }

        public TValue ConvertValueToUnit(TValue value, TUnit sourceUnit, TUnit targetUnit)
        {
            if (value == null) throw new ArgumentNullException(nameof(value));
            if (sourceUnit == null) throw new ArgumentNullException(nameof(sourceUnit));
            if (targetUnit == null) throw new ArgumentNullException(nameof(targetUnit));

            if (sourceUnit.Equals(targetUnit))
                return value;

            var sourceUnitValueInBaseUnits = unitRepository.GetPreciseUnitValueInBaseUnits(sourceUnit);
            var targetUnitValueInBaseUnits = unitRepository.GetPreciseUnitValueInBaseUnits(targetUnit);

            if (sourceUnitValueInBaseUnits.HasValue == false)
                throw new UnitNotFoundException<TUnit>(sourceUnit);

            if (targetUnitValueInBaseUnits.HasValue == false)
                throw new UnitNotFoundException<TUnit>(targetUnit);

            return valueCalculator.Multiply(value, sourceUnitValueInBaseUnits.Value / targetUnitValueInBaseUnits.Value);
        }
    }
}