namespace CoreTaxXmlWriter.Models;

public class TaxInvoiceBulk
{
    public string TIN { get; set; } = string.Empty;

    public List<TaxInvoice> ListOfTaxInvoice { get; } = [];
}
