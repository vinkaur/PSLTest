using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using System.Xml;

namespace PSLTest
{
    public partial class validations : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        public bool ValidatePubRequest(string publishRequest)
        {
            bool publishRequestXMLIsValid = false;

            if (string.IsNullOrWhiteSpace(publishRequest))
            {
                throw new ArgumentNullException("DLAPTransformer.ValidatePubRequest() : string:publishRequest can not be null or empty");
            }

            XDocument publishRequestXML = null;
            try
            {
                publishRequestXML = XDocument.Parse(publishRequest);
            }
            catch (Exception ex)
            {
                throw new Exception("DLAPTransformer.ValidatePubRequest() : publishRequest XML is not well formed.");
            }

            if (publishRequestXML == null)
            {
                throw new Exception("DLAPTransformer.ValidatePubRequest() : publishRequest XML can not be null");
            }

            if (publishRequestXML.Element("pubrequest") == null)
            {
                throw new Exception("DLAPTransformer.ValidatePubRequest() : Pubrequest element can not be null");
            }

            var allRequests = from allRequestsXML in publishRequestXML.Element("pubrequest").Elements("request") select allRequestsXML;
            if (allRequests.Count() == 0)
                throw new Exception("DLAPTransformer.ValidatePubRequest() : Request element can not be null");


            var allRequestsRsuiteids = publishRequestXML.Element("pubrequest").Elements("request").Select(m => m.Attribute("rsuiteid")).Where(a => a != null).ToList();
            if (allRequestsRsuiteids.Count() == 0 || allRequestsRsuiteids.Count() < allRequests.Count())
            {
                throw new Exception("DLAPTransformer.ValidatePubRequest() : rsuiteid attribute can not be null");
            }
            if (allRequestsRsuiteids.Any(x => (string)x.Value.Trim() == ""))
            {
                throw new Exception("DLAPTransformer.ValidatePubRequest() : rsuiteid attribute value can not be empty");
            }

            var allRequestsTypes = publishRequestXML.Element("pubrequest").Elements("request").Select(m => m.Attribute("type")).Where(a => a != null).ToList();
            if (allRequestsTypes.Count() == 0 || allRequestsTypes.Count() < allRequests.Count())
            {
                throw new Exception("DLAPTransformer.ValidatePubRequest() : type attribute can not be null");
            }
            if (allRequestsTypes.Any(x => (string)x.Value.Trim() == ""))
            {
                throw new Exception("DLAPTransformer.ValidatePubRequest() : type attribute value can not be empty");
            }

