namespace Backend
{
    public interface IMessageHubClient
    {
        Task SendOffersToUser( List<string> message );


        Task SendMessageToChatroom( Message message );
    }

}
