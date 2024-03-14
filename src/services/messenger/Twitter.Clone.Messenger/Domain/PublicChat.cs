namespace Twitter.Clone.Messenger.Models
{
    public  class PublicChat : BaseChat
    {
        public Guid CreatorUserId { get; set; }
        public DateTime SendDate { get; set; }
        public virtual ICollection<Participant> Participants { get; set; } = new List<Participant>();
        public virtual ICollection<PublicMessage> PublicMessages { get; set; } = new List<PublicMessage>();

    }
}