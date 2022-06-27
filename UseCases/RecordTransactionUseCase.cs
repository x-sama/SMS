using UseCases.DataStorePluginInterfaces;
using UseCases.UseCasesInterfaces;

namespace UseCases;

public class RecordTransactionUseCase  : IRecordTransactionUseCase
{
    private readonly ITransactionRepository _transactionRepository;
    private readonly IGetProductByIdUseCase _getProductByIdUseCase;

    public RecordTransactionUseCase(ITransactionRepository transactionRepository , 
                                    IGetProductByIdUseCase getProductByIdUseCase)
    {
        _transactionRepository = transactionRepository;
        _getProductByIdUseCase = getProductByIdUseCase;
    }

    public void Execute(string cashierName,int productId, string productName ,int productQty)
    {
        var product = _getProductByIdUseCase.Execute(productId);
        _transactionRepository.Save(cashierName, productId, product.Price.Value, productName,productQty , product.Quantity.Value);
    }
    
}