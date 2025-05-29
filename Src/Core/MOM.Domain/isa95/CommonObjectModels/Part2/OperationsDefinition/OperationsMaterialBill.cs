namespace MOM.Domain.isa95.CommonObjectModels.Part2.OperationsDefinition
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.OperationsMaterialBill;
    using MOM.Domain.Common.Relationship.isa95.OperationsMaterialBillItem;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class OperationsMaterialBill : BaseEntity, IEquatable<OperationsMaterialBill>
    {
        public OperationsMaterialBill()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:OperationsMaterialBill;1";

        [JsonPropertyName("hierarchyScope")]
        public string? HierarchyScope { get; set; }

        [JsonPropertyName("useType")]
        public OperationsMaterialBillUseType? UseType { get; set; }

        [JsonIgnore]
        public new List<OperationsMaterialBillIsACollectionOfRelationship> IsACollectionOf { get; set; } = new List<OperationsMaterialBillIsACollectionOfRelationship>();

        [JsonIgnore]
        public new List<OperationsMaterialBillHierarchyScopeRelRelationship> HierarchyScopeRel { get; set; } = new List<OperationsMaterialBillHierarchyScopeRelRelationship>();

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsMaterialBill);
        }

        public bool Equals(OperationsMaterialBill? other)
        {
            return other is not null && base.Equals(other) && HierarchyScope == other.HierarchyScope && UseType == other.UseType;
        }

        public static bool operator ==(OperationsMaterialBill? left, OperationsMaterialBill? right)
        {
            return EqualityComparer<OperationsMaterialBill?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsMaterialBill? left, OperationsMaterialBill? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), HierarchyScope?.GetHashCode(), UseType?.GetHashCode());
        }
    }
}