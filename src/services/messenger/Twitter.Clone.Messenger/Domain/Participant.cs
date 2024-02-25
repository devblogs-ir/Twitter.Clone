namespace Twitter.Clone.Messenger.Models
{
    public class Participant
    {
        public Guid UserId { get; set; }
        public bool IsOwner { get; set; }
        public bool IsAdmin { get; set; }
        public bool CanSendMessage { get; set; }
        public string FirstName { get; set; }
        public bool LastName { get; set; }
        public PublicChat PublicChat { get; set; }
    }
}
