using UseCases.DataStorePluginInterfaces;
using UseCases.UseCasesInterfaces;

namespace UseCases;

public class DeleteCategoryByIdUseCase : IDeleteCategoryByIdUseCase 
{
    private readonly ICategoryRepository _categoryRepository;

    public DeleteCategoryByIdUseCase(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }
    
    
    
    public void Delete(int categoryId)
    {
        _categoryRepository.DeleteCategory(categoryId);
    }
}