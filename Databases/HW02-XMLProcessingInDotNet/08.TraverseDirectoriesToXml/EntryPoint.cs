namespace TraverseDirectoriesToXml
{
    using System;
    using System.IO;
    using System.Text;
    using System.Xml;

    public class EntryPoint
    {
        private static string outputFile = "../../../contentsTree.xml";
        private static Encoding encoding = Encoding.GetEncoding("windows-1251");
        private static XmlTextWriter writer = new XmlTextWriter(outputFile, encoding);

        public static void Main()
        {
            try
            {
                string inputDir = "./../../../";

                DirectoryInfo rootDir = new DirectoryInfo(inputDir);

                writer.Formatting = Formatting.Indented;
                writer.IndentChar = '\t';
                writer.Indentation = 1;
                writer.WriteStartDocument();
                writer.WriteStartElement("dir");
                writer.WriteAttributeString("name", rootDir.Name);

                WalkDirectoryTree(rootDir);

                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
            finally
            {
                writer.Dispose();
            }
        }

        private static void WalkDirectoryTree(DirectoryInfo root)
        {
            FileInfo[] files = null;
            DirectoryInfo[] subDirs = null;

            files = root.GetFiles("*.*");
            if (files != null)
            {
                foreach (FileInfo fileInfo in files)
                {
                    writer.WriteStartElement("file");
                    writer.WriteAttributeString("name", fileInfo.Name);
                    writer.WriteEndElement();
                }
            }

            subDirs = root.GetDirectories();
            if (subDirs != null)
            {
                foreach (DirectoryInfo dirInfo in subDirs)
                {
                    writer.WriteStartElement("dir");
                    writer.WriteAttributeString("name", dirInfo.Name);
                    WalkDirectoryTree(dirInfo);
                    
                    writer.WriteEndElement();
                }
            }
        }
    }
}
