namespace UseCases.UseCasesInterfaces;

public interface IRecordTransactionUseCase
{
    public void Execute(string cashierName, int productId, string productName,int productQty);
}