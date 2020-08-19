﻿using System;

namespace Quantify
{
    public partial class Quantity<TValue, TUnit, TQuantity>
    {
        /// <summary>
        /// Subtract the value of a quantity from the value of this quantity.
        /// </summary>
        /// <param name="subtrahendQuantity">The quantity for which the value will be subtracted from to value of this quantity.</param>
        /// <returns>A new <see cref="TQuantity"/> with the result of the calculation. The unit of the returned quantity will be the in the unit as this quantity.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="termQuantity"/> is <code>null</code>.</exception>
        public virtual TQuantity Subtract(TQuantity subtrahendQuantity)
        {
            if (subtrahendQuantity == null)
                throw new ArgumentNullException(nameof(subtrahendQuantity));

            var convertedSubtrahendQuantityValue = valueConverter.ConvertValueToUnit(subtrahendQuantity.Value, subtrahendQuantity.Unit, Unit);
            return Subtract(convertedSubtrahendQuantityValue);
        }

        public virtual TQuantity Subtract(TValue subtrahend)
        {
            if (subtrahend == null)
                throw new ArgumentNullException(nameof(subtrahend));

            var difference = valueCalculator.Subtract(Value, subtrahend);
            return CreateInstance(difference);
        }

        public virtual TQuantity Subtract(short subtrahend)
        {
            var difference = valueCalculator.Subtract(Value, subtrahend);
            return CreateInstance(difference);
        }

        public virtual TQuantity Subtract(ushort subtrahend)
        {
            var difference = valueCalculator.Subtract(Value, subtrahend);
            return CreateInstance(difference);
        }

        public virtual TQuantity Subtract(int subtrahend)
        {
            var difference = valueCalculator.Subtract(Value, subtrahend);
            return CreateInstance(difference);
        }

        public virtual TQuantity Subtract(uint subtrahend)
        {
            var difference = valueCalculator.Subtract(Value, subtrahend);
            return CreateInstance(difference);
        }

        public virtual TQuantity Subtract(long subtrahend)
        {
            var difference = valueCalculator.Subtract(Value, subtrahend);
            return CreateInstance(difference);
        }

        public virtual TQuantity Subtract(ulong subtrahend)
        {
            var difference = valueCalculator.Subtract(Value, subtrahend);
            return CreateInstance(difference);
        }

        public virtual TQuantity Subtract(double subtrahend)
        {
            var difference = valueCalculator.Subtract(Value, subtrahend);
            return CreateInstance(difference);
        }

        public virtual TQuantity Subtract(decimal subtrahend)
        {
            var difference = valueCalculator.Subtract(Value, subtrahend);
            return CreateInstance(difference);
        }

        public virtual TQuantity Subtract(float subtrahend)
        {
            var difference = valueCalculator.Subtract(Value, subtrahend);
            return CreateInstance(difference);
        }

        public static TQuantity operator -(Quantity<TValue, TUnit, TQuantity> minuendQuantity, TQuantity subtrahendQuantity)
        {
            if (minuendQuantity == null)
                throw new ArgumentNullException(nameof(minuendQuantity));

            if (subtrahendQuantity == null)
                throw new ArgumentNullException(nameof(subtrahendQuantity));

            return minuendQuantity.Subtract(subtrahendQuantity);
        }

        public static TQuantity operator -(Quantity<TValue, TUnit, TQuantity> minuendQuantity, short subtrahend)
        {
            if (minuendQuantity == null)
                throw new ArgumentNullException(nameof(minuendQuantity));

            return minuendQuantity.Subtract(subtrahend);
        }

        public static TQuantity operator -(Quantity<TValue, TUnit, TQuantity> minuendQuantity, ushort subtrahend)
        {
            if (minuendQuantity == null)
                throw new ArgumentNullException(nameof(minuendQuantity));

            return minuendQuantity.Subtract(subtrahend);
        }

        public static TQuantity operator -(Quantity<TValue, TUnit, TQuantity> minuendQuantity, int subtrahend)
        {
            if (minuendQuantity == null)
                throw new ArgumentNullException(nameof(minuendQuantity));

            return minuendQuantity.Subtract(subtrahend);
        }

        public static TQuantity operator -(Quantity<TValue, TUnit, TQuantity> minuendQuantity, uint subtrahend)
        {
            if (minuendQuantity == null)
                throw new ArgumentNullException(nameof(minuendQuantity));

            return minuendQuantity.Subtract(subtrahend);
        }

        public static TQuantity operator -(Quantity<TValue, TUnit, TQuantity> minuendQuantity, long subtrahend)
        {
            if (minuendQuantity == null)
                throw new ArgumentNullException(nameof(minuendQuantity));

            return minuendQuantity.Subtract(subtrahend);
        }

        public static TQuantity operator -(Quantity<TValue, TUnit, TQuantity> minuendQuantity, ulong subtrahend)
        {
            if (minuendQuantity == null)
                throw new ArgumentNullException(nameof(minuendQuantity));

            return minuendQuantity.Subtract(subtrahend);
        }

        public static TQuantity operator -(Quantity<TValue, TUnit, TQuantity> minuendQuantity, double subtrahend)
        {
            if (minuendQuantity == null)
                throw new ArgumentNullException(nameof(minuendQuantity));

            return minuendQuantity.Subtract(subtrahend);
        }

        public static TQuantity operator -(Quantity<TValue, TUnit, TQuantity> minuendQuantity, decimal subtrahend)
        {
            if (minuendQuantity == null)
                throw new ArgumentNullException(nameof(minuendQuantity));

            return minuendQuantity.Subtract(subtrahend);
        }

        public static TQuantity operator -(Quantity<TValue, TUnit, TQuantity> minuendQuantity, float subtrahend)
        {
            if (minuendQuantity == null)
                throw new ArgumentNullException(nameof(minuendQuantity));

            return minuendQuantity.Subtract(subtrahend);
        }
    }
}