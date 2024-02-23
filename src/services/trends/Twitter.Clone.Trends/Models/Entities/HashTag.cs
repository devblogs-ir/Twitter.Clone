namespace Twitter.Clone.Trends.Models.Entities;

public class HashTag
{
    public const string TableName = "HashTags";

    public long Id { get; set; }

    public required string Name { get; set; }
 
    public ICollection<HashTagEntry> Entries { get; set; } = null!;
}