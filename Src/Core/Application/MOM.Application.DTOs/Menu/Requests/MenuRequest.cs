namespace MOM.Application.DTOs.Menu.Requests
{
    /// <summary>
    ///
    /// </summary>
    public class MenuRequest
    {
        /// <summary>
        ///
        /// </summary>
        public Guid DtId { get; set; } = Guid.NewGuid();

        /// <summary>
        ///
        /// </summary>
        public Guid? ParentMenuDtId { get; set; }

        /// <summary>
        /// 编号
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        ///
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        public string? Icon { get; set; }

        /// <summary>
        /// 是否隐藏菜单
        /// </summary>
        public bool Hidden { get; set; }

        /// <summary>
        /// 是否总是显示
        /// </summary>
        public bool AlwaysShow { get; set; }

        /// <summary>
        /// 第几层的菜单
        /// </summary>
        public int Depth { get; set; }

        /// <summary>
        ///
        /// </summary>
        public MOM.Domain.Permission.Menu ToMenu()
        {
            return new Domain.Permission.Menu
            {
                DtId = DtId,
                ParentMenuDtId = ParentMenuDtId,
                Id = Id,
                Name = Name,
                Path = Path,
                Description = Description,
                Icon = Icon,
                Hidden = Hidden,
                AlwaysShow = AlwaysShow,
                Depth = Depth
            };
        }
    }
}