using System.Xml.Serialization;

namespace CoreTaxXmlWriter.Models;

public class TaxInvoice
{
    [XmlIgnore]
    public DateTime Date { get; set; }

    public string TaxInvoiceDate
    {
        get
        {
            return Date.ToString("yyyy-MM-dd");
        }
        set
        {
            throw new NotSupportedException();
        }
    }

    public string TaxInvoiceOpt { get; set; } = string.Empty;

    public string TrxCode { get; set; } = string.Empty;

    public string AddInfo { get; set; } = string.Empty;

    public string CustomDoc { get; set; } = string.Empty;

    public string RefDesc { get; set; } = string.Empty;

    public string FacilityStamp { get; set; } = string.Empty;

    public string SellerIDTKU { get; set; } = string.Empty;

    public string BuyerTin { get; set; } = string.Empty;

    public string BuyerDocument { get; set; } = string.Empty;

    public string BuyerCountry { get; set; } = string.Empty;

    public string BuyerDocumentNumber { get; set; } = string.Empty;

    public string BuyerName { get; set; } = string.Empty;

    public string BuyerAdress { get; set; } = string.Empty;

    public string BuyerEmail { get; set; } = string.Empty;

    public string BuyerIDTKU { get; set; } = string.Empty;

    public List<GoodService> ListOfGoodService { get; } = [];
}
