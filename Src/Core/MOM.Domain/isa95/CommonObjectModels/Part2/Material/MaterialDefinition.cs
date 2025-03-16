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
        /// ��ʶ��������Ϣ�ڻ��ڽ�ɫ���豸��νṹ�е�λ�á�
        /// </summary>
        /// <remarks>��ѡ�أ�������������豸������������綨���豸���վ�������</remarks>
        [JsonPropertyName("hierarchyScope")]
        public string? HierarchyScope { get; set; }

        /// <summary>
        /// ��װ����
        /// </summary>
        [JsonPropertyName("assemblyType")]
        public MaterialDefinitionAssemblyType? AssemblyType { get; set; }

        /// <summary>
        /// ��װ��ϵ������
        /// </summary>
        [JsonPropertyName("assemblyRelationship")]
        public MaterialDefinitionAssemblyRelationship? AssemblyRelationship { get; set; }

        /// <summary>
        /// ��Ϲ�ϵ
        /// </summary>
        /// <remarks>This material definition is part of the related object as the whole<br></br>������ϵĶ�������Ϊ������йض����һ����</remarks>
        [JsonIgnore]
        public virtual MaterialDefinitionIsAssembledFromRelationshipCollection IsAssembledFrom { get; set; } = new MaterialDefinitionIsAssembledFromRelationshipCollection();

        /// <summary>
        /// �����϶�������϶������ԡ�
        /// </summary>
        [JsonIgnore]
        public virtual MaterialDefinitionHasPropertiesOfRelationshipCollection HasPropertiesOf { get; set; } = new MaterialDefinitionHasPropertiesOfRelationshipCollection();

        /// <summary>
        /// This material definition objects support this material class.<br>������϶������֧����������ࡣ</br>
        /// </summary>
        [JsonIgnore]
        public virtual MaterialDefinitionIsMemberOfClassRelationshipCollection IsMemberOfClass { get; set; } = new MaterialDefinitionIsMemberOfClassRelationshipCollection();

        /// <summary>
        /// �ʺϲ�νṹ��Χ
        /// </summary>
        /// <remarks>��ѡ�Ĳ�ι�ϵ�����Ǳ�׼����һ���֡�</remarks>
        [JsonIgnore]
        public virtual MaterialDefinitionHierarchyScopeRelRelationshipCollection HierarchyScopeRel { get; set; } = new MaterialDefinitionHierarchyScopeRelRelationshipCollection();

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