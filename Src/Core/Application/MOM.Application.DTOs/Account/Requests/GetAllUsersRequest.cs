using MOM.Application.Wrappers;

namespace MOM.Application.DTOs.Account.Requests
{
    /// <summary>
    ///
    /// </summary>
    public class GetAllUsersRequest : PaginationRequestParameter
    {
        /// <summary>
        ///
        /// </summary>
        public string Name { get; set; }
    }
}