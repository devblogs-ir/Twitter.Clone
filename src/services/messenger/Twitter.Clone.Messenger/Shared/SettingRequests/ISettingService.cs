namespace Twitter.Clone.Messenger.Shared.SettingRequests
{
    public interface ISettingService
    {
        Task<bool> GetBlockedUser(Guid userId, ICollection<Guid> ParticipantIds);
    }
}
