using MOM.Application.DTOs.Menu.Responses;

namespace MOM.Application.DTOs.Menu
{
    /// <summary>
    ///
    /// </summary>
    public static class MenuException
    {
        /// <summary>
        ///
        /// </summary>
        public static MenuTreeNodeResponse ToMenuTreeNodeResponse(this Domain.Permission.Menu menu)
        {
            return new MenuTreeNodeResponse
            {
                DtId = menu.DtId,
                ParentMenuDtId = menu.ParentMenuDtId,
                Id = menu.Id,
                Name = menu.Name,
                Path = menu.Path,
                Description = menu.Description,
                Icon = menu.Icon,
                Hidden = menu.Hidden,
                AlwaysShow = menu.AlwaysShow,
                Depth = menu.Depth,
                Children = menu.Children.Select(c => c.ToMenuTreeNodeResponse()).OrderBy(c => c.Id).ToList(),
            };
        }
    }
}