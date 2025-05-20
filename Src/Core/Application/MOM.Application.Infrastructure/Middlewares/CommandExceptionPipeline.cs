using MediatR;
using Microsoft.Extensions.Logging;
using MOM.Application.Wrappers;

namespace MOM.Application.Infrastructure.Middlewares
{
    public class CommandExceptionPipeline<TRequest, TResponse>
    : IPipelineBehavior<TRequest, TResponse>
    where TRequest : IRequest<TResponse>
    {
        private readonly ILogger<CommandExceptionPipeline<TRequest, TResponse>> _logger;

        public CommandExceptionPipeline(
            ILogger<CommandExceptionPipeline<TRequest, TResponse>> logger)
        {
            _logger = logger;
        }

        public async Task<TResponse> Handle(
            TRequest request,
            RequestHandlerDelegate<TResponse> next,
            CancellationToken ct)
        {
            try
            {
                return await next();
            }
            catch (Exception ex)
            {
                // 结构化日志记录
                _logger.LogError(ex, "命令处理失败: {CommandType} {@CommandData}",
                    typeof(TRequest).Name,
                    Sanitize(request));

                // 遥测数据采集
                var properties = new Dictionary<string, string>
                {
                    ["CommandType"] = typeof(TRequest).Name,
                    ["ExceptionType"] = ex.GetType().Name
                };

                // 返回错误响应（适配BaseResult）
                if (typeof(TResponse) == typeof(BaseResult))
                {
                    return (TResponse)(object)BaseResult.Failure(new Error(ErrorCode.Exception, "COMMAND_FAILED", ex.Message));
                }

                throw new CommandExecutionException("命令执行失败", ex);
            }
        }

        private object Sanitize(TRequest request)
        {
            // 实现敏感数据过滤逻辑
            return new
            {
                request.GetType().Name,
                SafeProperties = request.GetType()
                    .GetProperties()
                    .ToDictionary(p => p.Name, p => p.Name == "Password" ? "***" : p.GetValue(request))
            };
        }
    }
}