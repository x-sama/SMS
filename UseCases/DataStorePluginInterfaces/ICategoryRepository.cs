using CoreBusiness;

namespace UseCases.DataStorePluginInterfaces;

public interface ICategoryRepository
{
    public IEnumerable<Category> GetAllCategories();
    public void AddCategory(Category category);
    public void UpdateCategory(Category category);
    public Category GetCategoryById(int id);
}