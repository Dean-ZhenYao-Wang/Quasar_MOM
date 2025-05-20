namespace MOM.Application.Wrappers
{
    public class BaseResult
    {
        /// <summary>
        /// 业务处理状态<br>true: 业务处理成功；false: 业务处理失败</br>
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// 错误信息，Success为false时此处才有元素
        /// </summary>
        public List<Error> Errors { get; set; }

        public static BaseResult Ok()
            => new() { Success = true };

        public static BaseResult Failure()
            => new() { Success = false };

        public static BaseResult Failure(Error error)
            => new() { Success = false, Errors = [error] };

        public static BaseResult Failure(IEnumerable<Error> errors)
            => new() { Success = false, Errors = errors.ToList() };

        public static implicit operator BaseResult(Error error)
            => new() { Success = false, Errors = [error] };

        public static implicit operator BaseResult(List<Error> errors)
            => new() { Success = false, Errors = errors };

        public BaseResult AddError(Error error)
        {
            Errors ??= [];
            Errors.Add(error);
            Success = false;
            return this;
        }
    }

    public class BaseResult<TData> : BaseResult
    {
        /// <summary>
        /// 数据
        /// </summary>
        public TData Data { get; set; }

        public static BaseResult<TData> Ok(TData data)
            => new() { Success = true, Data = data };

        public new static BaseResult<TData> Failure()
            => new() { Success = false };

        public new static BaseResult<TData> Failure(Error error)
            => new() { Success = false, Errors = [error] };

        public new static BaseResult<TData> Failure(IEnumerable<Error> errors)
            => new() { Success = false, Errors = errors.ToList() };

        public static implicit operator BaseResult<TData>(TData data)
            => new() { Success = true, Data = data };

        public static implicit operator BaseResult<TData>(Error error)
            => new() { Success = false, Errors = [error] };

        public static implicit operator BaseResult<TData>(List<Error> errors)
            => new() { Success = false, Errors = errors };
    }
}