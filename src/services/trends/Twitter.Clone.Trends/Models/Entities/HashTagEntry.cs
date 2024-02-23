namespace Twitter.Clone.Trends.Models.Entities;

public class HashTagEntry
{
    public const string TableName = "HashTagEntries";

    public long Id { get; set; }

    public long HashTagId { get; set; }

    public bool Processed { get; set; }

    public DateTime CreatedOn { get; set; }
}
