namespace DesignPatterns.PubSubPattern
{
    public class MessageEventArgs
    {
        public string Message { get; set; }
        public MessageEventArgs(string message)
        {
            Message = message;
        }
    }
}