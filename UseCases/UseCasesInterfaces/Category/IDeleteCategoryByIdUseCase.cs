using CoreBusiness;

namespace UseCases.UseCasesInterfaces;

public interface IDeleteCategoryByIdUseCase
{
    void Delete(int categoryId);
}