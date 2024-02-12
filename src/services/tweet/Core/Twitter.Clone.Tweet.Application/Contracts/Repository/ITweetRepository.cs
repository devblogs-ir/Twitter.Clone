namespace Twitter.Clone.Tweet.Application.Contracts.Repository;

using Twitter.Clone.Tweet.Domain.Entities;

public interface ITweetRepository
{ 
    Task CreateAsync(TweetEntity entity);
}