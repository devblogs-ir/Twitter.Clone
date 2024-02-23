namespace Twitter.Clone.Trends.Exceptions;

public sealed class AppSettingsNullReferenceException : Exception
{
    private const string _message = "The settings for the {0} to run the service were not found.";

    public AppSettingsNullReferenceException(string settingName)
        : base(string.Format(_message, settingName))
    {
            
    }
}
