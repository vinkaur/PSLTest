using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

using System.IO;

namespace PSLTest
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*var serializer = new XmlSerializer(typeof(pubrequest));
            using (var reader = XmlReader.Create(@"D:\Work\PSL\PSLTest\PSLTest\pub.xml"))
            {
                pubrequest info = (pubrequest)serializer.Deserialize(reader);
            }*/

           var serializer = new XmlSerializer(typeof(Item));
           XDocument xdoc = XDocument.Load(@"D:\Work\PSL\PSLTest\PSLTest\ItemXML.xml");
           using (var reader = XmlReader.Create(@"D:\Work\PSL\PSLTest\PSLTest\ItemXML.xml"))
           {
               Item info = (Item)serializer.Deserialize(reader);
           }

            //XDocument xdoc = XDocument.Load(@"D:\Work\PSL\PSLTest\PSLTest\ItemXML.xml");

        }
    }
}