using System;
using System.Threading.Tasks;

namespace ClickToEat.MessageBus
{
    public interface IMessageBus
    {
        Task PublishMessage(BaseMessage message, string topicName);
    }
}
