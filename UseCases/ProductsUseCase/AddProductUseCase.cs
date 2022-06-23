using CoreBusiness;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCasesInterfaces;

namespace UseCases;

public class AddProductUseCase: IAddProductUseCase
{
    private readonly IProductRepository _productRepository;


    public AddProductUseCase(IProductRepository productRepository )
    {
        _productRepository = productRepository;
    }
    public void Execute(Product product)
    {
        _productRepository.AddProduct(product);
    }
}