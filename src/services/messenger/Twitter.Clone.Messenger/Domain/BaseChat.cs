namespace Twitter.Clone.Messenger.Models
{
    public class BaseChat
    {
        public Guid ChatId { get; set; }
        public required string ChatName { get; set; } 
        public required string LastMessageBrief { get; set; }
        public byte UnseenNumbers { get; set; }
        public DateTime LastMessageDateTime { get; set; }

    }
}
