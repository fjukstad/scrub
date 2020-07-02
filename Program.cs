using System;
using System.IO;

namespace scrub
{
    class Program
    {
        /// <summary>
        /// A simple tool for removing `bin` and `obj` folders. Will recursively
        /// traverse the current working directory and remove folders as it finds
        /// them.
        /// </summary>
        /// <param name="path">
        ///     Where to start scrubbing away `bin` and `obj` folders
        /// </param>
        /// <param name="ask">
        ///     Ask before removing a folder. Set to `false` to skip any user
        ///     interaction
        /// </param>
        /// <param name="list">
        ///     Only print folder names, do not remove anyhing.
        /// </param>
        static void Main(string path = ".", bool ask = true, bool list = false)
        {
            RemoveBinAndObj(path, ask, list);
        }

        static void RemoveBinAndObj(string path, bool askForPermission, bool list)
        {
            var folders = Directory.EnumerateDirectories(path);
            foreach (var folder in folders)
            {
                var folderInfo = new DirectoryInfo(folder);
                if (folderInfo.Name == "bin" || folderInfo.Name == "obj")
                {
                    if (list)
                    {
                        Console.WriteLine($"'{folderInfo.FullName}'");
                    }
                    else
                    {
                        var shouldRemoveFolder = false;

                        if (askForPermission)
                        {
                            Console.WriteLine($"Should I remove '{folderInfo.FullName}'? y/n ");
                            var answer = Console.ReadLine();
                            if (answer == "y")
                            {
                                shouldRemoveFolder = true;
                            }
                            else
                            {
                                shouldRemoveFolder = false;
                            }
                        }
                        else
                        {
                            shouldRemoveFolder = true;
                        }

                        if (shouldRemoveFolder)
                        {
                            Console.WriteLine($"Removing '{folderInfo.FullName}'");
                            Directory.Delete(folderInfo.FullName, true);
                        }
                        else
                        {
                            Console.WriteLine($"Skipping '{folderInfo.FullName}'");
                        }
                    }
                }
                else
                {
                    RemoveBinAndObj(folder, askForPermission, list);
                }
            }
        }
    }
}
