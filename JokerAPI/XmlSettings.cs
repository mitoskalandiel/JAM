using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace JokerAPI
{
    public class SettingsXML
    {
        XmlDocument xmlDocument = new XmlDocument();
        string documentPath = "settings.xml";

        public SettingsXML()
        {
            
            try { xmlDocument.Load(documentPath); }
            catch { xmlDocument.LoadXml("<Settings></Settings>"); }
        }

        public SettingsXML(string file)
        {
            documentPath = file;
            try { xmlDocument.Load(documentPath); }
            catch { xmlDocument.LoadXml("<Settings></Settings>"); }
        }

        public decimal GetSetting(string xPath, decimal defaultValue)
        {
            return Convert.ToDecimal(GetSetting(xPath, Convert.ToString(defaultValue)));
        }

        public void PutSetting(string xPath, decimal value)
        {
            PutSetting(xPath, Convert.ToString(value));
        }

        public byte GetSetting(string xPath, byte defaultValue)
        {
            return Convert.ToByte(GetSetting(xPath, Convert.ToString(defaultValue)));
        }

        public void PutSetting(string xPath, byte value)
        {
            PutSetting(xPath, Convert.ToString(value));
        }
        
        public int GetSetting(string xPath, int defaultValue)
        {
            return Convert.ToInt16(GetSetting(xPath, Convert.ToString(defaultValue)));
        }

        public void PutSetting(string xPath, int value)
        {
            PutSetting(xPath, Convert.ToString(value));
        }

        public bool GetSetting(string xPath, bool defaultValue)
        {
            return Convert.ToBoolean(GetSetting(xPath, Convert.ToString(defaultValue)));
        }

        public void PutSetting(string xPath, bool value)
        {
            PutSetting(xPath, Convert.ToString(value));
        }

        public string GetSetting(string xPath, string defaultValue)
        {
            XmlNode xmlNode = xmlDocument.SelectSingleNode("Settings/" + xPath);
            if (xmlNode != null)
            {
                return xmlNode.InnerText;
            }
            else
            {
                return defaultValue;
            }
        }

        public void PutSetting(string xPath, string value)
        {
            XmlNode xmlNode = xmlDocument.SelectSingleNode("Settings/" + xPath);
            if (xmlNode == null)
            {
                xmlNode = createMissingNode("Settings/" + xPath);
            }
            xmlNode.InnerText = value;
            xmlDocument.Save(documentPath);
        }

        private XmlNode createMissingNode(string xPath)
        {
            string[] xPathSections = xPath.Split('/');
            string currentXPath = "";
            XmlNode testNode = null;
            XmlNode currentNode = xmlDocument.SelectSingleNode("Settings");
            foreach (string xPathSection in xPathSections)
            {
                currentXPath += xPathSection;
                testNode = xmlDocument.SelectSingleNode(currentXPath);
                if (testNode == null)
                {
                    currentNode.InnerXml += "<" +
                        xPathSection + "></" +
                        xPathSection + ">";
                }
                currentNode = xmlDocument.SelectSingleNode(currentXPath);
                currentXPath += "/";
            }
            return currentNode;
        }
    }
}
