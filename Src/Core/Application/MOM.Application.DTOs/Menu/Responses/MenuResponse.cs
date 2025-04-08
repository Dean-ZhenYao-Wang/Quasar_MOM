using MOM.Application.DTOs.Menu.Requests;
using MOM.Domain.Permission;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
