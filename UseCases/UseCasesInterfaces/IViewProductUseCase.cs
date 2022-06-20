using CoreBusiness;

namespace UseCases.UseCasesInterfaces;

public interface IViewProductUseCase
{
    IEnumerable<Product> Execute();
}