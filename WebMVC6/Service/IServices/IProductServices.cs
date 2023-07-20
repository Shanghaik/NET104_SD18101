using WebMVC6.Models;

namespace WebMVC6.Service.IServices
{
    public interface IProductServices
    {
        bool AddProduct(Product p);
        IEnumerable<Product> GetAllProducts();
        Product GetProductById(Guid id);
        bool UpdateProduct(Product p);
        bool DeleteProduct(Guid id);
    }
}
