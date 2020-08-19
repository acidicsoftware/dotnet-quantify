﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Quantify.IntegrationTests.Quantity.Assets;
using Quantify.Test.Assets;
using System;

namespace Quantify.IntegrationTests.Quantity
{
    [TestClass]
    public class QuantityConvertingTests
    {
        [TestMethod]
        public void WHEN_Converting_WHILE_UnitRepositoryThrowsException_THEN_PassExceptionOn()
        {
            // Arrange
            var expectedException = new UriFormatException();

            var unitRepositoryMock = new Mock<UnitRepository<double, string>>();
            unitRepositoryMock.Setup(unitRepository => unitRepository.GetUnitData(It.IsAny<string>())).Throws(expectedException);

            var quantity = new TestQuantity(42, TestData.Centimetre, unitRepositoryMock.Object);

            // Act & Assert
            ExceptionHelpers.ExpectException<Exception>(() => quantity.ToUnit("The Matrix Has You..."), actualException => ReferenceEquals(expectedException, actualException));
        }

        [TestMethod]
        public void WHEN_Converting_WHILE_TargetUnit_Known_THEN_ReturnConvertedQuantity()
        {
            // Arrange
            var quantity = TestQuantity.Create(2000, TestData.Metre);

            var expectedUnit = TestData.Kilometre;
            var expectedValue = quantity.Value / TestData.KilometreUnitValue;

            // Act
            var convertedQuantity = quantity.ToUnit(expectedUnit);

            // Assert
            Assert.AreEqual(expectedUnit, convertedQuantity.Unit);
            Assert.AreEqual(expectedValue, convertedQuantity.Value);
        }
    }
}