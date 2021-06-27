using System;
using System.Xml;

namespace xml
{
    class xml
    {
        static void CreateXMLFile()
        {
            XmlDocument xmldoc = new XmlDocument();
            XmlElement root = xmldoc.CreateElement("Email");
            xmldoc.AppendChild(root);
            XmlElement element1 = xmldoc.CreateElement("from");
            XmlText text1 = xmldoc.CreateTextNode("Nada");
            root.AppendChild(element1);
            element1.AppendChild(text1);

            XmlElement element2 = xmldoc.CreateElement("to");
            XmlText text2 = xmldoc.CreateTextNode("Lana");
            root.AppendChild(element2);
            element2.AppendChild(text2);

            XmlElement element3 = xmldoc.CreateElement("content");
            XmlText text3 = xmldoc.CreateTextNode("");
            root.AppendChild(element3);
            element3.AppendChild(text3);

            XmlElement element4 = xmldoc.CreateElement("introduction");
            XmlText text4 = xmldoc.CreateTextNode("Dear mr ahmed ... ");
            element3.AppendChild(element4);
            element4.AppendChild(text4);

            XmlElement element5 = xmldoc.CreateElement("Body");
            XmlText text5 = xmldoc.CreateTextNode("Welcome to C#... ");
            element3.AppendChild(element5);
            element5.AppendChild(text5);

            XmlElement element6 = xmldoc.CreateElement("Conclusion");
            XmlText text6 = xmldoc.CreateTextNode("Best Regards ");
            element3.AppendChild(element6);
            element6.AppendChild(text6);


            xmldoc.Save(@"/Users/nadaalotaibi/Downloads/Decomnt/email.xml");
            Console.WriteLine(xmldoc.InnerXml);


        }

        static void ReadXMLFile()
        {
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(@"/Users/nadaalotaibi/Downloads/Decomnt/email.xml");
            foreach (XmlNode node in xmldoc.DocumentElement.ChildNodes)
            {
                string element = node.Name;
                Console.Write(element + ": ");

                string text = node.InnerText;
                Console.WriteLine(text);

            }
        }

        static void Main(string[] args)
        {
             CreateXMLFile();
           ReadXMLFile();

        }
            
        }
    }

