using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

using System.Xml;

using Saxon.Api;

namespace SaxonWrapper
{
    public class XQueryProcessor
    {
        private Processor processor;
        private XQueryCompiler compiler;
        private XQueryEvaluator xqueryEvaluator;

        public XQueryProcessor()
        {
            processor = new Processor();
            compiler = processor.NewXQueryCompiler();
        }

        public void Load(string Query)
        {
            xqueryEvaluator = compiler.Compile(Query).Load();
        }

        public void LoadFromFile(string fileName)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                xqueryEvaluator = compiler.Compile(fs).Load();    
            }
            
        }

        public XmlNode RunQuery(XmlNode xmlNode)
        {
            XdmNode indoc = processor.NewDocumentBuilder().Build(new XmlNodeReader(xmlNode));
            DomDestination dest = new DomDestination();
            xqueryEvaluator.Run(dest);
            return dest.XmlDocument;
        }

        public void RunQuery(XmlNode xmlNode, XmlWriter output)
        {
            XdmNode indoc = processor.NewDocumentBuilder().Build(new XmlNodeReader(xmlNode));
            TextWriterDestination twd = new TextWriterDestination(output);
            xqueryEvaluator.ContextItem = indoc;
            xqueryEvaluator.Run(twd);
            twd.Close();
        }

        public static XmlNode RunQuery(XmlNode xmlNode, string XQuery)
        {
            XQueryProcessor saxonXQuery = new XQueryProcessor();
            saxonXQuery.Load(XQuery);
            return saxonXQuery.RunQuery(xmlNode);
        }

        public static void RunQuery(XmlNode inputNode, string XQuery, XmlWriter outputWriter)
        {
            XQueryProcessor saxonXQuery = new XQueryProcessor();
            saxonXQuery.Load(XQuery);
            saxonXQuery.RunQuery(inputNode, outputWriter);
        }

    }
}
