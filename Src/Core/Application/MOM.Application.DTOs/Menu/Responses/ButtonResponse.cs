using MOM.Application.DTOs.Menu.Requests;

namespace MOM.Application.DTOs.Menu.Responses
{
    /// <summary>
    ///
    /// </summary>
    public class ButtonResponse : ButtonRequest
    {
        /// <summary>
        ///
        /// </summary>
        public Guid MenuDtId { get; set; }
    }
}