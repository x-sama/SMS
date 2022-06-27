using CoreBusiness;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.InMemory;

public class TransactionInMemoryRepository : ITransactionRepository
{

    private  List<Transaction> _recordedTransactions;

    public TransactionInMemoryRepository()
    {
        _recordedTransactions = new List<Transaction>();
    }


    public IEnumerable<Transaction> GetByDay(string cashierName,DateTime dateTime)
    {
        if (string.IsNullOrWhiteSpace(cashierName))
            return _recordedTransactions.Where(x=> x.TimeStamp.Date == dateTime.Date);
        else
            return _recordedTransactions.Where(x =>
                string.Equals(x.CashierName, cashierName, StringComparison.OrdinalIgnoreCase)
                && x.TimeStamp.Date == dateTime.Date);
    }

    public IEnumerable<Transaction> Search(string cashierName, DateTime strDate, DateTime endDate)
    {
        if (string.IsNullOrWhiteSpace(cashierName))
            return _recordedTransactions.Where(x=> x.TimeStamp.Date >= strDate.Date && x.TimeStamp.Date <= endDate.Date.AddDays(1).Date);
        else
            return _recordedTransactions.Where(x =>
                string.Equals(x.CashierName, cashierName, StringComparison.OrdinalIgnoreCase)
                && x.TimeStamp.Date >= strDate.Date && x.TimeStamp.Date <= endDate.Date.AddDays(1).Date);
    }

    public IEnumerable<Transaction> Get(string cashierName)
    {
        if (string.IsNullOrWhiteSpace(cashierName))
            return _recordedTransactions;
        else
            return _recordedTransactions.Where(x =>
                string.Equals(x.CashierName, cashierName, StringComparison.OrdinalIgnoreCase));
    }

    public void Save(string cashierName ,int productId, double price, string productName,int soldQty , int beforeQty)
    {
        int transactionId = 0;
        if (_recordedTransactions.Any())
        {
            int maxId = _recordedTransactions.Max(x => x.TransactionId);
            transactionId = maxId + 1;
        }
        else
        {
            transactionId = 1;
        }

        _recordedTransactions.Add(new Transaction
        {
            TransactionId = transactionId,
            ProductId = productId,
            ProductName = productName,
            Price = price,
            SoldQty =  soldQty,
            BeforeQty = beforeQty,
            CashierName = cashierName,
            TimeStamp = DateTime.Now
        });

}
}