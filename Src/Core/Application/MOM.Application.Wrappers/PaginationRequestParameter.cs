namespace MOM.Application.Wrappers
{
    public class PaginationRequestParameter
    {
        /// <summary>
        /// 要查看的页数：从1开始数
        /// </summary>
        public int PageNumber { get; set; }

        /// <summary>
        /// 每页显示数据条数
        /// </summary>
        public int PageSize { get; set; }

        public PaginationRequestParameter()
        {
            PageNumber = 1;
            PageSize = 20;
        }

        public PaginationRequestParameter(int pageNumber, int pageSize)
        {
            PageNumber = pageNumber < 1 ? 1 : pageNumber;
            PageSize = pageSize;
        }
    }
}