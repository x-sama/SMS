using CoreBusiness;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCasesInterfaces;

namespace UseCases;

public class GetTransactionReportUseCase : IGetTransactionReportUseCase
{
    private readonly ITransactionRepository _transactionRepository;

    public GetTransactionReportUseCase(ITransactionRepository transactionRepository)
    {
        _transactionRepository = transactionRepository;
    }
    public IEnumerable<Transaction> Execute(
        string cashierName,
        DateTime startDate,
        DateTime endDate)
    {
        return _transactionRepository.Search(cashierName, startDate, endDate);
    }
}