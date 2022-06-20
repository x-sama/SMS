using CoreBusiness;

namespace UseCases.DataStorePluginInterfaces;

public interface IProductRepository
{
    IEnumerable<Product> GetAllProducts();
    void AddProduct(Product product);
    void UpdateProduct(Product product);
    public Product GetProductById(int id);
}