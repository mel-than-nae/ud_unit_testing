using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class HtmlFormatterTests
    {
        [Test]
        public void FormatAsBold_WhenCalled_ShouldEncloseTheStringWithStrongElement()
        {
            var formatter = new HtmlFormatter();

            var result = formatter.FormatAsBold("abc");
            
            // Specific Assertion
            // Good solution because what comes out of this method is important.
            Assert.That(result, Is.EqualTo("<strong>abc</strong>").IgnoreCase);
            
            // // More general
            // Assert.That(result, Does.StartWith("<strong>"));
            // Assert.That(result, Does.EndWith("</strong>"));
            // Assert.That(result, Does.Contain("abc"));
        }
    }
}