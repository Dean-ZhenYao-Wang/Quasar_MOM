using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOM.Application.DTOs.Permission.Requests
{
    public class SettingPermissionRequest
    {
        public required List<string> menuButtonIds { get; set; } = new List<string>();
        public required Guid Owner { get; set; }
    }
}
