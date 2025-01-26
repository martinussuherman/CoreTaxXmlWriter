using CoreTaxXmlWriter;
using CoreTaxXmlWriter.Models;

Console.WriteLine("Start generate xml");

GoodService goodService = new()
{
    Opt = "A",
    Code = "000000",
    Name = "Barang",
    Unit = "UM.0001",
    Price = 15000,
    Qty = 200,
    TotalDiscount = 100000,
    TaxBase = 2900000,
    OtherTaxBase = 2900000,
    VATRate = 11,
    VAT = 319000,
    STLGRate = 20,
    STLG = 580000
};

TaxInvoice taxInvoice = new()
{
    Date = new DateTime(2023, 09, 13),
    TaxInvoiceOpt = "Normal",
    TrxCode = "01",
    SellerIDTKU = "0000000000000000000000",
    BuyerTin = "xxxxxxxxxxxxxxxx",
    BuyerDocument = "TIN",
    BuyerCountry = "IND",
    BuyerEmail = "someemail@gmail.com",
    BuyerIDTKU = "0000000000000000000000"
};

TaxInvoiceBulk taxInvoiceBulk = new()
{
    TIN = "xxxxxxxxxxxxxxxx"
};

taxInvoice.ListOfGoodService.Add(goodService);
taxInvoiceBulk.ListOfTaxInvoice.Add(taxInvoice);
TaxInvoiceWriter taxInvoiceWriter = new();
taxInvoiceWriter.WriteXml(taxInvoiceBulk);

Console.WriteLine("Finish generate xml");
