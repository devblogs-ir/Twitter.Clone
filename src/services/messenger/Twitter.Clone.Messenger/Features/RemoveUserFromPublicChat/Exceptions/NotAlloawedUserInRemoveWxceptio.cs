using System.Runtime.Serialization;

namespace Twitter.Clone.Messenger.Features.RemoveUserFromPublicChat.Exceptions
{
    [Serializable]
    internal class NotAlloawedUserInRemoveFromChatException : Exception
    {
        public NotAlloawedUserInRemoveFromChatException()
        {
        }

        public NotAlloawedUserInRemoveFromChatException(string? message) : base(message)
        {
        }

        public NotAlloawedUserInRemoveFromChatException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        
    }
}