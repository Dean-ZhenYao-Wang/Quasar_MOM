namespace MOM.Application.DTOs.Permission.Requests
{
    /// <summary>
    ///
    /// </summary>
    public class SettingPermissionRequest
    {
        /// <summary>
        /// 菜单或按钮的DtId清单
        /// </summary>
        public List<string> menuButtonIds { get; set; } = new List<string>();

        /// <summary>
        /// 所有者DtId,谁对这些菜单和按钮具有权限
        /// </summary>
        public Guid Owner { get; set; }
    }
}