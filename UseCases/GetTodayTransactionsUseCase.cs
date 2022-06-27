using CoreBusiness;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCasesInterfaces;

namespace UseCases;

public class GetTodayTransactionsUseCase : IGetTodayTransactionsUseCase
{
    private readonly ITransactionRepository _transactionRepository;

    public GetTodayTransactionsUseCase(ITransactionRepository transactionRepository)
    {
        _transactionRepository = transactionRepository;
    }
    public IEnumerable<Transaction> Execute(string cashierName)
    {
        return _transactionRepository.GetByDay(cashierName, DateTime.Now);
    }
}