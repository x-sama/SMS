namespace UseCases.UseCasesInterfaces;

public interface ISellProductUseCase
{
    void Execute(string cashierName,int productId, int sellQty);
}