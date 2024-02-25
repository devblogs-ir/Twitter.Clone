namespace Twitter.Clone.Messenger.Models    
{
    public class PublicMessage
    {
        public long PublicMessageId { get; set; }
        public required string MessageBody { get; set; }
        public Guid MessageOwner { get; set; }
        public DateTime SentDateTime { get; set; }
        public bool IsEdited { get; set; }
        public required ICollection<PublicMessageStatus> Participants { get; set; }
        public Guid ChatId { get; set; }
        public required PublicChat PublicChat { get; set; }
}
}