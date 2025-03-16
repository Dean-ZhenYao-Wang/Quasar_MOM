namespace MOM.Domain.isa95.CommonObjectModels.Part2.Material
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.MaterialClass;
    using MOM.Domain.isa95.CommonObjectModels;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public partial class MaterialClass : ResourceClass, IEquatable<MaterialClass>
    {
        public MaterialClass() : base()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:MaterialClass;1";

        /// <summary>
        /// 标识交换的信息在基于角色的设备层次结构中的位置。
        /// </summary>
        /// <remarks>可选地，层次作用域定义设备类的作用域，例如定义设备类的站点或区域。</remarks>
        [JsonPropertyName("hierarchyScope")]
        public string? HierarchyScope { get; set; }

        /// <summary>
        /// 组装类型
        /// </summary>
        [JsonPropertyName("assemblyType")]
        public MaterialClassAssemblyType? AssemblyType { get; set; }

        /// <summary>
        /// 组装关系的类型
        /// </summary>
        [JsonPropertyName("assemblyRelationship")]
        public MaterialClassAssemblyRelationship? AssemblyRelationship { get; set; }

        /// <summary>
        /// 线性分类 在物料主数据建设工程，往往分类采用线分类   https://zhuanlan.zhihu.com/p/496464306
        /// 当前分类包含的子分类
        /// </summary>
        /// <remarks>父子关系<br></br>This material class(s) include properties of the material class.<br></br>该材料类别包括该材料类别的属性。</remarks>
        [JsonIgnore]
        public virtual MaterialClassIncludesPropertiesOfRelationshipCollection IncludesPropertiesOf { get; set; } = new MaterialClassIncludesPropertiesOfRelationshipCollection();

        /// <summary>
        /// 面分类 又称平行分类 物料模板采用面分类 https://zhuanlan.zhihu.com/p/496464306
        /// 组成当前分类的类型
        /// </summary>
        /// <remarks>组合关系<br></br>This parent material class is whole of the child material class(s) as the part.<br></br>这个父材质类是子材质类的整体。</remarks>
        [JsonIgnore]
        public virtual MaterialClassIsAssembledFromRelationshipCollection IsAssembledFrom { get; set; } = new MaterialClassIsAssembledFromRelationshipCollection();

        /// <summary>
        /// 该物料类的物料类属性。
        /// </summary>
        [JsonIgnore]
        public virtual MaterialClassHasPropertiesOfRelationshipCollection HasPropertiesOf { get; set; } = new MaterialClassHasPropertiesOfRelationshipCollection();

        /// <summary>
        /// 适合层次结构范围
        /// </summary>
        /// <remarks>可选的层次关系。不是标准规格的一部分。</remarks>
        [JsonIgnore]
        public virtual MaterialClassHierarchyScopeRelRelationshipCollection HierarchyScopeRel { get; set; } = new MaterialClassHierarchyScopeRelRelationshipCollection();

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialClass);
        }

        public bool Equals(MaterialClass? other)
        {
            return other is not null && base.Equals(other) && HierarchyScope == other.HierarchyScope && AssemblyType == other.AssemblyType && AssemblyRelationship == other.AssemblyRelationship;
        }

        public static bool operator ==(MaterialClass? left, MaterialClass? right)
        {
            return EqualityComparer<MaterialClass?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialClass? left, MaterialClass? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), HierarchyScope?.GetHashCode(), AssemblyType?.GetHashCode(), AssemblyRelationship?.GetHashCode());
        }
    }
}