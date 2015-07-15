
/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
public partial class itemx
{

    private itemData dataField;

    private string itemidField;

    private ushort entityidField;

    /// <remarks/>
    public itemData data
    {
        get
        {
            return this.dataField;
        }
        set
        {
            this.dataField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string itemid
    {
        get
        {
            return this.itemidField;
        }
        set
        {
            this.itemidField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ushort entityid
    {
        get
        {
            return this.entityidField;
        }
        set
        {
            this.entityidField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class itemDatax
{

    private string parentField;

    /// <remarks/>
    public string parent
    {
        get
        {
            return this.parentField;
        }
        set
        {
            this.parentField = value;
        }
    }
}

