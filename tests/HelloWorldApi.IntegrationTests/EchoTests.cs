using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using HelloWorldApi.Host;
using HelloWorldApi.Host.Controllers;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using NUnit.Framework;

namespace HelloWorldApi.IntegrationTests
{
    [TestFixture]
    public class EchoTests
    {
        private TestServer _server;
        private HttpClient _client;

        [OneTimeSetUp]
        public void GivenHelloWorldApi()
        {
            var helloWorldApiHost = new WebHostBuilder()
                                          .UseStartup<Startup>();

            _server = new TestServer(helloWorldApiHost);
            _client = _server.CreateClient();
        }

        [Test]
        public async Task WhenMakingARequestToHello_ThenHelloWorldIsReturned()
        {
            var response = await _client.GetAsync("hello");

            var actualOutput = await response.Content.ReadAsStringAsync();

            Assert.That(actualOutput, Is.EqualTo("Hello world"));
        }
    }
}
