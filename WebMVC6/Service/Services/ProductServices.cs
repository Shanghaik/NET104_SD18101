using Microsoft.EntityFrameworkCore;
using WebMVC6.Models;
using WebMVC6.Repository.Repositories;
using WebMVC6.Service.IServices;

namespace WebMVC6.Service.Services
{
    public class ProductServices : IProductServices
    {
        AllRepositories<Product> allRepositories;
        public ProductServices(){ 
            // Tạo ra DbContext để gán cho AllRepo
            CuaHangDbContext dbcontext = new CuaHangDbContext();
            // Gán dbset của lớp AllRepo = dbset trong context
            // Để Dbset áp dụng trong Repo chính là Dbset trong
            // dbcontext
            DbSet<Product> dbset = dbcontext.Products;
            // Tạo mới AllRepo với constructor có tham số
            allRepositories = new AllRepositories<Product>(
                dbcontext, dbset );
        }
        public ProductServices(AllRepositories<Product> allRepositories)
        {
            this.allRepositories = allRepositories;
        }

        public bool AddProduct(Product p)
        {
            return allRepositories.AddItem(p);
        }

        public bool DeleteProduct(Guid id)
        {
            return allRepositories.
                DeleteItem(GetProductById(id));
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return allRepositories.GetAll();
        }

        public Product GetProductById(Guid id)
        {
            return allRepositories.GetItem(id);
        }

        public bool UpdateProduct(Product p)
        {
            return allRepositories.UpdateItem(p);
        }
    }
}
