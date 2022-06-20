using CoreBusiness;

namespace UseCases.UseCasesInterfaces;

public interface IViewCategoriesUseCases
{
    public IEnumerable<Category> Execute();
}