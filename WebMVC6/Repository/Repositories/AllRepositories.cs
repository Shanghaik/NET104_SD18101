using Microsoft.EntityFrameworkCore;
using WebMVC6.Models;
using WebMVC6.Repository.IRepositories;

namespace WebMVC6.Repository.Repositories
{
    public class AllRepositories<T> 
        : IAllRepositories<T> where T : class
    {
        /*
         * var là keyword đánh dấu 1 biến có thể nhận được mọi kiểu
         * dữ liệu nhưng khi đã xác định kiểu dữ liệu cần dùng thì
         * không thể thay đổi được
         * dynamic là kiểu dữ liệu linh hoạt cho phép biến nhận mọi
         * kiểu dữ liệu và có thể thay đổi được
         */
        CuaHangDbContext cuaHangDbContext = new CuaHangDbContext();
        DbSet<T> DbSet;
        public AllRepositories(){}
        public AllRepositories(CuaHangDbContext cuaHangDbContext,
            DbSet<T> dbSet)
        {
            this.cuaHangDbContext = cuaHangDbContext;
            DbSet = dbSet;
        }

        public bool AddItem(T item)
        {
            try
            {
                DbSet.Add(item);
                cuaHangDbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool DeleteItem(T item)
        {
            try
            {
                DbSet.Remove(item);
                cuaHangDbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }       
        }

        public IEnumerable<T> GetAll()
        {
            return DbSet.ToList(); // Trả về trực tiếp kết quả
        }

         public T GetItem(dynamic id)
        {
            return DbSet.Find(id); // Find dùng để tìm kiếm nhưng
            // Find mà truyền thẳng vào 1
            // parameter thì chỉ dùng cho key
        }

        public bool UpdateItem(T item)
        {
            try
            {
                DbSet.Update(item);
                cuaHangDbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
