using CoreBusiness;

namespace UseCases.UseCasesInterfaces;

public interface IGetTodayTransactionsUseCase
{
    IEnumerable<Transaction> Execute(string cashierName);
}