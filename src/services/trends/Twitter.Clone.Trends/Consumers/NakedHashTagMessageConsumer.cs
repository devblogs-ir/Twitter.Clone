namespace Twitter.Clone.Trends.Consumers;

public class NakedHashTagMessageConsumer(TrendsDbContext trendDbContext) : IConsumer<NakedHashTagMessage>
{
    public async Task Consume(ConsumeContext<NakedHashTagMessage> context)
    {
        if (context.Message is null) { return; }

        var hashTag = new HashTag
        {
            Name = context.Message.Name,
            CreatedOn = DateTime.UtcNow,
            Id = context.MessageId ?? Guid.NewGuid(),
            Processed = false
        };

        await trendDbContext.HashTags.AddAsync(hashTag, context.CancellationToken);
        await trendDbContext.SaveChangesAsync(context.CancellationToken);
    }
}
