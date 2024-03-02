namespace Twitter.Clone.Timeline.ExceptionHandling
{
    public class CustomException : Exception
    {
        public CustomException(string message):base(message =message??"Error!!") { }
    }
    public class NullException : Exception
    {
        public NullException() : base("this field can not be null!!") { }
    }
}
