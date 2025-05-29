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
        /// �������Ե����͡�
        /// </summary>
        [JsonPropertyName("propertyType")]
        public MaterialDefinitionPropertyPropertyType? PropertyType { get; set; }

        /// <summary>
        /// Ƕ�׵����϶���������Ϊ���幹����������϶������Ե�һ���֡�
        /// </summary>
        [JsonIgnore]
public virtual List<MaterialDefinitionPropertyContainsRelationship> Contains { get; set; } = new List<MaterialDefinitionPropertyContainsRelationship>();

        /// <summary>
        /// ��������϶���֧�������࣬������������Ӧ�������϶������ԡ�������϶�������ӳ�䵽��Ӧ�����������ԡ�
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