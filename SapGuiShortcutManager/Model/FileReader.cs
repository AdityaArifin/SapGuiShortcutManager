using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SapGuiShortcutManager.Model
{
    class FileReader
    {
        #region Constructor
        public FileReader()
        {

        }
        #endregion

        #region Properties
        #endregion

        #region Methods
        public XmlDocument ReadXMLFile(String filePath)
        {
            XmlDocument document = new XmlDocument();
            document.Load(@filePath);
            return document;
        }

        public XmlNodeList ReadConfiguration(String filePath, String configNode)
        {
            XmlDocument document = new XmlDocument();
            document = ReadXMLFile(filePath);

            XmlNodeList nodes = document.DocumentElement.SelectNodes(configNode);
            return nodes;
        }
        #endregion
    }
}
