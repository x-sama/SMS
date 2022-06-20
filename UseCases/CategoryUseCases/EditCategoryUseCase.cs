using CoreBusiness;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCasesInterfaces;

namespace UseCases;

public class EditCategoryUseCase : IEditCategoryUseCse
{
    private readonly ICategoryRepository _categoryRepository;

    public EditCategoryUseCase(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }
    public void Execute(Category category)
    {
        _categoryRepository.UpdateCategory(category);
    }
}