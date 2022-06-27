using UseCases.DataStorePluginInterfaces;
using UseCases.UseCasesInterfaces;

namespace UseCases;

public class SellProductUseCase: ISellProductUseCase
{
    private readonly IProductRepository _productRepository;
    private readonly IRecordTransactionUseCase _recordTransactionUseCase;


    public SellProductUseCase(IProductRepository productRepository
        ,IRecordTransactionUseCase recordTransactionUseCase)
    {
        _productRepository = productRepository;
        _recordTransactionUseCase = recordTransactionUseCase;
    }
    public void Execute(string cashierName,int productId, int sellQty)
    {
        var product = _productRepository.GetProductById(productId);
        if (product == null) return;
        _recordTransactionUseCase.Execute(cashierName,productId,product.Name,sellQty);
        product.Quantity -= sellQty;
        _productRepository.UpdateProduct(product);

    }
}