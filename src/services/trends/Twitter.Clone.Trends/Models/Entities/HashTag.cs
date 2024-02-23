
namespace Twitter.Clone.Trends.Models.Entities;

public class HashTag
{
    public const string TableName = "HashTags";

    public long Id { get; set; }

    public required string Name { get; set; }

    public ICollection<HashTagEntry> Entries { get; set; } = null!;

    public static HashTag Create(string name)
        => new HashTag { Name = name };

    public void AddEntry(DateTime occurredOn, string ipAddress)
    {
        Entries ??= new List<HashTagEntry>();

        Entries.Add(new HashTagEntry
        {
            CreatedOn = occurredOn,
            Processed = false,
            IPAddress = ipAddress,
        });
    }
}