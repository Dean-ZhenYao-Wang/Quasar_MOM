namespace MOM.Domain.isa95.CommonObjectModels.Part2.Material
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.MaterialDefinition;
    using MOM.Domain.isa95.CommonObjectModels;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public partial class MaterialDefinition : Resource, IEquatable<MaterialDefinition>
    {
        public MaterialDefinition()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:MaterialDefinition;1";

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
        public MaterialDefinitionAssemblyType? AssemblyType { get; set; }

        /// <summary>
        /// 组装关系的类型
        /// </summary>
        [JsonPropertyName("assemblyRelationship")]
        public MaterialDefinitionAssemblyRelationship? AssemblyRelationship { get; set; }

        /// <summary>
        /// 组合关系
        /// </summary>
        /// <remarks>This material definition is part of the related object as the whole<br></br>这个物料的定义是作为整体的有关对象的一部分</remarks>
        [JsonIgnore]
public virtual List<MaterialDefinitionIsAssembledFromRelationship> IsAssembledFrom { get; set; } = new List<MaterialDefinitionIsAssembledFromRelationship>();

        /// <summary>
        /// 本物料定义的物料定义属性。
        /// </summary>
        [JsonIgnore]
public virtual List<MaterialDefinitionHasPropertiesOfRelationship> HasPropertiesOf { get; set; } = new List<MaterialDefinitionHasPropertiesOfRelationship>();

        /// <summary>
        /// This material definition objects support this material class.<br>这个物料定义对象支持这个物料类。</br>
        /// </summary>
        [JsonIgnore]
public virtual List<MaterialDefinitionIsMemberOfClassRelationship> IsMemberOfClass { get; set; } = new List<MaterialDefinitionIsMemberOfClassRelationship>();

        /// <summary>
        /// 适合层次结构范围
        /// </summary>
        /// <remarks>可选的层次关系。不是标准规格的一部分。</remarks>
        [JsonIgnore]
public virtual List<MaterialDefinitionHierarchyScopeRelRelationship> HierarchyScopeRel { get; set; } = new List<MaterialDefinitionHierarchyScopeRelRelationship>();

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialDefinition);
        }

        public bool Equals(MaterialDefinition? other)
        {
            return other is not null && base.Equals(other) && HierarchyScope == other.HierarchyScope && AssemblyType == other.AssemblyType && AssemblyRelationship == other.AssemblyRelationship;
        }

        public static bool operator ==(MaterialDefinition? left, MaterialDefinition? right)
        {
            return EqualityComparer<MaterialDefinition?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialDefinition? left, MaterialDefinition? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), HierarchyScope?.GetHashCode(), AssemblyType?.GetHashCode(), AssemblyRelationship?.GetHashCode());
        }
    }
}