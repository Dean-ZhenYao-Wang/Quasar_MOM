namespace MOM.Domain.isa95.ext
{
    using MOM.Domain.Common;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class LangStringSet : BaseEntity, IEquatable<LangStringSet>, IEquatable<BaseEntity>
    {
        public LangStringSet()
        {
        }

        [JsonIgnore]
        public static string ModelId { get; } = "dtmi:digitaltwins:isa95:LangStringSet;1";

        [JsonPropertyName("langString")]
        public IDictionary<string, string>? LangString { get; set; }

        public override bool Equals(object? obj)
        {
            return Equals(obj as LangStringSet);
        }

        public bool Equals(LangStringSet? other)
        {
            return other is not null && DtId == other.DtId && LangString == other.LangString;
        }

        public static bool operator ==(LangStringSet? left, LangStringSet? right)
        {
            return EqualityComparer<LangStringSet?>.Default.Equals(left, right);
        }

        public static bool operator !=(LangStringSet? left, LangStringSet? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), ModelId?.GetHashCode(), LangString?.GetHashCode());
        }

        public bool Equals(BaseEntity? other)
        {
            return Equals(other as LangStringSet) || new TwinEqualityComparer().Equals(this, other);
        }
    }
}