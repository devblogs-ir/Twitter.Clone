namespace Twitter.Clone.Trends.Consumers;

public class NakedHashTagMessageConsumer(TrendsDbContext trendDbContext) : IConsumer<NakedHashTagMessage>
{
    public async Task Consume(ConsumeContext<NakedHashTagMessage> context)
    {
        if (context.Message is null) { return; }

        if (!IsMessageValid(context.Message)) { return; }

        var hashTag = await trendDbContext.HashTags.FirstOrDefaultAsync(x => x.Name == context.Message.Name, context.CancellationToken);
        if (hashTag is null)
        {
            hashTag = HashTag.Create(context.Message.Name);
            await trendDbContext.HashTags.AddAsync(hashTag, context.CancellationToken);
        }

        hashTag.AddEntry(context.Message.OccurredOn, context.Message.IP);
        await trendDbContext.SaveChangesAsync(context.CancellationToken);

        static bool IsMessageValid(NakedHashTagMessage message) => !string.IsNullOrEmpty(message.IP) &&
                                                                   !string.IsNullOrEmpty(message.Name);
    }
}
