using NUnit.Framework;
using TestWeb.Controllers;

namespace TestWeb.Tests.Controllers
{
    [TestFixture]
    public class HomeControllerTest
    {
        [Test]
        public void IndexTest()
        {
            var controller = new HomeController();
            var view = controller.Index();
            Assert.NotNull(view);
        }
    }
}
