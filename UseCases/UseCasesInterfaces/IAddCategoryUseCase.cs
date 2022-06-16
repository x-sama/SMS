using CoreBusiness;

namespace UseCases.UseCasesInterfaces;

public interface IAddCategoryUseCase
{
    void Execute(Category category);
}