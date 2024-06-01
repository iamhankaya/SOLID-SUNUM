
/*
 public class Invoice
{
    public decimal Amount { get; set; }

    public decimal CalculateTotal()
    {
        return Amount * 1.2m; // vergi dahil fiyat
    }

    public void SaveToFile()
    {
        System.IO.File.WriteAllText("invoice.txt", Amount.ToString());
    }
}

    SRP'YE UYGUN DEGIL
 */
public class Invoice
{
    public decimal Amount { get; set; }

    public decimal CalculateTotal()
    {
        return Amount * 1.2m; // vergi dahil fiyat
    }
}

public class InvoiceRepository
{
    public void SaveToFile(Invoice invoice)
    {
        System.IO.File.WriteAllText("invoice.txt", invoice.Amount.ToString());
    }
}
    //SRP'YE UYGUN