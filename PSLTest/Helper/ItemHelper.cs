using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;
using System.Xml.Linq;

namespace PSLTest.Helper
{
    public class ItemHelper
    {
        public Dictionary<string, string> DictType = new Dictionary<string, string>()
        {
            {"learningcurve","CustomActivity"},
            {"resource","Resource"},
            {"arga","CustomActivity"},
            {"dropbox","Assignment"},
            {"unit","Folder"},
            {"quiz","Assessment"},
            {"argaflashcard","Assignment"},
        };
        
        public string GetParentId(XElement xItemElement)
        {
            string strParentId = string.Empty;
            strParentId = xItemElement.Element("toc").Element("structure").Element("parentid").Value;
            return strParentId;
        }

        public string GetType(XElement xItemElement)
        {
            string strType = string.Empty;
            strType = xItemElement.Attribute("type").Value;
            if (strType != "" && DictType.Keys.Contains(strType))
                strType = DictType[strType].ToString();
            else 
                strType = "NO_VALUE";
            return strType;
        }

        public string GetSequecneId(XElement xItemElement)
        {
            string strSequence = "NO_VALUE";
            strSequence = xItemElement.Element("toc").Element("structure").Element("sequence").Value;
            return strSequence;
        }

        public string GetTitle(XElement xItemElement)
        {
            string strTitle = "NO_VALUE";
            strTitle = xItemElement.Element("contentmetadata").Element("title").Value;
            return strTitle;
        }

       
    }
}