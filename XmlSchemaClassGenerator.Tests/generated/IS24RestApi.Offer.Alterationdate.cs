//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 0.2.5145.38480.
namespace IS24RestApi.Offer.Alterationdate
{
    using System.Collections.ObjectModel;
    using System.Xml.Serialization;
    
    
    /// <summary>
    /// </summary>
    [System.SerializableAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "0.2.5145.38480")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute("possibleAlterationDate", Namespace="http://rest.immobilienscout24.de/schema/offer/alterationdate/1.0")]
    [System.Xml.Serialization.XmlRootAttribute("possibleAlterationDate", Namespace="http://rest.immobilienscout24.de/schema/offer/alterationdate/1.0")]
    public partial class PossibleAlterationDate
    {
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("nextPossibleAlterationDate", Namespace="http://rest.immobilienscout24.de/schema/offer/alterationdate/1.0", DataType="date")]
        public System.DateTime NextPossibleAlterationDate { get; set; }
    }
}
