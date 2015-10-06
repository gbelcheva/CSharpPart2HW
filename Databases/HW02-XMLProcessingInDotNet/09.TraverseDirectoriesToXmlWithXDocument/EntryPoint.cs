namespace TraverseDirectoriesToXmlWithXDocument
{
    using System.IO;
    using System.Xml.Linq;

    public class EntryPoint
    {      
        public static void Main()
        {
            string outputFile = "../../../contentsTreeXDocument.xml";
            string inputDir = "./../../../";

            DirectoryInfo rootDir = new DirectoryInfo(inputDir);

            var result = WalkDirectoryTree(rootDir);

            var xDoc = new XDocument(result);
            xDoc.Save(outputFile);
        }

        static XElement WalkDirectoryTree(DirectoryInfo root)
        {
            FileInfo[] files = null;
            DirectoryInfo[] subDirs = null;

            XElement rootElement = new XElement("dir", new XAttribute("name", root.Name));

            files = root.GetFiles("*.*");
            if (files != null)
            {
                foreach (FileInfo fileInfo in files)
                {
                    rootElement.Add(new XElement("file", new XAttribute("name", fileInfo.Name)));
                }
            }

            subDirs = root.GetDirectories();
            if (subDirs != null)
            {
                foreach (DirectoryInfo dirInfo in subDirs)
                {
                    rootElement.Add(WalkDirectoryTree(dirInfo));
                }
            }

            return rootElement;
        }
    }
}
