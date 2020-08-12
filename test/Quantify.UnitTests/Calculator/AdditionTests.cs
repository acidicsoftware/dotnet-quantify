﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Quantify.UnitTests.Calculator
{
    [TestClass]
    public class AdditionTests
    {
        [DataTestMethod]
        [DataRow("254.1478", "32767")]
        [DataRow("25.458", "4")]
        [DataRow("25.458", "0")]
        [DataRow("22.69841", "-52")]
        [DataRow("254.1478", "-32768")]
        [DataRow("0", "32767")]
        [DataRow("0", "2")]
        [DataRow("0", "0")]
        [DataRow("0", "-5")]
        [DataRow("0", "-32768")]
        [DataRow("-571.123", "32767")]
        [DataRow("-32.9284", "88")]
        [DataRow("-26.456", "0")]
        [DataRow("-11.112", "-2")]
        [DataRow("-12.3456", "-32768")]
        public void WHEN_Adding_WHILE_FirstTerm_Decimal_SecondTerm_Short_THEN_ReturnSum(string term1String, string term2String)
        {
            // Arrange
            var valueCalculator = new DecimalValueCalculator();

            decimal term1 = decimal.Parse(term1String);
            short term2 = short.Parse(term2String);

            var expectedSum = term1 + term2;

            // Act
            var actualSum = valueCalculator.Add(term1, term2);

            // Assert
            Assert.AreEqual(expectedSum, actualSum);
        }

        [DataTestMethod]
        [DataRow("254.1478", "32767")]
        [DataRow("25.458", "4")]
        [DataRow("25.458", "0")]
        [DataRow("0", "32767")]
        [DataRow("0", "2")]
        [DataRow("0", "0")]
        [DataRow("-571.123", "32767")]
        [DataRow("-32.9284", "88")]
        [DataRow("-26.456", "0")]
        public void WHEN_Adding_WHILE_FirstTerm_Decimal_SecondTerm_UnsignedShort_THEN_ReturnSum(string term1String, string term2String)
        {
            // Arrange
            var valueCalculator = new DecimalValueCalculator();

            decimal term1 = decimal.Parse(term1String);
            ushort term2 = ushort.Parse(term2String);

            var expectedSum = term1 + term2;

            // Act
            var actualSum = valueCalculator.Add(term1, term2);

            // Assert
            Assert.AreEqual(expectedSum, actualSum);
        }

        [DataTestMethod]
        [DataRow("147.258", int.MaxValue)]
        [DataRow("25.458", 8)]
        [DataRow("25.458", 0)]
        [DataRow("13.131313", -31)]
        [DataRow("147.258", int.MinValue)]
        [DataRow("0", int.MaxValue)]
        [DataRow("0", 2)]
        [DataRow("0", 0)]
        [DataRow("0", -5)]
        [DataRow("0", int.MinValue)]
        [DataRow("-587.23654", int.MaxValue)]
        [DataRow("-57.123456789", 16)]
        [DataRow("-26.456", 0)]
        [DataRow("-77.777", -28)]
        [DataRow("-1.578", int.MinValue)]
        public void WHEN_Adding_WHILE_FirstTerm_Decimal_SecondTerm_Integer_THEN_ReturnSum(string term1String, int term2)
        {
            // Arrange
            var valueCalculator = new DecimalValueCalculator();

            decimal term1 = decimal.Parse(term1String);

            var expectedSum = term1 + term2;

            // Act
            var actualSum = valueCalculator.Add(term1, term2);

            // Assert
            Assert.AreEqual(expectedSum, actualSum);
        }

        [DataTestMethod]
        [DataRow("147.258", uint.MaxValue)]
        [DataRow("25.458", 8U)]
        [DataRow("25.458", 0U)]
        [DataRow("0", uint.MaxValue)]
        [DataRow("0", 2U)]
        [DataRow("0", 0U)]
        [DataRow("-587.23654", uint.MaxValue)]
        [DataRow("-57.123456789", 16U)]
        [DataRow("-26.456", 0U)]
        public void WHEN_Adding_WHILE_FirstTerm_Decimal_SecondTerm_UnsignedInteger_THEN_ReturnSum(string term1String, uint term2)
        {
            // Arrange
            var valueCalculator = new DecimalValueCalculator();

            decimal term1 = decimal.Parse(term1String);

            var expectedSum = term1 + term2;

            // Act
            var actualSum = valueCalculator.Add(term1, term2);

            // Assert
            Assert.AreEqual(expectedSum, actualSum);
        }

        [DataTestMethod]
        [DataRow("147.258", long.MaxValue)]
        [DataRow("25.458", 8L)]
        [DataRow("25.458", 0L)]
        [DataRow("13.131313", -31L)]
        [DataRow("147.258", long.MinValue)]
        [DataRow("0", long.MaxValue)]
        [DataRow("0", 2L)]
        [DataRow("0", 0L)]
        [DataRow("0", -5L)]
        [DataRow("0", long.MinValue)]
        [DataRow("-587.23654", long.MaxValue)]
        [DataRow("-57.123456789", 16L)]
        [DataRow("-26.456", 0L)]
        [DataRow("-77.777", -28L)]
        [DataRow("-1.578", long.MinValue)]
        public void WHEN_Adding_WHILE_FirstTerm_Decimal_SecondTerm_Long_THEN_ReturnSum(string term1String, long term2)
        {
            // Arrange
            var valueCalculator = new DecimalValueCalculator();

            decimal term1 = decimal.Parse(term1String);

            var expectedSum = term1 + term2;

            // Act
            var actualSum = valueCalculator.Add(term1, term2);

            // Assert
            Assert.AreEqual(expectedSum, actualSum);
        }

        [DataTestMethod]
        [DataRow("147.258", ulong.MaxValue)]
        [DataRow("25.458", 8UL)]
        [DataRow("25.458", 0UL)]
        [DataRow("0", ulong.MaxValue)]
        [DataRow("0", 2UL)]
        [DataRow("0", 0UL)]
        [DataRow("-587.23654", ulong.MaxValue)]
        [DataRow("-57.123456789", 16UL)]
        [DataRow("-26.456", 0UL)]
        public void WHEN_Adding_WHILE_FirstTerm_Decimal_SecondTerm_UnsignedLong_THEN_ReturnSum(string term1String, ulong term2)
        {
            // Arrange
            var valueCalculator = new DecimalValueCalculator();

            decimal term1 = decimal.Parse(term1String);

            var expectedSum = term1 + term2;

            // Act
            var actualSum = valueCalculator.Add(term1, term2);

            // Assert
            Assert.AreEqual(expectedSum, actualSum);
        }

        [DataTestMethod]
        [DataRow("25.458", 4.8753)]
        [DataRow("25.458", 0)]
        [DataRow("22.69841", -52.435724)]
        [DataRow("0", 2.321)]
        [DataRow("0", 0)]
        [DataRow("-32.9284", 88.93754)]
        [DataRow("-26.456", 0)]
        [DataRow("-11.112", -2.365444)]
        public void WHEN_Adding_WHILE_FirstTerm_Decimal_SecondTerm_Double_THEN_ReturnSum(string term1String, double term2)
        {
            // Arrange
            var valueCalculator = new DecimalValueCalculator();

            decimal term1 = decimal.Parse(term1String);

            var expectedSum = term1 + Convert.ToDecimal(term2);

            // Act
            var actualSum = valueCalculator.Add(term1, term2);

            // Assert
            Assert.AreEqual(expectedSum, actualSum);
        }

        [DataTestMethod]
        [DataRow("25.458", "4.8753")]
        [DataRow("25.458", "0")]
        [DataRow("22.69841", "-52.435724")]
        [DataRow("0", "2.321")]
        [DataRow("0", "0")]
        [DataRow("0", "-5.68749")]
        [DataRow("-32.9284", "88.93754")]
        [DataRow("-26.456", "0")]
        [DataRow("-11.112", "-2.365444")]
        public void WHEN_Adding_WHILE_FirstTerm_Decimal_SecondTerm_Decimal_THEN_ReturnSum(string term1String, string term2String)
        {
            // Arrange
            var valueCalculator = new DecimalValueCalculator();

            decimal term1 = decimal.Parse(term1String);
            decimal term2 = decimal.Parse(term2String);

            var expectedSum = term1 + term2;

            // Act
            var actualSum = valueCalculator.Add(term1, term2);

            // Assert
            Assert.AreEqual(expectedSum, actualSum);
        }

        [DataTestMethod]
        [DataRow("25.458", 4.8753f)]
        [DataRow("25.458", 0f)]
        [DataRow("22.69841", -52.435724f)]
        [DataRow("0", 2.321f)]
        [DataRow("0", 0f)]
        [DataRow("0", -5.68749f)]
        [DataRow("-32.9284", 88.93754f)]
        [DataRow("-26.456", 0f)]
        [DataRow("-11.112", -2.365444f)]
        public void WHEN_Adding_WHILE_FirstTerm_Decimal_SecondTerm_Float_THEN_ReturnSum(string term1String, float term2)
        {
            // Arrange
            var valueCalculator = new DecimalValueCalculator();

            decimal term1 = decimal.Parse(term1String);

            var expectedSum = term1 + Convert.ToDecimal(term2);

            // Act
            var actualSum = valueCalculator.Add(term1, term2);

            // Assert
            Assert.AreEqual(expectedSum, actualSum);
        }

        [DataTestMethod]
        [DataRow(double.MaxValue, "9")]
        [DataRow(double.MaxValue, "0")]
        [DataRow(double.MaxValue, "-857")]
        [DataRow(25.458, "4")]
        [DataRow(25.458, "0")]
        [DataRow(22.69841, "-52")]
        [DataRow(0, "2")]
        [DataRow(0, "0")]
        [DataRow(0, "-5")]
        [DataRow(-32.9284, "88")]
        [DataRow(-26.456, "0")]
        [DataRow(-11.112, "-2")]
        [DataRow(double.MinValue, "9")]
        [DataRow(double.MinValue, "0")]
        [DataRow(double.MinValue, "-857")]
        public void WHEN_Adding_WHILE_FirstTerm_Double_SecondTerm_Short_THEN_ReturnSum(double term1, string term2String)
        {
            // Arrange
            var valueCalculator = new DoubleValueCalculator();

            short term2 = short.Parse(term2String);

            var expectedSum = term1 + term2;

            // Act
            var actualSum = valueCalculator.Add(term1, term2);

            // Assert
            Assert.AreEqual(expectedSum, actualSum);
        }

        [DataTestMethod]
        [DataRow(double.MaxValue, "9")]
        [DataRow(double.MaxValue, "0")]
        [DataRow(25.458, "4")]
        [DataRow(25.458, "0")]
        [DataRow(0, "2")]
        [DataRow(0, "0")]
        [DataRow(-32.9284, "88")]
        [DataRow(-26.456, "0")]
        [DataRow(double.MinValue, "9")]
        [DataRow(double.MinValue, "0")]
        public void WHEN_Adding_WHILE_FirstTerm_Double_SecondTerm_UnsignedShort_THEN_ReturnSum(double term1, string term2String)
        {
            // Arrange
            var valueCalculator = new DoubleValueCalculator();

            ushort term2 = ushort.Parse(term2String);

            var expectedSum = term1 + term2;

            // Act
            var actualSum = valueCalculator.Add(term1, term2);

            // Assert
            Assert.AreEqual(expectedSum, actualSum);
        }

        [DataTestMethod]
        [DataRow(double.MaxValue, int.MaxValue)]
        [DataRow(double.MaxValue, 4)]
        [DataRow(double.MaxValue, 0)]
        [DataRow(double.MaxValue, -52)]
        [DataRow(double.MaxValue, int.MinValue)]
        [DataRow(25.458, int.MaxValue)]
        [DataRow(25.458, 4)]
        [DataRow(25.458, 0)]
        [DataRow(22.69841, -52)]
        [DataRow(25.458, int.MinValue)]
        [DataRow(-26.456, int.MaxValue)]
        [DataRow(-32.9284, 88)]
        [DataRow(-26.456, 0)]
        [DataRow(-11.112, -2)]
        [DataRow(-26.456, int.MinValue)]
        [DataRow(0, int.MaxValue)]
        [DataRow(0, 2)]
        [DataRow(0, 0)]
        [DataRow(0, -5)]
        [DataRow(0, int.MinValue)]
        [DataRow(double.MinValue, int.MaxValue)]
        [DataRow(double.MinValue, 2)]
        [DataRow(double.MinValue, 0)]
        [DataRow(double.MinValue, -5)]
        [DataRow(double.MinValue, int.MinValue)]
        public void WHEN_Adding_WHILE_FirstTerm_Double_SecondTerm_Integer_THEN_ReturnSum(double term1, int term2)
        {
            // Arrange
            var valueCalculator = new DoubleValueCalculator();

            var expectedSum = term1 + term2;

            // Act
            var actualSum = valueCalculator.Add(term1, term2);

            // Assert
            Assert.AreEqual(expectedSum, actualSum);
        }

        [DataTestMethod]
        [DataRow(double.MaxValue, uint.MaxValue)]
        [DataRow(double.MaxValue, 4U)]
        [DataRow(double.MaxValue, 0U)]
        [DataRow(25.458, uint.MaxValue)]
        [DataRow(25.458, 4U)]
        [DataRow(25.458, 0U)]
        [DataRow(-26.456, uint.MaxValue)]
        [DataRow(-32.9284, 88U)]
        [DataRow(-26.456, 0U)]
        [DataRow(0, uint.MaxValue)]
        [DataRow(0, 2U)]
        [DataRow(0, 0U)]
        [DataRow(double.MinValue, uint.MaxValue)]
        [DataRow(double.MinValue, 2U)]
        [DataRow(double.MinValue, 0U)]
        public void WHEN_Adding_WHILE_FirstTerm_Double_SecondTerm_UnsignedInteger_THEN_ReturnSum(double term1, uint term2)
        {
            // Arrange
            var valueCalculator = new DoubleValueCalculator();

            var expectedSum = term1 + term2;

            // Act
            var actualSum = valueCalculator.Add(term1, term2);

            // Assert
            Assert.AreEqual(expectedSum, actualSum);
        }

        [DataTestMethod]
        [DataRow(double.MaxValue, long.MaxValue)]
        [DataRow(double.MaxValue, 4L)]
        [DataRow(double.MaxValue, 0L)]
        [DataRow(double.MaxValue, -52L)]
        [DataRow(double.MaxValue, long.MinValue)]
        [DataRow(25.458, long.MaxValue)]
        [DataRow(25.458, 4L)]
        [DataRow(25.458, 0L)]
        [DataRow(22.69841, -52L)]
        [DataRow(25.458, long.MinValue)]
        [DataRow(-26.456, long.MaxValue)]
        [DataRow(-32.9284, 88L)]
        [DataRow(-26.456, 0L)]
        [DataRow(-11.112, -2L)]
        [DataRow(-26.456, long.MinValue)]
        [DataRow(0, long.MaxValue)]
        [DataRow(0, 2L)]
        [DataRow(0, 0L)]
        [DataRow(0, -5L)]
        [DataRow(0, long.MinValue)]
        [DataRow(double.MinValue, long.MaxValue)]
        [DataRow(double.MinValue, 2L)]
        [DataRow(double.MinValue, 0L)]
        [DataRow(double.MinValue, -5L)]
        [DataRow(double.MinValue, long.MinValue)]
        public void WHEN_Adding_WHILE_FirstTerm_Double_SecondTerm_Long_THEN_ReturnSum(double term1, long term2)
        {
            // Arrange
            var valueCalculator = new DoubleValueCalculator();

            var expectedSum = term1 + term2;

            // Act
            var actualSum = valueCalculator.Add(term1, term2);

            // Assert
            Assert.AreEqual(expectedSum, actualSum);
        }

        [DataTestMethod]
        [DataRow(double.MaxValue, ulong.MaxValue)]
        [DataRow(double.MaxValue, 4UL)]
        [DataRow(double.MaxValue, 0UL)]
        [DataRow(25.458, ulong.MaxValue)]
        [DataRow(25.458, 4UL)]
        [DataRow(25.458, 0UL)]
        [DataRow(-26.456, ulong.MaxValue)]
        [DataRow(-32.9284, 88UL)]
        [DataRow(-26.456, 0UL)]
        [DataRow(0, ulong.MaxValue)]
        [DataRow(0, 2UL)]
        [DataRow(0, 0UL)]
        [DataRow(double.MinValue, ulong.MaxValue)]
        [DataRow(double.MinValue, 2UL)]
        [DataRow(double.MinValue, 0UL)]
        public void WHEN_Adding_WHILE_FirstTerm_Double_SecondTerm_UnsignedLong_THEN_ReturnSum(double term1, ulong term2)
        {
            // Arrange
            var valueCalculator = new DoubleValueCalculator();

            var expectedSum = term1 + term2;

            // Act
            var actualSum = valueCalculator.Add(term1, term2);

            // Assert
            Assert.AreEqual(expectedSum, actualSum);
        }


        [DataTestMethod]
        [DataRow(double.MaxValue, double.MaxValue)]
        [DataRow(double.MaxValue, 4.8753)]
        [DataRow(double.MaxValue, 0)]
        [DataRow(double.MaxValue, -52.435724)]
        [DataRow(double.MaxValue, double.MinValue)]
        [DataRow(25.458, double.MaxValue)]
        [DataRow(25.458, 4.8753)]
        [DataRow(25.458, 0)]
        [DataRow(22.69841, -52.435724)]
        [DataRow(22.69841, double.MinValue)]
        [DataRow(0, double.MaxValue)]
        [DataRow(0, 2.321)]
        [DataRow(0, 0)]
        [DataRow(0, -5.68749)]
        [DataRow(0, double.MinValue)]
        [DataRow(-26.456, double.MaxValue)]
        [DataRow(-32.9284, 88.93754)]
        [DataRow(-26.456, 0)]
        [DataRow(-11.112, -2.365444)]
        [DataRow(-26.456, double.MinValue)]
        [DataRow(double.MinValue, double.MaxValue)]
        [DataRow(double.MinValue, 4.8753)]
        [DataRow(double.MinValue, 0)]
        [DataRow(double.MinValue, -52.435724)]
        [DataRow(double.MinValue, double.MinValue)]
        public void WHEN_Adding_WHILE_FirstTerm_Double_SecondTerm_Double_THEN_ReturnSum(double term1, double term2)
        {
            // Arrange
            var valueCalculator = new DoubleValueCalculator();

            var expectedSum = term1 + term2;

            // Act
            var actualSum = valueCalculator.Add(term1, term2);

            // Assert
            Assert.AreEqual(expectedSum, actualSum);
        }

        [DataTestMethod]
        [DataRow(double.MaxValue, "2.321")]
        [DataRow(double.MaxValue, "0")]
        [DataRow(double.MaxValue, "-5.68749")]
        [DataRow(25.458, "4.8753")]
        [DataRow(25.458, "0")]
        [DataRow(22.69841, "-52.435724")]
        [DataRow(0, "2.321")]
        [DataRow(0, "0")]
        [DataRow(0, "-5.68749")]
        [DataRow(-32.9284, "88.93754")]
        [DataRow(-26.456, "0")]
        [DataRow(-11.112, "-2.365444")]
        [DataRow(double.MinValue, "2.321")]
        [DataRow(double.MinValue, "0")]
        [DataRow(double.MinValue, "-5.68749")]
        public void WHEN_Adding_WHILE_FirstTerm_Double_SecondTerm_Decimal_THEN_ReturnSum(double term1, string term2String)
        {
            // Arrange
            var valueCalculator = new DoubleValueCalculator();

            decimal term2 = decimal.Parse(term2String);

            var expectedSum = term1 + Convert.ToDouble(term2);

            // Act
            var actualSum = valueCalculator.Add(term1, term2);

            // Assert
            Assert.AreEqual(expectedSum, actualSum);
        }

        [DataTestMethod]
        [DataRow(double.MaxValue, float.MaxValue)]
        [DataRow(double.MaxValue, 4.8753f)]
        [DataRow(double.MaxValue, 0f)]
        [DataRow(double.MaxValue, -52.435724f)]
        [DataRow(double.MaxValue, float.MinValue)]
        [DataRow(25.458, float.MaxValue)]
        [DataRow(25.458, 4.8753f)]
        [DataRow(25.458, 0f)]
        [DataRow(22.69841, -52.435724f)]
        [DataRow(22.69841, float.MinValue)]
        [DataRow(0, float.MaxValue)]
        [DataRow(0, 2.321f)]
        [DataRow(0, 0f)]
        [DataRow(0, -5.68749f)]
        [DataRow(0, float.MinValue)]
        [DataRow(-26.456, float.MaxValue)]
        [DataRow(-32.9284, 88.93754f)]
        [DataRow(-26.456, 0f)]
        [DataRow(-11.112, -2.365444f)]
        [DataRow(-26.456, float.MinValue)]
        [DataRow(double.MinValue, float.MaxValue)]
        [DataRow(double.MinValue, 4.8753f)]
        [DataRow(double.MinValue, 0f)]
        [DataRow(double.MinValue, -52.435724f)]
        [DataRow(double.MinValue, float.MinValue)]
        public void WHEN_Adding_WHILE_FirstTerm_Double_SecondTerm_Float_THEN_ReturnSum(double term1, float term2)
        {
            // Arrange
            var valueCalculator = new DoubleValueCalculator();

            var expectedSum = term1 + term2;

            // Act
            var actualSum = valueCalculator.Add(term1, term2);

            // Assert
            Assert.AreEqual(expectedSum, actualSum);
        }
    }
}