namespace Twitter.Clone.Messenger.Models
{
    public class Participant
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        //public bool IsOwner { get; set; }
        //public bool IsAdmin { get; set; }
        //public bool CanSendMessage { get; set; }
        public Guid PublicMessageId { get; set; }

        public PublicChat? PublicChat { get; set; }
    }
}
