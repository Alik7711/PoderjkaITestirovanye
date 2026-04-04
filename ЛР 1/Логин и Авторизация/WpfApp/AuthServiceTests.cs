using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WpfApp.Tests
{
    [TestClass]
    public class AuthServiceTests
    {
        private AuthService _authService;

        [TestInitialize]
        public void Setup()
        {
            _authService = new AuthService();
        }

        [TestMethod]
        public void Authenticate_ValidCredentials_ReturnsTrue()
        {
            // Arrange
            string username = "user";
            string password = "pass";

            // Act
            bool result = _authService.Authenticate(username, password);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Authenticate_InvalidCredentials_ReturnsFalse()
        {
            // Arrange
            string username = "invalidUser";
            string password = "invalidPass";

            // Act
            bool result = _authService.Authenticate(username, password);

            // Assert
            Assert.IsFalse(result);
        }
    }
}