using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOM.Application.DTOs.Permission.Requests
{
    public class SettingPermissionRequest
    {
        /// <summary>
        /// 菜单或按钮的DtId清单
        /// </summary>
        public required List<string> menuButtonIds { get; set; } = new List<string>();
        /// <summary>
        /// 所有者DtId,谁对这些菜单和按钮具有权限
        /// </summary>
        public required Guid Owner { get; set; }
    }
}
