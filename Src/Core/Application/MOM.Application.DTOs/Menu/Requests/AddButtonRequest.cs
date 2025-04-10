using MOM.Domain.Permission;

namespace MOM.Application.DTOs.Menu.Requests
{
    public class AddButtonRequest:ButtonRequest
    {
        public required Guid MenuDtId { get; set; }
        public Button ToButton()
        {
            Button model = new Button()
            {
                MenuDtId = MenuDtId,
                Id = Id,
                Name = Name,
                Icon = Icon,
            };
            return model;
        }
    }
}