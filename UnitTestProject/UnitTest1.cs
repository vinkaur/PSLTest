using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PSLTest;
using System.Web.UI;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedExceptionAttribute(typeof(Exception))]
        public void TestValidatePubRequestWhenXMLIsInvalid()
        {
            //Arrange
            string strCourseXML = "<pubrequest requestid='adsfds' type='dlap' tier='dev' entityid='132434' discipline='astronomy'>" +
                                    "<daterequested>3/14/2015 14:00</daterequested>" +
                                    "<publishuser>gsternig</publishuser> " +
                                      "<request rsuiteid='rsuitid1' type='learningcurve'>" +
                                            "<version>2.1</version>" +
                                            "<action>insert</action>  " +         
                                            "<contentmetadata> " +
                                                "<title>Reel Teaching Clip:  Chinese Immigrants Encounter Nativism (2:04)</title>" +
                                                "<contenttype>ExternalContent</contenttype>" +
                                                "<displaytype>Display Content</displaytype>   " +    
                                                "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                                "<referencedobjects>" +
                                                  "<object version='1'>/js</object>" +
                                                  "<object version='1'>/images</object>" +
                                                "</referencedobjects>" +                      
                                            "</contentmetadata>" +
                                            "<coursecontentmetadata>" +
                                                "<allowComments>true</allowComments>" +
                                                "<attemptlimit>0</attemptlimit>" +
                                                "<defaultpoints>0</defaultpoints>" +
                                                "<description>Test Description</description>" +
                                                "<graderule>2</graderule>" +
                                                "<instructoronly>Student instructor</instructoronly>" +
                                                "<latesubmissions>true</latesubmissions>" +
                                                "<openinsuppwindow>true</openinsuppwindow>" +
                                                "<subtitle>Clip</subtitle>" +
                                                "<thumbnailimage version='1' />" +
                                                "<useproxypage>false</useproxypage>" +
                                                "<viewsubmit>yes</viewsubmit>" +        
                                                "<associatedunits>" +
                                                    "<unit rsuiteid='rsuitid1'>Chapter 1</unit>" +
                                                "</associatedunits>" +        
                                            "</coursecontentmetadata> " +     
                                            "<toc>" +
                                                "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                                    "<associatedunitid/>" +
                                                    "<parentid>bsi__17593B4C__90B3__45B3__8211__6B0CA6984500</parentid>" +
                                                    "<sequence>zzzb</sequence>" +
                                                "</structure>" +
                                            "</toc>" +
                                        "</request>" +
                                      "<request rsuiteid='rsuitid2' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>0</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid2'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuiteid3' type='quiz'>" +
                                        "<version>2.3</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid3'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuitid4' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid4'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuitid5' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid5'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                    "</pubrequest>" ;

            validations validations = new validations();

            //Act
            validations.ValidatePubRequest(strCourseXML);
        }
        [TestMethod]
        [ExpectedExceptionAttribute(typeof(Exception))]
        public void TestValidatePubRequestWhenPubRequestTagIsMissing()
        {
            //Arrange
            bool result;
            string strCourseXML = "<pubrequest requestid='adsfds' type='dlap' tier='dev' entityid='132434' discipline='astronomy'>" +
                                    "<daterequested>3/14/2015 14:00</daterequested>" +
                                    "<publishuser>gsternig</publishuser> " +
                                      "<request rsuiteid='rsuitid1' type='learningcurve'>" +
                                            "<version>2.1</version>" +
                                            "<action>insert</action>  " +         
                                            "<contentmetadata> " +
                                                "<title>Reel Teaching Clip:  Chinese Immigrants Encounter Nativism (2:04)</title>" +
                                                "<contenttype>ExternalContent</contenttype>" +
                                                "<displaytype>Display Content</displaytype>   " +    
                                                "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                                "<referencedobjects>" +
                                                  "<object version='1'>/js</object>" +
                                                  "<object version='1'>/images</object>" +
                                                "</referencedobjects>" +                      
                                            "</contentmetadata>" +
                                            "<coursecontentmetadata>" +
                                                "<allowComments>true</allowComments>" +
                                                "<attemptlimit>0</attemptlimit>" +
                                                "<defaultpoints>0</defaultpoints>" +
                                                "<description>Test Description</description>" +
                                                "<graderule>2</graderule>" +
                                                "<instructoronly>Student instructor</instructoronly>" +
                                                "<latesubmissions>true</latesubmissions>" +
                                                "<openinsuppwindow>true</openinsuppwindow>" +
                                                "<subtitle>Clip</subtitle>" +
                                                "<thumbnailimage version='1' />" +
                                                "<useproxypage>false</useproxypage>" +
                                                "<viewsubmit>yes</viewsubmit>" +        
                                                "<associatedunits>" +
                                                    "<unit rsuiteid='rsuitid1'>Chapter 1</unit>" +
                                                "</associatedunits>" +        
                                            "</coursecontentmetadata> " +     
                                            "<toc>" +
                                                "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                                    "<associatedunitid/>" +
                                                    "<parentid>bsi__17593B4C__90B3__45B3__8211__6B0CA6984500</parentid>" +
                                                    "<sequence>zzzb</sequence>" +
                                                "</structure>" +
                                            "</toc>" +
                                        "</request>" +
                                      "<request rsuiteid='rsuitid2' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>0</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid2'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuiteid3' type='quiz'>" +
                                        "<version>2.3</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid3'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuitid4' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid4'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuitid5' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid5'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                    "</pubrequest>" ;

            validations validations = new validations();

            //Act
            result = validations.ValidatePubRequest(strCourseXML);
        }

        [TestMethod]
        [ExpectedExceptionAttribute(typeof(Exception))]
        public void TestValidatePubRequestWhenPubRequestAttributeRequestidIsMissing()
        {
            //Arrange
            bool result;
            string strCourseXML = "<pubrequest requestid='adsfds' type='dlap' tier='dev' entityid='132434' discipline='astronomy'>" +
                                    "<daterequested>3/14/2015 14:00</daterequested>" +
                                    "<publishuser>gsternig</publishuser> " +
                                      "<request rsuiteid='rsuitid1' type='learningcurve'>" +
                                            "<version>2.1</version>" +
                                            "<action>insert</action>  " +         
                                            "<contentmetadata> " +
                                                "<title>Reel Teaching Clip:  Chinese Immigrants Encounter Nativism (2:04)</title>" +
                                                "<contenttype>ExternalContent</contenttype>" +
                                                "<displaytype>Display Content</displaytype>   " +    
                                                "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                                "<referencedobjects>" +
                                                  "<object version='1'>/js</object>" +
                                                  "<object version='1'>/images</object>" +
                                                "</referencedobjects>" +                      
                                            "</contentmetadata>" +
                                            "<coursecontentmetadata>" +
                                                "<allowComments>true</allowComments>" +
                                                "<attemptlimit>0</attemptlimit>" +
                                                "<defaultpoints>0</defaultpoints>" +
                                                "<description>Test Description</description>" +
                                                "<graderule>2</graderule>" +
                                                "<instructoronly>Student instructor</instructoronly>" +
                                                "<latesubmissions>true</latesubmissions>" +
                                                "<openinsuppwindow>true</openinsuppwindow>" +
                                                "<subtitle>Clip</subtitle>" +
                                                "<thumbnailimage version='1' />" +
                                                "<useproxypage>false</useproxypage>" +
                                                "<viewsubmit>yes</viewsubmit>" +        
                                                "<associatedunits>" +
                                                    "<unit rsuiteid='rsuitid1'>Chapter 1</unit>" +
                                                "</associatedunits>" +        
                                            "</coursecontentmetadata> " +     
                                            "<toc>" +
                                                "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                                    "<associatedunitid/>" +
                                                    "<parentid>bsi__17593B4C__90B3__45B3__8211__6B0CA6984500</parentid>" +
                                                    "<sequence>zzzb</sequence>" +
                                                "</structure>" +
                                            "</toc>" +
                                        "</request>" +
                                      "<request rsuiteid='rsuitid2' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>0</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid2'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuiteid3' type='quiz'>" +
                                        "<version>2.3</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid3'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuitid4' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid4'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuitid5' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid5'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                    "</pubrequest>" ;
            validations validations = new validations();

            //Act
            result = validations.ValidatePubRequest(strCourseXML);
        }

        [TestMethod]
        [ExpectedExceptionAttribute(typeof(Exception))]
        public void TestValidatePubRequestWhenPubRequestAttributeRequestidIsEmpty()
        {
            //Arrange
            bool result;
           string strCourseXML = "<pubrequest requestid='adsfds' type='dlap' tier='dev' entityid='132434' discipline='astronomy'>" +
                                    "<daterequested>3/14/2015 14:00</daterequested>" +
                                    "<publishuser>gsternig</publishuser> " +
                                      "<request rsuiteid='rsuitid1' type='learningcurve'>" +
                                            "<version>2.1</version>" +
                                            "<action>insert</action>  " +         
                                            "<contentmetadata> " +
                                                "<title>Reel Teaching Clip:  Chinese Immigrants Encounter Nativism (2:04)</title>" +
                                                "<contenttype>ExternalContent</contenttype>" +
                                                "<displaytype>Display Content</displaytype>   " +    
                                                "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                                "<referencedobjects>" +
                                                  "<object version='1'>/js</object>" +
                                                  "<object version='1'>/images</object>" +
                                                "</referencedobjects>" +                      
                                            "</contentmetadata>" +
                                            "<coursecontentmetadata>" +
                                                "<allowComments>true</allowComments>" +
                                                "<attemptlimit>0</attemptlimit>" +
                                                "<defaultpoints>0</defaultpoints>" +
                                                "<description>Test Description</description>" +
                                                "<graderule>2</graderule>" +
                                                "<instructoronly>Student instructor</instructoronly>" +
                                                "<latesubmissions>true</latesubmissions>" +
                                                "<openinsuppwindow>true</openinsuppwindow>" +
                                                "<subtitle>Clip</subtitle>" +
                                                "<thumbnailimage version='1' />" +
                                                "<useproxypage>false</useproxypage>" +
                                                "<viewsubmit>yes</viewsubmit>" +        
                                                "<associatedunits>" +
                                                    "<unit rsuiteid='rsuitid1'>Chapter 1</unit>" +
                                                "</associatedunits>" +        
                                            "</coursecontentmetadata> " +     
                                            "<toc>" +
                                                "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                                    "<associatedunitid/>" +
                                                    "<parentid>bsi__17593B4C__90B3__45B3__8211__6B0CA6984500</parentid>" +
                                                    "<sequence>zzzb</sequence>" +
                                                "</structure>" +
                                            "</toc>" +
                                        "</request>" +
                                      "<request rsuiteid='rsuitid2' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>0</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid2'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuiteid3' type='quiz'>" +
                                        "<version>2.3</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid3'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuitid4' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid4'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuitid5' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid5'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                    "</pubrequest>" ;
            validations validations = new validations();

            //Act
            result = validations.ValidatePubRequest(strCourseXML);
        }

        [TestMethod]
        [ExpectedExceptionAttribute(typeof(Exception))]
        public void TestValidatePubRequestWhenPubRequestAttributeTypeIsMissing()
        {
            //Arrange
            bool result;
            string strCourseXML = "<pubrequest requestid='adsfds' type='dlap' tier='dev' entityid='132434' discipline='astronomy'>" +
                                    "<daterequested>3/14/2015 14:00</daterequested>" +
                                    "<publishuser>gsternig</publishuser> " +
                                      "<request rsuiteid='rsuitid1' type='learningcurve'>" +
                                            "<version>2.1</version>" +
                                            "<action>insert</action>  " +
                                            "<contentmetadata> " +
                                                "<title>Reel Teaching Clip:  Chinese Immigrants Encounter Nativism (2:04)</title>" +
                                                "<contenttype>ExternalContent</contenttype>" +
                                                "<displaytype>Display Content</displaytype>   " +
                                                "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                                "<referencedobjects>" +
                                                  "<object version='1'>/js</object>" +
                                                  "<object version='1'>/images</object>" +
                                                "</referencedobjects>" +
                                            "</contentmetadata>" +
                                            "<coursecontentmetadata>" +
                                                "<allowComments>true</allowComments>" +
                                                "<attemptlimit>0</attemptlimit>" +
                                                "<defaultpoints>0</defaultpoints>" +
                                                "<description>Test Description</description>" +
                                                "<graderule>2</graderule>" +
                                                "<instructoronly>Student instructor</instructoronly>" +
                                                "<latesubmissions>true</latesubmissions>" +
                                                "<openinsuppwindow>true</openinsuppwindow>" +
                                                "<subtitle>Clip</subtitle>" +
                                                "<thumbnailimage version='1' />" +
                                                "<useproxypage>false</useproxypage>" +
                                                "<viewsubmit>yes</viewsubmit>" +
                                                "<associatedunits>" +
                                                    "<unit rsuiteid='rsuitid1'>Chapter 1</unit>" +
                                                "</associatedunits>" +
                                            "</coursecontentmetadata> " +
                                            "<toc>" +
                                                "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                                    "<associatedunitid/>" +
                                                    "<parentid>bsi__17593B4C__90B3__45B3__8211__6B0CA6984500</parentid>" +
                                                    "<sequence>zzzb</sequence>" +
                                                "</structure>" +
                                            "</toc>" +
                                        "</request>" +
                                      "<request rsuiteid='rsuitid2' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>0</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid2'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuiteid3' type='quiz'>" +
                                        "<version>2.3</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid3'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuitid4' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid4'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuitid5' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid5'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                    "</pubrequest>";

            validations validations = new validations();

            //Act
            result = validations.ValidatePubRequest(strCourseXML);
        }

        [TestMethod]
        [ExpectedExceptionAttribute(typeof(Exception))]
        public void TestValidatePubRequestWhenPubRequestAttributeTypeIsEmpty()
        {
            //Arrange
            bool result;
            string strCourseXML = "<pubrequest requestid='adsfds' type='dlap' tier='dev' entityid='132434' discipline='astronomy'>" +
                                    "<daterequested>3/14/2015 14:00</daterequested>" +
                                    "<publishuser>gsternig</publishuser> " +
                                      "<request rsuiteid='rsuitid1' type='learningcurve'>" +
                                            "<version>2.1</version>" +
                                            "<action>insert</action>  " +
                                            "<contentmetadata> " +
                                                "<title>Reel Teaching Clip:  Chinese Immigrants Encounter Nativism (2:04)</title>" +
                                                "<contenttype>ExternalContent</contenttype>" +
                                                "<displaytype>Display Content</displaytype>   " +
                                                "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                                "<referencedobjects>" +
                                                  "<object version='1'>/js</object>" +
                                                  "<object version='1'>/images</object>" +
                                                "</referencedobjects>" +
                                            "</contentmetadata>" +
                                            "<coursecontentmetadata>" +
                                                "<allowComments>true</allowComments>" +
                                                "<attemptlimit>0</attemptlimit>" +
                                                "<defaultpoints>0</defaultpoints>" +
                                                "<description>Test Description</description>" +
                                                "<graderule>2</graderule>" +
                                                "<instructoronly>Student instructor</instructoronly>" +
                                                "<latesubmissions>true</latesubmissions>" +
                                                "<openinsuppwindow>true</openinsuppwindow>" +
                                                "<subtitle>Clip</subtitle>" +
                                                "<thumbnailimage version='1' />" +
                                                "<useproxypage>false</useproxypage>" +
                                                "<viewsubmit>yes</viewsubmit>" +
                                                "<associatedunits>" +
                                                    "<unit rsuiteid='rsuitid1'>Chapter 1</unit>" +
                                                "</associatedunits>" +
                                            "</coursecontentmetadata> " +
                                            "<toc>" +
                                                "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                                    "<associatedunitid/>" +
                                                    "<parentid>bsi__17593B4C__90B3__45B3__8211__6B0CA6984500</parentid>" +
                                                    "<sequence>zzzb</sequence>" +
                                                "</structure>" +
                                            "</toc>" +
                                        "</request>" +
                                      "<request rsuiteid='rsuitid2' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>0</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid2'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuiteid3' type='quiz'>" +
                                        "<version>2.3</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid3'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuitid4' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid4'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuitid5' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid5'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                    "</pubrequest>";

            validations validations = new validations();

            //Act
            result = validations.ValidatePubRequest(strCourseXML);
        }
        [TestMethod]
        [ExpectedExceptionAttribute(typeof(Exception))]
        public void TestValidatePubRequestWhenEntityIdNull()
        {
            // Arrange
            bool result;
            validations validations = new validations();
            string strCourseXML = "<pubrequest requestid='adsfds' type='dlap' tier='dev' entityid='132434' discipline='astronomy'>" +
                                    "<daterequested>3/14/2015 14:00</daterequested>" +
                                    "<publishuser>gsternig</publishuser> " +
                                      "<request rsuiteid='rsuitid1' type='learningcurve'>" +
                                            "<version>2.1</version>" +
                                            "<action>insert</action>  " +
                                            "<contentmetadata> " +
                                                "<title>Reel Teaching Clip:  Chinese Immigrants Encounter Nativism (2:04)</title>" +
                                                "<contenttype>ExternalContent</contenttype>" +
                                                "<displaytype>Display Content</displaytype>   " +
                                                "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                                "<referencedobjects>" +
                                                  "<object version='1'>/js</object>" +
                                                  "<object version='1'>/images</object>" +
                                                "</referencedobjects>" +
                                            "</contentmetadata>" +
                                            "<coursecontentmetadata>" +
                                                "<allowComments>true</allowComments>" +
                                                "<attemptlimit>0</attemptlimit>" +
                                                "<defaultpoints>0</defaultpoints>" +
                                                "<description>Test Description</description>" +
                                                "<graderule>2</graderule>" +
                                                "<instructoronly>Student instructor</instructoronly>" +
                                                "<latesubmissions>true</latesubmissions>" +
                                                "<openinsuppwindow>true</openinsuppwindow>" +
                                                "<subtitle>Clip</subtitle>" +
                                                "<thumbnailimage version='1' />" +
                                                "<useproxypage>false</useproxypage>" +
                                                "<viewsubmit>yes</viewsubmit>" +
                                                "<associatedunits>" +
                                                    "<unit rsuiteid='rsuitid1'>Chapter 1</unit>" +
                                                "</associatedunits>" +
                                            "</coursecontentmetadata> " +
                                            "<toc>" +
                                                "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                                    "<associatedunitid/>" +
                                                    "<parentid>bsi__17593B4C__90B3__45B3__8211__6B0CA6984500</parentid>" +
                                                    "<sequence>zzzb</sequence>" +
                                                "</structure>" +
                                            "</toc>" +
                                        "</request>" +
                                      "<request rsuiteid='rsuitid2' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>0</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid2'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuiteid3' type='quiz'>" +
                                        "<version>2.3</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid3'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuitid4' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid4'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuitid5' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid5'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                    "</pubrequest>";
            //Act
            result = validations.ValidatePubRequest(strCourseXML);
        }

        [TestMethod]
        [ExpectedExceptionAttribute(typeof(Exception))]
        public void TestValidatePubRequestWhenPubRequestAttributeTierIsMissing()
        {
            //Arrange
            bool result;
            string strCourseXML = "<pubrequest requestid='adsfds' type='dlap' tier='dev' entityid='132434' discipline='astronomy'>" +
                                    "<daterequested>3/14/2015 14:00</daterequested>" +
                                    "<publishuser>gsternig</publishuser> " +
                                      "<request rsuiteid='rsuitid1' type='learningcurve'>" +
                                            "<version>2.1</version>" +
                                            "<action>insert</action>  " +
                                            "<contentmetadata> " +
                                                "<title>Reel Teaching Clip:  Chinese Immigrants Encounter Nativism (2:04)</title>" +
                                                "<contenttype>ExternalContent</contenttype>" +
                                                "<displaytype>Display Content</displaytype>   " +
                                                "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                                "<referencedobjects>" +
                                                  "<object version='1'>/js</object>" +
                                                  "<object version='1'>/images</object>" +
                                                "</referencedobjects>" +
                                            "</contentmetadata>" +
                                            "<coursecontentmetadata>" +
                                                "<allowComments>true</allowComments>" +
                                                "<attemptlimit>0</attemptlimit>" +
                                                "<defaultpoints>0</defaultpoints>" +
                                                "<description>Test Description</description>" +
                                                "<graderule>2</graderule>" +
                                                "<instructoronly>Student instructor</instructoronly>" +
                                                "<latesubmissions>true</latesubmissions>" +
                                                "<openinsuppwindow>true</openinsuppwindow>" +
                                                "<subtitle>Clip</subtitle>" +
                                                "<thumbnailimage version='1' />" +
                                                "<useproxypage>false</useproxypage>" +
                                                "<viewsubmit>yes</viewsubmit>" +
                                                "<associatedunits>" +
                                                    "<unit rsuiteid='rsuitid1'>Chapter 1</unit>" +
                                                "</associatedunits>" +
                                            "</coursecontentmetadata> " +
                                            "<toc>" +
                                                "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                                    "<associatedunitid/>" +
                                                    "<parentid>bsi__17593B4C__90B3__45B3__8211__6B0CA6984500</parentid>" +
                                                    "<sequence>zzzb</sequence>" +
                                                "</structure>" +
                                            "</toc>" +
                                        "</request>" +
                                      "<request rsuiteid='rsuitid2' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>0</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid2'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuiteid3' type='quiz'>" +
                                        "<version>2.3</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid3'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuitid4' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid4'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuitid5' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid5'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                    "</pubrequest>";

            validations validations = new validations();

            //Act
            result = validations.ValidatePubRequest(strCourseXML);
        }

        [TestMethod]
        [ExpectedExceptionAttribute(typeof(Exception))]
        public void TestValidatePubRequestWhenPubRequestAttributeTierIsEmpty()
        {
            //Arrange
            bool result;
            string strCourseXML = "<pubrequest requestid='adsfds' type='dlap' tier='dev' entityid='132434' discipline='astronomy'>" +
                                     "<daterequested>3/14/2015 14:00</daterequested>" +
                                     "<publishuser>gsternig</publishuser> " +
                                       "<request rsuiteid='rsuitid1' type='learningcurve'>" +
                                             "<version>2.1</version>" +
                                             "<action>insert</action>  " +
                                             "<contentmetadata> " +
                                                 "<title>Reel Teaching Clip:  Chinese Immigrants Encounter Nativism (2:04)</title>" +
                                                 "<contenttype>ExternalContent</contenttype>" +
                                                 "<displaytype>Display Content</displaytype>   " +
                                                 "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                                 "<referencedobjects>" +
                                                   "<object version='1'>/js</object>" +
                                                   "<object version='1'>/images</object>" +
                                                 "</referencedobjects>" +
                                             "</contentmetadata>" +
                                             "<coursecontentmetadata>" +
                                                 "<allowComments>true</allowComments>" +
                                                 "<attemptlimit>0</attemptlimit>" +
                                                 "<defaultpoints>0</defaultpoints>" +
                                                 "<description>Test Description</description>" +
                                                 "<graderule>2</graderule>" +
                                                 "<instructoronly>Student instructor</instructoronly>" +
                                                 "<latesubmissions>true</latesubmissions>" +
                                                 "<openinsuppwindow>true</openinsuppwindow>" +
                                                 "<subtitle>Clip</subtitle>" +
                                                 "<thumbnailimage version='1' />" +
                                                 "<useproxypage>false</useproxypage>" +
                                                 "<viewsubmit>yes</viewsubmit>" +
                                                 "<associatedunits>" +
                                                     "<unit rsuiteid='rsuitid1'>Chapter 1</unit>" +
                                                 "</associatedunits>" +
                                             "</coursecontentmetadata> " +
                                             "<toc>" +
                                                 "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                                     "<associatedunitid/>" +
                                                     "<parentid>bsi__17593B4C__90B3__45B3__8211__6B0CA6984500</parentid>" +
                                                     "<sequence>zzzb</sequence>" +
                                                 "</structure>" +
                                             "</toc>" +
                                         "</request>" +
                                       "<request rsuiteid='rsuitid2' type='quiz'>" +
                                         "<version>2.1</version>" +
                                         "<action>insert</action>" +
                                         "<contentmetadata>" +
                                           "<title>Testing Item 2</title>" +
                                           "<contenttype>ExternalContent</contenttype>" +
                                           "<displaytype>Display Content</displaytype>" +
                                           "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                           "<referencedobjects>" +
                                             "<object version='1'>/js</object>" +
                                             "<object version='1'>/images</object>" +
                                           "</referencedobjects>" +
                                         "</contentmetadata>" +
                                         "<coursecontentmetadata>" +
                                           "<allowComments>true</allowComments>" +
                                           "<attemptlimit>0</attemptlimit>" +
                                           "<defaultpoints>0</defaultpoints>" +
                                           "<description>Test Description</description>" +
                                           "<graderule>2</graderule>" +
                                           "<instructoronly>Student instructor</instructoronly>" +
                                           "<latesubmissions>true</latesubmissions>" +
                                           "<openinsuppwindow>true</openinsuppwindow>" +
                                           "<subtitle>Clip</subtitle>" +
                                           "<thumbnailimage version='1' />" +
                                           "<useproxypage>false</useproxypage>" +
                                           "<viewsubmit>yes</viewsubmit>" +
                                           "<associatedunits>" +
                                             "<unit rsuiteid='rsuitid2'>Chapter 2</unit>" +
                                           "</associatedunits>" +
                                         "</coursecontentmetadata>" +
                                         "<toc>" +
                                           "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                             "<associatedunitid/>" +
                                             "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                             "<sequence>zzzC</sequence>" +
                                           "</structure>" +
                                         "</toc>" +
                                       "</request>" +
                                       "<request rsuiteid='rsuiteid3' type='quiz'>" +
                                         "<version>2.3</version>" +
                                         "<action>insert</action>" +
                                         "<contentmetadata>" +
                                           "<title>Testing Item 2</title>" +
                                           "<contenttype>ExternalContent</contenttype>" +
                                           "<displaytype>Display Content</displaytype>" +
                                           "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                           "<referencedobjects>" +
                                             "<object version='1'>/js</object>" +
                                             "<object version='1'>/images</object>" +
                                           "</referencedobjects>" +
                                         "</contentmetadata>" +
                                         "<coursecontentmetadata>" +
                                           "<allowComments>true</allowComments>" +
                                           "<attemptlimit>1</attemptlimit>" +
                                           "<defaultpoints>0</defaultpoints>" +
                                           "<description>Test Description</description>" +
                                           "<graderule>2</graderule>" +
                                           "<instructoronly>Student instructor</instructoronly>" +
                                           "<latesubmissions>true</latesubmissions>" +
                                           "<openinsuppwindow>true</openinsuppwindow>" +
                                           "<subtitle>Clip</subtitle>" +
                                           "<thumbnailimage version='1' />" +
                                           "<useproxypage>false</useproxypage>" +
                                           "<viewsubmit>yes</viewsubmit>" +
                                           "<associatedunits>" +
                                             "<unit rsuiteid='rsuitid3'>Chapter 2</unit>" +
                                           "</associatedunits>" +
                                         "</coursecontentmetadata>" +
                                         "<toc>" +
                                           "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                             "<associatedunitid/>" +
                                             "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                             "<sequence>zzzC</sequence>" +
                                           "</structure>" +
                                         "</toc>" +
                                       "</request>" +
                                       "<request rsuiteid='rsuitid4' type='quiz'>" +
                                         "<version>2.1</version>" +
                                         "<action>insert</action>" +
                                         "<contentmetadata>" +
                                           "<title>Testing Item 2</title>" +
                                           "<contenttype>ExternalContent</contenttype>" +
                                           "<displaytype>Display Content</displaytype>" +
                                           "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                           "<referencedobjects>" +
                                             "<object version='1'>/js</object>" +
                                             "<object version='1'>/images</object>" +
                                           "</referencedobjects>" +
                                         "</contentmetadata>" +
                                         "<coursecontentmetadata>" +
                                           "<allowComments>true</allowComments>" +
                                           "<attemptlimit>1</attemptlimit>" +
                                           "<defaultpoints>0</defaultpoints>" +
                                           "<description>Test Description</description>" +
                                           "<graderule>2</graderule>" +
                                           "<instructoronly>Student instructor</instructoronly>" +
                                           "<latesubmissions>true</latesubmissions>" +
                                           "<openinsuppwindow>true</openinsuppwindow>" +
                                           "<subtitle>Clip</subtitle>" +
                                           "<thumbnailimage version='1' />" +
                                           "<useproxypage>false</useproxypage>" +
                                           "<viewsubmit>yes</viewsubmit>" +
                                           "<associatedunits>" +
                                             "<unit rsuiteid='rsuitid4'>Chapter 2</unit>" +
                                           "</associatedunits>" +
                                         "</coursecontentmetadata>" +
                                         "<toc>" +
                                           "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                             "<associatedunitid/>" +
                                             "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                             "<sequence>zzzC</sequence>" +
                                           "</structure>" +
                                         "</toc>" +
                                       "</request>" +
                                       "<request rsuiteid='rsuitid5' type='quiz'>" +
                                         "<version>2.1</version>" +
                                         "<action>insert</action>" +
                                         "<contentmetadata>" +
                                           "<title>Testing Item 2</title>" +
                                           "<contenttype>ExternalContent</contenttype>" +
                                           "<displaytype>Display Content</displaytype>" +
                                           "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                           "<referencedobjects>" +
                                             "<object version='1'>/js</object>" +
                                             "<object version='1'>/images</object>" +
                                           "</referencedobjects>" +
                                         "</contentmetadata>" +
                                         "<coursecontentmetadata>" +
                                           "<allowComments>true</allowComments>" +
                                           "<attemptlimit>1</attemptlimit>" +
                                           "<defaultpoints>0</defaultpoints>" +
                                           "<description>Test Description</description>" +
                                           "<graderule>2</graderule>" +
                                           "<instructoronly>Student instructor</instructoronly>" +
                                           "<latesubmissions>true</latesubmissions>" +
                                           "<openinsuppwindow>true</openinsuppwindow>" +
                                           "<subtitle>Clip</subtitle>" +
                                           "<thumbnailimage version='1' />" +
                                           "<useproxypage>false</useproxypage>" +
                                           "<viewsubmit>yes</viewsubmit>" +
                                           "<associatedunits>" +
                                             "<unit rsuiteid='rsuitid5'>Chapter 2</unit>" +
                                           "</associatedunits>" +
                                         "</coursecontentmetadata>" +
                                         "<toc>" +
                                           "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                             "<associatedunitid/>" +
                                             "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                             "<sequence>zzzC</sequence>" +
                                           "</structure>" +
                                         "</toc>" +
                                       "</request>" +
                                     "</pubrequest>";

            validations validations = new validations();

            //Act
            result = validations.ValidatePubRequest(strCourseXML);
        }

        [TestMethod]
        [ExpectedExceptionAttribute(typeof(Exception))]
        public void TestValidatePubRequestWhenPubRequestAttributeDisciplineIsMissing()
        {
            //Arrange
            bool result;
            string strCourseXML = "<pubrequest requestid='adsfds' type='dlap' tier='dev' entityid='132434' discipline='astronomy'>" +
                                    "<daterequested>3/14/2015 14:00</daterequested>" +
                                    "<publishuser>gsternig</publishuser> " +
                                      "<request rsuiteid='rsuitid1' type='learningcurve'>" +
                                            "<version>2.1</version>" +
                                            "<action>insert</action>  " +
                                            "<contentmetadata> " +
                                                "<title>Reel Teaching Clip:  Chinese Immigrants Encounter Nativism (2:04)</title>" +
                                                "<contenttype>ExternalContent</contenttype>" +
                                                "<displaytype>Display Content</displaytype>   " +
                                                "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                                "<referencedobjects>" +
                                                  "<object version='1'>/js</object>" +
                                                  "<object version='1'>/images</object>" +
                                                "</referencedobjects>" +
                                            "</contentmetadata>" +
                                            "<coursecontentmetadata>" +
                                                "<allowComments>true</allowComments>" +
                                                "<attemptlimit>0</attemptlimit>" +
                                                "<defaultpoints>0</defaultpoints>" +
                                                "<description>Test Description</description>" +
                                                "<graderule>2</graderule>" +
                                                "<instructoronly>Student instructor</instructoronly>" +
                                                "<latesubmissions>true</latesubmissions>" +
                                                "<openinsuppwindow>true</openinsuppwindow>" +
                                                "<subtitle>Clip</subtitle>" +
                                                "<thumbnailimage version='1' />" +
                                                "<useproxypage>false</useproxypage>" +
                                                "<viewsubmit>yes</viewsubmit>" +
                                                "<associatedunits>" +
                                                    "<unit rsuiteid='rsuitid1'>Chapter 1</unit>" +
                                                "</associatedunits>" +
                                            "</coursecontentmetadata> " +
                                            "<toc>" +
                                                "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                                    "<associatedunitid/>" +
                                                    "<parentid>bsi__17593B4C__90B3__45B3__8211__6B0CA6984500</parentid>" +
                                                    "<sequence>zzzb</sequence>" +
                                                "</structure>" +
                                            "</toc>" +
                                        "</request>" +
                                      "<request rsuiteid='rsuitid2' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>0</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid2'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuiteid3' type='quiz'>" +
                                        "<version>2.3</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid3'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuitid4' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid4'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuitid5' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid5'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                    "</pubrequest>";

            validations validations = new validations();

            //Act
            result = validations.ValidatePubRequest(strCourseXML);
        }

        [TestMethod]
        [ExpectedExceptionAttribute(typeof(Exception))]
        public void TestValidatePubRequestWhenPubRequestAttributeDisciplineIsEmpty()
        {
            //Arrange
            bool result;
            string strCourseXML = "<pubrequest requestid='adsfds' type='dlap' tier='dev' entityid='132434' discipline='astronomy'>" +
                                    "<daterequested>3/14/2015 14:00</daterequested>" +
                                    "<publishuser>gsternig</publishuser> " +
                                      "<request rsuiteid='rsuitid1' type='learningcurve'>" +
                                            "<version>2.1</version>" +
                                            "<action>insert</action>  " +
                                            "<contentmetadata> " +
                                                "<title>Reel Teaching Clip:  Chinese Immigrants Encounter Nativism (2:04)</title>" +
                                                "<contenttype>ExternalContent</contenttype>" +
                                                "<displaytype>Display Content</displaytype>   " +
                                                "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                                "<referencedobjects>" +
                                                  "<object version='1'>/js</object>" +
                                                  "<object version='1'>/images</object>" +
                                                "</referencedobjects>" +
                                            "</contentmetadata>" +
                                            "<coursecontentmetadata>" +
                                                "<allowComments>true</allowComments>" +
                                                "<attemptlimit>0</attemptlimit>" +
                                                "<defaultpoints>0</defaultpoints>" +
                                                "<description>Test Description</description>" +
                                                "<graderule>2</graderule>" +
                                                "<instructoronly>Student instructor</instructoronly>" +
                                                "<latesubmissions>true</latesubmissions>" +
                                                "<openinsuppwindow>true</openinsuppwindow>" +
                                                "<subtitle>Clip</subtitle>" +
                                                "<thumbnailimage version='1' />" +
                                                "<useproxypage>false</useproxypage>" +
                                                "<viewsubmit>yes</viewsubmit>" +
                                                "<associatedunits>" +
                                                    "<unit rsuiteid='rsuitid1'>Chapter 1</unit>" +
                                                "</associatedunits>" +
                                            "</coursecontentmetadata> " +
                                            "<toc>" +
                                                "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                                    "<associatedunitid/>" +
                                                    "<parentid>bsi__17593B4C__90B3__45B3__8211__6B0CA6984500</parentid>" +
                                                    "<sequence>zzzb</sequence>" +
                                                "</structure>" +
                                            "</toc>" +
                                        "</request>" +
                                      "<request rsuiteid='rsuitid2' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>0</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid2'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuiteid3' type='quiz'>" +
                                        "<version>2.3</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid3'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuitid4' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid4'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuitid5' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid5'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                    "</pubrequest>";
            validations validations = new validations();

            //Act
            result = validations.ValidatePubRequest(strCourseXML);
        }

        
        [TestMethod]
        [ExpectedExceptionAttribute(typeof(Exception))]
        public void TestValidatePubRequestWhenRequestTagIsMissing()
        {
            //Arrange
            bool result;
            string strCourseXML = "<pubrequest requestid='adsfds' type='dlap' tier='dev' entityid='132434' discipline='astronomy'>" +
                                    "<daterequested>3/14/2015 14:00</daterequested>" +
                                    "<publishuser>gsternig</publishuser> " +
                                      "<request rsuiteid='rsuitid1' type='learningcurve'>" +
                                            "<version>2.1</version>" +
                                            "<action>insert</action>  " +
                                            "<contentmetadata> " +
                                                "<title>Reel Teaching Clip:  Chinese Immigrants Encounter Nativism (2:04)</title>" +
                                                "<contenttype>ExternalContent</contenttype>" +
                                                "<displaytype>Display Content</displaytype>   " +
                                                "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                                "<referencedobjects>" +
                                                  "<object version='1'>/js</object>" +
                                                  "<object version='1'>/images</object>" +
                                                "</referencedobjects>" +
                                            "</contentmetadata>" +
                                            "<coursecontentmetadata>" +
                                                "<allowComments>true</allowComments>" +
                                                "<attemptlimit>0</attemptlimit>" +
                                                "<defaultpoints>0</defaultpoints>" +
                                                "<description>Test Description</description>" +
                                                "<graderule>2</graderule>" +
                                                "<instructoronly>Student instructor</instructoronly>" +
                                                "<latesubmissions>true</latesubmissions>" +
                                                "<openinsuppwindow>true</openinsuppwindow>" +
                                                "<subtitle>Clip</subtitle>" +
                                                "<thumbnailimage version='1' />" +
                                                "<useproxypage>false</useproxypage>" +
                                                "<viewsubmit>yes</viewsubmit>" +
                                                "<associatedunits>" +
                                                    "<unit rsuiteid='rsuitid1'>Chapter 1</unit>" +
                                                "</associatedunits>" +
                                            "</coursecontentmetadata> " +
                                            "<toc>" +
                                                "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                                    "<associatedunitid/>" +
                                                    "<parentid>bsi__17593B4C__90B3__45B3__8211__6B0CA6984500</parentid>" +
                                                    "<sequence>zzzb</sequence>" +
                                                "</structure>" +
                                            "</toc>" +
                                        "</request>" +
                                      "<request rsuiteid='rsuitid2' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>0</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid2'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuiteid3' type='quiz'>" +
                                        "<version>2.3</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid3'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuitid4' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid4'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuitid5' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid5'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                    "</pubrequest>";

            validations validations = new validations();

            //Act
            result = validations.ValidatePubRequest(strCourseXML);
        }

        [TestMethod]
        [ExpectedExceptionAttribute(typeof(Exception))]
        public void TestValidatePubRequestWhenRsuiteIdIsMissing()
        {
            //Arrange
            bool result;
            string strCourseXML = "<pubrequest requestid='adsfds' type='dlap' tier='dev' entityid='132434' discipline='astronomy'>" +
                                    "<daterequested>3/14/2015 14:00</daterequested>" +
                                    "<publishuser>gsternig</publishuser> " +
                                      "<request rsuiteid='rsuitid1' type='learningcurve'>" +
                                            "<version>2.1</version>" +
                                            "<action>insert</action>  " +
                                            "<contentmetadata> " +
                                                "<title>Reel Teaching Clip:  Chinese Immigrants Encounter Nativism (2:04)</title>" +
                                                "<contenttype>ExternalContent</contenttype>" +
                                                "<displaytype>Display Content</displaytype>   " +
                                                "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                                "<referencedobjects>" +
                                                  "<object version='1'>/js</object>" +
                                                  "<object version='1'>/images</object>" +
                                                "</referencedobjects>" +
                                            "</contentmetadata>" +
                                            "<coursecontentmetadata>" +
                                                "<allowComments>true</allowComments>" +
                                                "<attemptlimit>0</attemptlimit>" +
                                                "<defaultpoints>0</defaultpoints>" +
                                                "<description>Test Description</description>" +
                                                "<graderule>2</graderule>" +
                                                "<instructoronly>Student instructor</instructoronly>" +
                                                "<latesubmissions>true</latesubmissions>" +
                                                "<openinsuppwindow>true</openinsuppwindow>" +
                                                "<subtitle>Clip</subtitle>" +
                                                "<thumbnailimage version='1' />" +
                                                "<useproxypage>false</useproxypage>" +
                                                "<viewsubmit>yes</viewsubmit>" +
                                                "<associatedunits>" +
                                                    "<unit rsuiteid='rsuitid1'>Chapter 1</unit>" +
                                                "</associatedunits>" +
                                            "</coursecontentmetadata> " +
                                            "<toc>" +
                                                "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                                    "<associatedunitid/>" +
                                                    "<parentid>bsi__17593B4C__90B3__45B3__8211__6B0CA6984500</parentid>" +
                                                    "<sequence>zzzb</sequence>" +
                                                "</structure>" +
                                            "</toc>" +
                                        "</request>" +
                                      "<request rsuiteid='rsuitid2' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>0</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid2'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuiteid3' type='quiz'>" +
                                        "<version>2.3</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid3'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuitid4' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid4'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuitid5' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid5'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                    "</pubrequest>";

            validations validations = new validations();

            //Act
            result = validations.ValidatePubRequest(strCourseXML);
        }

        [TestMethod]
        [ExpectedExceptionAttribute(typeof(Exception))]
        public void TestValidatePubRequestWhenRsuiteIdIsEmpty()
        {
            //Arrange
            bool result;
            string strCourseXML = "<pubrequest requestid='adsfds' type='dlap' tier='dev' entityid='132434' discipline='astronomy'>" +
                                    "<daterequested>3/14/2015 14:00</daterequested>" +
                                    "<publishuser>gsternig</publishuser> " +
                                      "<request rsuiteid='rsuitid1' type='learningcurve'>" +
                                            "<version>2.1</version>" +
                                            "<action>insert</action>  " +
                                            "<contentmetadata> " +
                                                "<title>Reel Teaching Clip:  Chinese Immigrants Encounter Nativism (2:04)</title>" +
                                                "<contenttype>ExternalContent</contenttype>" +
                                                "<displaytype>Display Content</displaytype>   " +
                                                "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                                "<referencedobjects>" +
                                                  "<object version='1'>/js</object>" +
                                                  "<object version='1'>/images</object>" +
                                                "</referencedobjects>" +
                                            "</contentmetadata>" +
                                            "<coursecontentmetadata>" +
                                                "<allowComments>true</allowComments>" +
                                                "<attemptlimit>0</attemptlimit>" +
                                                "<defaultpoints>0</defaultpoints>" +
                                                "<description>Test Description</description>" +
                                                "<graderule>2</graderule>" +
                                                "<instructoronly>Student instructor</instructoronly>" +
                                                "<latesubmissions>true</latesubmissions>" +
                                                "<openinsuppwindow>true</openinsuppwindow>" +
                                                "<subtitle>Clip</subtitle>" +
                                                "<thumbnailimage version='1' />" +
                                                "<useproxypage>false</useproxypage>" +
                                                "<viewsubmit>yes</viewsubmit>" +
                                                "<associatedunits>" +
                                                    "<unit rsuiteid='rsuitid1'>Chapter 1</unit>" +
                                                "</associatedunits>" +
                                            "</coursecontentmetadata> " +
                                            "<toc>" +
                                                "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                                    "<associatedunitid/>" +
                                                    "<parentid>bsi__17593B4C__90B3__45B3__8211__6B0CA6984500</parentid>" +
                                                    "<sequence>zzzb</sequence>" +
                                                "</structure>" +
                                            "</toc>" +
                                        "</request>" +
                                      "<request rsuiteid='rsuitid2' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>0</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid2'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuiteid3' type='quiz'>" +
                                        "<version>2.3</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid3'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuitid4' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid4'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuitid5' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid5'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                    "</pubrequest>";

            validations validations = new validations();

            //Act
            result = validations.ValidatePubRequest(strCourseXML);
        }

        [TestMethod]
        [ExpectedExceptionAttribute(typeof(Exception))]
        public void TestValidatePubRequestWhenTypeIsMissing()
        {
            //Arrange
            bool result;
            string strCourseXML = "<pubrequest requestid='adsfds' type='dlap' tier='dev' entityid='132434' discipline='astronomy'>" +
                                    "<daterequested>3/14/2015 14:00</daterequested>" +
                                    "<publishuser>gsternig</publishuser> " +
                                      "<request rsuiteid='rsuitid1' type='learningcurve'>" +
                                            "<version>2.1</version>" +
                                            "<action>insert</action>  " +
                                            "<contentmetadata> " +
                                                "<title>Reel Teaching Clip:  Chinese Immigrants Encounter Nativism (2:04)</title>" +
                                                "<contenttype>ExternalContent</contenttype>" +
                                                "<displaytype>Display Content</displaytype>   " +
                                                "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                                "<referencedobjects>" +
                                                  "<object version='1'>/js</object>" +
                                                  "<object version='1'>/images</object>" +
                                                "</referencedobjects>" +
                                            "</contentmetadata>" +
                                            "<coursecontentmetadata>" +
                                                "<allowComments>true</allowComments>" +
                                                "<attemptlimit>0</attemptlimit>" +
                                                "<defaultpoints>0</defaultpoints>" +
                                                "<description>Test Description</description>" +
                                                "<graderule>2</graderule>" +
                                                "<instructoronly>Student instructor</instructoronly>" +
                                                "<latesubmissions>true</latesubmissions>" +
                                                "<openinsuppwindow>true</openinsuppwindow>" +
                                                "<subtitle>Clip</subtitle>" +
                                                "<thumbnailimage version='1' />" +
                                                "<useproxypage>false</useproxypage>" +
                                                "<viewsubmit>yes</viewsubmit>" +
                                                "<associatedunits>" +
                                                    "<unit rsuiteid='rsuitid1'>Chapter 1</unit>" +
                                                "</associatedunits>" +
                                            "</coursecontentmetadata> " +
                                            "<toc>" +
                                                "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                                    "<associatedunitid/>" +
                                                    "<parentid>bsi__17593B4C__90B3__45B3__8211__6B0CA6984500</parentid>" +
                                                    "<sequence>zzzb</sequence>" +
                                                "</structure>" +
                                            "</toc>" +
                                        "</request>" +
                                      "<request rsuiteid='rsuitid2' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>0</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid2'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuiteid3' type='quiz'>" +
                                        "<version>2.3</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid3'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuitid4' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid4'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuitid5' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid5'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                    "</pubrequest>";
            validations validations = new validations();

            //Act
            result = validations.ValidatePubRequest(strCourseXML);
        }

        [TestMethod]
        [ExpectedExceptionAttribute(typeof(Exception))]
        public void TestValidatePubRequestWhenTypeIsEmpty()
        {
            //Arrange
            bool result;
            string strCourseXML = "<pubrequest requestid='adsfds' type='dlap' tier='dev' entityid='132434' discipline='astronomy'>" +
                                    "<daterequested>3/14/2015 14:00</daterequested>" +
                                    "<publishuser>gsternig</publishuser> " +
                                      "<request rsuiteid='rsuitid1' type='learningcurve'>" +
                                            "<version>2.1</version>" +
                                            "<action>insert</action>  " +
                                            "<contentmetadata> " +
                                                "<title>Reel Teaching Clip:  Chinese Immigrants Encounter Nativism (2:04)</title>" +
                                                "<contenttype>ExternalContent</contenttype>" +
                                                "<displaytype>Display Content</displaytype>   " +
                                                "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                                "<referencedobjects>" +
                                                  "<object version='1'>/js</object>" +
                                                  "<object version='1'>/images</object>" +
                                                "</referencedobjects>" +
                                            "</contentmetadata>" +
                                            "<coursecontentmetadata>" +
                                                "<allowComments>true</allowComments>" +
                                                "<attemptlimit>0</attemptlimit>" +
                                                "<defaultpoints>0</defaultpoints>" +
                                                "<description>Test Description</description>" +
                                                "<graderule>2</graderule>" +
                                                "<instructoronly>Student instructor</instructoronly>" +
                                                "<latesubmissions>true</latesubmissions>" +
                                                "<openinsuppwindow>true</openinsuppwindow>" +
                                                "<subtitle>Clip</subtitle>" +
                                                "<thumbnailimage version='1' />" +
                                                "<useproxypage>false</useproxypage>" +
                                                "<viewsubmit>yes</viewsubmit>" +
                                                "<associatedunits>" +
                                                    "<unit rsuiteid='rsuitid1'>Chapter 1</unit>" +
                                                "</associatedunits>" +
                                            "</coursecontentmetadata> " +
                                            "<toc>" +
                                                "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                                    "<associatedunitid/>" +
                                                    "<parentid>bsi__17593B4C__90B3__45B3__8211__6B0CA6984500</parentid>" +
                                                    "<sequence>zzzb</sequence>" +
                                                "</structure>" +
                                            "</toc>" +
                                        "</request>" +
                                      "<request rsuiteid='rsuitid2' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>0</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid2'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuiteid3' type='quiz'>" +
                                        "<version>2.3</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid3'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuitid4' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid4'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuitid5' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid5'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                    "</pubrequest>";

            validations validations = new validations();

            //Act
            result = validations.ValidatePubRequest(strCourseXML);
        }

        [TestMethod]
        [ExpectedExceptionAttribute(typeof(Exception))]
        public void TestValidatePubRequestWhenActionIsMissing()
        {
            //Arrange
            bool result;
            string strCourseXML = "<pubrequest requestid='adsfds' type='dlap' tier='dev' entityid='132434' discipline='astronomy'>" +
                                    "<daterequested>3/14/2015 14:00</daterequested>" +
                                    "<publishuser>gsternig</publishuser> " +
                                      "<request rsuiteid='rsuitid1' type='learningcurve'>" +
                                            "<version>2.1</version>" +
                                            "<action>insert</action>  " +
                                            "<contentmetadata> " +
                                                "<title>Reel Teaching Clip:  Chinese Immigrants Encounter Nativism (2:04)</title>" +
                                                "<contenttype>ExternalContent</contenttype>" +
                                                "<displaytype>Display Content</displaytype>   " +
                                                "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                                "<referencedobjects>" +
                                                  "<object version='1'>/js</object>" +
                                                  "<object version='1'>/images</object>" +
                                                "</referencedobjects>" +
                                            "</contentmetadata>" +
                                            "<coursecontentmetadata>" +
                                                "<allowComments>true</allowComments>" +
                                                "<attemptlimit>0</attemptlimit>" +
                                                "<defaultpoints>0</defaultpoints>" +
                                                "<description>Test Description</description>" +
                                                "<graderule>2</graderule>" +
                                                "<instructoronly>Student instructor</instructoronly>" +
                                                "<latesubmissions>true</latesubmissions>" +
                                                "<openinsuppwindow>true</openinsuppwindow>" +
                                                "<subtitle>Clip</subtitle>" +
                                                "<thumbnailimage version='1' />" +
                                                "<useproxypage>false</useproxypage>" +
                                                "<viewsubmit>yes</viewsubmit>" +
                                                "<associatedunits>" +
                                                    "<unit rsuiteid='rsuitid1'>Chapter 1</unit>" +
                                                "</associatedunits>" +
                                            "</coursecontentmetadata> " +
                                            "<toc>" +
                                                "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                                    "<associatedunitid/>" +
                                                    "<parentid>bsi__17593B4C__90B3__45B3__8211__6B0CA6984500</parentid>" +
                                                    "<sequence>zzzb</sequence>" +
                                                "</structure>" +
                                            "</toc>" +
                                        "</request>" +
                                      "<request rsuiteid='rsuitid2' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>0</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid2'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuiteid3' type='quiz'>" +
                                        "<version>2.3</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid3'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuitid4' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid4'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuitid5' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid5'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                    "</pubrequest>";

            validations validations = new validations();

            //Act
            result = validations.ValidatePubRequest(strCourseXML);
        }

        [TestMethod]
        [ExpectedExceptionAttribute(typeof(Exception))]
        public void TestValidatePubRequestWhenActionIsEmpty()
        {
            //Arrange
            bool result;
            string strCourseXML = "<pubrequest requestid='adsfds' type='dlap' tier='dev' entityid='132434' discipline='astronomy'>" +
                                    "<daterequested>3/14/2015 14:00</daterequested>" +
                                    "<publishuser>gsternig</publishuser> " +
                                      "<request rsuiteid='rsuitid1' type='learningcurve'>" +
                                            "<version>2.1</version>" +
                                            "<action>insert</action>  " +
                                            "<contentmetadata> " +
                                                "<title>Reel Teaching Clip:  Chinese Immigrants Encounter Nativism (2:04)</title>" +
                                                "<contenttype>ExternalContent</contenttype>" +
                                                "<displaytype>Display Content</displaytype>   " +
                                                "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                                "<referencedobjects>" +
                                                  "<object version='1'>/js</object>" +
                                                  "<object version='1'>/images</object>" +
                                                "</referencedobjects>" +
                                            "</contentmetadata>" +
                                            "<coursecontentmetadata>" +
                                                "<allowComments>true</allowComments>" +
                                                "<attemptlimit>0</attemptlimit>" +
                                                "<defaultpoints>0</defaultpoints>" +
                                                "<description>Test Description</description>" +
                                                "<graderule>2</graderule>" +
                                                "<instructoronly>Student instructor</instructoronly>" +
                                                "<latesubmissions>true</latesubmissions>" +
                                                "<openinsuppwindow>true</openinsuppwindow>" +
                                                "<subtitle>Clip</subtitle>" +
                                                "<thumbnailimage version='1' />" +
                                                "<useproxypage>false</useproxypage>" +
                                                "<viewsubmit>yes</viewsubmit>" +
                                                "<associatedunits>" +
                                                    "<unit rsuiteid='rsuitid1'>Chapter 1</unit>" +
                                                "</associatedunits>" +
                                            "</coursecontentmetadata> " +
                                            "<toc>" +
                                                "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                                    "<associatedunitid/>" +
                                                    "<parentid>bsi__17593B4C__90B3__45B3__8211__6B0CA6984500</parentid>" +
                                                    "<sequence>zzzb</sequence>" +
                                                "</structure>" +
                                            "</toc>" +
                                        "</request>" +
                                      "<request rsuiteid='rsuitid2' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>0</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid2'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuiteid3' type='quiz'>" +
                                        "<version>2.3</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid3'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuitid4' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid4'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuitid5' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid5'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                    "</pubrequest>";

            validations validations = new validations();

            //Act
            result = validations.ValidatePubRequest(strCourseXML);
        }

        [TestMethod]
        [ExpectedExceptionAttribute(typeof(Exception))]
        public void TestValidatePubRequestWhenCheckActionValue()
        {
            //Arrange
            bool result;
            string strCourseXML = "<pubrequest requestid='adsfds' type='dlap' tier='dev' entityid='132434' discipline='astronomy'>" +
                                     "<daterequested>3/14/2015 14:00</daterequested>" +
                                     "<publishuser>gsternig</publishuser> " +
                                       "<request rsuiteid='rsuitid1' type='learningcurve'>" +
                                             "<version>2.1</version>" +
                                             "<action>insert</action>  " +
                                             "<contentmetadata> " +
                                                 "<title>Reel Teaching Clip:  Chinese Immigrants Encounter Nativism (2:04)</title>" +
                                                 "<contenttype>ExternalContent</contenttype>" +
                                                 "<displaytype>Display Content</displaytype>   " +
                                                 "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                                 "<referencedobjects>" +
                                                   "<object version='1'>/js</object>" +
                                                   "<object version='1'>/images</object>" +
                                                 "</referencedobjects>" +
                                             "</contentmetadata>" +
                                             "<coursecontentmetadata>" +
                                                 "<allowComments>true</allowComments>" +
                                                 "<attemptlimit>0</attemptlimit>" +
                                                 "<defaultpoints>0</defaultpoints>" +
                                                 "<description>Test Description</description>" +
                                                 "<graderule>2</graderule>" +
                                                 "<instructoronly>Student instructor</instructoronly>" +
                                                 "<latesubmissions>true</latesubmissions>" +
                                                 "<openinsuppwindow>true</openinsuppwindow>" +
                                                 "<subtitle>Clip</subtitle>" +
                                                 "<thumbnailimage version='1' />" +
                                                 "<useproxypage>false</useproxypage>" +
                                                 "<viewsubmit>yes</viewsubmit>" +
                                                 "<associatedunits>" +
                                                     "<unit rsuiteid='rsuitid1'>Chapter 1</unit>" +
                                                 "</associatedunits>" +
                                             "</coursecontentmetadata> " +
                                             "<toc>" +
                                                 "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                                     "<associatedunitid/>" +
                                                     "<parentid>bsi__17593B4C__90B3__45B3__8211__6B0CA6984500</parentid>" +
                                                     "<sequence>zzzb</sequence>" +
                                                 "</structure>" +
                                             "</toc>" +
                                         "</request>" +
                                       "<request rsuiteid='rsuitid2' type='quiz'>" +
                                         "<version>2.1</version>" +
                                         "<action>insert</action>" +
                                         "<contentmetadata>" +
                                           "<title>Testing Item 2</title>" +
                                           "<contenttype>ExternalContent</contenttype>" +
                                           "<displaytype>Display Content</displaytype>" +
                                           "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                           "<referencedobjects>" +
                                             "<object version='1'>/js</object>" +
                                             "<object version='1'>/images</object>" +
                                           "</referencedobjects>" +
                                         "</contentmetadata>" +
                                         "<coursecontentmetadata>" +
                                           "<allowComments>true</allowComments>" +
                                           "<attemptlimit>0</attemptlimit>" +
                                           "<defaultpoints>0</defaultpoints>" +
                                           "<description>Test Description</description>" +
                                           "<graderule>2</graderule>" +
                                           "<instructoronly>Student instructor</instructoronly>" +
                                           "<latesubmissions>true</latesubmissions>" +
                                           "<openinsuppwindow>true</openinsuppwindow>" +
                                           "<subtitle>Clip</subtitle>" +
                                           "<thumbnailimage version='1' />" +
                                           "<useproxypage>false</useproxypage>" +
                                           "<viewsubmit>yes</viewsubmit>" +
                                           "<associatedunits>" +
                                             "<unit rsuiteid='rsuitid2'>Chapter 2</unit>" +
                                           "</associatedunits>" +
                                         "</coursecontentmetadata>" +
                                         "<toc>" +
                                           "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                             "<associatedunitid/>" +
                                             "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                             "<sequence>zzzC</sequence>" +
                                           "</structure>" +
                                         "</toc>" +
                                       "</request>" +
                                       "<request rsuiteid='rsuiteid3' type='quiz'>" +
                                         "<version>2.3</version>" +
                                         "<action>insert</action>" +
                                         "<contentmetadata>" +
                                           "<title>Testing Item 2</title>" +
                                           "<contenttype>ExternalContent</contenttype>" +
                                           "<displaytype>Display Content</displaytype>" +
                                           "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                           "<referencedobjects>" +
                                             "<object version='1'>/js</object>" +
                                             "<object version='1'>/images</object>" +
                                           "</referencedobjects>" +
                                         "</contentmetadata>" +
                                         "<coursecontentmetadata>" +
                                           "<allowComments>true</allowComments>" +
                                           "<attemptlimit>1</attemptlimit>" +
                                           "<defaultpoints>0</defaultpoints>" +
                                           "<description>Test Description</description>" +
                                           "<graderule>2</graderule>" +
                                           "<instructoronly>Student instructor</instructoronly>" +
                                           "<latesubmissions>true</latesubmissions>" +
                                           "<openinsuppwindow>true</openinsuppwindow>" +
                                           "<subtitle>Clip</subtitle>" +
                                           "<thumbnailimage version='1' />" +
                                           "<useproxypage>false</useproxypage>" +
                                           "<viewsubmit>yes</viewsubmit>" +
                                           "<associatedunits>" +
                                             "<unit rsuiteid='rsuitid3'>Chapter 2</unit>" +
                                           "</associatedunits>" +
                                         "</coursecontentmetadata>" +
                                         "<toc>" +
                                           "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                             "<associatedunitid/>" +
                                             "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                             "<sequence>zzzC</sequence>" +
                                           "</structure>" +
                                         "</toc>" +
                                       "</request>" +
                                       "<request rsuiteid='rsuitid4' type='quiz'>" +
                                         "<version>2.1</version>" +
                                         "<action>insert</action>" +
                                         "<contentmetadata>" +
                                           "<title>Testing Item 2</title>" +
                                           "<contenttype>ExternalContent</contenttype>" +
                                           "<displaytype>Display Content</displaytype>" +
                                           "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                           "<referencedobjects>" +
                                             "<object version='1'>/js</object>" +
                                             "<object version='1'>/images</object>" +
                                           "</referencedobjects>" +
                                         "</contentmetadata>" +
                                         "<coursecontentmetadata>" +
                                           "<allowComments>true</allowComments>" +
                                           "<attemptlimit>1</attemptlimit>" +
                                           "<defaultpoints>0</defaultpoints>" +
                                           "<description>Test Description</description>" +
                                           "<graderule>2</graderule>" +
                                           "<instructoronly>Student instructor</instructoronly>" +
                                           "<latesubmissions>true</latesubmissions>" +
                                           "<openinsuppwindow>true</openinsuppwindow>" +
                                           "<subtitle>Clip</subtitle>" +
                                           "<thumbnailimage version='1' />" +
                                           "<useproxypage>false</useproxypage>" +
                                           "<viewsubmit>yes</viewsubmit>" +
                                           "<associatedunits>" +
                                             "<unit rsuiteid='rsuitid4'>Chapter 2</unit>" +
                                           "</associatedunits>" +
                                         "</coursecontentmetadata>" +
                                         "<toc>" +
                                           "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                             "<associatedunitid/>" +
                                             "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                             "<sequence>zzzC</sequence>" +
                                           "</structure>" +
                                         "</toc>" +
                                       "</request>" +
                                       "<request rsuiteid='rsuitid5' type='quiz'>" +
                                         "<version>2.1</version>" +
                                         "<action>insert</action>" +
                                         "<contentmetadata>" +
                                           "<title>Testing Item 2</title>" +
                                           "<contenttype>ExternalContent</contenttype>" +
                                           "<displaytype>Display Content</displaytype>" +
                                           "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                           "<referencedobjects>" +
                                             "<object version='1'>/js</object>" +
                                             "<object version='1'>/images</object>" +
                                           "</referencedobjects>" +
                                         "</contentmetadata>" +
                                         "<coursecontentmetadata>" +
                                           "<allowComments>true</allowComments>" +
                                           "<attemptlimit>1</attemptlimit>" +
                                           "<defaultpoints>0</defaultpoints>" +
                                           "<description>Test Description</description>" +
                                           "<graderule>2</graderule>" +
                                           "<instructoronly>Student instructor</instructoronly>" +
                                           "<latesubmissions>true</latesubmissions>" +
                                           "<openinsuppwindow>true</openinsuppwindow>" +
                                           "<subtitle>Clip</subtitle>" +
                                           "<thumbnailimage version='1' />" +
                                           "<useproxypage>false</useproxypage>" +
                                           "<viewsubmit>yes</viewsubmit>" +
                                           "<associatedunits>" +
                                             "<unit rsuiteid='rsuitid5'>Chapter 2</unit>" +
                                           "</associatedunits>" +
                                         "</coursecontentmetadata>" +
                                         "<toc>" +
                                           "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                             "<associatedunitid/>" +
                                             "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                             "<sequence>zzzC</sequence>" +
                                           "</structure>" +
                                         "</toc>" +
                                       "</request>" +
                                     "</pubrequest>";

            validations validations = new validations();

            //Act
            result = validations.ValidatePubRequest(strCourseXML);
        }

        [TestMethod]
        [ExpectedExceptionAttribute(typeof(Exception))]
        public void TestValidatePubRequestWhenContentmetadataIsMissing()
        {
            //Arrange
            bool result;
            string strCourseXML = "<pubrequest requestid='adsfds' type='dlap' tier='dev' entityid='132434' discipline='astronomy'>" +
                                    "<daterequested>3/14/2015 14:00</daterequested>" +
                                    "<publishuser>gsternig</publishuser> " +
                                      "<request rsuiteid='rsuitid1' type='learningcurve'>" +
                                            "<version>2.1</version>" +
                                            "<action>insert</action>  " +
                                            "<contentmetadata> " +
                                                "<title>Reel Teaching Clip:  Chinese Immigrants Encounter Nativism (2:04)</title>" +
                                                "<contenttype>ExternalContent</contenttype>" +
                                                "<displaytype>Display Content</displaytype>   " +
                                                "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                                "<referencedobjects>" +
                                                  "<object version='1'>/js</object>" +
                                                  "<object version='1'>/images</object>" +
                                                "</referencedobjects>" +
                                            "</contentmetadata>" +
                                            "<coursecontentmetadata>" +
                                                "<allowComments>true</allowComments>" +
                                                "<attemptlimit>0</attemptlimit>" +
                                                "<defaultpoints>0</defaultpoints>" +
                                                "<description>Test Description</description>" +
                                                "<graderule>2</graderule>" +
                                                "<instructoronly>Student instructor</instructoronly>" +
                                                "<latesubmissions>true</latesubmissions>" +
                                                "<openinsuppwindow>true</openinsuppwindow>" +
                                                "<subtitle>Clip</subtitle>" +
                                                "<thumbnailimage version='1' />" +
                                                "<useproxypage>false</useproxypage>" +
                                                "<viewsubmit>yes</viewsubmit>" +
                                                "<associatedunits>" +
                                                    "<unit rsuiteid='rsuitid1'>Chapter 1</unit>" +
                                                "</associatedunits>" +
                                            "</coursecontentmetadata> " +
                                            "<toc>" +
                                                "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                                    "<associatedunitid/>" +
                                                    "<parentid>bsi__17593B4C__90B3__45B3__8211__6B0CA6984500</parentid>" +
                                                    "<sequence>zzzb</sequence>" +
                                                "</structure>" +
                                            "</toc>" +
                                        "</request>" +
                                      "<request rsuiteid='rsuitid2' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>0</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid2'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuiteid3' type='quiz'>" +
                                        "<version>2.3</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid3'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuitid4' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid4'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuitid5' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid5'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                    "</pubrequest>";

            validations validations = new validations();

            //Act
            result = validations.ValidatePubRequest(strCourseXML);
        }

        [TestMethod]
        [ExpectedExceptionAttribute(typeof(Exception))]
        public void TestValidatePubRequestWhenTitleIsMissing()
        {
            //Arrange
            bool result;
            string strCourseXML = "<pubrequest requestid='adsfds' type='dlap' tier='dev' entityid='132434' discipline='astronomy'>" +
                                    "<daterequested>3/14/2015 14:00</daterequested>" +
                                    "<publishuser>gsternig</publishuser> " +
                                      "<request rsuiteid='rsuitid1' type='learningcurve'>" +
                                            "<version>2.1</version>" +
                                            "<action>insert</action>  " +
                                            "<contentmetadata> " +
                                                "<title>Reel Teaching Clip:  Chinese Immigrants Encounter Nativism (2:04)</title>" +
                                                "<contenttype>ExternalContent</contenttype>" +
                                                "<displaytype>Display Content</displaytype>   " +
                                                "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                                "<referencedobjects>" +
                                                  "<object version='1'>/js</object>" +
                                                  "<object version='1'>/images</object>" +
                                                "</referencedobjects>" +
                                            "</contentmetadata>" +
                                            "<coursecontentmetadata>" +
                                                "<allowComments>true</allowComments>" +
                                                "<attemptlimit>0</attemptlimit>" +
                                                "<defaultpoints>0</defaultpoints>" +
                                                "<description>Test Description</description>" +
                                                "<graderule>2</graderule>" +
                                                "<instructoronly>Student instructor</instructoronly>" +
                                                "<latesubmissions>true</latesubmissions>" +
                                                "<openinsuppwindow>true</openinsuppwindow>" +
                                                "<subtitle>Clip</subtitle>" +
                                                "<thumbnailimage version='1' />" +
                                                "<useproxypage>false</useproxypage>" +
                                                "<viewsubmit>yes</viewsubmit>" +
                                                "<associatedunits>" +
                                                    "<unit rsuiteid='rsuitid1'>Chapter 1</unit>" +
                                                "</associatedunits>" +
                                            "</coursecontentmetadata> " +
                                            "<toc>" +
                                                "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                                    "<associatedunitid/>" +
                                                    "<parentid>bsi__17593B4C__90B3__45B3__8211__6B0CA6984500</parentid>" +
                                                    "<sequence>zzzb</sequence>" +
                                                "</structure>" +
                                            "</toc>" +
                                        "</request>" +
                                      "<request rsuiteid='rsuitid2' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>0</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid2'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuiteid3' type='quiz'>" +
                                        "<version>2.3</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid3'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuitid4' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid4'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuitid5' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid5'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                    "</pubrequest>";

            validations validations = new validations();

            //Act
            result = validations.ValidatePubRequest(strCourseXML);
        }

        [TestMethod]
        [ExpectedExceptionAttribute(typeof(Exception))]
        public void TestValidatePubRequestWhenTitleIsEmpty()
        {
            //Arrange
            bool result;
            string strCourseXML = "<pubrequest requestid='adsfds' type='dlap' tier='dev' entityid='132434' discipline='astronomy'>" +
                                    "<daterequested>3/14/2015 14:00</daterequested>" +
                                    "<publishuser>gsternig</publishuser> " +
                                      "<request rsuiteid='rsuitid1' type='learningcurve'>" +
                                            "<version>2.1</version>" +
                                            "<action>insert</action>  " +
                                            "<contentmetadata> " +
                                                "<title>Reel Teaching Clip:  Chinese Immigrants Encounter Nativism (2:04)</title>" +
                                                "<contenttype>ExternalContent</contenttype>" +
                                                "<displaytype>Display Content</displaytype>   " +
                                                "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                                "<referencedobjects>" +
                                                  "<object version='1'>/js</object>" +
                                                  "<object version='1'>/images</object>" +
                                                "</referencedobjects>" +
                                            "</contentmetadata>" +
                                            "<coursecontentmetadata>" +
                                                "<allowComments>true</allowComments>" +
                                                "<attemptlimit>0</attemptlimit>" +
                                                "<defaultpoints>0</defaultpoints>" +
                                                "<description>Test Description</description>" +
                                                "<graderule>2</graderule>" +
                                                "<instructoronly>Student instructor</instructoronly>" +
                                                "<latesubmissions>true</latesubmissions>" +
                                                "<openinsuppwindow>true</openinsuppwindow>" +
                                                "<subtitle>Clip</subtitle>" +
                                                "<thumbnailimage version='1' />" +
                                                "<useproxypage>false</useproxypage>" +
                                                "<viewsubmit>yes</viewsubmit>" +
                                                "<associatedunits>" +
                                                    "<unit rsuiteid='rsuitid1'>Chapter 1</unit>" +
                                                "</associatedunits>" +
                                            "</coursecontentmetadata> " +
                                            "<toc>" +
                                                "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                                    "<associatedunitid/>" +
                                                    "<parentid>bsi__17593B4C__90B3__45B3__8211__6B0CA6984500</parentid>" +
                                                    "<sequence>zzzb</sequence>" +
                                                "</structure>" +
                                            "</toc>" +
                                        "</request>" +
                                      "<request rsuiteid='rsuitid2' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>0</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid2'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuiteid3' type='quiz'>" +
                                        "<version>2.3</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid3'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuitid4' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid4'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuitid5' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid5'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                    "</pubrequest>";

            validations validations = new validations();

            //Act
            result = validations.ValidatePubRequest(strCourseXML);
        }

        [TestMethod]
        [ExpectedExceptionAttribute(typeof(Exception))]
        public void TestValidatePubRequestWhenUrlIsMissing()
        {
            //Arrange
            bool result;
            string strCourseXML = "<pubrequest requestid='adsfds' type='dlap' tier='dev' entityid='132434' discipline='astronomy'>" +
                                    "<daterequested>3/14/2015 14:00</daterequested>" +
                                    "<publishuser>gsternig</publishuser> " +
                                      "<request rsuiteid='rsuitid1' type='learningcurve'>" +
                                            "<version>2.1</version>" +
                                            "<action>insert</action>  " +
                                            "<contentmetadata> " +
                                                "<title>Reel Teaching Clip:  Chinese Immigrants Encounter Nativism (2:04)</title>" +
                                                "<contenttype>ExternalContent</contenttype>" +
                                                "<displaytype>Display Content</displaytype>   " +
                                                "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                                "<referencedobjects>" +
                                                  "<object version='1'>/js</object>" +
                                                  "<object version='1'>/images</object>" +
                                                "</referencedobjects>" +
                                            "</contentmetadata>" +
                                            "<coursecontentmetadata>" +
                                                "<allowComments>true</allowComments>" +
                                                "<attemptlimit>0</attemptlimit>" +
                                                "<defaultpoints>0</defaultpoints>" +
                                                "<description>Test Description</description>" +
                                                "<graderule>2</graderule>" +
                                                "<instructoronly>Student instructor</instructoronly>" +
                                                "<latesubmissions>true</latesubmissions>" +
                                                "<openinsuppwindow>true</openinsuppwindow>" +
                                                "<subtitle>Clip</subtitle>" +
                                                "<thumbnailimage version='1' />" +
                                                "<useproxypage>false</useproxypage>" +
                                                "<viewsubmit>yes</viewsubmit>" +
                                                "<associatedunits>" +
                                                    "<unit rsuiteid='rsuitid1'>Chapter 1</unit>" +
                                                "</associatedunits>" +
                                            "</coursecontentmetadata> " +
                                            "<toc>" +
                                                "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                                    "<associatedunitid/>" +
                                                    "<parentid>bsi__17593B4C__90B3__45B3__8211__6B0CA6984500</parentid>" +
                                                    "<sequence>zzzb</sequence>" +
                                                "</structure>" +
                                            "</toc>" +
                                        "</request>" +
                                      "<request rsuiteid='rsuitid2' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>0</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid2'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuiteid3' type='quiz'>" +
                                        "<version>2.3</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid3'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuitid4' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid4'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuitid5' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid5'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                    "</pubrequest>";

            validations validations = new validations();

            //Act
            result = validations.ValidatePubRequest(strCourseXML);
        }

        [TestMethod]
        [ExpectedExceptionAttribute(typeof(Exception))]
        public void TestValidatePubRequestWhenUrlIsEmpty()
        {
            //Arrange
            bool result;
            string strCourseXML = "<pubrequest requestid='adsfds' type='dlap' tier='dev' entityid='132434' discipline='astronomy'>" +
                                    "<daterequested>3/14/2015 14:00</daterequested>" +
                                    "<publishuser>gsternig</publishuser> " +
                                      "<request rsuiteid='rsuitid1' type='learningcurve'>" +
                                            "<version>2.1</version>" +
                                            "<action>insert</action>  " +
                                            "<contentmetadata> " +
                                                "<title>Reel Teaching Clip:  Chinese Immigrants Encounter Nativism (2:04)</title>" +
                                                "<contenttype>ExternalContent</contenttype>" +
                                                "<displaytype>Display Content</displaytype>   " +
                                                "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                                "<referencedobjects>" +
                                                  "<object version='1'>/js</object>" +
                                                  "<object version='1'>/images</object>" +
                                                "</referencedobjects>" +
                                            "</contentmetadata>" +
                                            "<coursecontentmetadata>" +
                                                "<allowComments>true</allowComments>" +
                                                "<attemptlimit>0</attemptlimit>" +
                                                "<defaultpoints>0</defaultpoints>" +
                                                "<description>Test Description</description>" +
                                                "<graderule>2</graderule>" +
                                                "<instructoronly>Student instructor</instructoronly>" +
                                                "<latesubmissions>true</latesubmissions>" +
                                                "<openinsuppwindow>true</openinsuppwindow>" +
                                                "<subtitle>Clip</subtitle>" +
                                                "<thumbnailimage version='1' />" +
                                                "<useproxypage>false</useproxypage>" +
                                                "<viewsubmit>yes</viewsubmit>" +
                                                "<associatedunits>" +
                                                    "<unit rsuiteid='rsuitid1'>Chapter 1</unit>" +
                                                "</associatedunits>" +
                                            "</coursecontentmetadata> " +
                                            "<toc>" +
                                                "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                                    "<associatedunitid/>" +
                                                    "<parentid>bsi__17593B4C__90B3__45B3__8211__6B0CA6984500</parentid>" +
                                                    "<sequence>zzzb</sequence>" +
                                                "</structure>" +
                                            "</toc>" +
                                        "</request>" +
                                      "<request rsuiteid='rsuitid2' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>0</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid2'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuiteid3' type='quiz'>" +
                                        "<version>2.3</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid3'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuitid4' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid4'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuitid5' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid5'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                    "</pubrequest>";

            validations validations = new validations();

            //Act
            result = validations.ValidatePubRequest(strCourseXML);
        }
        [TestMethod]
        [ExpectedExceptionAttribute(typeof(Exception))]
        public void TestValidatePubRequestWhenContenttypeIsMissing()
        {
            //Arrange

            bool result;
            string strCourseXML = "<pubrequest requestid='adsfds' type='dlap' tier='dev' entityid='132434' discipline='astronomy'>" +
                                    "<daterequested>3/14/2015 14:00</daterequested>" +
                                    "<publishuser>gsternig</publishuser> " +
                                      "<request rsuiteid='rsuitid1' type='learningcurve'>" +
                                            "<version>2.1</version>" +
                                            "<action>insert</action>  " +         
                                            "<contentmetadata> " +
                                                "<title>Reel Teaching Clip:  Chinese Immigrants Encounter Nativism (2:04)</title>" +
                                                "<contenttype>ExternalContent</contenttype>" +
                                                "<displaytype>Display Content</displaytype>   " +    
                                                "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                                "<referencedobjects>" +
                                                  "<object version='1'>/js</object>" +
                                                  "<object version='1'>/images</object>" +
                                                "</referencedobjects>" +                      
                                            "</contentmetadata>" +
                                            "<coursecontentmetadata>" +
                                                "<allowComments>true</allowComments>" +
                                                "<attemptlimit>0</attemptlimit>" +
                                                "<defaultpoints>0</defaultpoints>" +
                                                "<description>Test Description</description>" +
                                                "<graderule>2</graderule>" +
                                                "<instructoronly>Student instructor</instructoronly>" +
                                                "<latesubmissions>true</latesubmissions>" +
                                                "<openinsuppwindow>true</openinsuppwindow>" +
                                                "<subtitle>Clip</subtitle>" +
                                                "<thumbnailimage version='1' />" +
                                                "<useproxypage>false</useproxypage>" +
                                                "<viewsubmit>yes</viewsubmit>" +        
                                                "<associatedunits>" +
                                                    "<unit rsuiteid='rsuitid1'>Chapter 1</unit>" +
                                                "</associatedunits>" +        
                                            "</coursecontentmetadata> " +     
                                            "<toc>" +
                                                "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                                    "<associatedunitid/>" +
                                                    "<parentid>bsi__17593B4C__90B3__45B3__8211__6B0CA6984500</parentid>" +
                                                    "<sequence>zzzb</sequence>" +
                                                "</structure>" +
                                            "</toc>" +
                                        "</request>" +
                                      "<request rsuiteid='rsuitid2' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>0</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid2'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuiteid3' type='quiz'>" +
                                        "<version>2.3</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid3'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuitid4' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid4'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuitid5' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid5'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                    "</pubrequest>" ;

            validations validations = new validations();

            //Act
            result = validations.ValidatePubRequest(strCourseXML);
        }

        [TestMethod]
        [ExpectedExceptionAttribute(typeof(Exception))]
        public void TestValidatePubRequestWhenContenttypeIsEmpty()
        {
            //Arrange
            bool result;
            string strCourseXML = "<pubrequest requestid='adsfds' type='dlap' tier='dev' entityid='132434' discipline='astronomy'>" +
                                    "<daterequested>3/14/2015 14:00</daterequested>" +
                                    "<publishuser>gsternig</publishuser> " +
                                      "<request rsuiteid='rsuitid1' type='learningcurve'>" +
                                            "<version>2.1</version>" +
                                            "<action>insert</action>  " +
                                            "<contentmetadata> " +
                                                "<title>Reel Teaching Clip:  Chinese Immigrants Encounter Nativism (2:04)</title>" +
                                                "<contenttype>ExternalContent</contenttype>" +
                                                "<displaytype>Display Content</displaytype>   " +
                                                "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                                "<referencedobjects>" +
                                                  "<object version='1'>/js</object>" +
                                                  "<object version='1'>/images</object>" +
                                                "</referencedobjects>" +
                                            "</contentmetadata>" +
                                            "<coursecontentmetadata>" +
                                                "<allowComments>true</allowComments>" +
                                                "<attemptlimit>0</attemptlimit>" +
                                                "<defaultpoints>0</defaultpoints>" +
                                                "<description>Test Description</description>" +
                                                "<graderule>2</graderule>" +
                                                "<instructoronly>Student instructor</instructoronly>" +
                                                "<latesubmissions>true</latesubmissions>" +
                                                "<openinsuppwindow>true</openinsuppwindow>" +
                                                "<subtitle>Clip</subtitle>" +
                                                "<thumbnailimage version='1' />" +
                                                "<useproxypage>false</useproxypage>" +
                                                "<viewsubmit>yes</viewsubmit>" +
                                                "<associatedunits>" +
                                                    "<unit rsuiteid='rsuitid1'>Chapter 1</unit>" +
                                                "</associatedunits>" +
                                            "</coursecontentmetadata> " +
                                            "<toc>" +
                                                "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                                    "<associatedunitid/>" +
                                                    "<parentid>bsi__17593B4C__90B3__45B3__8211__6B0CA6984500</parentid>" +
                                                    "<sequence>zzzb</sequence>" +
                                                "</structure>" +
                                            "</toc>" +
                                        "</request>" +
                                      "<request rsuiteid='rsuitid2' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>0</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid2'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuiteid3' type='quiz'>" +
                                        "<version>2.3</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid3'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuitid4' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid4'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuitid5' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid5'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                    "</pubrequest>";

            validations validations = new validations();

            //Act
            result = validations.ValidatePubRequest(strCourseXML);
        }

        [TestMethod]
        [ExpectedExceptionAttribute(typeof(Exception))]
        public void TestValidatePubRequestWhenDisplaytypeIsMissing()
        {
            //Arrange
            bool result;
            string strCourseXML = "<pubrequest requestid='adsfds' type='dlap' tier='dev' entityid='132434' discipline='astronomy'>" +
                                    "<daterequested>3/14/2015 14:00</daterequested>" +
                                    "<publishuser>gsternig</publishuser> " +
                                      "<request rsuiteid='rsuitid1' type='learningcurve'>" +
                                            "<version>2.1</version>" +
                                            "<action>insert</action>  " +
                                            "<contentmetadata> " +
                                                "<title>Reel Teaching Clip:  Chinese Immigrants Encounter Nativism (2:04)</title>" +
                                                "<contenttype>ExternalContent</contenttype>" +
                                                "<displaytype>Display Content</displaytype>   " +
                                                "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                                "<referencedobjects>" +
                                                  "<object version='1'>/js</object>" +
                                                  "<object version='1'>/images</object>" +
                                                "</referencedobjects>" +
                                            "</contentmetadata>" +
                                            "<coursecontentmetadata>" +
                                                "<allowComments>true</allowComments>" +
                                                "<attemptlimit>0</attemptlimit>" +
                                                "<defaultpoints>0</defaultpoints>" +
                                                "<description>Test Description</description>" +
                                                "<graderule>2</graderule>" +
                                                "<instructoronly>Student instructor</instructoronly>" +
                                                "<latesubmissions>true</latesubmissions>" +
                                                "<openinsuppwindow>true</openinsuppwindow>" +
                                                "<subtitle>Clip</subtitle>" +
                                                "<thumbnailimage version='1' />" +
                                                "<useproxypage>false</useproxypage>" +
                                                "<viewsubmit>yes</viewsubmit>" +
                                                "<associatedunits>" +
                                                    "<unit rsuiteid='rsuitid1'>Chapter 1</unit>" +
                                                "</associatedunits>" +
                                            "</coursecontentmetadata> " +
                                            "<toc>" +
                                                "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                                    "<associatedunitid/>" +
                                                    "<parentid>bsi__17593B4C__90B3__45B3__8211__6B0CA6984500</parentid>" +
                                                    "<sequence>zzzb</sequence>" +
                                                "</structure>" +
                                            "</toc>" +
                                        "</request>" +
                                      "<request rsuiteid='rsuitid2' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>0</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid2'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuiteid3' type='quiz'>" +
                                        "<version>2.3</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid3'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuitid4' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid4'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuitid5' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid5'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                    "</pubrequest>";

            validations validations = new validations();

            //Act
            result = validations.ValidatePubRequest(strCourseXML);
        }

        [TestMethod]
        [ExpectedExceptionAttribute(typeof(Exception))]
        public void TestValidatePubRequestWhenDisplaytypeIsEmpty()
        {
            //Arrange
            bool result;
            string strCourseXML = "<pubrequest requestid='adsfds' type='dlap' tier='dev' entityid='132434' discipline='astronomy'>" +
                                    "<daterequested>3/14/2015 14:00</daterequested>" +
                                    "<publishuser>gsternig</publishuser> " +
                                      "<request rsuiteid='rsuitid1' type='learningcurve'>" +
                                            "<version>2.1</version>" +
                                            "<action>insert</action>  " +
                                            "<contentmetadata> " +
                                                "<title>Reel Teaching Clip:  Chinese Immigrants Encounter Nativism (2:04)</title>" +
                                                "<contenttype>ExternalContent</contenttype>" +
                                                "<displaytype>Display Content</displaytype>   " +
                                                "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                                "<referencedobjects>" +
                                                  "<object version='1'>/js</object>" +
                                                  "<object version='1'>/images</object>" +
                                                "</referencedobjects>" +
                                            "</contentmetadata>" +
                                            "<coursecontentmetadata>" +
                                                "<allowComments>true</allowComments>" +
                                                "<attemptlimit>0</attemptlimit>" +
                                                "<defaultpoints>0</defaultpoints>" +
                                                "<description>Test Description</description>" +
                                                "<graderule>2</graderule>" +
                                                "<instructoronly>Student instructor</instructoronly>" +
                                                "<latesubmissions>true</latesubmissions>" +
                                                "<openinsuppwindow>true</openinsuppwindow>" +
                                                "<subtitle>Clip</subtitle>" +
                                                "<thumbnailimage version='1' />" +
                                                "<useproxypage>false</useproxypage>" +
                                                "<viewsubmit>yes</viewsubmit>" +
                                                "<associatedunits>" +
                                                    "<unit rsuiteid='rsuitid1'>Chapter 1</unit>" +
                                                "</associatedunits>" +
                                            "</coursecontentmetadata> " +
                                            "<toc>" +
                                                "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                                    "<associatedunitid/>" +
                                                    "<parentid>bsi__17593B4C__90B3__45B3__8211__6B0CA6984500</parentid>" +
                                                    "<sequence>zzzb</sequence>" +
                                                "</structure>" +
                                            "</toc>" +
                                        "</request>" +
                                      "<request rsuiteid='rsuitid2' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>0</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid2'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuiteid3' type='quiz'>" +
                                        "<version>2.3</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid3'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuitid4' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid4'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuitid5' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid5'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                    "</pubrequest>";

            validations validations = new validations();

            //Act
            result = validations.ValidatePubRequest(strCourseXML);
        }

        [TestMethod]
        [ExpectedExceptionAttribute(typeof(Exception))]
        public void TestValidatePubRequestWhenDefaultfileIsMissing()
        {
            //Arrange
            bool result;
            string strCourseXML = "<pubrequest requestid='adsfds' type='dlap' tier='dev' entityid='132434' discipline='astronomy'>" +
                                    "<daterequested>3/14/2015 14:00</daterequested>" +
                                    "<publishuser>gsternig</publishuser> " +
                                      "<request rsuiteid='rsuitid1' type='learningcurve'>" +
                                            "<version>2.1</version>" +
                                            "<action>insert</action>  " +
                                            "<contentmetadata> " +
                                                "<title>Reel Teaching Clip:  Chinese Immigrants Encounter Nativism (2:04)</title>" +
                                                "<contenttype>ExternalContent</contenttype>" +
                                                "<displaytype>Display Content</displaytype>   " +
                                                "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                                "<referencedobjects>" +
                                                  "<object version='1'>/js</object>" +
                                                  "<object version='1'>/images</object>" +
                                                "</referencedobjects>" +
                                            "</contentmetadata>" +
                                            "<coursecontentmetadata>" +
                                                "<allowComments>true</allowComments>" +
                                                "<attemptlimit>0</attemptlimit>" +
                                                "<defaultpoints>0</defaultpoints>" +
                                                "<description>Test Description</description>" +
                                                "<graderule>2</graderule>" +
                                                "<instructoronly>Student instructor</instructoronly>" +
                                                "<latesubmissions>true</latesubmissions>" +
                                                "<openinsuppwindow>true</openinsuppwindow>" +
                                                "<subtitle>Clip</subtitle>" +
                                                "<thumbnailimage version='1' />" +
                                                "<useproxypage>false</useproxypage>" +
                                                "<viewsubmit>yes</viewsubmit>" +
                                                "<associatedunits>" +
                                                    "<unit rsuiteid='rsuitid1'>Chapter 1</unit>" +
                                                "</associatedunits>" +
                                            "</coursecontentmetadata> " +
                                            "<toc>" +
                                                "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                                    "<associatedunitid/>" +
                                                    "<parentid>bsi__17593B4C__90B3__45B3__8211__6B0CA6984500</parentid>" +
                                                    "<sequence>zzzb</sequence>" +
                                                "</structure>" +
                                            "</toc>" +
                                        "</request>" +
                                      "<request rsuiteid='rsuitid2' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>0</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid2'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuiteid3' type='quiz'>" +
                                        "<version>2.3</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid3'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuitid4' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid4'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuitid5' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid5'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                    "</pubrequest>";
            validations validations = new validations();

            //Act
            result = validations.ValidatePubRequest(strCourseXML);
        }

        [TestMethod]
        [ExpectedExceptionAttribute(typeof(Exception))]
        public void TestValidatePubRequestWhenDefaultfileAttributeTypeIsMissing()
        {
            //Arrange
            bool result;
            string strCourseXML = "<pubrequest requestid='adsfds' type='dlap' tier='dev' entityid='132434' discipline='astronomy'>" +
                                    "<daterequested>3/14/2015 14:00</daterequested>" +
                                    "<publishuser>gsternig</publishuser> " +
                                      "<request rsuiteid='rsuitid1' type='learningcurve'>" +
                                            "<version>2.1</version>" +
                                            "<action>insert</action>  " +
                                            "<contentmetadata> " +
                                                "<title>Reel Teaching Clip:  Chinese Immigrants Encounter Nativism (2:04)</title>" +
                                                "<contenttype>ExternalContent</contenttype>" +
                                                "<displaytype>Display Content</displaytype>   " +
                                                "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                                "<referencedobjects>" +
                                                  "<object version='1'>/js</object>" +
                                                  "<object version='1'>/images</object>" +
                                                "</referencedobjects>" +
                                            "</contentmetadata>" +
                                            "<coursecontentmetadata>" +
                                                "<allowComments>true</allowComments>" +
                                                "<attemptlimit>0</attemptlimit>" +
                                                "<defaultpoints>0</defaultpoints>" +
                                                "<description>Test Description</description>" +
                                                "<graderule>2</graderule>" +
                                                "<instructoronly>Student instructor</instructoronly>" +
                                                "<latesubmissions>true</latesubmissions>" +
                                                "<openinsuppwindow>true</openinsuppwindow>" +
                                                "<subtitle>Clip</subtitle>" +
                                                "<thumbnailimage version='1' />" +
                                                "<useproxypage>false</useproxypage>" +
                                                "<viewsubmit>yes</viewsubmit>" +
                                                "<associatedunits>" +
                                                    "<unit rsuiteid='rsuitid1'>Chapter 1</unit>" +
                                                "</associatedunits>" +
                                            "</coursecontentmetadata> " +
                                            "<toc>" +
                                                "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                                    "<associatedunitid/>" +
                                                    "<parentid>bsi__17593B4C__90B3__45B3__8211__6B0CA6984500</parentid>" +
                                                    "<sequence>zzzb</sequence>" +
                                                "</structure>" +
                                            "</toc>" +
                                        "</request>" +
                                      "<request rsuiteid='rsuitid2' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>0</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid2'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuiteid3' type='quiz'>" +
                                        "<version>2.3</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid3'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuitid4' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid4'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuitid5' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid5'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                    "</pubrequest>";

            validations validations = new validations();

            //Act
            result = validations.ValidatePubRequest(strCourseXML);
        }

        [TestMethod]
        [ExpectedExceptionAttribute(typeof(Exception))]
        public void TestValidatePubRequestWhenDefaultfileAttributeTypeIsEmpty()
        {
            //Arrange
            bool result;
            string strCourseXML = "<pubrequest requestid='adsfds' type='dlap' tier='dev' entityid='132434' discipline='astronomy'>" +
                                    "<daterequested>3/14/2015 14:00</daterequested>" +
                                    "<publishuser>gsternig</publishuser> " +
                                      "<request rsuiteid='rsuitid1' type='learningcurve'>" +
                                            "<version>2.1</version>" +
                                            "<action>insert</action>  " +
                                            "<contentmetadata> " +
                                                "<title>Reel Teaching Clip:  Chinese Immigrants Encounter Nativism (2:04)</title>" +
                                                "<contenttype>ExternalContent</contenttype>" +
                                                "<displaytype>Display Content</displaytype>   " +
                                                "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                                "<referencedobjects>" +
                                                  "<object version='1'>/js</object>" +
                                                  "<object version='1'>/images</object>" +
                                                "</referencedobjects>" +
                                            "</contentmetadata>" +
                                            "<coursecontentmetadata>" +
                                                "<allowComments>true</allowComments>" +
                                                "<attemptlimit>0</attemptlimit>" +
                                                "<defaultpoints>0</defaultpoints>" +
                                                "<description>Test Description</description>" +
                                                "<graderule>2</graderule>" +
                                                "<instructoronly>Student instructor</instructoronly>" +
                                                "<latesubmissions>true</latesubmissions>" +
                                                "<openinsuppwindow>true</openinsuppwindow>" +
                                                "<subtitle>Clip</subtitle>" +
                                                "<thumbnailimage version='1' />" +
                                                "<useproxypage>false</useproxypage>" +
                                                "<viewsubmit>yes</viewsubmit>" +
                                                "<associatedunits>" +
                                                    "<unit rsuiteid='rsuitid1'>Chapter 1</unit>" +
                                                "</associatedunits>" +
                                            "</coursecontentmetadata> " +
                                            "<toc>" +
                                                "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                                    "<associatedunitid/>" +
                                                    "<parentid>bsi__17593B4C__90B3__45B3__8211__6B0CA6984500</parentid>" +
                                                    "<sequence>zzzb</sequence>" +
                                                "</structure>" +
                                            "</toc>" +
                                        "</request>" +
                                      "<request rsuiteid='rsuitid2' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>0</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid2'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuiteid3' type='quiz'>" +
                                        "<version>2.3</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid3'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuitid4' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid4'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuitid5' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid5'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                    "</pubrequest>";

            validations validations = new validations();

            //Act
            result = validations.ValidatePubRequest(strCourseXML);
        }

        [TestMethod]
        [ExpectedExceptionAttribute(typeof(Exception))]
        public void TestValidatePubRequestWhenDefaultfileIsEmpty()
        {
            //Arrange
            bool result;
            string strCourseXML = "<pubrequest requestid='adsfds' type='dlap' tier='dev' entityid='132434' discipline='astronomy'>" +
                                    "<daterequested>3/14/2015 14:00</daterequested>" +
                                    "<publishuser>gsternig</publishuser> " +
                                      "<request rsuiteid='rsuitid1' type='learningcurve'>" +
                                            "<version>2.1</version>" +
                                            "<action>insert</action>  " +
                                            "<contentmetadata> " +
                                                "<title>Reel Teaching Clip:  Chinese Immigrants Encounter Nativism (2:04)</title>" +
                                                "<contenttype>ExternalContent</contenttype>" +
                                                "<displaytype>Display Content</displaytype>   " +
                                                "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                                "<referencedobjects>" +
                                                  "<object version='1'>/js</object>" +
                                                  "<object version='1'>/images</object>" +
                                                "</referencedobjects>" +
                                            "</contentmetadata>" +
                                            "<coursecontentmetadata>" +
                                                "<allowComments>true</allowComments>" +
                                                "<attemptlimit>0</attemptlimit>" +
                                                "<defaultpoints>0</defaultpoints>" +
                                                "<description>Test Description</description>" +
                                                "<graderule>2</graderule>" +
                                                "<instructoronly>Student instructor</instructoronly>" +
                                                "<latesubmissions>true</latesubmissions>" +
                                                "<openinsuppwindow>true</openinsuppwindow>" +
                                                "<subtitle>Clip</subtitle>" +
                                                "<thumbnailimage version='1' />" +
                                                "<useproxypage>false</useproxypage>" +
                                                "<viewsubmit>yes</viewsubmit>" +
                                                "<associatedunits>" +
                                                    "<unit rsuiteid='rsuitid1'>Chapter 1</unit>" +
                                                "</associatedunits>" +
                                            "</coursecontentmetadata> " +
                                            "<toc>" +
                                                "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                                    "<associatedunitid/>" +
                                                    "<parentid>bsi__17593B4C__90B3__45B3__8211__6B0CA6984500</parentid>" +
                                                    "<sequence>zzzb</sequence>" +
                                                "</structure>" +
                                            "</toc>" +
                                        "</request>" +
                                      "<request rsuiteid='rsuitid2' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>0</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid2'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuiteid3' type='quiz'>" +
                                        "<version>2.3</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid3'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuitid4' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid4'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuitid5' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid5'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                    "</pubrequest>";

            validations validations = new validations();

            //Act
            result = validations.ValidatePubRequest(strCourseXML);
        }

        [TestMethod]
        [ExpectedExceptionAttribute(typeof(Exception))]
        public void TestValidatePubRequestWhenCoursecontentmetadataIsMissing()
        {
            //Arrange
            bool result;
            string strCourseXML = "<pubrequest requestid='adsfds' type='dlap' tier='dev' entityid='132434' discipline='astronomy'>" +
                                    "<daterequested>3/14/2015 14:00</daterequested>" +
                                    "<publishuser>gsternig</publishuser> " +
                                      "<request rsuiteid='rsuitid1' type='learningcurve'>" +
                                            "<version>2.1</version>" +
                                            "<action>insert</action>  " +
                                            "<contentmetadata> " +
                                                "<title>Reel Teaching Clip:  Chinese Immigrants Encounter Nativism (2:04)</title>" +
                                                "<contenttype>ExternalContent</contenttype>" +
                                                "<displaytype>Display Content</displaytype>   " +
                                                "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                                "<referencedobjects>" +
                                                  "<object version='1'>/js</object>" +
                                                  "<object version='1'>/images</object>" +
                                                "</referencedobjects>" +
                                            "</contentmetadata>" +
                                            "<coursecontentmetadata>" +
                                                "<allowComments>true</allowComments>" +
                                                "<attemptlimit>0</attemptlimit>" +
                                                "<defaultpoints>0</defaultpoints>" +
                                                "<description>Test Description</description>" +
                                                "<graderule>2</graderule>" +
                                                "<instructoronly>Student instructor</instructoronly>" +
                                                "<latesubmissions>true</latesubmissions>" +
                                                "<openinsuppwindow>true</openinsuppwindow>" +
                                                "<subtitle>Clip</subtitle>" +
                                                "<thumbnailimage version='1' />" +
                                                "<useproxypage>false</useproxypage>" +
                                                "<viewsubmit>yes</viewsubmit>" +
                                                "<associatedunits>" +
                                                    "<unit rsuiteid='rsuitid1'>Chapter 1</unit>" +
                                                "</associatedunits>" +
                                            "</coursecontentmetadata> " +
                                            "<toc>" +
                                                "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                                    "<associatedunitid/>" +
                                                    "<parentid>bsi__17593B4C__90B3__45B3__8211__6B0CA6984500</parentid>" +
                                                    "<sequence>zzzb</sequence>" +
                                                "</structure>" +
                                            "</toc>" +
                                        "</request>" +
                                      "<request rsuiteid='rsuitid2' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>0</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid2'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuiteid3' type='quiz'>" +
                                        "<version>2.3</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid3'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuitid4' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid4'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuitid5' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid5'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                    "</pubrequest>";

            validations validations = new validations();

            //Act
            result = validations.ValidatePubRequest(strCourseXML);
        }
        [TestMethod]
        [ExpectedExceptionAttribute(typeof(Exception))]
        public void TestValidatePubRequestWhenAllowcommentsIsMissing()
        {
            //Arrange
            bool result;
            string strCourseXML = "<pubrequest requestid='adsfds' type='dlap' tier='dev' entityid='132434' discipline='astronomy'>" +
                                    "<daterequested>3/14/2015 14:00</daterequested>" +
                                    "<publishuser>gsternig</publishuser> " +
                                      "<request rsuiteid='rsuitid1' type='learningcurve'>" +
                                            "<version>2.1</version>" +
                                            "<action>insert</action>  " +
                                            "<contentmetadata> " +
                                                "<title>Reel Teaching Clip:  Chinese Immigrants Encounter Nativism (2:04)</title>" +
                                                "<contenttype>ExternalContent</contenttype>" +
                                                "<displaytype>Display Content</displaytype>   " +
                                                "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                                "<referencedobjects>" +
                                                  "<object version='1'>/js</object>" +
                                                  "<object version='1'>/images</object>" +
                                                "</referencedobjects>" +
                                            "</contentmetadata>" +
                                            "<coursecontentmetadata>" +
                                                "<allowComments>true</allowComments>" +
                                                "<attemptlimit>0</attemptlimit>" +
                                                "<defaultpoints>0</defaultpoints>" +
                                                "<description>Test Description</description>" +
                                                "<graderule>2</graderule>" +
                                                "<instructoronly>Student instructor</instructoronly>" +
                                                "<latesubmissions>true</latesubmissions>" +
                                                "<openinsuppwindow>true</openinsuppwindow>" +
                                                "<subtitle>Clip</subtitle>" +
                                                "<thumbnailimage version='1' />" +
                                                "<useproxypage>false</useproxypage>" +
                                                "<viewsubmit>yes</viewsubmit>" +
                                                "<associatedunits>" +
                                                    "<unit rsuiteid='rsuitid1'>Chapter 1</unit>" +
                                                "</associatedunits>" +
                                            "</coursecontentmetadata> " +
                                            "<toc>" +
                                                "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                                    "<associatedunitid/>" +
                                                    "<parentid>bsi__17593B4C__90B3__45B3__8211__6B0CA6984500</parentid>" +
                                                    "<sequence>zzzb</sequence>" +
                                                "</structure>" +
                                            "</toc>" +
                                        "</request>" +
                                      "<request rsuiteid='rsuitid2' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>0</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid2'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuiteid3' type='quiz'>" +
                                        "<version>2.3</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid3'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuitid4' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid4'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuitid5' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid5'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                    "</pubrequest>";

            validations validations = new validations();

            //Act
            result = validations.ValidatePubRequest(strCourseXML);
        }
        [TestMethod]
        [ExpectedExceptionAttribute(typeof(Exception))]
        public void TestValidatePubRequestWhenAttemptlimitIsMissing()
        {
            //Arrange
            bool result;
            string strCourseXML = "<pubrequest requestid='adsfds' type='dlap' tier='dev' entityid='132434' discipline='astronomy'>" +
                                    "<daterequested>3/14/2015 14:00</daterequested>" +
                                    "<publishuser>gsternig</publishuser> " +
                                      "<request rsuiteid='rsuitid1' type='learningcurve'>" +
                                            "<version>2.1</version>" +
                                            "<action>insert</action>  " +
                                            "<contentmetadata> " +
                                                "<title>Reel Teaching Clip:  Chinese Immigrants Encounter Nativism (2:04)</title>" +
                                                "<contenttype>ExternalContent</contenttype>" +
                                                "<displaytype>Display Content</displaytype>   " +
                                                "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                                "<referencedobjects>" +
                                                  "<object version='1'>/js</object>" +
                                                  "<object version='1'>/images</object>" +
                                                "</referencedobjects>" +
                                            "</contentmetadata>" +
                                            "<coursecontentmetadata>" +
                                                "<allowComments>true</allowComments>" +
                                                "<attemptlimit>0</attemptlimit>" +
                                                "<defaultpoints>0</defaultpoints>" +
                                                "<description>Test Description</description>" +
                                                "<graderule>2</graderule>" +
                                                "<instructoronly>Student instructor</instructoronly>" +
                                                "<latesubmissions>true</latesubmissions>" +
                                                "<openinsuppwindow>true</openinsuppwindow>" +
                                                "<subtitle>Clip</subtitle>" +
                                                "<thumbnailimage version='1' />" +
                                                "<useproxypage>false</useproxypage>" +
                                                "<viewsubmit>yes</viewsubmit>" +
                                                "<associatedunits>" +
                                                    "<unit rsuiteid='rsuitid1'>Chapter 1</unit>" +
                                                "</associatedunits>" +
                                            "</coursecontentmetadata> " +
                                            "<toc>" +
                                                "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                                    "<associatedunitid/>" +
                                                    "<parentid>bsi__17593B4C__90B3__45B3__8211__6B0CA6984500</parentid>" +
                                                    "<sequence>zzzb</sequence>" +
                                                "</structure>" +
                                            "</toc>" +
                                        "</request>" +
                                      "<request rsuiteid='rsuitid2' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>0</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid2'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuiteid3' type='quiz'>" +
                                        "<version>2.3</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid3'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuitid4' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid4'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuitid5' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid5'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                    "</pubrequest>";

            validations validations = new validations();

            //Act
            result = validations.ValidatePubRequest(strCourseXML);
        }

        [TestMethod]
        [ExpectedExceptionAttribute(typeof(Exception))]
        public void TestValidatePubRequestWhenAssociatedunitsIsMissing()
        {
            //Arrange
            bool result;
            string strCourseXML = "<pubrequest requestid='adsfds' type='dlap' tier='dev' entityid='132434' discipline='astronomy'>" +
                                    "<daterequested>3/14/2015 14:00</daterequested>" +
                                    "<publishuser>gsternig</publishuser> " +
                                      "<request rsuiteid='rsuitid1' type='learningcurve'>" +
                                            "<version>2.1</version>" +
                                            "<action>insert</action>  " +
                                            "<contentmetadata> " +
                                                "<title>Reel Teaching Clip:  Chinese Immigrants Encounter Nativism (2:04)</title>" +
                                                "<contenttype>ExternalContent</contenttype>" +
                                                "<displaytype>Display Content</displaytype>   " +
                                                "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                                "<referencedobjects>" +
                                                  "<object version='1'>/js</object>" +
                                                  "<object version='1'>/images</object>" +
                                                "</referencedobjects>" +
                                            "</contentmetadata>" +
                                            "<coursecontentmetadata>" +
                                                "<allowComments>true</allowComments>" +
                                                "<attemptlimit>0</attemptlimit>" +
                                                "<defaultpoints>0</defaultpoints>" +
                                                "<description>Test Description</description>" +
                                                "<graderule>2</graderule>" +
                                                "<instructoronly>Student instructor</instructoronly>" +
                                                "<latesubmissions>true</latesubmissions>" +
                                                "<openinsuppwindow>true</openinsuppwindow>" +
                                                "<subtitle>Clip</subtitle>" +
                                                "<thumbnailimage version='1' />" +
                                                "<useproxypage>false</useproxypage>" +
                                                "<viewsubmit>yes</viewsubmit>" +
                                                "<associatedunits>" +
                                                    "<unit rsuiteid='rsuitid1'>Chapter 1</unit>" +
                                                "</associatedunits>" +
                                            "</coursecontentmetadata> " +
                                            "<toc>" +
                                                "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                                    "<associatedunitid/>" +
                                                    "<parentid>bsi__17593B4C__90B3__45B3__8211__6B0CA6984500</parentid>" +
                                                    "<sequence>zzzb</sequence>" +
                                                "</structure>" +
                                            "</toc>" +
                                        "</request>" +
                                      "<request rsuiteid='rsuitid2' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>0</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid2'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuiteid3' type='quiz'>" +
                                        "<version>2.3</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid3'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuitid4' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid4'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuitid5' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid5'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                    "</pubrequest>";

            validations validations = new validations();

            //Act
            result = validations.ValidatePubRequest(strCourseXML);
        }

        [TestMethod]
        [ExpectedExceptionAttribute(typeof(Exception))]
        public void TestValidatePubRequestWhenUnitIsMissing()
        {
            //Arrange
            bool result;
            string strCourseXML = "<pubrequest requestid='adsfds' type='dlap' tier='dev' entityid='132434' discipline='astronomy'>" +
                                    "<daterequested>3/14/2015 14:00</daterequested>" +
                                    "<publishuser>gsternig</publishuser> " +
                                      "<request rsuiteid='rsuitid1' type='learningcurve'>" +
                                            "<version>2.1</version>" +
                                            "<action>insert</action>  " +
                                            "<contentmetadata> " +
                                                "<title>Reel Teaching Clip:  Chinese Immigrants Encounter Nativism (2:04)</title>" +
                                                "<contenttype>ExternalContent</contenttype>" +
                                                "<displaytype>Display Content</displaytype>   " +
                                                "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                                "<referencedobjects>" +
                                                  "<object version='1'>/js</object>" +
                                                  "<object version='1'>/images</object>" +
                                                "</referencedobjects>" +
                                            "</contentmetadata>" +
                                            "<coursecontentmetadata>" +
                                                "<allowComments>true</allowComments>" +
                                                "<attemptlimit>0</attemptlimit>" +
                                                "<defaultpoints>0</defaultpoints>" +
                                                "<description>Test Description</description>" +
                                                "<graderule>2</graderule>" +
                                                "<instructoronly>Student instructor</instructoronly>" +
                                                "<latesubmissions>true</latesubmissions>" +
                                                "<openinsuppwindow>true</openinsuppwindow>" +
                                                "<subtitle>Clip</subtitle>" +
                                                "<thumbnailimage version='1' />" +
                                                "<useproxypage>false</useproxypage>" +
                                                "<viewsubmit>yes</viewsubmit>" +
                                                "<associatedunits>" +
                                                    "<unit rsuiteid='rsuitid1'>Chapter 1</unit>" +
                                                "</associatedunits>" +
                                            "</coursecontentmetadata> " +
                                            "<toc>" +
                                                "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                                    "<associatedunitid/>" +
                                                    "<parentid>bsi__17593B4C__90B3__45B3__8211__6B0CA6984500</parentid>" +
                                                    "<sequence>zzzb</sequence>" +
                                                "</structure>" +
                                            "</toc>" +
                                        "</request>" +
                                      "<request rsuiteid='rsuitid2' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>0</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid2'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuiteid3' type='quiz'>" +
                                        "<version>2.3</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid3'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuitid4' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid4'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuitid5' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid5'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                    "</pubrequest>";

            validations validations = new validations();

            //Act
            result = validations.ValidatePubRequest(strCourseXML);
        }

        [TestMethod]
        [ExpectedExceptionAttribute(typeof(Exception))]
        public void TestValidatePubRequestWhenUnitAttributeRsuiteIdIsMissing()
        {
            //Arrange
            bool result;
            string strCourseXML = "<pubrequest requestid='adsfds' type='dlap' tier='dev' entityid='132434' discipline='astronomy'>" +
                                    "<daterequested>3/14/2015 14:00</daterequested>" +
                                    "<publishuser>gsternig</publishuser> " +
                                      "<request rsuiteid='rsuitid1' type='learningcurve'>" +
                                            "<version>2.1</version>" +
                                            "<action>insert</action>  " +
                                            "<contentmetadata> " +
                                                "<title>Reel Teaching Clip:  Chinese Immigrants Encounter Nativism (2:04)</title>" +
                                                "<contenttype>ExternalContent</contenttype>" +
                                                "<displaytype>Display Content</displaytype>   " +
                                                "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                                "<referencedobjects>" +
                                                  "<object version='1'>/js</object>" +
                                                  "<object version='1'>/images</object>" +
                                                "</referencedobjects>" +
                                            "</contentmetadata>" +
                                            "<coursecontentmetadata>" +
                                                "<allowComments>true</allowComments>" +
                                                "<attemptlimit>0</attemptlimit>" +
                                                "<defaultpoints>0</defaultpoints>" +
                                                "<description>Test Description</description>" +
                                                "<graderule>2</graderule>" +
                                                "<instructoronly>Student instructor</instructoronly>" +
                                                "<latesubmissions>true</latesubmissions>" +
                                                "<openinsuppwindow>true</openinsuppwindow>" +
                                                "<subtitle>Clip</subtitle>" +
                                                "<thumbnailimage version='1' />" +
                                                "<useproxypage>false</useproxypage>" +
                                                "<viewsubmit>yes</viewsubmit>" +
                                                "<associatedunits>" +
                                                    "<unit rsuiteid='rsuitid1'>Chapter 1</unit>" +
                                                "</associatedunits>" +
                                            "</coursecontentmetadata> " +
                                            "<toc>" +
                                                "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                                    "<associatedunitid/>" +
                                                    "<parentid>bsi__17593B4C__90B3__45B3__8211__6B0CA6984500</parentid>" +
                                                    "<sequence>zzzb</sequence>" +
                                                "</structure>" +
                                            "</toc>" +
                                        "</request>" +
                                      "<request rsuiteid='rsuitid2' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>0</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid2'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuiteid3' type='quiz'>" +
                                        "<version>2.3</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid3'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuitid4' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid4'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuitid5' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid5'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                    "</pubrequest>";

            validations validations = new validations();

            //Act
            result = validations.ValidatePubRequest(strCourseXML);
        }

        [TestMethod]
        [ExpectedExceptionAttribute(typeof(Exception))]
        public void TestValidatePubRequestWhenUnitAttributeRsuiteIdIsEmpty()
        {
            //Arrange
            bool result;
            string strCourseXML = "<pubrequest requestid='adsfds' type='dlap' tier='dev' entityid='132434' discipline='astronomy'>" +
                                    "<daterequested>3/14/2015 14:00</daterequested>" +
                                    "<publishuser>gsternig</publishuser> " +
                                      "<request rsuiteid='rsuitid1' type='learningcurve'>" +
                                            "<version>2.1</version>" +
                                            "<action>insert</action>  " +
                                            "<contentmetadata> " +
                                                "<title>Reel Teaching Clip:  Chinese Immigrants Encounter Nativism (2:04)</title>" +
                                                "<contenttype>ExternalContent</contenttype>" +
                                                "<displaytype>Display Content</displaytype>   " +
                                                "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                                "<referencedobjects>" +
                                                  "<object version='1'>/js</object>" +
                                                  "<object version='1'>/images</object>" +
                                                "</referencedobjects>" +
                                            "</contentmetadata>" +
                                            "<coursecontentmetadata>" +
                                                "<allowComments>true</allowComments>" +
                                                "<attemptlimit>0</attemptlimit>" +
                                                "<defaultpoints>0</defaultpoints>" +
                                                "<description>Test Description</description>" +
                                                "<graderule>2</graderule>" +
                                                "<instructoronly>Student instructor</instructoronly>" +
                                                "<latesubmissions>true</latesubmissions>" +
                                                "<openinsuppwindow>true</openinsuppwindow>" +
                                                "<subtitle>Clip</subtitle>" +
                                                "<thumbnailimage version='1' />" +
                                                "<useproxypage>false</useproxypage>" +
                                                "<viewsubmit>yes</viewsubmit>" +
                                                "<associatedunits>" +
                                                    "<unit rsuiteid='rsuitid1'>Chapter 1</unit>" +
                                                "</associatedunits>" +
                                            "</coursecontentmetadata> " +
                                            "<toc>" +
                                                "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                                    "<associatedunitid/>" +
                                                    "<parentid>bsi__17593B4C__90B3__45B3__8211__6B0CA6984500</parentid>" +
                                                    "<sequence>zzzb</sequence>" +
                                                "</structure>" +
                                            "</toc>" +
                                        "</request>" +
                                      "<request rsuiteid='rsuitid2' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>0</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid2'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuiteid3' type='quiz'>" +
                                        "<version>2.3</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid3'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuitid4' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid4'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuitid5' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid5'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                    "</pubrequest>";

            validations validations = new validations();

            //Act
            result = validations.ValidatePubRequest(strCourseXML);
        }

        [TestMethod]
        [ExpectedExceptionAttribute(typeof(Exception))]
        public void TestValidatePubRequestWhenUnitIsEmpty()
        {
            //Arrange
            bool result;
            string strCourseXML = "<pubrequest requestid='adsfds' type='dlap' tier='dev' entityid='132434' discipline='astronomy'>" +
                                     "<daterequested>3/14/2015 14:00</daterequested>" +
                                     "<publishuser>gsternig</publishuser> " +
                                       "<request rsuiteid='rsuitid1' type='learningcurve'>" +
                                             "<version>2.1</version>" +
                                             "<action>insert</action>  " +
                                             "<contentmetadata> " +
                                                 "<title>Reel Teaching Clip:  Chinese Immigrants Encounter Nativism (2:04)</title>" +
                                                 "<contenttype>ExternalContent</contenttype>" +
                                                 "<displaytype>Display Content</displaytype>   " +
                                                 "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                                 "<referencedobjects>" +
                                                   "<object version='1'>/js</object>" +
                                                   "<object version='1'>/images</object>" +
                                                 "</referencedobjects>" +
                                             "</contentmetadata>" +
                                             "<coursecontentmetadata>" +
                                                 "<allowComments>true</allowComments>" +
                                                 "<attemptlimit>0</attemptlimit>" +
                                                 "<defaultpoints>0</defaultpoints>" +
                                                 "<description>Test Description</description>" +
                                                 "<graderule>2</graderule>" +
                                                 "<instructoronly>Student instructor</instructoronly>" +
                                                 "<latesubmissions>true</latesubmissions>" +
                                                 "<openinsuppwindow>true</openinsuppwindow>" +
                                                 "<subtitle>Clip</subtitle>" +
                                                 "<thumbnailimage version='1' />" +
                                                 "<useproxypage>false</useproxypage>" +
                                                 "<viewsubmit>yes</viewsubmit>" +
                                                 "<associatedunits>" +
                                                     "<unit rsuiteid='rsuitid1'>Chapter 1</unit>" +
                                                 "</associatedunits>" +
                                             "</coursecontentmetadata> " +
                                             "<toc>" +
                                                 "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                                     "<associatedunitid/>" +
                                                     "<parentid>bsi__17593B4C__90B3__45B3__8211__6B0CA6984500</parentid>" +
                                                     "<sequence>zzzb</sequence>" +
                                                 "</structure>" +
                                             "</toc>" +
                                         "</request>" +
                                       "<request rsuiteid='rsuitid2' type='quiz'>" +
                                         "<version>2.1</version>" +
                                         "<action>insert</action>" +
                                         "<contentmetadata>" +
                                           "<title>Testing Item 2</title>" +
                                           "<contenttype>ExternalContent</contenttype>" +
                                           "<displaytype>Display Content</displaytype>" +
                                           "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                           "<referencedobjects>" +
                                             "<object version='1'>/js</object>" +
                                             "<object version='1'>/images</object>" +
                                           "</referencedobjects>" +
                                         "</contentmetadata>" +
                                         "<coursecontentmetadata>" +
                                           "<allowComments>true</allowComments>" +
                                           "<attemptlimit>0</attemptlimit>" +
                                           "<defaultpoints>0</defaultpoints>" +
                                           "<description>Test Description</description>" +
                                           "<graderule>2</graderule>" +
                                           "<instructoronly>Student instructor</instructoronly>" +
                                           "<latesubmissions>true</latesubmissions>" +
                                           "<openinsuppwindow>true</openinsuppwindow>" +
                                           "<subtitle>Clip</subtitle>" +
                                           "<thumbnailimage version='1' />" +
                                           "<useproxypage>false</useproxypage>" +
                                           "<viewsubmit>yes</viewsubmit>" +
                                           "<associatedunits>" +
                                             "<unit rsuiteid='rsuitid2'>Chapter 2</unit>" +
                                           "</associatedunits>" +
                                         "</coursecontentmetadata>" +
                                         "<toc>" +
                                           "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                             "<associatedunitid/>" +
                                             "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                             "<sequence>zzzC</sequence>" +
                                           "</structure>" +
                                         "</toc>" +
                                       "</request>" +
                                       "<request rsuiteid='rsuiteid3' type='quiz'>" +
                                         "<version>2.3</version>" +
                                         "<action>insert</action>" +
                                         "<contentmetadata>" +
                                           "<title>Testing Item 2</title>" +
                                           "<contenttype>ExternalContent</contenttype>" +
                                           "<displaytype>Display Content</displaytype>" +
                                           "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                           "<referencedobjects>" +
                                             "<object version='1'>/js</object>" +
                                             "<object version='1'>/images</object>" +
                                           "</referencedobjects>" +
                                         "</contentmetadata>" +
                                         "<coursecontentmetadata>" +
                                           "<allowComments>true</allowComments>" +
                                           "<attemptlimit>1</attemptlimit>" +
                                           "<defaultpoints>0</defaultpoints>" +
                                           "<description>Test Description</description>" +
                                           "<graderule>2</graderule>" +
                                           "<instructoronly>Student instructor</instructoronly>" +
                                           "<latesubmissions>true</latesubmissions>" +
                                           "<openinsuppwindow>true</openinsuppwindow>" +
                                           "<subtitle>Clip</subtitle>" +
                                           "<thumbnailimage version='1' />" +
                                           "<useproxypage>false</useproxypage>" +
                                           "<viewsubmit>yes</viewsubmit>" +
                                           "<associatedunits>" +
                                             "<unit rsuiteid='rsuitid3'>Chapter 2</unit>" +
                                           "</associatedunits>" +
                                         "</coursecontentmetadata>" +
                                         "<toc>" +
                                           "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                             "<associatedunitid/>" +
                                             "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                             "<sequence>zzzC</sequence>" +
                                           "</structure>" +
                                         "</toc>" +
                                       "</request>" +
                                       "<request rsuiteid='rsuitid4' type='quiz'>" +
                                         "<version>2.1</version>" +
                                         "<action>insert</action>" +
                                         "<contentmetadata>" +
                                           "<title>Testing Item 2</title>" +
                                           "<contenttype>ExternalContent</contenttype>" +
                                           "<displaytype>Display Content</displaytype>" +
                                           "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                           "<referencedobjects>" +
                                             "<object version='1'>/js</object>" +
                                             "<object version='1'>/images</object>" +
                                           "</referencedobjects>" +
                                         "</contentmetadata>" +
                                         "<coursecontentmetadata>" +
                                           "<allowComments>true</allowComments>" +
                                           "<attemptlimit>1</attemptlimit>" +
                                           "<defaultpoints>0</defaultpoints>" +
                                           "<description>Test Description</description>" +
                                           "<graderule>2</graderule>" +
                                           "<instructoronly>Student instructor</instructoronly>" +
                                           "<latesubmissions>true</latesubmissions>" +
                                           "<openinsuppwindow>true</openinsuppwindow>" +
                                           "<subtitle>Clip</subtitle>" +
                                           "<thumbnailimage version='1' />" +
                                           "<useproxypage>false</useproxypage>" +
                                           "<viewsubmit>yes</viewsubmit>" +
                                           "<associatedunits>" +
                                             "<unit rsuiteid='rsuitid4'>Chapter 2</unit>" +
                                           "</associatedunits>" +
                                         "</coursecontentmetadata>" +
                                         "<toc>" +
                                           "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                             "<associatedunitid/>" +
                                             "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                             "<sequence>zzzC</sequence>" +
                                           "</structure>" +
                                         "</toc>" +
                                       "</request>" +
                                       "<request rsuiteid='rsuitid5' type='quiz'>" +
                                         "<version>2.1</version>" +
                                         "<action>insert</action>" +
                                         "<contentmetadata>" +
                                           "<title>Testing Item 2</title>" +
                                           "<contenttype>ExternalContent</contenttype>" +
                                           "<displaytype>Display Content</displaytype>" +
                                           "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                           "<referencedobjects>" +
                                             "<object version='1'>/js</object>" +
                                             "<object version='1'>/images</object>" +
                                           "</referencedobjects>" +
                                         "</contentmetadata>" +
                                         "<coursecontentmetadata>" +
                                           "<allowComments>true</allowComments>" +
                                           "<attemptlimit>1</attemptlimit>" +
                                           "<defaultpoints>0</defaultpoints>" +
                                           "<description>Test Description</description>" +
                                           "<graderule>2</graderule>" +
                                           "<instructoronly>Student instructor</instructoronly>" +
                                           "<latesubmissions>true</latesubmissions>" +
                                           "<openinsuppwindow>true</openinsuppwindow>" +
                                           "<subtitle>Clip</subtitle>" +
                                           "<thumbnailimage version='1' />" +
                                           "<useproxypage>false</useproxypage>" +
                                           "<viewsubmit>yes</viewsubmit>" +
                                           "<associatedunits>" +
                                             "<unit rsuiteid='rsuitid5'>Chapter 2</unit>" +
                                           "</associatedunits>" +
                                         "</coursecontentmetadata>" +
                                         "<toc>" +
                                           "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                             "<associatedunitid/>" +
                                             "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                             "<sequence>zzzC</sequence>" +
                                           "</structure>" +
                                         "</toc>" +
                                       "</request>" +
                                     "</pubrequest>";

            validations validations = new validations();

            //Act
            result = validations.ValidatePubRequest(strCourseXML);
        }

        [TestMethod]
        [ExpectedExceptionAttribute(typeof(Exception))]
        public void TestValidatePubRequestWhenTocIsMissing()
        {
            //Arrange
            bool result;
            string strCourseXML = "<pubrequest requestid='adsfds' type='dlap' tier='dev' entityid='132434' discipline='astronomy'>" +
                                     "<daterequested>3/14/2015 14:00</daterequested>" +
                                     "<publishuser>gsternig</publishuser> " +
                                       "<request rsuiteid='rsuitid1' type='learningcurve'>" +
                                             "<version>2.1</version>" +
                                             "<action>insert</action>  " +
                                             "<contentmetadata> " +
                                                 "<title>Reel Teaching Clip:  Chinese Immigrants Encounter Nativism (2:04)</title>" +
                                                 "<contenttype>ExternalContent</contenttype>" +
                                                 "<displaytype>Display Content</displaytype>   " +
                                                 "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                                 "<referencedobjects>" +
                                                   "<object version='1'>/js</object>" +
                                                   "<object version='1'>/images</object>" +
                                                 "</referencedobjects>" +
                                             "</contentmetadata>" +
                                             "<coursecontentmetadata>" +
                                                 "<allowComments>true</allowComments>" +
                                                 "<attemptlimit>0</attemptlimit>" +
                                                 "<defaultpoints>0</defaultpoints>" +
                                                 "<description>Test Description</description>" +
                                                 "<graderule>2</graderule>" +
                                                 "<instructoronly>Student instructor</instructoronly>" +
                                                 "<latesubmissions>true</latesubmissions>" +
                                                 "<openinsuppwindow>true</openinsuppwindow>" +
                                                 "<subtitle>Clip</subtitle>" +
                                                 "<thumbnailimage version='1' />" +
                                                 "<useproxypage>false</useproxypage>" +
                                                 "<viewsubmit>yes</viewsubmit>" +
                                                 "<associatedunits>" +
                                                     "<unit rsuiteid='rsuitid1'>Chapter 1</unit>" +
                                                 "</associatedunits>" +
                                             "</coursecontentmetadata> " +
                                             "<toc>" +
                                                 "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                                     "<associatedunitid/>" +
                                                     "<parentid>bsi__17593B4C__90B3__45B3__8211__6B0CA6984500</parentid>" +
                                                     "<sequence>zzzb</sequence>" +
                                                 "</structure>" +
                                             "</toc>" +
                                         "</request>" +
                                       "<request rsuiteid='rsuitid2' type='quiz'>" +
                                         "<version>2.1</version>" +
                                         "<action>insert</action>" +
                                         "<contentmetadata>" +
                                           "<title>Testing Item 2</title>" +
                                           "<contenttype>ExternalContent</contenttype>" +
                                           "<displaytype>Display Content</displaytype>" +
                                           "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                           "<referencedobjects>" +
                                             "<object version='1'>/js</object>" +
                                             "<object version='1'>/images</object>" +
                                           "</referencedobjects>" +
                                         "</contentmetadata>" +
                                         "<coursecontentmetadata>" +
                                           "<allowComments>true</allowComments>" +
                                           "<attemptlimit>0</attemptlimit>" +
                                           "<defaultpoints>0</defaultpoints>" +
                                           "<description>Test Description</description>" +
                                           "<graderule>2</graderule>" +
                                           "<instructoronly>Student instructor</instructoronly>" +
                                           "<latesubmissions>true</latesubmissions>" +
                                           "<openinsuppwindow>true</openinsuppwindow>" +
                                           "<subtitle>Clip</subtitle>" +
                                           "<thumbnailimage version='1' />" +
                                           "<useproxypage>false</useproxypage>" +
                                           "<viewsubmit>yes</viewsubmit>" +
                                           "<associatedunits>" +
                                             "<unit rsuiteid='rsuitid2'>Chapter 2</unit>" +
                                           "</associatedunits>" +
                                         "</coursecontentmetadata>" +
                                         "<toc>" +
                                           "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                             "<associatedunitid/>" +
                                             "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                             "<sequence>zzzC</sequence>" +
                                           "</structure>" +
                                         "</toc>" +
                                       "</request>" +
                                       "<request rsuiteid='rsuiteid3' type='quiz'>" +
                                         "<version>2.3</version>" +
                                         "<action>insert</action>" +
                                         "<contentmetadata>" +
                                           "<title>Testing Item 2</title>" +
                                           "<contenttype>ExternalContent</contenttype>" +
                                           "<displaytype>Display Content</displaytype>" +
                                           "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                           "<referencedobjects>" +
                                             "<object version='1'>/js</object>" +
                                             "<object version='1'>/images</object>" +
                                           "</referencedobjects>" +
                                         "</contentmetadata>" +
                                         "<coursecontentmetadata>" +
                                           "<allowComments>true</allowComments>" +
                                           "<attemptlimit>1</attemptlimit>" +
                                           "<defaultpoints>0</defaultpoints>" +
                                           "<description>Test Description</description>" +
                                           "<graderule>2</graderule>" +
                                           "<instructoronly>Student instructor</instructoronly>" +
                                           "<latesubmissions>true</latesubmissions>" +
                                           "<openinsuppwindow>true</openinsuppwindow>" +
                                           "<subtitle>Clip</subtitle>" +
                                           "<thumbnailimage version='1' />" +
                                           "<useproxypage>false</useproxypage>" +
                                           "<viewsubmit>yes</viewsubmit>" +
                                           "<associatedunits>" +
                                             "<unit rsuiteid='rsuitid3'>Chapter 2</unit>" +
                                           "</associatedunits>" +
                                         "</coursecontentmetadata>" +
                                         "<toc>" +
                                           "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                             "<associatedunitid/>" +
                                             "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                             "<sequence>zzzC</sequence>" +
                                           "</structure>" +
                                         "</toc>" +
                                       "</request>" +
                                       "<request rsuiteid='rsuitid4' type='quiz'>" +
                                         "<version>2.1</version>" +
                                         "<action>insert</action>" +
                                         "<contentmetadata>" +
                                           "<title>Testing Item 2</title>" +
                                           "<contenttype>ExternalContent</contenttype>" +
                                           "<displaytype>Display Content</displaytype>" +
                                           "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                           "<referencedobjects>" +
                                             "<object version='1'>/js</object>" +
                                             "<object version='1'>/images</object>" +
                                           "</referencedobjects>" +
                                         "</contentmetadata>" +
                                         "<coursecontentmetadata>" +
                                           "<allowComments>true</allowComments>" +
                                           "<attemptlimit>1</attemptlimit>" +
                                           "<defaultpoints>0</defaultpoints>" +
                                           "<description>Test Description</description>" +
                                           "<graderule>2</graderule>" +
                                           "<instructoronly>Student instructor</instructoronly>" +
                                           "<latesubmissions>true</latesubmissions>" +
                                           "<openinsuppwindow>true</openinsuppwindow>" +
                                           "<subtitle>Clip</subtitle>" +
                                           "<thumbnailimage version='1' />" +
                                           "<useproxypage>false</useproxypage>" +
                                           "<viewsubmit>yes</viewsubmit>" +
                                           "<associatedunits>" +
                                             "<unit rsuiteid='rsuitid4'>Chapter 2</unit>" +
                                           "</associatedunits>" +
                                         "</coursecontentmetadata>" +
                                         "<toc>" +
                                           "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                             "<associatedunitid/>" +
                                             "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                             "<sequence>zzzC</sequence>" +
                                           "</structure>" +
                                         "</toc>" +
                                       "</request>" +
                                       "<request rsuiteid='rsuitid5' type='quiz'>" +
                                         "<version>2.1</version>" +
                                         "<action>insert</action>" +
                                         "<contentmetadata>" +
                                           "<title>Testing Item 2</title>" +
                                           "<contenttype>ExternalContent</contenttype>" +
                                           "<displaytype>Display Content</displaytype>" +
                                           "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                           "<referencedobjects>" +
                                             "<object version='1'>/js</object>" +
                                             "<object version='1'>/images</object>" +
                                           "</referencedobjects>" +
                                         "</contentmetadata>" +
                                         "<coursecontentmetadata>" +
                                           "<allowComments>true</allowComments>" +
                                           "<attemptlimit>1</attemptlimit>" +
                                           "<defaultpoints>0</defaultpoints>" +
                                           "<description>Test Description</description>" +
                                           "<graderule>2</graderule>" +
                                           "<instructoronly>Student instructor</instructoronly>" +
                                           "<latesubmissions>true</latesubmissions>" +
                                           "<openinsuppwindow>true</openinsuppwindow>" +
                                           "<subtitle>Clip</subtitle>" +
                                           "<thumbnailimage version='1' />" +
                                           "<useproxypage>false</useproxypage>" +
                                           "<viewsubmit>yes</viewsubmit>" +
                                           "<associatedunits>" +
                                             "<unit rsuiteid='rsuitid5'>Chapter 2</unit>" +
                                           "</associatedunits>" +
                                         "</coursecontentmetadata>" +
                                         "<toc>" +
                                           "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                             "<associatedunitid/>" +
                                             "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                             "<sequence>zzzC</sequence>" +
                                           "</structure>" +
                                         "</toc>" +
                                       "</request>" +
                                     "</pubrequest>";

            validations validations = new validations();

            //Act
            result = validations.ValidatePubRequest(strCourseXML);
        }

        [TestMethod]
        [ExpectedExceptionAttribute(typeof(Exception))]
        public void TestValidatePubRequestWhenStructureIsMissing()
        {
            //Arrange
            bool result;
            string strCourseXML = "<pubrequest requestid='adsfds' type='dlap' tier='dev' entityid='132434' discipline='astronomy'>" +
                                     "<daterequested>3/14/2015 14:00</daterequested>" +
                                     "<publishuser>gsternig</publishuser> " +
                                       "<request rsuiteid='rsuitid1' type='learningcurve'>" +
                                             "<version>2.1</version>" +
                                             "<action>insert</action>  " +
                                             "<contentmetadata> " +
                                                 "<title>Reel Teaching Clip:  Chinese Immigrants Encounter Nativism (2:04)</title>" +
                                                 "<contenttype>ExternalContent</contenttype>" +
                                                 "<displaytype>Display Content</displaytype>   " +
                                                 "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                                 "<referencedobjects>" +
                                                   "<object version='1'>/js</object>" +
                                                   "<object version='1'>/images</object>" +
                                                 "</referencedobjects>" +
                                             "</contentmetadata>" +
                                             "<coursecontentmetadata>" +
                                                 "<allowComments>true</allowComments>" +
                                                 "<attemptlimit>0</attemptlimit>" +
                                                 "<defaultpoints>0</defaultpoints>" +
                                                 "<description>Test Description</description>" +
                                                 "<graderule>2</graderule>" +
                                                 "<instructoronly>Student instructor</instructoronly>" +
                                                 "<latesubmissions>true</latesubmissions>" +
                                                 "<openinsuppwindow>true</openinsuppwindow>" +
                                                 "<subtitle>Clip</subtitle>" +
                                                 "<thumbnailimage version='1' />" +
                                                 "<useproxypage>false</useproxypage>" +
                                                 "<viewsubmit>yes</viewsubmit>" +
                                                 "<associatedunits>" +
                                                     "<unit rsuiteid='rsuitid1'>Chapter 1</unit>" +
                                                 "</associatedunits>" +
                                             "</coursecontentmetadata> " +
                                             "<toc>" +
                                                 "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                                     "<associatedunitid/>" +
                                                     "<parentid>bsi__17593B4C__90B3__45B3__8211__6B0CA6984500</parentid>" +
                                                     "<sequence>zzzb</sequence>" +
                                                 "</structure>" +
                                             "</toc>" +
                                         "</request>" +
                                       "<request rsuiteid='rsuitid2' type='quiz'>" +
                                         "<version>2.1</version>" +
                                         "<action>insert</action>" +
                                         "<contentmetadata>" +
                                           "<title>Testing Item 2</title>" +
                                           "<contenttype>ExternalContent</contenttype>" +
                                           "<displaytype>Display Content</displaytype>" +
                                           "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                           "<referencedobjects>" +
                                             "<object version='1'>/js</object>" +
                                             "<object version='1'>/images</object>" +
                                           "</referencedobjects>" +
                                         "</contentmetadata>" +
                                         "<coursecontentmetadata>" +
                                           "<allowComments>true</allowComments>" +
                                           "<attemptlimit>0</attemptlimit>" +
                                           "<defaultpoints>0</defaultpoints>" +
                                           "<description>Test Description</description>" +
                                           "<graderule>2</graderule>" +
                                           "<instructoronly>Student instructor</instructoronly>" +
                                           "<latesubmissions>true</latesubmissions>" +
                                           "<openinsuppwindow>true</openinsuppwindow>" +
                                           "<subtitle>Clip</subtitle>" +
                                           "<thumbnailimage version='1' />" +
                                           "<useproxypage>false</useproxypage>" +
                                           "<viewsubmit>yes</viewsubmit>" +
                                           "<associatedunits>" +
                                             "<unit rsuiteid='rsuitid2'>Chapter 2</unit>" +
                                           "</associatedunits>" +
                                         "</coursecontentmetadata>" +
                                         "<toc>" +
                                           "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                             "<associatedunitid/>" +
                                             "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                             "<sequence>zzzC</sequence>" +
                                           "</structure>" +
                                         "</toc>" +
                                       "</request>" +
                                       "<request rsuiteid='rsuiteid3' type='quiz'>" +
                                         "<version>2.3</version>" +
                                         "<action>insert</action>" +
                                         "<contentmetadata>" +
                                           "<title>Testing Item 2</title>" +
                                           "<contenttype>ExternalContent</contenttype>" +
                                           "<displaytype>Display Content</displaytype>" +
                                           "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                           "<referencedobjects>" +
                                             "<object version='1'>/js</object>" +
                                             "<object version='1'>/images</object>" +
                                           "</referencedobjects>" +
                                         "</contentmetadata>" +
                                         "<coursecontentmetadata>" +
                                           "<allowComments>true</allowComments>" +
                                           "<attemptlimit>1</attemptlimit>" +
                                           "<defaultpoints>0</defaultpoints>" +
                                           "<description>Test Description</description>" +
                                           "<graderule>2</graderule>" +
                                           "<instructoronly>Student instructor</instructoronly>" +
                                           "<latesubmissions>true</latesubmissions>" +
                                           "<openinsuppwindow>true</openinsuppwindow>" +
                                           "<subtitle>Clip</subtitle>" +
                                           "<thumbnailimage version='1' />" +
                                           "<useproxypage>false</useproxypage>" +
                                           "<viewsubmit>yes</viewsubmit>" +
                                           "<associatedunits>" +
                                             "<unit rsuiteid='rsuitid3'>Chapter 2</unit>" +
                                           "</associatedunits>" +
                                         "</coursecontentmetadata>" +
                                         "<toc>" +
                                           "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                             "<associatedunitid/>" +
                                             "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                             "<sequence>zzzC</sequence>" +
                                           "</structure>" +
                                         "</toc>" +
                                       "</request>" +
                                       "<request rsuiteid='rsuitid4' type='quiz'>" +
                                         "<version>2.1</version>" +
                                         "<action>insert</action>" +
                                         "<contentmetadata>" +
                                           "<title>Testing Item 2</title>" +
                                           "<contenttype>ExternalContent</contenttype>" +
                                           "<displaytype>Display Content</displaytype>" +
                                           "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                           "<referencedobjects>" +
                                             "<object version='1'>/js</object>" +
                                             "<object version='1'>/images</object>" +
                                           "</referencedobjects>" +
                                         "</contentmetadata>" +
                                         "<coursecontentmetadata>" +
                                           "<allowComments>true</allowComments>" +
                                           "<attemptlimit>1</attemptlimit>" +
                                           "<defaultpoints>0</defaultpoints>" +
                                           "<description>Test Description</description>" +
                                           "<graderule>2</graderule>" +
                                           "<instructoronly>Student instructor</instructoronly>" +
                                           "<latesubmissions>true</latesubmissions>" +
                                           "<openinsuppwindow>true</openinsuppwindow>" +
                                           "<subtitle>Clip</subtitle>" +
                                           "<thumbnailimage version='1' />" +
                                           "<useproxypage>false</useproxypage>" +
                                           "<viewsubmit>yes</viewsubmit>" +
                                           "<associatedunits>" +
                                             "<unit rsuiteid='rsuitid4'>Chapter 2</unit>" +
                                           "</associatedunits>" +
                                         "</coursecontentmetadata>" +
                                         "<toc>" +
                                           "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                             "<associatedunitid/>" +
                                             "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                             "<sequence>zzzC</sequence>" +
                                           "</structure>" +
                                         "</toc>" +
                                       "</request>" +
                                       "<request rsuiteid='rsuitid5' type='quiz'>" +
                                         "<version>2.1</version>" +
                                         "<action>insert</action>" +
                                         "<contentmetadata>" +
                                           "<title>Testing Item 2</title>" +
                                           "<contenttype>ExternalContent</contenttype>" +
                                           "<displaytype>Display Content</displaytype>" +
                                           "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                           "<referencedobjects>" +
                                             "<object version='1'>/js</object>" +
                                             "<object version='1'>/images</object>" +
                                           "</referencedobjects>" +
                                         "</contentmetadata>" +
                                         "<coursecontentmetadata>" +
                                           "<allowComments>true</allowComments>" +
                                           "<attemptlimit>1</attemptlimit>" +
                                           "<defaultpoints>0</defaultpoints>" +
                                           "<description>Test Description</description>" +
                                           "<graderule>2</graderule>" +
                                           "<instructoronly>Student instructor</instructoronly>" +
                                           "<latesubmissions>true</latesubmissions>" +
                                           "<openinsuppwindow>true</openinsuppwindow>" +
                                           "<subtitle>Clip</subtitle>" +
                                           "<thumbnailimage version='1' />" +
                                           "<useproxypage>false</useproxypage>" +
                                           "<viewsubmit>yes</viewsubmit>" +
                                           "<associatedunits>" +
                                             "<unit rsuiteid='rsuitid5'>Chapter 2</unit>" +
                                           "</associatedunits>" +
                                         "</coursecontentmetadata>" +
                                         "<toc>" +
                                           "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                             "<associatedunitid/>" +
                                             "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                             "<sequence>zzzC</sequence>" +
                                           "</structure>" +
                                         "</toc>" +
                                       "</request>" +
                                     "</pubrequest>";

            validations validations = new validations();

            //Act
            result = validations.ValidatePubRequest(strCourseXML);
        }

        [TestMethod]
        [ExpectedExceptionAttribute(typeof(Exception))]
        public void TestValidatePubRequestWhenStructureAttributeTypeIsMissing()
        {
            //Arrange
            bool result;
            string strCourseXML = "<pubrequest requestid='adsfds' type='dlap' tier='dev' entityid='132434' discipline='astronomy'>" +
                                    "<daterequested>3/14/2015 14:00</daterequested>" +
                                    "<publishuser>gsternig</publishuser> " +
                                      "<request rsuiteid='rsuitid1' type='learningcurve'>" +
                                            "<version>2.1</version>" +
                                            "<action>insert</action>  " +
                                            "<contentmetadata> " +
                                                "<title>Reel Teaching Clip:  Chinese Immigrants Encounter Nativism (2:04)</title>" +
                                                "<contenttype>ExternalContent</contenttype>" +
                                                "<displaytype>Display Content</displaytype>   " +
                                                "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                                "<referencedobjects>" +
                                                  "<object version='1'>/js</object>" +
                                                  "<object version='1'>/images</object>" +
                                                "</referencedobjects>" +
                                            "</contentmetadata>" +
                                            "<coursecontentmetadata>" +
                                                "<allowComments>true</allowComments>" +
                                                "<attemptlimit>0</attemptlimit>" +
                                                "<defaultpoints>0</defaultpoints>" +
                                                "<description>Test Description</description>" +
                                                "<graderule>2</graderule>" +
                                                "<instructoronly>Student instructor</instructoronly>" +
                                                "<latesubmissions>true</latesubmissions>" +
                                                "<openinsuppwindow>true</openinsuppwindow>" +
                                                "<subtitle>Clip</subtitle>" +
                                                "<thumbnailimage version='1' />" +
                                                "<useproxypage>false</useproxypage>" +
                                                "<viewsubmit>yes</viewsubmit>" +
                                                "<associatedunits>" +
                                                    "<unit rsuiteid='rsuitid1'>Chapter 1</unit>" +
                                                "</associatedunits>" +
                                            "</coursecontentmetadata> " +
                                            "<toc>" +
                                                "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                                    "<associatedunitid/>" +
                                                    "<parentid>bsi__17593B4C__90B3__45B3__8211__6B0CA6984500</parentid>" +
                                                    "<sequence>zzzb</sequence>" +
                                                "</structure>" +
                                            "</toc>" +
                                        "</request>" +
                                      "<request rsuiteid='rsuitid2' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>0</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid2'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuiteid3' type='quiz'>" +
                                        "<version>2.3</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid3'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuitid4' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid4'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuitid5' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid5'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                    "</pubrequest>";

            validations validations = new validations();

            //Act
            result = validations.ValidatePubRequest(strCourseXML);
        }

        [TestMethod]
        [ExpectedExceptionAttribute(typeof(Exception))]
        public void TestValidatePubRequestWhenStructureAttributeTypeIsEmpty()
        {
            //Arrange
            bool result;
            string strCourseXML = "<pubrequest requestid='adsfds' type='dlap' tier='dev' entityid='132434' discipline='astronomy'>" +
                                    "<daterequested>3/14/2015 14:00</daterequested>" +
                                    "<publishuser>gsternig</publishuser> " +
                                      "<request rsuiteid='rsuitid1' type='learningcurve'>" +
                                            "<version>2.1</version>" +
                                            "<action>insert</action>  " +         
                                            "<contentmetadata> " +
                                                "<title>Reel Teaching Clip:  Chinese Immigrants Encounter Nativism (2:04)</title>" +
                                                "<contenttype>ExternalContent</contenttype>" +
                                                "<displaytype>Display Content</displaytype>   " +    
                                                "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                                "<referencedobjects>" +
                                                  "<object version='1'>/js</object>" +
                                                  "<object version='1'>/images</object>" +
                                                "</referencedobjects>" +                      
                                            "</contentmetadata>" +
                                            "<coursecontentmetadata>" +
                                                "<allowComments>true</allowComments>" +
                                                "<attemptlimit>0</attemptlimit>" +
                                                "<defaultpoints>0</defaultpoints>" +
                                                "<description>Test Description</description>" +
                                                "<graderule>2</graderule>" +
                                                "<instructoronly>Student instructor</instructoronly>" +
                                                "<latesubmissions>true</latesubmissions>" +
                                                "<openinsuppwindow>true</openinsuppwindow>" +
                                                "<subtitle>Clip</subtitle>" +
                                                "<thumbnailimage version='1' />" +
                                                "<useproxypage>false</useproxypage>" +
                                                "<viewsubmit>yes</viewsubmit>" +        
                                                "<associatedunits>" +
                                                    "<unit rsuiteid='rsuitid1'>Chapter 1</unit>" +
                                                "</associatedunits>" +        
                                            "</coursecontentmetadata> " +     
                                            "<toc>" +
                                                "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                                    "<associatedunitid/>" +
                                                    "<parentid>bsi__17593B4C__90B3__45B3__8211__6B0CA6984500</parentid>" +
                                                    "<sequence>zzzb</sequence>" +
                                                "</structure>" +
                                            "</toc>" +
                                        "</request>" +
                                      "<request rsuiteid='rsuitid2' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>0</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid2'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuiteid3' type='quiz'>" +
                                        "<version>2.3</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid3'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuitid4' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid4'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuitid5' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid5'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                    "</pubrequest>" ;

            validations validations = new validations();

            //Act
            result = validations.ValidatePubRequest(strCourseXML);
        }

        [TestMethod]
        [ExpectedExceptionAttribute(typeof(Exception))]
        public void TestValidatePubRequestWhenStructureAttributeHidefromlaunchpadIsMissing()
        {
            //Arrange
            bool result;
            string strCourseXML = "<pubrequest requestid='adsfds' type='dlap' tier='dev' entityid='132434' discipline='astronomy'>" +
                                     "<daterequested>3/14/2015 14:00</daterequested>" +
                                     "<publishuser>gsternig</publishuser> " +
                                       "<request rsuiteid='rsuitid1' type='learningcurve'>" +
                                             "<version>2.1</version>" +
                                             "<action>insert</action>  " +
                                             "<contentmetadata> " +
                                                 "<title>Reel Teaching Clip:  Chinese Immigrants Encounter Nativism (2:04)</title>" +
                                                 "<contenttype>ExternalContent</contenttype>" +
                                                 "<displaytype>Display Content</displaytype>   " +
                                                 "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                                 "<referencedobjects>" +
                                                   "<object version='1'>/js</object>" +
                                                   "<object version='1'>/images</object>" +
                                                 "</referencedobjects>" +
                                             "</contentmetadata>" +
                                             "<coursecontentmetadata>" +
                                                 "<allowComments>true</allowComments>" +
                                                 "<attemptlimit>0</attemptlimit>" +
                                                 "<defaultpoints>0</defaultpoints>" +
                                                 "<description>Test Description</description>" +
                                                 "<graderule>2</graderule>" +
                                                 "<instructoronly>Student instructor</instructoronly>" +
                                                 "<latesubmissions>true</latesubmissions>" +
                                                 "<openinsuppwindow>true</openinsuppwindow>" +
                                                 "<subtitle>Clip</subtitle>" +
                                                 "<thumbnailimage version='1' />" +
                                                 "<useproxypage>false</useproxypage>" +
                                                 "<viewsubmit>yes</viewsubmit>" +
                                                 "<associatedunits>" +
                                                     "<unit rsuiteid='rsuitid1'>Chapter 1</unit>" +
                                                 "</associatedunits>" +
                                             "</coursecontentmetadata> " +
                                             "<toc>" +
                                                 "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                                     "<associatedunitid/>" +
                                                     "<parentid>bsi__17593B4C__90B3__45B3__8211__6B0CA6984500</parentid>" +
                                                     "<sequence>zzzb</sequence>" +
                                                 "</structure>" +
                                             "</toc>" +
                                         "</request>" +
                                       "<request rsuiteid='rsuitid2' type='quiz'>" +
                                         "<version>2.1</version>" +
                                         "<action>insert</action>" +
                                         "<contentmetadata>" +
                                           "<title>Testing Item 2</title>" +
                                           "<contenttype>ExternalContent</contenttype>" +
                                           "<displaytype>Display Content</displaytype>" +
                                           "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                           "<referencedobjects>" +
                                             "<object version='1'>/js</object>" +
                                             "<object version='1'>/images</object>" +
                                           "</referencedobjects>" +
                                         "</contentmetadata>" +
                                         "<coursecontentmetadata>" +
                                           "<allowComments>true</allowComments>" +
                                           "<attemptlimit>0</attemptlimit>" +
                                           "<defaultpoints>0</defaultpoints>" +
                                           "<description>Test Description</description>" +
                                           "<graderule>2</graderule>" +
                                           "<instructoronly>Student instructor</instructoronly>" +
                                           "<latesubmissions>true</latesubmissions>" +
                                           "<openinsuppwindow>true</openinsuppwindow>" +
                                           "<subtitle>Clip</subtitle>" +
                                           "<thumbnailimage version='1' />" +
                                           "<useproxypage>false</useproxypage>" +
                                           "<viewsubmit>yes</viewsubmit>" +
                                           "<associatedunits>" +
                                             "<unit rsuiteid='rsuitid2'>Chapter 2</unit>" +
                                           "</associatedunits>" +
                                         "</coursecontentmetadata>" +
                                         "<toc>" +
                                           "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                             "<associatedunitid/>" +
                                             "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                             "<sequence>zzzC</sequence>" +
                                           "</structure>" +
                                         "</toc>" +
                                       "</request>" +
                                       "<request rsuiteid='rsuiteid3' type='quiz'>" +
                                         "<version>2.3</version>" +
                                         "<action>insert</action>" +
                                         "<contentmetadata>" +
                                           "<title>Testing Item 2</title>" +
                                           "<contenttype>ExternalContent</contenttype>" +
                                           "<displaytype>Display Content</displaytype>" +
                                           "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                           "<referencedobjects>" +
                                             "<object version='1'>/js</object>" +
                                             "<object version='1'>/images</object>" +
                                           "</referencedobjects>" +
                                         "</contentmetadata>" +
                                         "<coursecontentmetadata>" +
                                           "<allowComments>true</allowComments>" +
                                           "<attemptlimit>1</attemptlimit>" +
                                           "<defaultpoints>0</defaultpoints>" +
                                           "<description>Test Description</description>" +
                                           "<graderule>2</graderule>" +
                                           "<instructoronly>Student instructor</instructoronly>" +
                                           "<latesubmissions>true</latesubmissions>" +
                                           "<openinsuppwindow>true</openinsuppwindow>" +
                                           "<subtitle>Clip</subtitle>" +
                                           "<thumbnailimage version='1' />" +
                                           "<useproxypage>false</useproxypage>" +
                                           "<viewsubmit>yes</viewsubmit>" +
                                           "<associatedunits>" +
                                             "<unit rsuiteid='rsuitid3'>Chapter 2</unit>" +
                                           "</associatedunits>" +
                                         "</coursecontentmetadata>" +
                                         "<toc>" +
                                           "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                             "<associatedunitid/>" +
                                             "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                             "<sequence>zzzC</sequence>" +
                                           "</structure>" +
                                         "</toc>" +
                                       "</request>" +
                                       "<request rsuiteid='rsuitid4' type='quiz'>" +
                                         "<version>2.1</version>" +
                                         "<action>insert</action>" +
                                         "<contentmetadata>" +
                                           "<title>Testing Item 2</title>" +
                                           "<contenttype>ExternalContent</contenttype>" +
                                           "<displaytype>Display Content</displaytype>" +
                                           "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                           "<referencedobjects>" +
                                             "<object version='1'>/js</object>" +
                                             "<object version='1'>/images</object>" +
                                           "</referencedobjects>" +
                                         "</contentmetadata>" +
                                         "<coursecontentmetadata>" +
                                           "<allowComments>true</allowComments>" +
                                           "<attemptlimit>1</attemptlimit>" +
                                           "<defaultpoints>0</defaultpoints>" +
                                           "<description>Test Description</description>" +
                                           "<graderule>2</graderule>" +
                                           "<instructoronly>Student instructor</instructoronly>" +
                                           "<latesubmissions>true</latesubmissions>" +
                                           "<openinsuppwindow>true</openinsuppwindow>" +
                                           "<subtitle>Clip</subtitle>" +
                                           "<thumbnailimage version='1' />" +
                                           "<useproxypage>false</useproxypage>" +
                                           "<viewsubmit>yes</viewsubmit>" +
                                           "<associatedunits>" +
                                             "<unit rsuiteid='rsuitid4'>Chapter 2</unit>" +
                                           "</associatedunits>" +
                                         "</coursecontentmetadata>" +
                                         "<toc>" +
                                           "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                             "<associatedunitid/>" +
                                             "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                             "<sequence>zzzC</sequence>" +
                                           "</structure>" +
                                         "</toc>" +
                                       "</request>" +
                                       "<request rsuiteid='rsuitid5' type='quiz'>" +
                                         "<version>2.1</version>" +
                                         "<action>insert</action>" +
                                         "<contentmetadata>" +
                                           "<title>Testing Item 2</title>" +
                                           "<contenttype>ExternalContent</contenttype>" +
                                           "<displaytype>Display Content</displaytype>" +
                                           "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                           "<referencedobjects>" +
                                             "<object version='1'>/js</object>" +
                                             "<object version='1'>/images</object>" +
                                           "</referencedobjects>" +
                                         "</contentmetadata>" +
                                         "<coursecontentmetadata>" +
                                           "<allowComments>true</allowComments>" +
                                           "<attemptlimit>1</attemptlimit>" +
                                           "<defaultpoints>0</defaultpoints>" +
                                           "<description>Test Description</description>" +
                                           "<graderule>2</graderule>" +
                                           "<instructoronly>Student instructor</instructoronly>" +
                                           "<latesubmissions>true</latesubmissions>" +
                                           "<openinsuppwindow>true</openinsuppwindow>" +
                                           "<subtitle>Clip</subtitle>" +
                                           "<thumbnailimage version='1' />" +
                                           "<useproxypage>false</useproxypage>" +
                                           "<viewsubmit>yes</viewsubmit>" +
                                           "<associatedunits>" +
                                             "<unit rsuiteid='rsuitid5'>Chapter 2</unit>" +
                                           "</associatedunits>" +
                                         "</coursecontentmetadata>" +
                                         "<toc>" +
                                           "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                             "<associatedunitid/>" +
                                             "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                             "<sequence>zzzC</sequence>" +
                                           "</structure>" +
                                         "</toc>" +
                                       "</request>" +
                                     "</pubrequest>";

            validations validations = new validations();

            //Act
            result = validations.ValidatePubRequest(strCourseXML);
        }

        [TestMethod]
        [ExpectedExceptionAttribute(typeof(Exception))]
        public void TestValidatePubRequestWhenStructureAttributeHidefromlaunchpadIsEmpty()
        {
            //Arrange
            bool result;
            string strCourseXML = "<pubrequest requestid='adsfds' type='dlap' tier='dev' entityid='132434' discipline='astronomy'>" +
                                    "<daterequested>3/14/2015 14:00</daterequested>" +
                                    "<publishuser>gsternig</publishuser> " +
                                      "<request rsuiteid='rsuitid1' type='learningcurve'>" +
                                            "<version>2.1</version>" +
                                            "<action>insert</action>  " +
                                            "<contentmetadata> " +
                                                "<title>Reel Teaching Clip:  Chinese Immigrants Encounter Nativism (2:04)</title>" +
                                                "<contenttype>ExternalContent</contenttype>" +
                                                "<displaytype>Display Content</displaytype>   " +
                                                "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                                "<referencedobjects>" +
                                                  "<object version='1'>/js</object>" +
                                                  "<object version='1'>/images</object>" +
                                                "</referencedobjects>" +
                                            "</contentmetadata>" +
                                            "<coursecontentmetadata>" +
                                                "<allowComments>true</allowComments>" +
                                                "<attemptlimit>0</attemptlimit>" +
                                                "<defaultpoints>0</defaultpoints>" +
                                                "<description>Test Description</description>" +
                                                "<graderule>2</graderule>" +
                                                "<instructoronly>Student instructor</instructoronly>" +
                                                "<latesubmissions>true</latesubmissions>" +
                                                "<openinsuppwindow>true</openinsuppwindow>" +
                                                "<subtitle>Clip</subtitle>" +
                                                "<thumbnailimage version='1' />" +
                                                "<useproxypage>false</useproxypage>" +
                                                "<viewsubmit>yes</viewsubmit>" +
                                                "<associatedunits>" +
                                                    "<unit rsuiteid='rsuitid1'>Chapter 1</unit>" +
                                                "</associatedunits>" +
                                            "</coursecontentmetadata> " +
                                            "<toc>" +
                                                "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                                    "<associatedunitid/>" +
                                                    "<parentid>bsi__17593B4C__90B3__45B3__8211__6B0CA6984500</parentid>" +
                                                    "<sequence>zzzb</sequence>" +
                                                "</structure>" +
                                            "</toc>" +
                                        "</request>" +
                                      "<request rsuiteid='rsuitid2' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>0</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid2'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuiteid3' type='quiz'>" +
                                        "<version>2.3</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid3'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuitid4' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid4'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuitid5' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid5'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                    "</pubrequest>";

            validations validations = new validations();

            //Act
            result = validations.ValidatePubRequest(strCourseXML);
        }

        [TestMethod]
        [ExpectedExceptionAttribute(typeof(Exception))]
        public void TestValidatePubRequestWhenAssociatedunitidIsMissing()
        {
            //Arrange
            bool result;
            string strCourseXML = "<pubrequest requestid='adsfds' type='dlap' tier='dev' entityid='132434' discipline='astronomy'>" +
                                    "<daterequested>3/14/2015 14:00</daterequested>" +
                                    "<publishuser>gsternig</publishuser> " +
                                      "<request rsuiteid='rsuitid1' type='learningcurve'>" +
                                            "<version>2.1</version>" +
                                            "<action>insert</action>  " +
                                            "<contentmetadata> " +
                                                "<title>Reel Teaching Clip:  Chinese Immigrants Encounter Nativism (2:04)</title>" +
                                                "<contenttype>ExternalContent</contenttype>" +
                                                "<displaytype>Display Content</displaytype>   " +
                                                "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                                "<referencedobjects>" +
                                                  "<object version='1'>/js</object>" +
                                                  "<object version='1'>/images</object>" +
                                                "</referencedobjects>" +
                                            "</contentmetadata>" +
                                            "<coursecontentmetadata>" +
                                                "<allowComments>true</allowComments>" +
                                                "<attemptlimit>0</attemptlimit>" +
                                                "<defaultpoints>0</defaultpoints>" +
                                                "<description>Test Description</description>" +
                                                "<graderule>2</graderule>" +
                                                "<instructoronly>Student instructor</instructoronly>" +
                                                "<latesubmissions>true</latesubmissions>" +
                                                "<openinsuppwindow>true</openinsuppwindow>" +
                                                "<subtitle>Clip</subtitle>" +
                                                "<thumbnailimage version='1' />" +
                                                "<useproxypage>false</useproxypage>" +
                                                "<viewsubmit>yes</viewsubmit>" +
                                                "<associatedunits>" +
                                                    "<unit rsuiteid='rsuitid1'>Chapter 1</unit>" +
                                                "</associatedunits>" +
                                            "</coursecontentmetadata> " +
                                            "<toc>" +
                                                "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                                    "<associatedunitid/>" +
                                                    "<parentid>bsi__17593B4C__90B3__45B3__8211__6B0CA6984500</parentid>" +
                                                    "<sequence>zzzb</sequence>" +
                                                "</structure>" +
                                            "</toc>" +
                                        "</request>" +
                                      "<request rsuiteid='rsuitid2' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>0</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid2'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuiteid3' type='quiz'>" +
                                        "<version>2.3</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid3'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuitid4' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid4'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuitid5' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid5'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                    "</pubrequest>";

            validations validations = new validations();

            //Act
            result = validations.ValidatePubRequest(strCourseXML);
        }

        [TestMethod]
        [ExpectedExceptionAttribute(typeof(Exception))]
        public void TestValidatePubRequestWhenParentidIsMissing()
        {
            //Arrange
            bool result;
            string strCourseXML = "<pubrequest requestid='adsfds' type='dlap' tier='dev' entityid='132434' discipline='astronomy'>" +
                                     "<daterequested>3/14/2015 14:00</daterequested>" +
                                     "<publishuser>gsternig</publishuser> " +
                                       "<request rsuiteid='rsuitid1' type='learningcurve'>" +
                                             "<version>2.1</version>" +
                                             "<action>insert</action>  " +
                                             "<contentmetadata> " +
                                                 "<title>Reel Teaching Clip:  Chinese Immigrants Encounter Nativism (2:04)</title>" +
                                                 "<contenttype>ExternalContent</contenttype>" +
                                                 "<displaytype>Display Content</displaytype>   " +
                                                 "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                                 "<referencedobjects>" +
                                                   "<object version='1'>/js</object>" +
                                                   "<object version='1'>/images</object>" +
                                                 "</referencedobjects>" +
                                             "</contentmetadata>" +
                                             "<coursecontentmetadata>" +
                                                 "<allowComments>true</allowComments>" +
                                                 "<attemptlimit>0</attemptlimit>" +
                                                 "<defaultpoints>0</defaultpoints>" +
                                                 "<description>Test Description</description>" +
                                                 "<graderule>2</graderule>" +
                                                 "<instructoronly>Student instructor</instructoronly>" +
                                                 "<latesubmissions>true</latesubmissions>" +
                                                 "<openinsuppwindow>true</openinsuppwindow>" +
                                                 "<subtitle>Clip</subtitle>" +
                                                 "<thumbnailimage version='1' />" +
                                                 "<useproxypage>false</useproxypage>" +
                                                 "<viewsubmit>yes</viewsubmit>" +
                                                 "<associatedunits>" +
                                                     "<unit rsuiteid='rsuitid1'>Chapter 1</unit>" +
                                                 "</associatedunits>" +
                                             "</coursecontentmetadata> " +
                                             "<toc>" +
                                                 "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                                     "<associatedunitid/>" +
                                                     "<parentid>bsi__17593B4C__90B3__45B3__8211__6B0CA6984500</parentid>" +
                                                     "<sequence>zzzb</sequence>" +
                                                 "</structure>" +
                                             "</toc>" +
                                         "</request>" +
                                       "<request rsuiteid='rsuitid2' type='quiz'>" +
                                         "<version>2.1</version>" +
                                         "<action>insert</action>" +
                                         "<contentmetadata>" +
                                           "<title>Testing Item 2</title>" +
                                           "<contenttype>ExternalContent</contenttype>" +
                                           "<displaytype>Display Content</displaytype>" +
                                           "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                           "<referencedobjects>" +
                                             "<object version='1'>/js</object>" +
                                             "<object version='1'>/images</object>" +
                                           "</referencedobjects>" +
                                         "</contentmetadata>" +
                                         "<coursecontentmetadata>" +
                                           "<allowComments>true</allowComments>" +
                                           "<attemptlimit>0</attemptlimit>" +
                                           "<defaultpoints>0</defaultpoints>" +
                                           "<description>Test Description</description>" +
                                           "<graderule>2</graderule>" +
                                           "<instructoronly>Student instructor</instructoronly>" +
                                           "<latesubmissions>true</latesubmissions>" +
                                           "<openinsuppwindow>true</openinsuppwindow>" +
                                           "<subtitle>Clip</subtitle>" +
                                           "<thumbnailimage version='1' />" +
                                           "<useproxypage>false</useproxypage>" +
                                           "<viewsubmit>yes</viewsubmit>" +
                                           "<associatedunits>" +
                                             "<unit rsuiteid='rsuitid2'>Chapter 2</unit>" +
                                           "</associatedunits>" +
                                         "</coursecontentmetadata>" +
                                         "<toc>" +
                                           "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                             "<associatedunitid/>" +
                                             "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                             "<sequence>zzzC</sequence>" +
                                           "</structure>" +
                                         "</toc>" +
                                       "</request>" +
                                       "<request rsuiteid='rsuiteid3' type='quiz'>" +
                                         "<version>2.3</version>" +
                                         "<action>insert</action>" +
                                         "<contentmetadata>" +
                                           "<title>Testing Item 2</title>" +
                                           "<contenttype>ExternalContent</contenttype>" +
                                           "<displaytype>Display Content</displaytype>" +
                                           "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                           "<referencedobjects>" +
                                             "<object version='1'>/js</object>" +
                                             "<object version='1'>/images</object>" +
                                           "</referencedobjects>" +
                                         "</contentmetadata>" +
                                         "<coursecontentmetadata>" +
                                           "<allowComments>true</allowComments>" +
                                           "<attemptlimit>1</attemptlimit>" +
                                           "<defaultpoints>0</defaultpoints>" +
                                           "<description>Test Description</description>" +
                                           "<graderule>2</graderule>" +
                                           "<instructoronly>Student instructor</instructoronly>" +
                                           "<latesubmissions>true</latesubmissions>" +
                                           "<openinsuppwindow>true</openinsuppwindow>" +
                                           "<subtitle>Clip</subtitle>" +
                                           "<thumbnailimage version='1' />" +
                                           "<useproxypage>false</useproxypage>" +
                                           "<viewsubmit>yes</viewsubmit>" +
                                           "<associatedunits>" +
                                             "<unit rsuiteid='rsuitid3'>Chapter 2</unit>" +
                                           "</associatedunits>" +
                                         "</coursecontentmetadata>" +
                                         "<toc>" +
                                           "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                             "<associatedunitid/>" +
                                             "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                             "<sequence>zzzC</sequence>" +
                                           "</structure>" +
                                         "</toc>" +
                                       "</request>" +
                                       "<request rsuiteid='rsuitid4' type='quiz'>" +
                                         "<version>2.1</version>" +
                                         "<action>insert</action>" +
                                         "<contentmetadata>" +
                                           "<title>Testing Item 2</title>" +
                                           "<contenttype>ExternalContent</contenttype>" +
                                           "<displaytype>Display Content</displaytype>" +
                                           "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                           "<referencedobjects>" +
                                             "<object version='1'>/js</object>" +
                                             "<object version='1'>/images</object>" +
                                           "</referencedobjects>" +
                                         "</contentmetadata>" +
                                         "<coursecontentmetadata>" +
                                           "<allowComments>true</allowComments>" +
                                           "<attemptlimit>1</attemptlimit>" +
                                           "<defaultpoints>0</defaultpoints>" +
                                           "<description>Test Description</description>" +
                                           "<graderule>2</graderule>" +
                                           "<instructoronly>Student instructor</instructoronly>" +
                                           "<latesubmissions>true</latesubmissions>" +
                                           "<openinsuppwindow>true</openinsuppwindow>" +
                                           "<subtitle>Clip</subtitle>" +
                                           "<thumbnailimage version='1' />" +
                                           "<useproxypage>false</useproxypage>" +
                                           "<viewsubmit>yes</viewsubmit>" +
                                           "<associatedunits>" +
                                             "<unit rsuiteid='rsuitid4'>Chapter 2</unit>" +
                                           "</associatedunits>" +
                                         "</coursecontentmetadata>" +
                                         "<toc>" +
                                           "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                             "<associatedunitid/>" +
                                             "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                             "<sequence>zzzC</sequence>" +
                                           "</structure>" +
                                         "</toc>" +
                                       "</request>" +
                                       "<request rsuiteid='rsuitid5' type='quiz'>" +
                                         "<version>2.1</version>" +
                                         "<action>insert</action>" +
                                         "<contentmetadata>" +
                                           "<title>Testing Item 2</title>" +
                                           "<contenttype>ExternalContent</contenttype>" +
                                           "<displaytype>Display Content</displaytype>" +
                                           "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                           "<referencedobjects>" +
                                             "<object version='1'>/js</object>" +
                                             "<object version='1'>/images</object>" +
                                           "</referencedobjects>" +
                                         "</contentmetadata>" +
                                         "<coursecontentmetadata>" +
                                           "<allowComments>true</allowComments>" +
                                           "<attemptlimit>1</attemptlimit>" +
                                           "<defaultpoints>0</defaultpoints>" +
                                           "<description>Test Description</description>" +
                                           "<graderule>2</graderule>" +
                                           "<instructoronly>Student instructor</instructoronly>" +
                                           "<latesubmissions>true</latesubmissions>" +
                                           "<openinsuppwindow>true</openinsuppwindow>" +
                                           "<subtitle>Clip</subtitle>" +
                                           "<thumbnailimage version='1' />" +
                                           "<useproxypage>false</useproxypage>" +
                                           "<viewsubmit>yes</viewsubmit>" +
                                           "<associatedunits>" +
                                             "<unit rsuiteid='rsuitid5'>Chapter 2</unit>" +
                                           "</associatedunits>" +
                                         "</coursecontentmetadata>" +
                                         "<toc>" +
                                           "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                             "<associatedunitid/>" +
                                             "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                             "<sequence>zzzC</sequence>" +
                                           "</structure>" +
                                         "</toc>" +
                                       "</request>" +
                                     "</pubrequest>";

            validations validations = new validations();

            //Act
            result = validations.ValidatePubRequest(strCourseXML);
        }

        [TestMethod]
        [ExpectedExceptionAttribute(typeof(Exception))]
        public void TestValidatePubRequestWhenSequenceIsMissing()
        {
            //Arrange
            bool result;
            string strCourseXML = "<pubrequest requestid='adsfds' type='dlap' tier='dev' entityid='132434' discipline='astronomy'>" +
                                    "<daterequested>3/14/2015 14:00</daterequested>" +
                                    "<publishuser>gsternig</publishuser> " +
                                      "<request rsuiteid='rsuitid1' type='learningcurve'>" +
                                            "<version>2.1</version>" +
                                            "<action>insert</action>  " +
                                            "<contentmetadata> " +
                                                "<title>Reel Teaching Clip:  Chinese Immigrants Encounter Nativism (2:04)</title>" +
                                                "<contenttype>ExternalContent</contenttype>" +
                                                "<displaytype>Display Content</displaytype>   " +
                                                "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                                "<referencedobjects>" +
                                                  "<object version='1'>/js</object>" +
                                                  "<object version='1'>/images</object>" +
                                                "</referencedobjects>" +
                                            "</contentmetadata>" +
                                            "<coursecontentmetadata>" +
                                                "<allowComments>true</allowComments>" +
                                                "<attemptlimit>0</attemptlimit>" +
                                                "<defaultpoints>0</defaultpoints>" +
                                                "<description>Test Description</description>" +
                                                "<graderule>2</graderule>" +
                                                "<instructoronly>Student instructor</instructoronly>" +
                                                "<latesubmissions>true</latesubmissions>" +
                                                "<openinsuppwindow>true</openinsuppwindow>" +
                                                "<subtitle>Clip</subtitle>" +
                                                "<thumbnailimage version='1' />" +
                                                "<useproxypage>false</useproxypage>" +
                                                "<viewsubmit>yes</viewsubmit>" +
                                                "<associatedunits>" +
                                                    "<unit rsuiteid='rsuitid1'>Chapter 1</unit>" +
                                                "</associatedunits>" +
                                            "</coursecontentmetadata> " +
                                            "<toc>" +
                                                "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                                    "<associatedunitid/>" +
                                                    "<parentid>bsi__17593B4C__90B3__45B3__8211__6B0CA6984500</parentid>" +
                                                    "<sequence>zzzb</sequence>" +
                                                "</structure>" +
                                            "</toc>" +
                                        "</request>" +
                                      "<request rsuiteid='rsuitid2' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>0</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid2'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuiteid3' type='quiz'>" +
                                        "<version>2.3</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid3'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuitid4' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid4'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuitid5' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid5'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                    "</pubrequest>";

            validations validations = new validations();

            //Act
            result = validations.ValidatePubRequest(strCourseXML);
        }


        [TestMethod]
        public void TestValidatePubRequest()
        {
            //Arrange
            bool result;
            string strCourseXML = "<pubrequest requestid='adsfds' type='dlap' tier='dev' entityid='132434' discipline='astronomy'>" +
                                    "<daterequested>3/14/2015 14:00</daterequested>" +
                                    "<publishuser>gsternig</publishuser> " +
                                      "<request rsuiteid='rsuitid1' type='learningcurve'>" +
                                            "<version>2.1</version>" +
                                            "<action>insert</action>  " +
                                            "<contentmetadata> " +
                                                "<title>Reel Teaching Clip:  Chinese Immigrants Encounter Nativism (2:04)</title>" +
                                                "<contenttype>ExternalContent</contenttype>" +
                                                "<displaytype>Display Content</displaytype>   " +
                                                "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                                "<referencedobjects>" +
                                                  "<object version='1'>/js</object>" +
                                                  "<object version='1'>/images</object>" +
                                                "</referencedobjects>" +
                                            "</contentmetadata>" +
                                            "<coursecontentmetadata>" +
                                                "<allowComments>true</allowComments>" +
                                                "<attemptlimit>0</attemptlimit>" +
                                                "<defaultpoints>0</defaultpoints>" +
                                                "<description>Test Description</description>" +
                                                "<graderule>2</graderule>" +
                                                "<instructoronly>Student instructor</instructoronly>" +
                                                "<latesubmissions>true</latesubmissions>" +
                                                "<openinsuppwindow>true</openinsuppwindow>" +
                                                "<subtitle>Clip</subtitle>" +
                                                "<thumbnailimage version='1' />" +
                                                "<useproxypage>false</useproxypage>" +
                                                "<viewsubmit>yes</viewsubmit>" +
                                                "<associatedunits>" +
                                                    "<unit rsuiteid='rsuitid1'>Chapter 1</unit>" +
                                                "</associatedunits>" +
                                            "</coursecontentmetadata> " +
                                            "<toc>" +
                                                "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                                    "<associatedunitid/>" +
                                                    "<parentid>bsi__17593B4C__90B3__45B3__8211__6B0CA6984500</parentid>" +
                                                    "<sequence>zzzb</sequence>" +
                                                "</structure>" +
                                            "</toc>" +
                                        "</request>" +
                                      "<request rsuiteid='rsuitid2' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>0</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid2'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuiteid3' type='quiz'>" +
                                        "<version>2.3</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid3'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuitid4' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid4'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                      "<request rsuiteid='rsuitid5' type='quiz'>" +
                                        "<version>2.1</version>" +
                                        "<action>insert</action>" +
                                        "<contentmetadata>" +
                                          "<title>Testing Item 2</title>" +
                                          "<contenttype>ExternalContent</contenttype>" +
                                          "<displaytype>Display Content</displaytype>" +
                                          "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                          "<referencedobjects>" +
                                            "<object version='1'>/js</object>" +
                                            "<object version='1'>/images</object>" +
                                          "</referencedobjects>" +
                                        "</contentmetadata>" +
                                        "<coursecontentmetadata>" +
                                          "<allowComments>true</allowComments>" +
                                          "<attemptlimit>1</attemptlimit>" +
                                          "<defaultpoints>0</defaultpoints>" +
                                          "<description>Test Description</description>" +
                                          "<graderule>2</graderule>" +
                                          "<instructoronly>Student instructor</instructoronly>" +
                                          "<latesubmissions>true</latesubmissions>" +
                                          "<openinsuppwindow>true</openinsuppwindow>" +
                                          "<subtitle>Clip</subtitle>" +
                                          "<thumbnailimage version='1' />" +
                                          "<useproxypage>false</useproxypage>" +
                                          "<viewsubmit>yes</viewsubmit>" +
                                          "<associatedunits>" +
                                            "<unit rsuiteid='rsuitid5'>Chapter 2</unit>" +
                                          "</associatedunits>" +
                                        "</coursecontentmetadata>" +
                                        "<toc>" +
                                          "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                            "<associatedunitid/>" +
                                            "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                            "<sequence>zzzC</sequence>" +
                                          "</structure>" +
                                        "</toc>" +
                                      "</request>" +
                                    "</pubrequest>";

            validations validations = new validations();

            //Act
            result = validations.ValidatePubRequest(strCourseXML);

            //Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result);
        }


        [TestMethod]
        public void TestValidatePubRequest2()
        {
            //Arrange
            bool result;
            string strCourseXML = "<pubrequest requestid='adsfds' type='dlap' tier='dev' entityid='132434' discipline='astronomy'>" +
                                     "<daterequested>3/14/2015 14:00</daterequested>" +
                                     "<publishuser>gsternig</publishuser> " +
                                       "<request rsuiteid='rsuitid1' type='learningcurve'>" +
                                             "<version>2.1</version>" +
                                             "<action>insert</action>  " +
                                             "<contentmetadata> " +
                                                 "<title>Reel Teaching Clip:  Chinese Immigrants Encounter Nativism (2:04)</title>" +
                                                 "<contenttype>ExternalContent</contenttype>" +
                                                 "<displaytype>Display Content</displaytype>   " +
                                                 "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                                 "<referencedobjects>" +
                                                   "<object version='1'>/js</object>" +
                                                   "<object version='1'>/images</object>" +
                                                 "</referencedobjects>" +
                                             "</contentmetadata>" +
                                             "<coursecontentmetadata>" +
                                                 "<allowComments>true</allowComments>" +
                                                 "<attemptlimit>0</attemptlimit>" +
                                                 "<defaultpoints>0</defaultpoints>" +
                                                 "<description>Test Description</description>" +
                                                 "<graderule>2</graderule>" +
                                                 "<instructoronly>Student instructor</instructoronly>" +
                                                 "<latesubmissions>true</latesubmissions>" +
                                                 "<openinsuppwindow>true</openinsuppwindow>" +
                                                 "<subtitle>Clip</subtitle>" +
                                                 "<thumbnailimage version='1' />" +
                                                 "<useproxypage>false</useproxypage>" +
                                                 "<viewsubmit>yes</viewsubmit>" +
                                                 "<associatedunits>" +
                                                     "<unit rsuiteid='rsuitid1'>Chapter 1</unit>" +
                                                 "</associatedunits>" +
                                             "</coursecontentmetadata> " +
                                             "<toc>" +
                                                 "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                                     "<associatedunitid/>" +
                                                     "<parentid>bsi__17593B4C__90B3__45B3__8211__6B0CA6984500</parentid>" +
                                                     "<sequence>zzzb</sequence>" +
                                                 "</structure>" +
                                             "</toc>" +
                                         "</request>" +
                                       "<request rsuiteid='rsuitid2' type='quiz'>" +
                                         "<version>2.1</version>" +
                                         "<action>insert</action>" +
                                         "<contentmetadata>" +
                                           "<title>Testing Item 2</title>" +
                                           "<contenttype>ExternalContent</contenttype>" +
                                           "<displaytype>Display Content</displaytype>" +
                                           "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                           "<referencedobjects>" +
                                             "<object version='1'>/js</object>" +
                                             "<object version='1'>/images</object>" +
                                           "</referencedobjects>" +
                                         "</contentmetadata>" +
                                         "<coursecontentmetadata>" +
                                           "<allowComments>true</allowComments>" +
                                           "<attemptlimit>0</attemptlimit>" +
                                           "<defaultpoints>0</defaultpoints>" +
                                           "<description>Test Description</description>" +
                                           "<graderule>2</graderule>" +
                                           "<instructoronly>Student instructor</instructoronly>" +
                                           "<latesubmissions>true</latesubmissions>" +
                                           "<openinsuppwindow>true</openinsuppwindow>" +
                                           "<subtitle>Clip</subtitle>" +
                                           "<thumbnailimage version='1' />" +
                                           "<useproxypage>false</useproxypage>" +
                                           "<viewsubmit>yes</viewsubmit>" +
                                           "<associatedunits>" +
                                             "<unit rsuiteid='rsuitid2'>Chapter 2</unit>" +
                                           "</associatedunits>" +
                                         "</coursecontentmetadata>" +
                                         "<toc>" +
                                           "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                             "<associatedunitid/>" +
                                             "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                             "<sequence>zzzC</sequence>" +
                                           "</structure>" +
                                         "</toc>" +
                                       "</request>" +
                                       "<request rsuiteid='rsuiteid3' type='quiz'>" +
                                         "<version>2.3</version>" +
                                         "<action>insert</action>" +
                                         "<contentmetadata>" +
                                           "<title>Testing Item 2</title>" +
                                           "<contenttype>ExternalContent</contenttype>" +
                                           "<displaytype>Display Content</displaytype>" +
                                           "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                           "<referencedobjects>" +
                                             "<object version='1'>/js</object>" +
                                             "<object version='1'>/images</object>" +
                                           "</referencedobjects>" +
                                         "</contentmetadata>" +
                                         "<coursecontentmetadata>" +
                                           "<allowComments>true</allowComments>" +
                                           "<attemptlimit>1</attemptlimit>" +
                                           "<defaultpoints>0</defaultpoints>" +
                                           "<description>Test Description</description>" +
                                           "<graderule>2</graderule>" +
                                           "<instructoronly>Student instructor</instructoronly>" +
                                           "<latesubmissions>true</latesubmissions>" +
                                           "<openinsuppwindow>true</openinsuppwindow>" +
                                           "<subtitle>Clip</subtitle>" +
                                           "<thumbnailimage version='1' />" +
                                           "<useproxypage>false</useproxypage>" +
                                           "<viewsubmit>yes</viewsubmit>" +
                                           "<associatedunits>" +
                                             "<unit rsuiteid='rsuitid3'>Chapter 2</unit>" +
                                           "</associatedunits>" +
                                         "</coursecontentmetadata>" +
                                         "<toc>" +
                                           "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                             "<associatedunitid/>" +
                                             "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                             "<sequence>zzzC</sequence>" +
                                           "</structure>" +
                                         "</toc>" +
                                       "</request>" +
                                       "<request rsuiteid='rsuitid4' type='quiz'>" +
                                         "<version>2.1</version>" +
                                         "<action>insert</action>" +
                                         "<contentmetadata>" +
                                           "<title>Testing Item 2</title>" +
                                           "<contenttype>ExternalContent</contenttype>" +
                                           "<displaytype>Display Content</displaytype>" +
                                           "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                           "<referencedobjects>" +
                                             "<object version='1'>/js</object>" +
                                             "<object version='1'>/images</object>" +
                                           "</referencedobjects>" +
                                         "</contentmetadata>" +
                                         "<coursecontentmetadata>" +
                                           "<allowComments>true</allowComments>" +
                                           "<attemptlimit>1</attemptlimit>" +
                                           "<defaultpoints>0</defaultpoints>" +
                                           "<description>Test Description</description>" +
                                           "<graderule>2</graderule>" +
                                           "<instructoronly>Student instructor</instructoronly>" +
                                           "<latesubmissions>true</latesubmissions>" +
                                           "<openinsuppwindow>true</openinsuppwindow>" +
                                           "<subtitle>Clip</subtitle>" +
                                           "<thumbnailimage version='1' />" +
                                           "<useproxypage>false</useproxypage>" +
                                           "<viewsubmit>yes</viewsubmit>" +
                                           "<associatedunits>" +
                                             "<unit rsuiteid='rsuitid4'>Chapter 2</unit>" +
                                           "</associatedunits>" +
                                         "</coursecontentmetadata>" +
                                         "<toc>" +
                                           "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                             "<associatedunitid/>" +
                                             "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                             "<sequence>zzzC</sequence>" +
                                           "</structure>" +
                                         "</toc>" +
                                       "</request>" +
                                       "<request rsuiteid='rsuitid5' type='quiz'>" +
                                         "<version>2.1</version>" +
                                         "<action>insert</action>" +
                                         "<contentmetadata>" +
                                           "<title>Testing Item 2</title>" +
                                           "<contenttype>ExternalContent</contenttype>" +
                                           "<displaytype>Display Content</displaytype>" +
                                           "<defaultfile type='external' version=''>chapter1.html</defaultfile>" +
                                           "<referencedobjects>" +
                                             "<object version='1'>/js</object>" +
                                             "<object version='1'>/images</object>" +
                                           "</referencedobjects>" +
                                         "</contentmetadata>" +
                                         "<coursecontentmetadata>" +
                                           "<allowComments>true</allowComments>" +
                                           "<attemptlimit>1</attemptlimit>" +
                                           "<defaultpoints>0</defaultpoints>" +
                                           "<description>Test Description</description>" +
                                           "<graderule>2</graderule>" +
                                           "<instructoronly>Student instructor</instructoronly>" +
                                           "<latesubmissions>true</latesubmissions>" +
                                           "<openinsuppwindow>true</openinsuppwindow>" +
                                           "<subtitle>Clip</subtitle>" +
                                           "<thumbnailimage version='1' />" +
                                           "<useproxypage>false</useproxypage>" +
                                           "<viewsubmit>yes</viewsubmit>" +
                                           "<associatedunits>" +
                                             "<unit rsuiteid='rsuitid5'>Chapter 2</unit>" +
                                           "</associatedunits>" +
                                         "</coursecontentmetadata>" +
                                         "<toc>" +
                                           "<structure type='launchpad' hidefromlaunchpad='no'>" +
                                             "<associatedunitid/>" +
                                             "<parentid>bsi__6F979F7F__6E3B__4C7D__B9C6__B61EA1377A9F</parentid>" +
                                             "<sequence>zzzC</sequence>" +
                                           "</structure>" +
                                         "</toc>" +
                                       "</request>" +
                                     "</pubrequest>";

            validations validations = new validations();

            //Act
            result = validations.ValidatePubRequest(strCourseXML);

        }
    }
}
