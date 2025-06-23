using MOM.Domain.Common.EnumType;

namespace MOM.Application.DTOs.HierarchyScope.Requests
{
    /// <summary>
    ///
    /// </summary>
    public class OrgRequest
    {
        /// <summary>
        /// 组织编号
        /// </summary>
        public string? Id { get; set; }

        /// <summary>
        /// 组织名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 层次结构范围设备级别
        /// </summary>
        public HierarchyScopeEquipmentLevel EquipmentLevel { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        public string? Address { get; set; }

        /// <summary>
        /// 负责人的DtId
        /// </summary>
        public Guid? ResponsibleDtId { get; set; }

        /// <summary>
        /// 上级组织DtId
        /// </summary>
        public Guid? SourceDtId { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// 激活--默认处于禁用状态。
        /// 禁用后，这将阻止跟踪和追溯、OEE 停机时间、SPC、设置和转换以及调度模块使用该区域及其下方的任何其他生产项目
        /// </summary>
        public bool Active { get; set; }

        /// <summary>
        ///
        /// </summary>
        public virtual Domain.isa95.CommonObjectModels.HierarchyScope ToHierarchyScope()
        {
            Domain.isa95.CommonObjectModels.HierarchyScope hierarchyScope = new Domain.isa95.CommonObjectModels.HierarchyScope(this.EquipmentLevel, this.Id, this.Name, this.Address, this.Active, this.Description, this.SourceDtId);
            hierarchyScope.ResponsibleDtId = this.ResponsibleDtId;
            hierarchyScope.Address = this.Address;
            return hierarchyScope;
        }
    }
}