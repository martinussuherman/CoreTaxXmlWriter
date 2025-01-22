using System.Xml.Schema;
using System.Xml.Serialization;

namespace CoreTaxXmlWriter.Models;

public class TaxInvoiceBulk
{
    [XmlAttribute("noNamespaceSchemaLocation", Namespace = XmlSchema.InstanceNamespace)]
    public string Attr
    {
        get
        {
            return "TaxInvoice.xsd";
        }
        set
        {
            throw new NotSupportedException();
        }
    }

    public string TIN { get; set; } = string.Empty;

    public List<TaxInvoice> ListOfTaxInvoice { get; } = [];
}
