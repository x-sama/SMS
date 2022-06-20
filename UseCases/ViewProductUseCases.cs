using CoreBusiness;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCasesInterfaces;

namespace UseCases;

public class ViewProductUseCases : IViewProductUseCase
{
    private readonly IProductRepository _productRepository;

    public ViewProductUseCases(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public IEnumerable<Product> Execute()
    {
        return _productRepository.GetAllProducts();
    }

}