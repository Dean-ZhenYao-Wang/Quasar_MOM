namespace MOM.Domain.isa95.CommonObjectModels.Part2.Material
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.MaterialDefinitionProperty;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public partial class MaterialDefinitionProperty : ResourceProperty, IEquatable<MaterialDefinitionProperty>
    {
        public MaterialDefinitionProperty()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:MaterialDefinitionProperty;1";

        /// <summary>
        /// 定义属性的类型。
        /// </summary>
        [JsonPropertyName("propertyType")]
        public MaterialDefinitionPropertyPropertyType? PropertyType { get; set; }

        /// <summary>
        /// 嵌套的物料定义属性作为整体构成了这个物料定义属性的一部分。
        /// </summary>
        [JsonIgnore]
public virtual List<MaterialDefinitionPropertyContainsRelationship> Contains { get; set; } = new List<MaterialDefinitionPropertyContainsRelationship>();

        /// <summary>
        /// 如果父物料定义支持物料类，则物料类属性应用于物料定义属性。这个物料定义属性映射到相应的物料类属性。
        /// 0...1
        /// </summary>
        [JsonIgnore]
public virtual List<MaterialDefinitionPropertyMapsToRelationship> MapsTo { get; set; } = new List<MaterialDefinitionPropertyMapsToRelationship>();

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialDefinitionProperty);
        }

        public bool Equals(MaterialDefinitionProperty? other)
        {
            return other is not null && base.Equals(other) && PropertyType == other.PropertyType;
        }

        public static bool operator ==(MaterialDefinitionProperty? left, MaterialDefinitionProperty? right)
        {
            return EqualityComparer<MaterialDefinitionProperty?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialDefinitionProperty? left, MaterialDefinitionProperty? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), PropertyType?.GetHashCode());
        }
    }
}