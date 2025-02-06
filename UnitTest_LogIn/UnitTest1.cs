using NUnit.Framework;
using Moq;
using TP_POO_A25447.BLL;
using TP_POO_A25447.Models;
using TP_POO_A25447.DAL;


namespace TP_POO_A25447.Tests
{
    [TestFixture]
    public class AuthServiceTests
    {
        private AuthService _authService;
        private Mock<ILandlordRepository> _mockRepo;

        [SetUp]
        public void Setup()
        {
            _mockRepo = new Mock<ILandlordRepository>();
            _authService = new AuthService(_mockRepo.Object);
        }

        [Test]
        public void Authenticate_ReturnsTrue_WhenCredentialsAreValid()
        {
            // Arrange
            _mockRepo.Setup(repo => repo.GetLandlord())
                     .Returns(new TP_POO_A25447.Models.Landlord("Rik", "1234", "123456789"));

            // Act
            bool result = _authService.Authenticate("Rik", "1234");

            // Assert
            Assert.IsTrue(result);
        }


        [Test]
        public void Authenticate_ReturnsFalse_WhenPasswordIsIncorrect()
        {
            // Arrange
            _mockRepo.Setup(repo => repo.GetLandlord())
                     .Returns(new Landlord("Rik", "1234", "123456789"));

            // Act
            bool result = _authService.Authenticate("Rik", "wrongpassword");

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void Authenticate_ReturnsFalse_WhenUsernameIsIncorrect()
        {
            // Arrange
            _mockRepo.Setup(repo => repo.GetLandlord())
                     .Returns(new Landlord("Rik", "1234", "123456789"));

            // Act
            bool result = _authService.Authenticate("WrongUser", "1234");

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void Authenticate_ReturnsFalse_WhenLandlordDoesNotExist()
        {
            // Arrange - Simula um landlord inexistente
            _mockRepo.Setup(repo => repo.GetLandlord()).Returns((Landlord)null);

            // Act
            bool result = _authService.Authenticate("Rik", "1234");

            // Assert
            Assert.IsFalse(result);
        }
    }
}
