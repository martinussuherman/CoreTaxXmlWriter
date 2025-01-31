using System.Xml;
using System.Xml.Serialization;
using CoreTaxXmlWriter.Models;

namespace CoreTaxXmlWriter;

public class TaxInvoiceWriter
{
    public void WriteXml(TaxInvoiceBulk taxInvoiceBulk, string filePath)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(TaxInvoiceBulk));
        XmlSerializerNamespaces namespaces = new();
        namespaces.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");
        TextWriter writer = new StreamWriter(filePath);
        serializer.Serialize(writer, taxInvoiceBulk, namespaces);
        writer.Close();
    }
}
