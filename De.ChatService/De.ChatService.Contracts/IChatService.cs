using System.ServiceModel;

namespace De.ChatService.Contracts
{
    [ServiceContract(Namespace = "http://Microsoft.ServiceModel.Samples", SessionMode = SessionMode.Required,
        CallbackContract = typeof (IChatServiceCallback))]
    public interface IChatService
    {
        [OperationContract]
        void Ping();
    }
}