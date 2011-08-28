using System;
using System.Collections.Generic;

namespace BeauGunderson.Extensions.Debugging
{
    public static class IEnumerableExtensions
    {
        public static void PrettyPrint<T>(this IEnumerable<T> source, string prefix = null)
        {
            if (!String.IsNullOrEmpty(prefix))
            {
                Console.WriteLine("{0}:", prefix);
                Console.WriteLine();
            }

            int count = 0;

            foreach (var o in source)
            {
                Console.WriteLine("\t{0}:\t{1}", count, o);

                count++;
            }

            Console.WriteLine();
        }
    }
}