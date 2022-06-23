using CoreBusiness;

namespace UseCases.UseCasesInterfaces;

public interface IUpdateProductUseCase
{
    void Execute(Product product);
}