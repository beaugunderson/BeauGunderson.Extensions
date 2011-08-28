namespace BeauGunderson.Extensions
{
    public static class GenericArrayExtensions
    {
        /// <summary>
        /// Get the array slice between the two indexes.
        /// Inclusive for start index, exclusive for end index.
        /// </summary>
        public static T[] Slice<T>(this T[] source, int start, int end)
        {
            // Handles negative ends
            if (end < 0)
            {
                end = source.Length + end;
            }

            int length = end - start;

            var result = new T[length];

            for (int i = 0; i < length; i++)
            {
                result[i] = source[i + start];
            }

            return result;
        }
    }
}