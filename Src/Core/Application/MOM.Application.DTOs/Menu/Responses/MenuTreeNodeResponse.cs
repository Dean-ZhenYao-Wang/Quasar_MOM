using MOM.Application.DTOs.Menu.Requests;

namespace MOM.Application.DTOs.Menu.Responses
{
    public class MenuTreeNodeResponse : MenuRequest
    {
        public List<MenuTreeNodeResponse> Children { get; set; } = new();
    }
}