            var allRequestsActions = publishRequestXML.Element("pubrequest").Elements("request").Select(m => m.Element("action")).Where(a => a != null).ToList();
            if (allRequestsActions.Count() == 0 || allRequestsActions.Count() < allRequests.Count())
            {
                throw new Exception("DLAPTransformer.ValidatePubRequest() : action element can not be null");
            }
            if (allRequestsActions.Any(x => (string)x.Value.Trim() == ""))
            {
                throw new Exception("DLAPTransformer.ValidatePubRequest() : action element value can not be empty");
            }
            if (allRequestsActions.Any(x => (string)x.Value.Trim() != "insert" && (string)x.Value.Trim() != "update" && (string)x.Value.Trim() != "delete"))
            {
                throw new Exception("DLAPTransformer.ValidatePubRequest() : action element value can not have operations other than insert/update/delete.");
            }
            var allRequestsContentmetadatas = publishRequestXML.Element("pubrequest").Elements("request").Select(m => m.Element("contentmetadata")).Where(a => a != null).ToList();
            if (allRequestsContentmetadatas.Count() == 0 || allRequestsContentmetadatas.Count() < allRequests.Count())
            {
                throw new Exception("DLAPTransformer.ValidatePubRequest() : contentmetadata element can not be null");
            }
            var allRequestsContentmetadataTitles = publishRequestXML.Element("pubrequest").Elements("request").Elements("contentmetadata").Select(m => m.Element("title")).Where(a => a != null).ToList();
            if (allRequestsContentmetadataTitles.Count() == 0 || allRequestsContentmetadataTitles.Count() < allRequests.Count())
            {
                throw new Exception("DLAPTransformer.ValidatePubRequest() : title element can not be null");
            }
            if (allRequestsContentmetadataTitles.Any(x => (string)x.Value.Trim() == ""))
            {
                throw new Exception("DLAPTransformer.ValidatePubRequest() : title element vxalue can not be empty");
            }
            var allRequestsContentmetadataUrls = publishRequestXML.Element("pubrequest").Elements("request").Elements("contentmetadata").Select(m => m.Element("url")).Where(a => a != null).ToList();
            if (allRequestsContentmetadataUrls.Count() == 0 || allRequestsContentmetadataUrls.Count() < allRequests.Count())
            {
                throw new Exception("DLAPTransformer.ValidatePubRequest() : url element can not be null");
            }
            if (allRequestsContentmetadataUrls.Any(x => (string)x.Value.Trim() == ""))
            {
                throw new Exception("DLAPTransformer.ValidatePubRequest() : url element value can not be empty");
            }
            var allRequestsContentmetadataContentTypes = publishRequestXML.Element("pubrequest").Elements("request").Elements("contentmetadata").Select(m => m.Element("contenttype")).Where(a => a != null).ToList();
            if (allRequestsContentmetadataContentTypes.Count() == 0 || allRequestsContentmetadataContentTypes.Count() < allRequests.Count())
            {
                throw new Exception("DLAPTransformer.ValidatePubRequest() : contenttype element can not be null");
            }
            if (allRequestsContentmetadataContentTypes.Any(x => (string)x.Value.Trim() == ""))
            {
                throw new Exception("DLAPTransformer.ValidatePubRequest() : contenttype element value can not be empty");
            }
            var allRequestsContentmetadataDisplayTypes = publishRequestXML.Element("pubrequest").Elements("request").Elements("contentmetadata").Select(m => m.Element("displaytype")).Where(a => a != null).ToList();
            if (allRequestsContentmetadataDisplayTypes.Count() == 0 || allRequestsContentmetadataDisplayTypes.Count() < allRequests.Count())
            {
                throw new Exception("DLAPTransformer.ValidatePubRequest() : displaytype element can not be null");
            }
            if (allRequestsContentmetadataDisplayTypes.Any(x => (string)x.Value.Trim() == ""))
            {
                throw new Exception("DLAPTransformer.ValidatePubRequest() : displaytype element value can not be empty");
            }
            var allRequestsContentmetadataDefaultFiles = publishRequestXML.Element("pubrequest").Elements("request").Elements("contentmetadata").Select(m => m.Element("defaultfile")).Where(a => a != null).ToList();
            if (allRequestsContentmetadataDefaultFiles.Count() == 0 || allRequestsContentmetadataDefaultFiles.Count() < allRequests.Count())
            {
                throw new Exception("DLAPTransformer.ValidatePubRequest() : defaultfile element can not be null");
            }
            if (allRequestsContentmetadataDefaultFiles.Any(x => (string)x.Value.Trim() == ""))
            {
                throw new Exception("DLAPTransformer.ValidatePubRequest() : defaultfile element value can not be empty");
            }
            var allRequestsContentmetadataDefaultFileTypes = publishRequestXML.Element("pubrequest").Elements("request").Elements("contentmetadata").Elements("defaultfile").Select(m => m.Attribute("type")).Where(a => a != null).ToList();
            if (allRequestsContentmetadataDefaultFileTypes.Count() == 0 || allRequestsContentmetadataDefaultFileTypes.Count() < allRequests.Count())
            {
                throw new Exception("DLAPTransformer.ValidatePubRequest() : type attribute can not be null");
            }
            if (allRequestsContentmetadataDefaultFileTypes.Any(x => (string)x.Value.Trim() == ""))
            {
                throw new Exception("DLAPTransformer.ValidatePubRequest() : type attribute value can not be empty");
            }
            var allRequestsCourseContentmetadatas = publishRequestXML.Element("pubrequest").Elements("request").Select(m => m.Element("coursecontentmetadata")).Where(a => a != null).ToList();
            if (allRequestsCourseContentmetadatas.Count() == 0 || allRequestsCourseContentmetadatas.Count() < allRequests.Count())
            {
                throw new Exception("DLAPTransformer.ValidatePubRequest() : action element can not be null");
            }
            var allRequestsCourseContentmetadataAllowComments = publishRequestXML.Element("pubrequest").Elements("request").Elements("coursecontentmetadata").Select(m => m.Element("allowcomments")).Where(a => a != null).ToList();
            if (allRequestsCourseContentmetadataAllowComments.Count() == 0 || allRequestsCourseContentmetadataAllowComments.Count() < allRequests.Count())
            {
                throw new Exception("DLAPTransformer.ValidatePubRequest() : allowcomments element can not be null");
            }
            var allRequestsCourseContentmetadataAttemptLimits = publishRequestXML.Element("pubrequest").Elements("request").Elements("coursecontentmetadata").Select(m => m.Element("attemptlimit")).Where(a => a != null).ToList();
            if (allRequestsCourseContentmetadataAttemptLimits.Count() == 0 || allRequestsCourseContentmetadataAttemptLimits.Count() < allRequests.Count())
            {
                throw new Exception("DLAPTransformer.ValidatePubRequest() : attemptlimit element can not be null");
            }
            var allRequestsCourseContentmetadatAssociatedUnits = publishRequestXML.Element("pubrequest").Elements("request").Elements("coursecontentmetadata").Select(m => m.Element("associatedunits")).Where(a => a != null).ToList();
            if (allRequestsCourseContentmetadatAssociatedUnits.Count() == 0 || allRequestsCourseContentmetadatAssociatedUnits.Count() < allRequests.Count())
            {
                throw new Exception("DLAPTransformer.ValidatePubRequest() : associatedunits element can not be null");
            }
            var allRequestsCourseContentmetadatAssociatedUnitUnits = publishRequestXML.Element("pubrequest").Elements("request").Elements("coursecontentmetadata").Elements("associatedunits").Select(m => m.Element("Unit")).Where(a => a != null).ToList();
            if (allRequestsCourseContentmetadatAssociatedUnitUnits.Count() == 0 || allRequestsCourseContentmetadatAssociatedUnitUnits.Count() < allRequests.Count())
            {
                throw new Exception("DLAPTransformer.ValidatePubRequest() : Unit element can not be null");
            }
            if (allRequestsCourseContentmetadatAssociatedUnitUnits.Any(x => (string)x.Value.Trim() == ""))
            {
                throw new Exception("DLAPTransformer.ValidatePubRequest() : Unit element value can not be empty");
            }
            var allRequestsCourseContentmetadatAssociatedUnitUnitRsuiteId = publishRequestXML.Element("pubrequest").Elements("request").Elements("coursecontentmetadata").Elements("associatedunits").Elements("unit").Select(m => m.Attribute("rsuiteid")).Where(a => a != null).ToList();
            if (allRequestsCourseContentmetadatAssociatedUnitUnitRsuiteId.Count() == 0 || allRequestsCourseContentmetadatAssociatedUnitUnitRsuiteId.Count() < allRequests.Count())
            {
                throw new Exception("DLAPTransformer.ValidatePubRequest() : Unit element attribute rsuiteid can not be null");
            }
            if (allRequestsCourseContentmetadatAssociatedUnitUnitRsuiteId.Any(x => (string)x.Value.Trim() == ""))
            {
                throw new Exception("DLAPTransformer.ValidatePubRequest() : Unit element attribute rsuiteid can not be empty");
            }
            var allRequestsTocs = publishRequestXML.Element("pubrequest").Elements("request").Select(m => m.Element("toc")).Where(a => a != null).ToList();
            if (allRequestsTocs.Count() == 0 || allRequestsTocs.Count() < allRequests.Count())
            {
                throw new Exception("DLAPTransformer.ValidatePubRequest() : TOC element can not be null");
            }
            var allRequestsTocStructures = publishRequestXML.Element("pubrequest").Elements("request").Elements("toc").Select(m => m.Element("structure")).Where(a => a != null).ToList();
            if (allRequestsTocStructures.Count() == 0 || allRequestsTocStructures.Count() < allRequests.Count())
            {
                throw new Exception("DLAPTransformer.ValidatePubRequest() : Structure element can not be null");
            }
            var allRequestsTocStructureTypes = publishRequestXML.Element("pubrequest").Elements("request").Elements("toc").Elements("structure").Select(m => m.Attribute("type")).Where(a => a != null).ToList();
            if (allRequestsTocStructureTypes.Count() == 0 || allRequestsTocStructureTypes.Count() < allRequests.Count())
            {
                throw new Exception("DLAPTransformer.ValidatePubRequest() : Structure element attribute type can not be null");
            }
            if (allRequestsTocStructureTypes.Any(x => (string)x.Value.Trim() == ""))
            {
                throw new Exception("DLAPTransformer.ValidatePubRequest() : Structure element attribute type can not be empty");
            }
            var allRequestsTocStructureHideFromLaunchpads = publishRequestXML.Element("pubrequest").Elements("request").Elements("toc").Elements("structure").Select(m => m.Attribute("hidefromlaunchpad")).Where(a => a != null).ToList();
            if (allRequestsTocStructureHideFromLaunchpads.Count() == 0 || allRequestsTocStructureHideFromLaunchpads.Count() < allRequests.Count())
            {
                throw new Exception("DLAPTransformer.ValidatePubRequest() : Structure element attribute hidefromlaunchpad can not be null");
            }
            if (allRequestsTocStructureHideFromLaunchpads.Any(x => (string)x.Value.Trim() == ""))
            {
                throw new Exception("DLAPTransformer.ValidatePubRequest() : Structure element attribute hidefromlaunchpad can not be empty");
            }
            var allRequestsTocStructureAssociatedUnitIds = publishRequestXML.Element("pubrequest").Elements("request").Elements("toc").Elements("structure").Select(m => m.Element("associatedunitid")).Where(a => a != null).ToList();
            if (allRequestsTocStructureAssociatedUnitIds.Count() == 0 || allRequestsTocStructureAssociatedUnitIds.Count() < allRequests.Count())
            {
                throw new Exception("DLAPTransformer.ValidatePubRequest() : Associated Unit Id element can not be null");
            }
            var allRequestsTocStructureparentid = publishRequestXML.Element("pubrequest").Elements("request").Elements("toc").Elements("structure").Select(m => m.Element("parentid")).Where(a => a != null).ToList();
            if (allRequestsTocStructureparentid.Count() == 0 || allRequestsTocStructureparentid.Count() < allRequests.Count())
            {
                throw new Exception("DLAPTransformer.ValidatePubRequest() : Parent Id element can not be null");
            }
            var allRequestsTocStructureSequence = publishRequestXML.Element("pubrequest").Elements("request").Elements("toc").Elements("structure").Select(m => m.Element("sequence")).Where(a => a != null).ToList();
            if (allRequestsTocStructureSequence.Count() == 0 || allRequestsTocStructureSequence.Count() < allRequests.Count())
            {
                throw new Exception("DLAPTransformer.ValidatePubRequest() : Sequence element can not be null");
            }
            return publishRequestXMLIsValid;
        }
        //public bool ValidatePubRequest(string publishRequest)
        //{
        //    bool test = true;
        //    XDocument xDoc = XDocument.Load(@"D:\\PSLTest\\PSLTest\\pub.xml");
            
