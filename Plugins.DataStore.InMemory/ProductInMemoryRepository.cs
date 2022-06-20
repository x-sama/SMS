using CoreBusiness;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.InMemory;

public class ProductInMemoryRepository : IProductRepository
{
    // list of Products 
    public List<Product> Products;

    public ProductInMemoryRepository()
    {
        Products = new List<Product>()
        {
            new Product{ProductId = 1, CategoryId = 1, Name = "product1", Price = 200, Quantity = 20},
            new Product{ProductId = 2, CategoryId = 1, Name = "product2", Price = 23, Quantity = 34},
            new Product{ProductId = 3, CategoryId = 2, Name = "product3", Price = 455, Quantity = 2},
            new Product{ProductId = 4, CategoryId = 2, Name = "product4", Price = 234, Quantity = 3},
            new Product{ProductId = 5, CategoryId = 3 ,Name = "product5", Price = 34, Quantity = 45},

        };
    }

    public IEnumerable<Product> GetAllProducts()
    {
        return Products;
    }

    public void AddProduct(Product product)
    {
        // add the product to the list
        if (Products.Any(x=> x.Name.Equals(product.Name, StringComparison.OrdinalIgnoreCase))) return;
        if (Products.Any())
        {
            var maxId = Products.Max(x => x.ProductId);
            product.ProductId = maxId + 1;
        }
        else
        {
            product.ProductId = 1;
        }
       
        Products.Add(product);
    }

    public void UpdateProduct(Product product)
    {
       
        if (GetProductById(product.ProductId) is { } productToUpdate)
        {
            productToUpdate.Name = product.Name;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.Price = product.Price;
            productToUpdate.Quantity = product.Quantity;
        }
    }

    public Product GetProductById(int id)
    {
        return Products.FirstOrDefault(x => x.ProductId == id);
    }
}