using MOM.Domain.Permission;

namespace MOM.Application.DTOs.Menu.Requests
{
    /// <summary>
    ///
    /// </summary>
    public class AddButtonRequest : ButtonRequest
    {
        /// <summary>
        ///
        /// </summary>
        public Guid MenuDtId { get; set; }

        /// <summary>
        ///
        /// </summary>
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