
/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class pubrequest {
    
    private string daterequestedField;
    
    private string publishuserField;
    
    private pubrequestRequest[] requestField;
    
    private string requestidField;
    
    private string typeField;
    
    private string tierField;
    
    private uint entityidField;
    
    private string disciplineField;
    
    /// <remarks/>
    public string daterequested {
        get {
            return this.daterequestedField;
        }
        set {
            this.daterequestedField = value;
        }
    }
    
    /// <remarks/>
    public string publishuser {
        get {
            return this.publishuserField;
        }
        set {
            this.publishuserField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("request")]
    public pubrequestRequest[] request {
        get {
            return this.requestField;
        }
        set {
            this.requestField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string requestid {
        get {
            return this.requestidField;
        }
        set {
            this.requestidField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type {
        get {
            return this.typeField;
        }
        set {
            this.typeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string tier {
        get {
            return this.tierField;
        }
        set {
            this.tierField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint entityid {
        get {
            return this.entityidField;
        }
        set {
            this.entityidField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string discipline {
        get {
            return this.disciplineField;
        }
        set {
            this.disciplineField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class pubrequestRequest {
    
    private decimal versionField;
    
    private string actionField;
    
    private pubrequestRequestContentmetadata contentmetadataField;
    
    private pubrequestRequestCoursecontentmetadata coursecontentmetadataField;
    
    private pubrequestRequestToc tocField;
    
    private string rsuiteidField;
    
    private string typeField;
    
    /// <remarks/>
    public decimal version {
        get {
            return this.versionField;
        }
        set {
            this.versionField = value;
        }
    }
    
    /// <remarks/>
    public string action {
        get {
            return this.actionField;
        }
        set {
            this.actionField = value;
        }
    }
    
    /// <remarks/>
    public pubrequestRequestContentmetadata contentmetadata {
        get {
            return this.contentmetadataField;
        }
        set {
            this.contentmetadataField = value;
        }
    }
    
    /// <remarks/>
    public pubrequestRequestCoursecontentmetadata coursecontentmetadata {
        get {
            return this.coursecontentmetadataField;
        }
        set {
            this.coursecontentmetadataField = value;
        }
    }
    
    /// <remarks/>
    public pubrequestRequestToc toc {
        get {
            return this.tocField;
        }
        set {
            this.tocField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string rsuiteid {
        get {
            return this.rsuiteidField;
        }
        set {
            this.rsuiteidField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type {
        get {
            return this.typeField;
        }
        set {
            this.typeField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class pubrequestRequestContentmetadata {
    
    private string titleField;
    
    private string contenttypeField;
    
    private string displaytypeField;
    
    private pubrequestRequestContentmetadataDefaultfile defaultfileField;
    
    private pubrequestRequestContentmetadataObject[] referencedobjectsField;
    
    /// <remarks/>
    public string title {
        get {
            return this.titleField;
        }
        set {
            this.titleField = value;
        }
    }
    
    /// <remarks/>
    public string contenttype {
        get {
            return this.contenttypeField;
        }
        set {
            this.contenttypeField = value;
        }
    }
    
    /// <remarks/>
    public string displaytype {
        get {
            return this.displaytypeField;
        }
        set {
            this.displaytypeField = value;
        }
    }
    
    /// <remarks/>
    public pubrequestRequestContentmetadataDefaultfile defaultfile {
        get {
            return this.defaultfileField;
        }
        set {
            this.defaultfileField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("object", IsNullable=false)]
    public pubrequestRequestContentmetadataObject[] referencedobjects {
        get {
            return this.referencedobjectsField;
        }
        set {
            this.referencedobjectsField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class pubrequestRequestContentmetadataDefaultfile {
    
    private string typeField;
    
    private string versionField;
    
    private string valueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type {
        get {
            return this.typeField;
        }
        set {
            this.typeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string version {
        get {
            return this.versionField;
        }
        set {
            this.versionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class pubrequestRequestContentmetadataObject {
    
    private byte versionField;
    
    private string valueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte version {
        get {
            return this.versionField;
        }
        set {
            this.versionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class pubrequestRequestCoursecontentmetadata {
    
    private bool allowCommentsField;
    
    private byte attemptlimitField;
    
    private byte defaultpointsField;
    
    private string descriptionField;
    
    private byte graderuleField;
    
    private string instructoronlyField;
    
    private bool latesubmissionsField;
    
    private bool openinsuppwindowField;
    
    private string subtitleField;
    
    private pubrequestRequestCoursecontentmetadataThumbnailimage thumbnailimageField;
    
    private bool useproxypageField;
    
    private string viewsubmitField;
    
    private pubrequestRequestCoursecontentmetadataAssociatedunits associatedunitsField;
    
    /// <remarks/>
    public bool allowComments {
        get {
            return this.allowCommentsField;
        }
        set {
            this.allowCommentsField = value;
        }
    }
    
    /// <remarks/>
    public byte attemptlimit {
        get {
            return this.attemptlimitField;
        }
        set {
            this.attemptlimitField = value;
        }
    }
    
    /// <remarks/>
    public byte defaultpoints {
        get {
            return this.defaultpointsField;
        }
        set {
            this.defaultpointsField = value;
        }
    }
    
    /// <remarks/>
    public string description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
    
    /// <remarks/>
    public byte graderule {
        get {
            return this.graderuleField;
        }
        set {
            this.graderuleField = value;
        }
    }
    
    /// <remarks/>
    public string instructoronly {
        get {
            return this.instructoronlyField;
        }
        set {
            this.instructoronlyField = value;
        }
    }
    
    /// <remarks/>
    public bool latesubmissions {
        get {
            return this.latesubmissionsField;
        }
        set {
            this.latesubmissionsField = value;
        }
    }
    
    /// <remarks/>
    public bool openinsuppwindow {
        get {
            return this.openinsuppwindowField;
        }
        set {
            this.openinsuppwindowField = value;
        }
    }
    
    /// <remarks/>
    public string subtitle {
        get {
            return this.subtitleField;
        }
        set {
            this.subtitleField = value;
        }
    }
    
    /// <remarks/>
    public pubrequestRequestCoursecontentmetadataThumbnailimage thumbnailimage {
        get {
            return this.thumbnailimageField;
        }
        set {
            this.thumbnailimageField = value;
        }
    }
    
    /// <remarks/>
    public bool useproxypage {
        get {
            return this.useproxypageField;
        }
        set {
            this.useproxypageField = value;
        }
    }
    
    /// <remarks/>
    public string viewsubmit {
        get {
            return this.viewsubmitField;
        }
        set {
            this.viewsubmitField = value;
        }
    }
    
    /// <remarks/>
    public pubrequestRequestCoursecontentmetadataAssociatedunits associatedunits {
        get {
            return this.associatedunitsField;
        }
        set {
            this.associatedunitsField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class pubrequestRequestCoursecontentmetadataThumbnailimage {
    
    private byte versionField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte version {
        get {
            return this.versionField;
        }
        set {
            this.versionField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class pubrequestRequestCoursecontentmetadataAssociatedunits {
    
    private pubrequestRequestCoursecontentmetadataAssociatedunitsUnit unitField;
    
    /// <remarks/>
    public pubrequestRequestCoursecontentmetadataAssociatedunitsUnit unit {
        get {
            return this.unitField;
        }
        set {
            this.unitField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class pubrequestRequestCoursecontentmetadataAssociatedunitsUnit {
    
    private string rsuiteidField;
    
    private string valueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string rsuiteid {
        get {
            return this.rsuiteidField;
        }
        set {
            this.rsuiteidField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class pubrequestRequestToc {
    
    private pubrequestRequestTocStructure structureField;
    
    /// <remarks/>
    public pubrequestRequestTocStructure structure {
        get {
            return this.structureField;
        }
        set {
            this.structureField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class pubrequestRequestTocStructure {
    
    private object associatedunitidField;
    
    private string parentidField;
    
    private string sequenceField;
    
    private string typeField;
    
    private string hidefromlaunchpadField;
    
    /// <remarks/>
    public object associatedunitid {
        get {
            return this.associatedunitidField;
        }
        set {
            this.associatedunitidField = value;
        }
    }
    
    /// <remarks/>
    public string parentid {
        get {
            return this.parentidField;
        }
        set {
            this.parentidField = value;
        }
    }
    
    /// <remarks/>
    public string sequence {
        get {
            return this.sequenceField;
        }
        set {
            this.sequenceField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type {
        get {
            return this.typeField;
        }
        set {
            this.typeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string hidefromlaunchpad {
        get {
            return this.hidefromlaunchpadField;
        }
        set {
            this.hidefromlaunchpadField = value;
        }
    }
}
