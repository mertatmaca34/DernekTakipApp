namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        public Result(bool success, string message) : this(success)
        {
            Message = message;
        }

        public Result(bool success)
        {
            Success = success;
            Message = "";
        }

        public bool Success { get; }
        public string Message { get; }
    }
}
