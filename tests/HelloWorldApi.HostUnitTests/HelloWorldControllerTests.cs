using HelloWorldApi.Host.Controllers;
using NUnit.Framework;

namespace HelloWorldApi.HostUnitTests
{
    [TestFixture]
    public class HelloWorldControllerTests
    {
        [Test]
        public void GivenHelloWorldController_WhenCallingGet_ThenHelloWorldIsReturned()
        {
            HelloWorldController controller = new HelloWorldController();

            var actualOutput = controller.Get();

            Assert.That(actualOutput, Is.EqualTo("Hello world"));
        }
    }
}
