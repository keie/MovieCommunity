

namespace Tests
{
    using MovieCommunity.Controllers;
    using NUnit.Framework;
    public class LoginTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void LoginUser()
        {
            LoginController log = new LoginController();
            bool resp = log.Login();
            Assert.IsTrue(resp);
        }
    }
}