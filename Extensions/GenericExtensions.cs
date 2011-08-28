using System.Collections;

namespace BeauGunderson.Extensions
{
    public static class GenericExtensions
    {
        public static bool EqualsStructure<T>(this T a, T b)
            where T : IStructuralEquatable
        {
            return a.Equals(b, StructuralComparisons.StructuralEqualityComparer);
        }

        public static int CompareStructureTo<T>(this T a, T b)
            where T : IStructuralComparable
        {
            return a.CompareTo(b, StructuralComparisons.StructuralComparer);
        }
    }
}