namespace _03.FileSystemTree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Folder
    {
        private int size;

        public Folder(string name)
        {
            this.Name = name;
            this.Files = new List<File>();
            this.ChildFolders = new List<Folder>();
        }

        public string Name { get; set; }

        public List<File> Files { get; set; }

        public List<Folder> ChildFolders { get; set; }

        public int CalculateFileSizesSum()
        {
            //if (this.ChildFolders.Length == 0)
            //{
            //    foreach (var file in this.Files)
            //    {
            //        this.size += file.Size;
            //    }

            //    return this.size;
            //}

            foreach (var file in this.Files)
            {
                size += file.Size;
            }

            foreach (var folder in this.ChildFolders)
            {
                this.size += folder.CalculateFileSizesSum();
            }

            return this.size;
        }
    }
}
