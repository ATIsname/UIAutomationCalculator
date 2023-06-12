using System.Reflection;

namespace UICalculator.Extensions
{
    static class TypeExtensions
    {
        public static IEnumerable<T> GetAttributes<T>(this ICustomAttributeProvider source, bool inherit) where T : Attribute
        {
            var attrs = source.GetCustomAttributes(typeof(T), inherit);

            return (attrs != null) ? (T[])attrs : Enumerable.Empty<T>();
        }
    }

}
