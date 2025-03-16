namespace MOM.Application.Infrastructure.Middlewares
{
    // 自定义异常类型
    public class CommandExecutionException : Exception
    {
        public string ErrorCode { get; }

        public CommandExecutionException(string message, Exception inner, string code = "SYSTEM_ERROR")
            : base(message, inner)
        {
            ErrorCode = code;
        }
    }
}
