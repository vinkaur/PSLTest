using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Serialization;
using AutoMapper;
using System.IO;

namespace PSLTest
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ItemRequest r = new ItemRequest();

            var serializer = new XmlSerializer(typeof(pubrequest));
            using (var reader = XmlReader.Create("D:\\GitHub\\PSL\\PSLTest\\PSLTest\\PSLTest\\pub.xml"))
            {
                pubrequest info = (pubrequest)serializer.Deserialize(reader);
                var data = info.Request.Select(m => m.Toc.Structure);
                
                r.Item = new List<Item>();
                var item = Mapper.Map<List<request>, List<Item>>(info.Request);
                r.Item = item;
                var text = Mapper.Map<List<Structure>, List<Data>>(data.ToList());                
                var title = Mapper.Map<List<ContentMetaData>, List<Data>>((info.Request.Select(m => m.ContentMetaData)).Where(m => m != null).ToList());
                text.ForEach(m => r.Item.ForEach(x => x.Data = m));                
                title.ForEach(m => r.Item.ForEach(x => x.Data.Title = m.Title));

            }
            var serialize = new XmlSerializer(typeof(ItemRequest));

            using (var writer = File.OpenWrite("D:\\GitHub\\PSL\\PSLTest\\PSLTest\\PSLTest\\FinalXml.xml"))
            {
                serialize.Serialize(writer, r);
            }      
        }
    }
}