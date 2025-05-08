using Moq;
using PropertyManager.Application.Exceptions;

namespace PropertyManager.Application.UnitTest.Exceptions
{
    [TestFixture]
    public class DbContextExceptionTests
    {
        [Test]
        public void DbContextException_WithMessage_ShouldMatchExpected()
        {
            // Arrange
            const string expectedMessage = "Test message";
            // Act
            var actual = new DbContextException(expectedMessage);
            // Assert
       
            Assert.That(actual.Message, Is.EqualTo(expectedMessage));
        }

        [Test]
        public void DbContextException_WithMessageAndInnerException_ReturnsExpected()
        {
            // Arrange
            const string expectedMessage = "Test message";
            var innerException = new Mock<Exception>();
            // Act
            var actual = new DbContextException(expectedMessage, innerException.Object);
            // Assert
      
            Assert.That(actual.Message, Is.EqualTo(expectedMessage));
            Assert.That(actual.InnerException, Is.EqualTo(innerException.Object));
        }

    
    }
}
