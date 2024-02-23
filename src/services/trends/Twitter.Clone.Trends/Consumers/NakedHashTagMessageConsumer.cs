namespace Twitter.Clone.Trends.Consumers;

public class NakedHashTagMessageConsumer(TrendsDbContext trendDbContext) : IConsumer<NakedHashTagMessage>
{
    public async Task Consume(ConsumeContext<NakedHashTagMessage> context)
    {
        if (context.Message is null) { return; }

        var hashTag = await trendDbContext.HashTags.FindAsync(context.Message.Name, context.CancellationToken);
        if (hashTag is null)
        {
            hashTag = HashTag.Create(context.Message.Name);
            await trendDbContext.HashTags.AddAsync(hashTag, context.CancellationToken);
        }

        hashTag.AddEntry(context.Message.OccurredOn, context.Message.IP);
        await trendDbContext.SaveChangesAsync(context.CancellationToken);
    }
}
