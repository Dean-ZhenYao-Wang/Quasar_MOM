namespace MOM.Domain.isa95.CommonObjectModels.Part2.Personnel
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.Person;
    using MOM.Domain.isa95.CommonObjectModels;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Text.Json.Serialization;

    public partial class Person : Resource, IEquatable<Person>
    {
        public Person()
        {
        }

        /// <summary>
        /// �����豸��ɫ���/������֯
        /// </summary>
        [JsonPropertyName("hierarchyScope")]
        public string? HierarchyScope
        { get { return HierarchyScopeRel?.Name; } }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// ��ǰ����λ��
        /// </summary>
        [JsonPropertyName("operationalLocation")]
        public string? OperationalLocation { get; set; }

        /// <summary>
        /// ��ǰ����λ������
        /// </summary>
        [JsonPropertyName("operationalLocationType")]
        public PersonOperationalLocationType? OperationalLocationType { get; set; }

        [JsonIgnore]
        public virtual PersonDefinedByRelationshipCollection DefinedBy { get; set; } = new PersonDefinedByRelationshipCollection();

        /// <summary>
        /// ��չ���ԡ�������ҵ�����
        /// </summary>
        [JsonIgnore]
        public virtual PersonHasValuesOfRelationshipCollection HasValuesOf { get; set; } = new PersonHasValuesOfRelationshipCollection();

        /// <summary>
        /// ȷ����������Ϣ�ڻ��ڽ�ɫ���豸��νṹ�е�λ�á���ѡ�أ���νṹ����������Ա�����������
        /// </summary>
        //[MaxLength(1)]
        [ForeignKey(nameof(HierarchyScopeRelDtId))]
        [JsonIgnore]
        public virtual HierarchyScope HierarchyScopeRel { get; set; }
        /// <summary>
        /// ȷ����������Ϣ�ڻ��ڽ�ɫ���豸��νṹ�е�λ�á���ѡ�أ���νṹ����������Ա�����������
        /// </summary>
        public Guid? HierarchyScopeRelDtId { get; set; }

        //[MaxLength(1)]
        [JsonIgnore]
        public virtual PersonOperationalLocationRelRelationshipCollection OperationalLocationRel { get; set; } = new PersonOperationalLocationRelRelationshipCollection();
        /// <summary>
        /// �ڿռ��Ͻ������ɫ����Ϊ��ά�㡢һά�ߡ���ά��״����άʵ��<br/>
        /// / / WKT / POLYGON��(-646.99 676.18, -645.14 683.09, -)��
        /// </summary>
        [JsonIgnore]
        public SpatialDefinition SpatialDefinition { get; set; }

        public override bool Equals(object? obj)
        {
            return Equals(obj as Person);
        }

        public bool Equals(Person? other)
        {
            return other is not null && base.Equals(other) && HierarchyScope == other.HierarchyScope && Name == other.Name && OperationalLocation == other.OperationalLocation && OperationalLocationType == other.OperationalLocationType;
        }

        public static bool operator ==(Person? left, Person? right)
        {
            return EqualityComparer<Person?>.Default.Equals(left, right);
        }

        public static bool operator !=(Person? left, Person? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), HierarchyScope?.GetHashCode(), Name?.GetHashCode(), OperationalLocation?.GetHashCode(), OperationalLocationType?.GetHashCode());
        }

        public List<string> GetDefinedBy()
        {
            return this.DefinedBy.Select(m => m.Target.Id).ToList();
        }
    }
}