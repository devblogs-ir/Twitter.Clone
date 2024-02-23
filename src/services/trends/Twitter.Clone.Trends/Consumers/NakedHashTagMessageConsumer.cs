namespace Twitter.Clone.Trends.Consumers;

public class NakedHashTagMessageConsumer(TrendsDbContext trendDbContext) : IConsumer<NakedHashTagMessage>
{
    public async Task Consume(ConsumeContext<NakedHashTagMessage> context)
    {
        if (context.Message is null) { return; }





        var hashTag = new HashTag
        {
            Name = context.Message.Name,
        };

        await trendDbContext.HashTags.AddAsync(hashTag, context.CancellationToken);
        await trendDbContext.SaveChangesAsync(context.CancellationToken);
    }
}
