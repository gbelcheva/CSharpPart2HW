namespace _03.FileSystemTree
{
    using System;
    using System.IO;

    public class Startup
    {
        static void Main()
        {
            Folder folder = new Folder("Help");
            GetDirectoryTree(new DirectoryInfo(@"C:\WINDOWS\Help"), folder);
            int initialDepth = 0;
            TraverseFolder(folder, initialDepth);

            int folderSize = folder.CalculateFileSizesSum();
            Console.WriteLine("Size of directory {0}: {1} Bytes", folder.Name, folderSize);
        }

        private static void TraverseFolder(Folder folder, int depth)
        {
            var folders = folder.ChildFolders;
            foreach (var item in folders)
            {
                Console.WriteLine("{0}Folder: {1}", new string('-', depth), item.Name);
                TraverseFolder(item, ++depth);
                depth--;
            }

            var files = folder.Files;
            foreach (var item in files)
            {
                Console.WriteLine("{0}File: {1}", new string('-', depth), item.Name);
            }
        }

        private static void GetDirectoryTree(DirectoryInfo directory, Folder folder)
        {

            var files = directory.GetFiles();
            foreach (var file in files)
            {
                var myFile = new File(file.Name, (int)file.Length);

                folder.Files.Add(myFile);
            }

            var directories = directory.GetDirectories();
            foreach (var dir in directories)
            {
                try
                {
                    var newFolder = new Folder(dir.Name);

                    GetDirectoryTree(dir, newFolder);

                    folder.ChildFolders.Add(newFolder);
                }
                catch (UnauthorizedAccessException)
                {
                    return;
                }
            }
        }
    }
}

