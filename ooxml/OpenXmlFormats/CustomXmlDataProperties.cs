// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.38967
//    <NameSpace>schemas</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>False</IncludeSerializeMethod><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net20</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>False</GenerateXMLAttributes><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>False</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------
namespace NPOI.OpenXmlFormats
{
    using System.Xml.Serialization;
    using System.Collections.Generic;
    using System.Xml.Schema;

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/customXml")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/customXml", IsNullable = true)]
    public class CT_DatastoreItem
    {

        private List<CT_DatastoreSchemaRef> schemaRefsField;

        private string itemIDField;

        public CT_DatastoreItem()
        {
            this.schemaRefsField = new List<CT_DatastoreSchemaRef>();
        }

        [XmlArrayAttribute(Order = 0)]
        [XmlArrayItemAttribute("schemaRef", IsNullable = false)]
        public List<CT_DatastoreSchemaRef> schemaRefs
        {
            get
            {
                return this.schemaRefsField;
            }
            set
            {
                this.schemaRefsField = value;
            }
        }

        [XmlAttributeAttribute(Form = XmlSchemaForm.Qualified, DataType = "token")]
        public string itemID
        {
            get
            {
                return this.itemIDField;
            }
            set
            {
                this.itemIDField = value;
            }
        }
    }
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/customXml")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/customXml", IsNullable = true)]
    public class CT_DatastoreSchemaRef
    {

        private string uriField;
        [XmlAttributeAttribute(Form = XmlSchemaForm.Qualified)]
        public string uri
        {
            get
            {
                return this.uriField;
            }
            set
            {
                this.uriField = value;
            }
        }
    }
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/customXml")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/customXml", IsNullable = true)]

    public class CT_DatastoreSchemaRefs
    {

        private List<CT_DatastoreSchemaRef> schemaRefField;

        public CT_DatastoreSchemaRefs()
        {
            this.schemaRefField = new List<CT_DatastoreSchemaRef>();
        }
        [XmlElementAttribute("schemaRef")]
        public List<CT_DatastoreSchemaRef> schemaRef
        {
            get
            {
                return this.schemaRefField;
            }
            set
            {
                this.schemaRefField = value;
            }
        }
    }
}
