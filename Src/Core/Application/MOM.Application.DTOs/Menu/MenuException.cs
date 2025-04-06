using MOM.Application.DTOs.Menu.Responses;
using MOM.Application.DTOs.Resource.Responses;
using MOM.Domain.isa95.CommonObjectModels.Part2.Personnel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOM.Domain.Permission
{
    public static class MenuException
    {
        public static MenuTreeNodeResponse ToMenuTreeNodeResponse(this Menu menu, Guid? parentMenuDtId)
        {
            return new MenuTreeNodeResponse
            {
                DtId = menu.DtId,
                ParentMenuDtId = parentMenuDtId,
                Id = menu.Id,
                Name = menu.Name,
                Path = menu.Path,
                Description = menu.Description,
                Icon = menu.Icon,
                Hidden = menu.Hidden,
                AlwaysShow = menu.AlwaysShow,
                Depth = menu.Depth,
                Children = menu.Children.Select(c => c.ToMenuTreeNodeResponse(menu.DtId)).OrderBy(c => c.Id).ToList(),
            };
        }
    }
}
