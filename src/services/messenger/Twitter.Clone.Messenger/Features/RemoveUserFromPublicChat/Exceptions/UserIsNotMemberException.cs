using System.Runtime.Serialization;

namespace Twitter.Clone.Messenger.Features.RemoveUserFromPublicChat.Exceptions
{
    [Serializable]
    internal class UserIsNotMemberOfChatException : Exception
    {
        public UserIsNotMemberOfChatException() : base("This User is not member of this conversation")
        {
        }

        public UserIsNotMemberOfChatException(string? message) : base(message)
        {
        }

        public UserIsNotMemberOfChatException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}