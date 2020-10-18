using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class DemeritPointsCalculatorTests
    {
        private DemeritPointsCalculator _calc;
        [SetUp]
        public void Setup()
        {
            _calc = new DemeritPointsCalculator();
        }
        
        [Test]
        public void CalculateDemeritPoints_SpeedIsNegative_Throws_ArgumentOutOfRangeException()
        {
            Assert.That(() => _calc.CalculateDemeritPoints(-10), Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }
        
        [Test]
        public void CalculateDemeritPoints_SpeedIsGreaterThanSpeedLimit_Throws_ArgumentOutOfRangeException()
        {
            Assert.That(() => _calc.CalculateDemeritPoints(301), Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }

        [Test]
        public void CalculateDemeritPoints_SpeedIsZero_ReturnZero()
        {
            var result = _calc.CalculateDemeritPoints(0);
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void CalculateDemeritPoints_SpeedIs300_ReturnTheCalculation()
        {
            var result = _calc.CalculateDemeritPoints(300);
            Assert.That(result, Is.EqualTo(47));
        }

        

        [Test]
        public void CalculateDemeritPoints_LessThanSpeedLimit_ReturnsZero()
        {
            var result =_calc.CalculateDemeritPoints(64);
            
            Assert.That(result, Is.EqualTo(0));
        }
        
        [Test]
        public void CalculateDemeritPoints_WhenCalledEqualWithSpeedLimit_ReturnsZero()
        {
            var result = _calc.CalculateDemeritPoints(65);
            
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void CalculateDemeritPoints_WhenCalledWithMoreThanSpeedLimit_ReturnsTheCalculationCorrectly()
        {
            var result = _calc.CalculateDemeritPoints(150);
            
            Assert.That(result, Is.EqualTo(17));
        }
    }
}