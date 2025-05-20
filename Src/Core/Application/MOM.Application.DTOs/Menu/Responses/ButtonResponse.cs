using MOM.Application.DTOs.Menu.Requests;

namespace MOM.Application.DTOs.Menu.Responses
{
    public class ButtonResponse : ButtonRequest
    {
        public Guid MenuDtId { get; set; }
    }
}