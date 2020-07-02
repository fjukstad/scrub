using System;
using System.IO;

namespace scrub
{
    class Program
    {
        /// <param name="path">
        ///     Where to start scrubbing away `bin` and `obj` folders
        /// </param>
        static void Main(string path = ".")
        {
            RemoveBinAndObj(path);
        }

        static void RemoveBinAndObj(string path)
        {
            var folders = Directory.EnumerateDirectories(path);
            foreach (var folder in folders)
            {
                var folderInfo = new DirectoryInfo(folder);
                if (folderInfo.Name == "bin" || folderInfo.Name == "obj")
                {
                    Console.WriteLine($"Removing '{folderInfo.FullName}'");
                    Directory.Delete(folderInfo.FullName, true);
                }
                else
                {
                    RemoveBinAndObj(folder);
                }
            }
        }
    }
}
