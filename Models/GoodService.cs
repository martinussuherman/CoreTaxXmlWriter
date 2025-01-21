namespace CoreTaxXmlWriter.Models;

public class GoodService
{
	public string Opt { get; set; } = string.Empty;

	public string Code { get; set; } = string.Empty;

	public string Name { get; set; } = string.Empty;

	public string Unit { get; set; } = string.Empty;

	public decimal Price { get; set; }

	public ulong Qty { get; set; }

	public decimal TotalDiscount { get; set; }

	public decimal TaxBase { get; set; }

	public decimal OtherTaxBase { get; set; }

	public byte VATRate { get; set; }

	public decimal VAT { get; set; }

	public byte STLGRate { get; set; }

	public decimal STLG { get; set; }
}
