using CoreBusiness;

namespace UseCases.UseCasesInterfaces;

public interface IGetCategoryByIdUseCase
{
    public Category Execute(int id);
}