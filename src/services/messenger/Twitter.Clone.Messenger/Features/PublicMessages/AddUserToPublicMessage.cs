using MediatR;
using Twitter.Clone.Messenger.Models;
using Twitter.Clone.Messenger.ServiceManager;

namespace Twitter.Clone.Messenger.Features.PublicMessages
{
    public class AddUserToPublicMessage
    {
        //Input
        public class AddUserCommand : IRequest<AddUserResponse>
        {
            public Guid UserId { get; set; }
            public Guid PublicMessageId { get; set; }
        }

        //Output
        public class AddUserResponse
        {
            public string? ConfirmationResponse { get; set; }
        }

        //Handler
        public class Handler : IRequestHandler<AddUserCommand, AddUserResponse>
        {
            private readonly IServiceManager _serviceManager;
            private readonly ILogger<Handler> _logger;
            //private readonly IMapper _mapper;

            public Handler(IServiceManager serviceManager, ILogger<Handler> logger)
            {
                _serviceManager = serviceManager;
                _logger = logger;
            }

            public async Task<AddUserResponse> Handle(AddUserCommand request, CancellationToken cancellationToken)
            {
                var publicMessage = await _serviceManager.PublicMessageService.GetPublicMessageByIdAsync(request.PublicMessageId);

                if (publicMessage == null)
                {
                    return new AddUserResponse { ConfirmationResponse = "Public message not found" };
                }

                var isParticipantExist = publicMessage.Participants.Any(par => par.UserId == request.UserId);

                if (isParticipantExist)
                {
                    return new AddUserResponse { ConfirmationResponse = "User already in public message" };
                }

                var participantIds = publicMessage.Participants.Select(par => par.Id).ToList();

                var isUserBlocked = await _serviceManager.SettingService.GetBlockedUser(request.UserId, participantIds);

                if (isUserBlocked == false)
                {
                    var participant = new Participant
                    {
                        Id = Guid.NewGuid(),
                        UserId = request.UserId,
                        PublicMessageId = request.PublicMessageId
                    };

                    publicMessage.Participants.Add(participant);
                    await _serviceManager.SaveAsync();

                    //var result = _mapper.Map<GameResult>(game);
                    return new AddUserResponse { ConfirmationResponse = "User added to public message" };
                }
                else
                {
                    return new AddUserResponse { ConfirmationResponse = "User is blocked" };
                }
            }
        }
    }
}
