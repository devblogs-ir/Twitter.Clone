using Twitter.Clone.Messenger.Enums;

namespace Twitter.Clone.Messenger.Models
{
    public class PrivateMessage
    {
        public long PrivateMessageId { get; set; }
        public required string MessageBody { get; set; }
        public bool IsForStarter { get; set; }
        public MessageStatus MessageStatus { get; set; }
        public bool IsDeletedForStarter { get; set; }
        public bool IsDeletedForTarget{ get; set; }
        public DateTime DeliverDateTime { get; set; }
        public bool IsEdited { get; set; }
        public Guid PrivateChatId { get; set; }
        public required virtual PrivateChat PrivateChat { get; set; }
    }
}