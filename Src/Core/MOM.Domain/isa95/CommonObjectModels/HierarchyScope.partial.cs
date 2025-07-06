using MOM.Domain.Common.EnumType;
using MOM.Domain.isa95.CommonObjectModels.Part2.Personnel;
using MOM.Domain.Permission;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MOM.Domain.isa95.CommonObjectModels
{
    /// <summary>
    /// 设备角色层次结构，逻辑工厂结构
    /// </summary>
    public partial class HierarchyScope
    {
        /// <summary>
        /// 路径
        /// </summary>
        public string FullPath { get; set; } = string.Empty;

        /// <summary>
        /// 说明
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// 负责人DtId
        /// </summary>
        public Guid? ResponsibleDtId { get; set; }

        /// <summary>
        /// 负责人
        /// </summary>
        [JsonIgnore]
        [ForeignKey(nameof(ResponsibleDtId))]
        public virtual Person? Responsible { get; set; }

        /// <summary>
        /// 负责人姓名
        /// </summary>
        public string? ResponsibleName
        {
            get
            {
                return Responsible?.Name;
            }
        }

        /// <summary>
        /// 激活--默认处于禁用状态。
        /// 禁用后，这将阻止跟踪和追溯、OEE 停机时间、SPC、设置和转换以及调度模块使用该区域及其下方的任何其他生产项目
        /// </summary>
        public bool Active { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        public string? Address { get; set; }

        /// <summary>
        /// 权限清单
        /// </summary>
        public virtual List<OrgPermission> Permissions { get; set; } = new List<OrgPermission>();

        /// <summary>
        /// 班组清单
        /// </summary>
        public virtual List<PersonnelClass> Teams { get; set; } = new List<PersonnelClass>();

        /// <summary>
        /// 人员清单
        /// </summary>
        public virtual List<Person> Peoples { get; set; } = new List<Person>();

        /// <summary>
        /// 父级唯一标识
        /// </summary>
        public Guid? SourceDtId { get; set; }

        /// <summary>
        /// 父级
        /// </summary>
        [ForeignKey(nameof(SourceDtId))]
        public virtual HierarchyScope Source { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <param name="equipmentLevel"></param>
        /// <param name="Id"></param>
        /// <param name="name"></param>
        /// <param name="address"></param>
        /// <param name="active"></param>
        /// <param name="description"></param>
        /// <param name="sourceDtId"></param>
        public HierarchyScope(HierarchyScopeEquipmentLevel equipmentLevel, string Id, string name, string? address = null, bool active = false, string? description = null, Guid? sourceDtId = null)
        {
            EquipmentLevel = equipmentLevel;
            this.Id = Id;
            this.Name = name;
            Address = address;
            Description = description;
            Active = active;
            SourceDtId = sourceDtId;
            if (sourceDtId == null)
                FullPath = this.Name;
        }

        /// <summary>
        /// 软删除，存在子级，无法删除
        /// </summary>
        /// <exception cref="MethodAccessException"></exception>
        public virtual void Delete()
        {
            this.IsDelete = true;
            if (this.Contains.Any(st => st.IsDelete == false))
            {
                throw new MethodAccessException("存在子级，无法删除，是否强制删除(强制删除时子级也将会被删除)。");
            }
            else
            {
                this.ForcedDeletion();
            }
        }

        /// <summary>
        /// 强制删除
        /// </summary>
        public virtual void ForcedDeletion()
        {
            this.ForcedDeletionContainTargets();
            this.IsDelete = true;
            this.Contains.Clear();
            //todo 需要定时任务配合，因为这个clear只会删除关系表中的SourceId列的内容，并未删除整行，需要定时任务定时删除表中这种数据
        }

        /// <summary>
        /// 强制删除关联的子级
        /// </summary>
        public virtual void ForcedDeletionContainTargets()
        {
            foreach (var st in this.Contains.Where(m => m.Target.IsDelete == false))
            {
                st.Target.ForcedDeletion();
            }
        }

        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="hierarchyScope"></param>
        public virtual void Update(HierarchyScope hierarchyScope)
        {
            this.Id = hierarchyScope.Id;
            this.Name = hierarchyScope.Name;
            this.Description = hierarchyScope.Description;
            this.Active = hierarchyScope.Active;
            this.EquipmentLevel = hierarchyScope.EquipmentLevel;
            this.EquipmentID = hierarchyScope.EquipmentID;
            this.ResponsibleDtId = hierarchyScope.ResponsibleDtId;
            this.Address = hierarchyScope.Address;
            this.SourceDtId = hierarchyScope.SourceDtId;
        }

        // 辅助方法：获取直接子级（通过Contains关系）
        public IEnumerable<HierarchyScope> GetChildren()
        {
            return Contains.Select(c => c.Target);
        }

        // 类型安全的泛型方法：获取特定类型的直接子级
        public IEnumerable<T> GetChildren<T>() where T : HierarchyScope
        {
            return GetChildren().OfType<T>();
        }

        // 类型安全的泛型方法：获取特定类型的父级
        public T GetParent<T>() where T : HierarchyScope
        {
            return Source as T;
        }
        // 获取所有祖先
        public IEnumerable<HierarchyScope> GetAncestors()
        {
            var current = this.Source;
            while (current != null)
            {
                yield return current;
                current = current.Source;
            }
        }

        // 获取特定类型的祖先
        public IEnumerable<T> GetAncestors<T>() where T : HierarchyScope
        {
            return this.GetAncestors().OfType<T>();
        }

        // 获取所有后代（递归通过Contains关系）
        public IEnumerable<HierarchyScope> GetDescendants()
        {
            foreach (var child in this.GetChildren())
            {
                yield return child;
                foreach (var descendant in child.GetDescendants())
                {
                    yield return descendant;
                }
            }
        }

        // 获取特定类型的后代
        public IEnumerable<T> GetDescendants<T>() where T : HierarchyScope
        {
            return this.GetDescendants().OfType<T>();
        }

        // 获取根节点
        public HierarchyScope GetRoot()
        {
            var current = this;
            while (current.Source != null)
            {
                current = current.Source;
            }
            return current;
        }

        // 获取层级路径
        public string GetHierarchyPath(string separator = " > ")
        {
            var path = new List<string>();
            var current = this;

            while (current != null)
            {
                path.Insert(0, current.Name);
                current = current.Source;
            }

            return string.Join(separator, path);
        }

        /// <summary>
        /// 判断指定父级是否能够增加指定子级
        /// todo
        /// </summary>
        /// <param name="sourceEquipmentLevel">父设备层次</param>
        /// <param name="targetEquipment">子设备层次</param>
        /// <exception cref="MethodAccessException"></exception>
        public void ContainsIsAddTarget(HierarchyScopeEquipmentLevel sourceEquipmentLevel, HierarchyScopeEquipmentLevel targetEquipment)
        {
            switch (sourceEquipmentLevel)
            {
                case HierarchyScopeEquipmentLevel.Enterprise:
                    switch (targetEquipment)
                    {
                        case HierarchyScopeEquipmentLevel.Enterprise:
                        case HierarchyScopeEquipmentLevel.Site:
                        case HierarchyScopeEquipmentLevel.Area:
                            break;
                        default:
                            throw new MethodAccessException("企业下只能添加企业、站点/工厂、区域/部门");
                    }
                    break;

                case HierarchyScopeEquipmentLevel.Site:
                    if (targetEquipment != HierarchyScopeEquipmentLevel.Area)
                        throw new MethodAccessException("站点下只能添加区域/部门");
                    break;

                case HierarchyScopeEquipmentLevel.Area:
                    switch (targetEquipment)
                    {
                        case HierarchyScopeEquipmentLevel.Production_Line:
                        case HierarchyScopeEquipmentLevel.Work_Cell:
                        case HierarchyScopeEquipmentLevel.Process_Cell:
                        case HierarchyScopeEquipmentLevel.Work_Center:
                        case HierarchyScopeEquipmentLevel.Storage_Zone:
                            break;
                        default:
                            throw new MethodAccessException("站点下只能添加生产工艺段、生产单元、生产线、存储区、工作中心");
                    }
                    break;

                case HierarchyScopeEquipmentLevel.Process_Cell:
                    switch (targetEquipment)
                    {
                        case HierarchyScopeEquipmentLevel.Work_Unit:
                        case HierarchyScopeEquipmentLevel.Unit:
                        case HierarchyScopeEquipmentLevel.Production_Unit:
                        case HierarchyScopeEquipmentLevel.Work_Center:
                        case HierarchyScopeEquipmentLevel.Storage_Unit:
                            break;
                        default:
                            throw new MethodAccessException("工作中心下只能添加单元、工段/工位、存储单元、工作中心、工作单元");
                    }
                    break;

                case HierarchyScopeEquipmentLevel.Work_Center:
                case HierarchyScopeEquipmentLevel.Production_Unit:
                    if (targetEquipment != HierarchyScopeEquipmentLevel.Unit)
                        throw new MethodAccessException("生产工艺段下只能添加单元");
                    break;

                case HierarchyScopeEquipmentLevel.Production_Line:
                    switch (targetEquipment)
                    {
                        case HierarchyScopeEquipmentLevel.Work_Unit:
                        case HierarchyScopeEquipmentLevel.Unit:
                        case HierarchyScopeEquipmentLevel.Production_Unit:
                        case HierarchyScopeEquipmentLevel.Work_Center:
                        case HierarchyScopeEquipmentLevel.Storage_Unit:
                        case HierarchyScopeEquipmentLevel.Work_Cell:
                            break;
                        default:
                            throw new MethodAccessException("生产线下只能添加子生产线、工段/工位");
                    }
                    break;

                case HierarchyScopeEquipmentLevel.Storage_Zone:
                    if (targetEquipment != HierarchyScopeEquipmentLevel.Storage_Zone || targetEquipment != HierarchyScopeEquipmentLevel.Storage_Unit)
                        throw new MethodAccessException("存储区下只能添加存储区、存储单元");
                    break;

                case HierarchyScopeEquipmentLevel.Work_Unit:
                    throw new MethodAccessException("工作单元下暂时不能添加任何级别");
                case HierarchyScopeEquipmentLevel.Unit:
                    throw new MethodAccessException("单元（用于批生产的设备/用于连续生产的设备）下不能添加任何基于角色的设备层次");
                case HierarchyScopeEquipmentLevel.Work_Cell:
                    if (targetEquipment != HierarchyScopeEquipmentLevel.Unit)
                        throw new MethodAccessException("生产单元下只能添加单元");
                    break;

                case HierarchyScopeEquipmentLevel.Storage_Unit:
                    throw new MethodAccessException("存储单元下不能添加任何基于角色的设备层次");
            }
        }


        public void AddChild(Guid targetDtId)
        {
            this.Contains.Add(new Common.Relationship.isa95.HierarchyScope.HierarchyScopeContainsRelationship(this.DtId, targetDtId));
        }

        public void DeleteChild(Guid targetDtId)
        {
            this.Contains.Remove(this.Contains.Where(m => m.TargetId == targetDtId).First());
        }
    }
}