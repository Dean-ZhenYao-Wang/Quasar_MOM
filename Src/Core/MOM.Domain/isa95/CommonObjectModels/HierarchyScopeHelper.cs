using MOM.Domain.Common.EnumType;

namespace MOM.Domain.isa95.CommonObjectModels
{
    /// <summary>
    /// 设备角色层次辅助类
    /// </summary>
    public static class HierarchyScopeHelper
    {
        /// <summary>
        /// 判断指定父级是否能够增加指定子级
        /// todo
        /// </summary>
        /// <param name="sourceEquipmentLevel">父设备层次</param>
        /// <param name="targetEquipment">子设备层次</param>
        /// <exception cref="MethodAccessException"></exception>
        public static void ContainsIsAddTarget(HierarchyScopeEquipmentLevel sourceEquipmentLevel, HierarchyScopeEquipmentLevel targetEquipment)
        {
            switch (sourceEquipmentLevel)
            {
                case HierarchyScopeEquipmentLevel.Enterprise:
                    if (targetEquipment != HierarchyScopeEquipmentLevel.Site && targetEquipment != HierarchyScopeEquipmentLevel.Enterprise)
                        throw new MethodAccessException("企业下只能添加企业、站点");
                    break;

                case HierarchyScopeEquipmentLevel.Site:
                    if (targetEquipment != HierarchyScopeEquipmentLevel.Area)
                        throw new MethodAccessException("站点下只能添加区域");
                    break;

                case HierarchyScopeEquipmentLevel.Area:
                    switch (targetEquipment)
                    {
                        case HierarchyScopeEquipmentLevel.Enterprise:
                        case HierarchyScopeEquipmentLevel.Site:
                        case HierarchyScopeEquipmentLevel.Area:
                        case HierarchyScopeEquipmentLevel.Work_Unit:
                        case HierarchyScopeEquipmentLevel.Unit:
                        case HierarchyScopeEquipmentLevel.Storage_Unit:
                            throw new MethodAccessException("站点下只能添加生产工艺段、生产单元、生产线、存储区、工作中心");
                    }
                    break;

                case HierarchyScopeEquipmentLevel.Work_Center:
                    switch (targetEquipment)
                    {
                        case HierarchyScopeEquipmentLevel.Enterprise:
                        case HierarchyScopeEquipmentLevel.Site:
                        case HierarchyScopeEquipmentLevel.Area:
                        case HierarchyScopeEquipmentLevel.Process_Cell:
                        case HierarchyScopeEquipmentLevel.Production_Unit:
                        case HierarchyScopeEquipmentLevel.Production_Line:
                        case HierarchyScopeEquipmentLevel.Storage_Zone:
                            throw new MethodAccessException("工作中心下只能添加单元、工段/工位、存储单元、工作中心、工作单元");
                    }
                    break;

                case HierarchyScopeEquipmentLevel.Process_Cell:
                case HierarchyScopeEquipmentLevel.Production_Unit:
                    if (targetEquipment != HierarchyScopeEquipmentLevel.Unit)
                        throw new MethodAccessException("生产工艺段下只能添加生产工艺段、单元");
                    break;

                case HierarchyScopeEquipmentLevel.Production_Line:
                    if (targetEquipment != HierarchyScopeEquipmentLevel.Work_Cell)
                        throw new MethodAccessException("生产线下只能添加子生产线、工段/工位");
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
    }
}