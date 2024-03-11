using MassTransit;

using Twitter.Clone.MessagingContracts.Notifier;

namespace Twitter.Clone.Notifier.Host.Consumers;

public class MentionMessageConsumer() : IConsumer<MentionMessage>
{
    public async Task Consume(ConsumeContext<MentionMessage> context)
    {
        if (context.Message is null) { return; }
            
    }
}
