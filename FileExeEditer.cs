using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Dismord_voic
{
    internal class FileExeEditer
    {
        static public void Load_File(DataGridView FileDataGridView)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load("словарь.xml");
            XmlElement xRoot = xmlDocument.DocumentElement;

            foreach (XmlNode node in xRoot)
            {
                XmlNode attr = node.Attributes.GetNamedItem("id");
                if (attr.Value == "exe")
                {
                    FileDataGridView.RowCount = node.ChildNodes[0].ChildNodes.Count + 1;
                    int i = 0;
                    foreach (XmlNode childNode in node.ChildNodes[0].ChildNodes)
                    {
                        FileDataGridView[0, i].Value = childNode.FirstChild.InnerText;
                        string text = childNode.LastChild.InnerText.Split('"')[1];

                        FileDataGridView[1, i].Value = text;
                        i++;
                    }
                }
            }
        }


        static public void Save_File(DataGridView FileDataGridView)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load("словарь.xml");
            XmlElement xRoot = xmlDocument.DocumentElement;

            foreach (XmlNode node in xRoot)
            {
                XmlNode attr = node.Attributes.GetNamedItem("id");
                if (attr.Value == "exe")
                {
                    node.ChildNodes[0].RemoveAll();
                    for (int i = 0; i < FileDataGridView.RowCount; i++)
                    {
                        if ((FileDataGridView[1, i].Value != null) && (FileDataGridView[0, i].Value != null))
                        {
                            XmlElement FileElement = xmlDocument.CreateElement("item", "http://www.w3.org/2001/06/grammar");
                            XmlElement FileElementTag = xmlDocument.CreateElement("tag", "http://www.w3.org/2001/06/grammar");
                            XmlText FileElementTagText = xmlDocument.CreateTextNode(ConvertToTagText(FileDataGridView[1, i].Value.ToString()));

                            XmlText FileElementText = xmlDocument.CreateTextNode(FileDataGridView[0, i].Value.ToString());

                            FileElementTag.AppendChild(FileElementTagText);
                            FileElement.AppendChild(FileElementText);
                            FileElement.AppendChild(FileElementTag);
                            node.ChildNodes[0].AppendChild(FileElement);
                        }

                    }

                }
            }
            xmlDocument.Save("словарь.xml");
        }


        private static string ConvertToTagText(string text)
        {
            string result = "$ = \"";

            result += text;


            result += "\"";
            return result;


        }
    }
}
