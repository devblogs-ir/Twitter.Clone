namespace Twitter.Clone.Messenger.Models
{
    public partial class PrivateChat : BaseChat
    {
        public Guid StarterUserId { get; set; }
        public Guid TargetUserId { get; set; }
        public bool IsDeletedForStarter { get; set; }
        public bool IsDeletedForTarget { get; set; }
        public virtual ICollection<PrivateMessage> PrivateMessages { get; set; } = new List<PrivateMessage>();
    }
}