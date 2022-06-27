using CoreBusiness;

namespace UseCases.UseCasesInterfaces;

public interface IGetTransactionReportUseCase
{
    public IEnumerable<Transaction> Execute(string cashierName, DateTime startDate, DateTime endDate);
}