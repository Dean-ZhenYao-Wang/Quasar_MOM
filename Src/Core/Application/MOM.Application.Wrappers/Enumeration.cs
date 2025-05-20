using System.Reflection;

namespace MOM.Application.Wrappers
{
    public abstract class Enumeration<TEnum> : IEquatable<Enumeration<TEnum>>
    where TEnum : Enumeration<TEnum>
    {
        public int Id { get; }
        public string Name { get; }

        protected Enumeration(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public static IReadOnlyCollection<TEnum> All =>
            typeof(TEnum)
                .GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly)
                .Select(f => f.GetValue(null))
                .Cast<TEnum>()
                .ToList();

        public static TEnum? FromId(int id) => All.FirstOrDefault(x => x.Id == id);

        public static TEnum? FromName(string name) => All.FirstOrDefault(x => x.Name == name);

        public bool Equals(Enumeration<TEnum>? other) =>
            other is not null && GetType() == other.GetType() && Id == other.Id;

        public override bool Equals(object? obj) => obj is Enumeration<TEnum> other && Equals(other);

        public override int GetHashCode() => HashCode.Combine(Id, GetType());

        public override string ToString() => Name;

        public static bool operator ==(Enumeration<TEnum>? left, Enumeration<TEnum>? right) =>
            Equals(left, right);

        public static bool operator !=(Enumeration<TEnum>? left, Enumeration<TEnum>? right) =>
            !Equals(left, right);
    }
}