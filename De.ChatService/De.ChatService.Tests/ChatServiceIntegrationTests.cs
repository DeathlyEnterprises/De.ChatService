using De.ChatService.Contracts;
using De.Client;
using De.Server;
using NUnit.Framework;

namespace De.ChatService.Tests
{
    [TestFixture]
    public class ChatServiceIntegrationTests
    {
        [Test]
        public void ConnectAndPing()
        {
            var server = new Server<Server.ChatService, IChatService>("localhost", "12345", "IntegrationTest");
            server.StartServer();

            var client = new Client<IChatService>("localhost", "12345", "IntegrationTest");
            client.Connect();
            client.GetService().Ping();
            client.Disconnect();

            server.StopServer();
        }
    }
}