using System;
using System.Xml;

namespace XMLmanipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("students.xml");
            foreach(XmlNode node in doc.DocumentElement)
            {
                
                foreach(XmlNode child in node.ChildNodes)
                {
                    Console.WriteLine(child.InnerText);
                }
            }
        }
    }
}
