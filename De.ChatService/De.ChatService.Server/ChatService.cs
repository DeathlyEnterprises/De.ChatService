using De.ChatService.Contracts;

namespace De.ChatService.Server
{
    public class ChatService : IChatService
    {
        public void Ping()
        {
        }

        public string Echo(string message)
        {
            return message;
        }
    }
}