using NUnit.Framework;
using TestNinja.Mocking;

namespace TestNinja.UnitTests.Mocking
{
    [TestFixture]
    public class BookingHelperTests
    {
        [Test]
        public void OverlappingBookingsExist_BookStatusIsCancelled_ReturnStringEmpty()
        {
            var booking = new Booking() {Status = "Cancelled"};

            var result = BookingHelper.OverlappingBookingsExist(booking);
            
            Assert.That(result, Is.EqualTo(string.Empty));
        }
    }
}