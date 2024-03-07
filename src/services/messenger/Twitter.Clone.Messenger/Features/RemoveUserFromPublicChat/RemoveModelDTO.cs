namespace Twitter.Clone.Messenger.Features.RemoveUserFromPublicChat
{
    public class RemoveModelDTO
    {
        public Guid PublicChatId { get; set; }
        public Guid IntendToRemoveUserId { get; set; }

        public required string ApplicationFeedBack { get; set; }
        public bool OperationResult { get; set; }
    }
}
