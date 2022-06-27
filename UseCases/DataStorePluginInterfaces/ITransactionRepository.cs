using CoreBusiness;

namespace UseCases.DataStorePluginInterfaces;

public interface ITransactionRepository
{
    public IEnumerable<Transaction> GetByDay(string cashierName, DateTime dateTime);
    public IEnumerable<Transaction> Search(string cashierName, DateTime strDate, DateTime dateTime);
    public IEnumerable<Transaction> Get(string cashierName);
    public void Save(string cashierName ,int productId, double price,string productName, int soldQty , int beforeQty);
}