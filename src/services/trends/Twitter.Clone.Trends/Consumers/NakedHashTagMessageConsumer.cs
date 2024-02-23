namespace Twitter.Clone.Trends.Consumers;

public class NakedHashTagMessageConsumer(TrendDbContext trendDbContext) : IConsumer<NakedHashTagMessage>
{
    public async Task Consume(ConsumeContext<NakedHashTagMessage> context)
    {
        if (context.Message is null) { return; }

        await trendDbContext.HashTags.AddAsync(context.Message);
    }
}
