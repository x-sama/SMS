using CoreBusiness;

namespace UseCases.DataStorePluginInterfaces;

public interface IProductRepository
{
    IEnumerable<Product> GetAllProducts();
    IEnumerable<Product> GetAllProductsRelatedToCategoryId(int categoryId);
    void AddProduct(Product product);
    void UpdateProduct(Product product);
    void DeleteProduct(int product);
    public Product GetProductById(int id);
    
}