        //    var request = from req in xDoc.Descendants("pubrequest").Elements("request") select req;

        //    var rsuiteid = xDoc.Descendants("pubrequest").Select(m => m.Elements("request").Attributes("rsuiteid").Where(x => x.Value == "")).ToList();

        //    var type = xDoc.Descendants("pubrequest").Select(m => m.Elements("request").Attributes("type").Where(x => x.Value == "")).ToList();

        //    var action = xDoc.Descendants("pubrequest").Select(m => m.Elements("request").Elements("action").Where(x => x.Value == "")).ToList();

        //    var actions = xDoc.Descendants("pubrequest").Select(m => m.Element("request").Element("action").Value);

        //    if (request.Count() == 0)
        //        throw new Exception("DLAPTransformer.ValidatePubRequest() : Request element can not be null");

        //    if (request.Attributes("rsuiteid") == null ||
        //        rsuiteid.Count() != 0)
        //        throw new Exception("DLAPTransformer.ValidatePubRequest() : rsuiteid attribute can not be null or empty");

        //    if (request.Attributes("type") == null ||
        //       type.Count() != 0)
        //        throw new Exception("DLAPTransformer.ValidatePubRequest() : type attribute can not be null or empty");

        //    if (request.Elements("action").Count() != request.Count() ||
        //        action.Count() != 0)
        //        throw new Exception("DLAPTransformer.ValidatePubRequest() : action element can not be null or empty");

        //    if (actions.Contains("insert") &&
        //        actions.Contains("update") &&
        //        actions.Contains("delete"))
        //        throw new Exception("DLAPTransformer.ValidatePubRequest() : Action element can not perform operations other than insert/update/delete");

        //    if (request.Elements("contentmetadata").Count() != request.Count())
        //        throw new Exception("DLAPTransformer.ValidatePubRequest() : contentmetxadata element can not be null");

        //    if (request.Elements("coursecontentmetadata").Count() != request.Count())
        //        throw new Exception("DLAPTransformer.ValidatePubRequest() : coursecontentmetadata element can not be null");

        //    if (request.Elements("toc").Count() != request.Count())
        //        throw new Exception("DLAPTransformer.ValidatePubRequest() : toc element can not be null");
        //    return test;
        //}
    }
}