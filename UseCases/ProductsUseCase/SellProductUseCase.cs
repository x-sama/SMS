using UseCases.DataStorePluginInterfaces;
using UseCases.UseCasesInterfaces;

namespace UseCases;

public class SellProductUseCase: ISellProductUseCase
{
    private readonly IProductRepository _productRepository;

    public SellProductUseCase(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }
    public void Execute(int productId, int sellQty)
    {
        var product = _productRepository.GetProductById(productId);
        if (product == null) return;
        product.Quantity -= sellQty;
        _productRepository.UpdateProduct(product);
    }
}