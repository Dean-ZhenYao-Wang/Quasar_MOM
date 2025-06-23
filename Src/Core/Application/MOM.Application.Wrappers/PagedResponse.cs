namespace MOM.Application.Wrappers
{
    public class PagedResponse<T> : BaseResult<List<T>>
    {
        /// <summary>
        /// 查看的页数
        /// </summary>
        public int Page { get; set; }

        /// <summary>
        /// 每页显示的数据条数
        /// </summary>
        public int PageSize { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        public int TotalPages { get; set; }

        /// <summary>
        /// 数据总条数
        /// </summary>
        public int TotalItems { get; set; }

        public static PagedResponse<T> Ok(PaginationResponseDto<T> model)
        {
            return new PagedResponse<T>
            {
                Success = true,
                Data = model.Data,
                Page = model.PageNumber,
                PageSize = model.PageSize,
                TotalItems = model.Count,
                TotalPages = (int)Math.Ceiling(model.Count / (double)model.PageSize)
            };
        }

        public new static PagedResponse<T> Failure(Error error)
            => new() { Success = false, Errors = [error] };

        public new static PagedResponse<T> Failure(IEnumerable<Error> errors)
            => new() { Success = false, Errors = errors.ToList() };

        public static implicit operator PagedResponse<T>(PaginationResponseDto<T> model)
            => Ok(model);

        public static implicit operator PagedResponse<T>(Error error)
            => new() { Success = false, Errors = [error] };

        public static implicit operator PagedResponse<T>(List<Error> errors)
            => new() { Success = false, Errors = errors };
    }
}