namespace CoreBusiness;

public class Transaction
{
    public int TransactionId { get; set; }
    public DateTime TimeStamp { get; set; }
    public int ProductId { get; set; }
    public int SoldQty { get; set; }
    public int BeforeQty { get; set; }
    public double Price { get; set; }
    public string CashierName { get; set; }
    public string ProductName { get; set; }
    
    
}