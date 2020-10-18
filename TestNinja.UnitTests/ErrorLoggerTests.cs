using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class ErrorLoggerTests
    {
        private ErrorLogger _logger;
        
        [SetUp]
        public void SetUp()
        {
            _logger = new ErrorLogger();
        }
        
        [Test]
        public void Log_WhenCalled_SetTheLastErrorProperty()
        {
            _logger.Log("a");
            
            Assert.That(_logger.LastError, Is.EqualTo("a"));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void Log_InvalidError_ThrowsArgumentNullException(string error)
        {
            // _logger.Log(error);
            
            // we test exception throwing methods with lambda expressions / delegates
            Assert.That(() => _logger.Log(error), Throws.ArgumentNullException);
        }

        [Test]
        public void Log_ValidError_RaiseErrorLoggedEvent()
        {
            
            // Before Acting we need to subscribe to the event
            var id = Guid.Empty;
            _logger.ErrorLogged += (sender, args) => { id = args; };
            
            _logger.Log("a");
            
            Assert.That(id, Is.Not.EqualTo(Guid.Empty));
        }
    }
}