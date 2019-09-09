

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
            string resp = log.Login();
            //Assert.IsTrue(resp);
            if (resp == "success")
            {
                Assert.Pass();
            }
            Assert.Fail();
        }
    }
}