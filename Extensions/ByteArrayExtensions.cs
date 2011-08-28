using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace BeauGunderson.Extensions
{
    public static class ByteArrayExtensions
    {
        public static T ToObject<T>(this byte[] bytes)
        {
            var stream = new MemoryStream(bytes);
            var formatter = new BinaryFormatter();

            stream.Position = 0;

            return (T)formatter.Deserialize(stream);
        }
    }
}