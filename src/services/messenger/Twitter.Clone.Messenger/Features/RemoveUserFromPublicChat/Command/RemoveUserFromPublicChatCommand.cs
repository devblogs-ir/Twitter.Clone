using MediatR;
using Twitter.Clone.Messenger.Models;

namespace Twitter.Clone.Messenger.Features.RemoveUserFromPublicChat.Command
{
    public record RemoveUserFromPublicChatCommand(RemoveModelDTO ModelDTO) : IRequest<RemoveModelDTO>;

}
