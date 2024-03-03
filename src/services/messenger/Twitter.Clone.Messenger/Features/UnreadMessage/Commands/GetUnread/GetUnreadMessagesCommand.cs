using MediatR;
using Twitter.Clone.Messenger.Models;
using Twitter.Clone.Messenger.Shared.Enums;

namespace Twitter.Clone.Messenger.Features.UnreadMessage.Commands.GetUnread;

public class GetUnreadMessagesCommand : IRequest<IEnumerable<GetUnreadMessagesResponse>>
{
    public required string UserId { get; set; }
}


//public long PrivateMessageId { get; set; }
//public required string MessageBody { get; set; }
//public bool IsForStarter { get; set; }
//public MessageStatus MessageStatus { get; set; }
//public bool IsDeletedForStarter { get; set; }
//public bool IsDeletedForTarget { get; set; }
//public DateTime DeliverDateTime { get; set; }
//public bool IsEdited { get; set; }
//public Guid PrivateChatId { get; set; }
//public required virtual PrivateChat PrivateChat { get; set; }



public class GetUnreadMessagesResponse
{
    public long PrivateMessageId { get; set; }
    public required string MessageBody { get; set; }
}


