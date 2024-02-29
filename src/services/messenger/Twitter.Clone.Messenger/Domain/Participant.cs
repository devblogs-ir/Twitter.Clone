namespace Twitter.Clone.Messenger.Models
{
    public class Participant
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public bool IsOwner { get; set; }
        public bool IsAdmin { get; set; }
        public bool CanSendMessage { get; set; }
        public required string FirstName { get; set; }
        public bool LastName { get; set; }
        public required PublicChat PublicChat { get; set; }
    }
}
