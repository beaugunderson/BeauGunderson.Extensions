using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace BeauGunderson.Extensions
{
    public static class DirectoryExtensions
    {
        public static void TraverseTree(this DirectoryInfo directory,
            Func<FileInfo, bool> fileAction,
            Func<DirectoryInfo, bool> directoryAction,
            CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var directories = new Stack<DirectoryInfo>(20);

            if (!directory.Exists)
            {
                throw new ArgumentException();
            }

            directories.Push(directory);

            while (directories.Count > 0)
            {
                cancellationToken.ThrowIfCancellationRequested();

                DirectoryInfo[] subdirectories;

                var currentDirectory = directories.Pop();

                directoryAction(currentDirectory);

                try
                {
                    subdirectories = currentDirectory.GetDirectories();
                }
                catch (UnauthorizedAccessException)
                {
                    continue;
                }
                catch (DirectoryNotFoundException)
                {
                    continue;
                }

                FileInfo[] files;

                try
                {
                    files = currentDirectory.GetFiles();
                }
                catch (UnauthorizedAccessException)
                {
                    continue;
                }
                catch (DirectoryNotFoundException)
                {
                    continue;
                }

                foreach (var file in files)
                {
                    cancellationToken.ThrowIfCancellationRequested();

                    fileAction(file);
                }

                foreach (var subDirectory in subdirectories)
                {
                    directories.Push(subDirectory);
                }
            }
        }
    }
}