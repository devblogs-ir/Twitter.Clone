using Twitter.Clone.Messenger.Shared.Enums;

namespace Twitter.Clone.Messenger.Models
{
    public class PublicMessageStatus
    {
        public long PublicMessageStatusId { get; set; }
        public long PublicMessageId { get; set; }
        public required PublicMessage PublicMessage { get; set; }
        public Guid UserId { get; set; }
        public MessageStatus SentMessageSatus { get; set; }
        public DateTime DeliverDateTime { get; set; }
        public bool IsDeleted { get; set; }
    }
}