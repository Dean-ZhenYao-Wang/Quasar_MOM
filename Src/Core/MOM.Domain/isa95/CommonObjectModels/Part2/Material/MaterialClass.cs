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
        /// ��ʶ��������Ϣ�ڻ��ڽ�ɫ���豸��νṹ�е�λ�á�
        /// </summary>
        /// <remarks>��ѡ�أ�������������豸������������綨���豸���վ�������</remarks>
        [JsonPropertyName("hierarchyScope")]
        public string? HierarchyScope { get; set; }

        /// <summary>
        /// ��װ����
        /// </summary>
        [JsonPropertyName("assemblyType")]
        public MaterialClassAssemblyType? AssemblyType { get; set; }

        /// <summary>
        /// ��װ��ϵ������
        /// </summary>
        [JsonPropertyName("assemblyRelationship")]
        public MaterialClassAssemblyRelationship? AssemblyRelationship { get; set; }

        /// <summary>
        /// ���Է��� �����������ݽ��蹤�̣�������������߷���   https://zhuanlan.zhihu.com/p/496464306
        /// ��ǰ����������ӷ���
        /// </summary>
        /// <remarks>���ӹ�ϵ<br></br>This material class(s) include properties of the material class.<br></br>�ò����������ò����������ԡ�</remarks>
        [JsonIgnore]
        public virtual MaterialClassIncludesPropertiesOfRelationshipCollection IncludesPropertiesOf { get; set; } = new MaterialClassIncludesPropertiesOfRelationshipCollection();

        /// <summary>
        /// ����� �ֳ�ƽ�з��� ����ģ���������� https://zhuanlan.zhihu.com/p/496464306
        /// ��ɵ�ǰ���������
        /// </summary>
        /// <remarks>��Ϲ�ϵ<br></br>This parent material class is whole of the child material class(s) as the part.<br></br>��������������Ӳ���������塣</remarks>
        [JsonIgnore]
        public virtual MaterialClassIsAssembledFromRelationshipCollection IsAssembledFrom { get; set; } = new MaterialClassIsAssembledFromRelationshipCollection();

        /// <summary>
        /// ������������������ԡ�
        /// </summary>
        [JsonIgnore]
        public virtual MaterialClassHasPropertiesOfRelationshipCollection HasPropertiesOf { get; set; } = new MaterialClassHasPropertiesOfRelationshipCollection();

        /// <summary>
        /// �ʺϲ�νṹ��Χ
        /// </summary>
        /// <remarks>��ѡ�Ĳ�ι�ϵ�����Ǳ�׼����һ���֡�</remarks>
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