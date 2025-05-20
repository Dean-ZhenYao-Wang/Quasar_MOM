namespace MOM.Application.Wrappers
{
    public class PaginationRequestParameter
    {
        /// <summary>
        /// Ҫ�鿴��ҳ������1��ʼ��
        /// </summary>
        public int PageNumber { get; set; }

        /// <summary>
        /// ÿҳ��ʾ��������
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