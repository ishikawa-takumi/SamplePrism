using Sample02.Services.Interfaces;

namespace Sample02.Services
{
    public class MessageService : IMessageService
    {
        public string GetMessage()
        {
            return "Hello from the Message Service";
        }
    }
}
