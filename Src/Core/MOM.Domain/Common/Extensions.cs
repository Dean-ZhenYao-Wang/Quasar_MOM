namespace MOM.Domain.Common
{
    internal static class Extensions
    {
        internal static int CustomHash(this object o, params int?[] values)
        {
            var hash = 1009;
            foreach (var i in values)
            {
                if (i != null && i.HasValue)
                {
                    hash = hash * 9176 + i.Value;
                }
            }

            return hash;
        }
    }
}