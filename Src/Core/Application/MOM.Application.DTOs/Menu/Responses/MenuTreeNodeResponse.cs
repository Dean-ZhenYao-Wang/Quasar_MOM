using MOM.Application.DTOs.Menu.Requests;

namespace MOM.Application.DTOs.Menu.Responses
{
    /// <summary>
    ///
    /// </summary>
    public class MenuTreeNodeResponse : MenuRequest
    {
        /// <summary>
        ///
        /// </summary>
        public List<MenuTreeNodeResponse> Children { get; set; } = new();
    }
}