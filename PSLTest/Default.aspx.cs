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
using AutoMapper;

namespace PSLTest
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*var serializer = new XmlSerializer(typeof(Item));
            Item pubreq = new Item();
            var serializer = new XmlSerializer(typeof(pubrequest));
            using (var reader = XmlReader.Create(@"D:\Work\PSL\PSLTest\PSLTest\pub.xml"))
            {
                pubrequest info = (pubrequest)serializer.Deserialize(reader);
            }*/

            
           /*var serializer = new XmlSerializer(typeof(pubrequest));
           pubrequest pubreq = new pubrequest();
           using (var reader = XmlReader.Create(@"D:\Work\PSL\PSLTest\PSLTest\pub.xml"))
           {
               pubreq = (pubrequest)serializer.Deserialize(reader);
           }
            Mapper.CreateMap<pubrequest, Item>().ForMember(it => it.ItemId, map => map.MapFrom(pb => pb.RequestId ));

           var item = Mapper.Map<pubrequest, Item>(pubreq);*/

            loadRequestItemXML();
        }

        public void loadRequestItemXML()
        {
            var serializer = new XmlSerializer(typeof(pubrequest));
            using (var reader = XmlReader.Create("D:\\GitHub\\PSL\\PSLTest\\PSLTest\\PSLTest\\pub.xml"))
            {
                pubrequest info = (pubrequest)serializer.Deserialize(reader);
                // do whatever you wanted to do with those locations
                Mapper.CreateMap<request, Item>().ForMember(s => s.ActualEntityId, opt => opt.MapFrom(c => c.Action));
                var item = Mapper.Map<List<request>, List<Item>>(info.Request);
            }
        }
    }
}