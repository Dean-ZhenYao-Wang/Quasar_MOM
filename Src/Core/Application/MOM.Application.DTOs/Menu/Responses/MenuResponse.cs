using MOM.Application.DTOs.Menu.Requests;

namespace MOM.Application.DTOs.Menu.Responses
{
    public class MenuResponse : MenuRequest
    {
        /// <summary>
        /// 是否有子菜单
        /// </summary>
        public bool IsChild { get; set; } = false;
    }
}