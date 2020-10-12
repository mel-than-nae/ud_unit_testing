using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class ReservationTests
    {

        [Test]
        public void CanBeCancelledBy_AdminCancelling_ReturnsTrue()
        {
            // Arrange
            var reservation = new Reservation();
            // Act
            var result = reservation.CanBeCancelledBy(new User() {IsAdmin =  true});
            // Assert
            Assert.IsTrue(result);
        }
        
        
        [Test]
        public void CanBeCancelledBy_SameUserCancelling_ReturnsTrue()
        {
            // Arrange
            var user = new User();
            var reservation = new Reservation() { MadeBy =  user};
            // Act 
            var result = reservation.CanBeCancelledBy(user);
            // Assert
            Assert.IsTrue(result);
        }
        
        
        [Test]
        public void CanBeCancelledBy_DifferentUserCancelling_ReturnsFalse()
        {
            // Arrange
            var user = new User();
            var user1 = new User();
            var reservation = new Reservation() { MadeBy =  user};
            // Act 
            var result = reservation.CanBeCancelledBy(user1);
            // Assert
            Assert.That(result, Is.False);
        }
    }
}