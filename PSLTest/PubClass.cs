using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace PSLTest
{
    [Serializable]
    [XmlRoot("pubrequest")]
    public class pubrequest
    {
        [XmlAttribute("requestid")]
        public string RequestId { get; set; }

        [XmlAttribute("type")]
        public string Type { get; set; }

        [XmlAttribute("tier")]
        public string Tier { get; set; }

        [XmlAttribute("entityid")]
        public int EntityId { get; set; }

        [XmlAttribute("discipline")]
        public string Discipline { get; set; }

        [XmlElement("request")]
        public List<request> Request { get; set; }

    }

    public class request
    {
        [XmlAttribute("rsuiteid")]
        public string RsuiteId { get; set; }

        [XmlAttribute("type")]
        public string Type { get; set; }

        [XmlElement("version")]
        public string Version { get; set; }

        [XmlElement("action")]
        public string Action { get; set; }

        [XmlElement("contentmetadata")]
        public ContentMetaData ContentMetaData { get; set; }

        [XmlElement("coursecontentmetadata")]
        public CourseContentMetaData CourseContentMetaData { get; set; }

        [XmlElement("toc")]
        public Toc Toc { get; set; }

    }

    public class ContentMetaData
    {
        [XmlElement("title")]
        public string Title { get; set; }

        [XmlElement("contenttype")]
        public string ContentType { get; set; }

        [XmlElement("displaytype")]
        public string DisplayType { get; set; }        

        [XmlElement("defaultfile")]
        public DefaultFile DefaultFile { get; set; }

        [XmlArray("referencedobjects"), XmlArrayItem("object")]
        public List<Object> Object { get; set; }
    }

    public class DefaultFile
    {
        [XmlAttribute("type")]
        public string Type { get; set; }

        [XmlAttribute("version")]
        public string Version { get; set; }
    }

    public class Object
    {
        [XmlElement("version")]
        public string Version { get; set; }
    }
    public class CourseContentMetaData
    {
        [XmlElement("allowComments")]
        public string AllowComments { get; set; }

        [XmlElement("attemptlimit")]
        public string AttemptLimit { get; set; }

        [XmlElement("defaultpoints")]
        public string DefaultPoints { get; set; }

        [XmlElement("description")]
        public string Description { get; set; }

        [XmlElement("graderule")]
        public string GradeRule { get; set; }

        [XmlElement("instructoronly")]
        public string InstructorOnly { get; set; }

        [XmlElement("latesubmissions")]
        public string LateSubmissions { get; set; }

        [XmlElement("openinsuppwindow")]
        public string OpenInSuppWindow { get; set; }

        [XmlElement("subtitle")]
        public string SubTitle { get; set; }

        [XmlElement("thumbnailimage")]
        public ThumbNailImage ThumbNailImage { get; set; }

        [XmlElement("useproxypage")]
        public string UseProxyPage { get; set; }

        [XmlElement("viewsubmit")]
        public string ViewSubmit { get; set; }

        [XmlArray("associatedunits"), XmlArrayItem("unit")]
        public List<Unit> Unit { get; set; }
    }

    public class ThumbNailImage
    {
        [XmlAttribute("version")]
        public string Version { get; set; }
    }

    public class Unit
    {
        [XmlAttribute("rsuiteid")]
        public string RsuiteId { get; set; }
    }
    public class Toc
    {
        [XmlElement("structure")]
        public Structure Structure { get; set; }                
    }

    public class Structure
    {
        [XmlElement("associatedunitid")]
        public string AssociatedUnitId { get; set; }

        [XmlElement("parentid")]
        public string ParentId { get; set; }

        [XmlElement("sequence")]
        public string Sequence { get; set; }
    }
}