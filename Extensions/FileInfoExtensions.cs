using System.IO;

namespace BeauGunderson.Extensions
{
    public static class FileInfoExtensions
    {
        public static bool FindInFile(this FileInfo file, string term)
        {
            if (term == null)
            {
                return false;
            }

            var fileStream = file.OpenText();

            while (!fileStream.EndOfStream)
            {
                var line = fileStream.ReadLine();

                if (line != null && 
                    line.Contains(term))
                {
                    return true;
                }
            }

            return false;
        }
    }
}