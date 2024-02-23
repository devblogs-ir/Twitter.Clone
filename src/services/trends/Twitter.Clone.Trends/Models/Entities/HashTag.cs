using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Twitter.Clone.Trends.Models.Entities;

public class HashTag
{
    public const string TableName = "HashTags";

    public Guid Id { get; set; }

    public bool Processed { get; set; }

    public required string Name { get; set; }

    public DateTime CreatedOn { get; set; }
}
