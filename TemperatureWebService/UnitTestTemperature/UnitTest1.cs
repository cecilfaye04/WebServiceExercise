using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TemperatureWebService;

namespace UnitTestTemperature
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCelsiusToFahrenheit()
        {
            //Arrange
            var systemUnderTest = new TempWebService();
            var dependency = 23;
            var expected = 73.4;
            //Act
            var actual = systemUnderTest.CelsiusToFahrenheit(dependency);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCelsiusToKelvin()
        {
            //Arrange
            var systemUnderTest = new TempWebService();
            var dependency = 1232;
            var expected = 1505.15;
            //Act
            var actual = systemUnderTest.CelsiusToKelvin(dependency);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestFahrenheitToCelsius()
        {
            //Arrange
            var systemUnderTest = new TempWebService();
            var dependency = 122;
            var expected = 50;
            //Act
            var actual = systemUnderTest.FahrenheitToCelsius(dependency);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestFahrenheitToKelvin()
        {
            //Arrange
            var systemUnderTest = new TempWebService();
            var dependency = 212;
            var expected = 373.15;
            //Act
            var actual = systemUnderTest.FahrenheitToKelvin(dependency);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestKelvinToCelsius()
        {
            //Arrange
            var systemUnderTest = new TempWebService();
            var dependency = 3224;
            var expected = 2950.85;
            //Act
            var actual = systemUnderTest.KelvinToCelsius(dependency);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestKelvinToFahrenheit()
        {
            //Arrange
            var systemUnderTest = new TempWebService();
            var dependency = 32;
            var expected = -402.07;
            //Act
            var actual = systemUnderTest.KelvinToFahrenheit(dependency);
            //Assert
            Assert.AreEqual(expected, actual);
        }





    }
}
