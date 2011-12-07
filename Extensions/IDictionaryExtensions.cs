using System;
using System.Collections.Generic;

namespace BeauGunderson.Extensions
{
    public static class IDictionaryExtensions
    {
        public static TValue GetValueOrDefault<TKey, TValue>
            (this IDictionary<TKey, TValue> dictionary, TKey key)
        {
            lock (dictionary)
            {
                bool exists = dictionary.ContainsKey(key);

                if (!exists)
                {
                    dictionary[key] = typeof (TValue).IsValueType ? 
                        default(TValue) : 
                        Activator.CreateInstance<TValue>();
                }

                return dictionary[key];
            }
        }
    }
}