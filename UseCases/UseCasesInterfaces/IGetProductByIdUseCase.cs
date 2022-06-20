using CoreBusiness;

namespace UseCases.UseCasesInterfaces;

public interface IGetProductByIdUseCase
{
    Product Execute(int id);
}