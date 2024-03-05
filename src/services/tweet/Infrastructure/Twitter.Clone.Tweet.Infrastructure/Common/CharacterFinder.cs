using System.Text.RegularExpressions;

namespace Twitter.Clone.Tweet.Infrastructure.Common
{
    public class CharacterFinder
    {
        public static List<string> FindWordsWith(char character, string input)
        {
            List<string> tags = new List<string>();
            string pattern = $@"{character}\w+";

            Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
            MatchCollection matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                tags.Add(match.Value.Substring(1));
            }

            return tags;
        }
    }
}
