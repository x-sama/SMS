using CoreBusiness;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.InMemory;

public class CategoryInMemoryRepository : ICategoryRepository
{
    // list of categories 
    public List<Category> Categories;

    public CategoryInMemoryRepository()
    {
        Categories = new List<Category>()
        {
            new Category { CategoryId = 1, Name = "Beverage", Description = "Beverage" },
            new Category { CategoryId = 2, Name = "Bakery", Description = "Bakery" },
            new Category { CategoryId = 3, Name = "Meal", Description = "Meal" }
        };
    }
    public IEnumerable<Category> GetAllCategories()
    {
        return Categories;
    }

    public void AddCategory(Category category)
    {
        // add the category we get to the fake database list 
        if (Categories.Any(x=> x.Name.Equals(category.Name, StringComparison.OrdinalIgnoreCase))) return;
        if (Categories.Any())
        {
            var maxId = Categories.Max(x => x.CategoryId);
            category.CategoryId = maxId + 1;
        }
        else
        {
            category.CategoryId = 1;
        }
       
        Categories.Add(category);
    }

    public void UpdateCategory(Category category)
    {
        if (GetCategoryById(category.CategoryId) is { } categoryToUpdate)
        {
            categoryToUpdate.Name = category.Name;
            categoryToUpdate.Description = category.Description;
        }
    }

    public Category GetCategoryById(int id)
    {
        return Categories.FirstOrDefault(x => x.CategoryId == id);
    }

    public void DeleteCategory(int id)
    {
        var categoryToDelete = GetCategoryById(id);
        Categories.Remove(categoryToDelete);
    }
}