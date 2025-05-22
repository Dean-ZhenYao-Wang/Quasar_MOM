namespace MOM.Application.Wrappers
{
    public class PaginationRequestParameter
    {
        /// <summary>
        /// Ҫ�鿴��ҳ������1��ʼ��
        /// </summary>
        public int Page { get; set; }

        /// <summary>
        /// ÿҳ��ʾ��������
        /// </summary>
        public int PageSize { get; set; }

        public PaginationRequestParameter()
        {
            Page = 1;
            PageSize = 20;
        }

        public PaginationRequestParameter(int pageNumber, int pageSize)
        {
            Page = pageNumber < 1 ? 1 : pageNumber;
            PageSize = pageSize;
        }
    }
}