using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebMVC6.Models;
using WebMVC6.Service.Services;

namespace WebMVC6.Controllers
{
    public class HomeController : Controller
    {
        // private readonly ILogger<HomeController> _logger;
        private readonly ProductServices _services = new ProductServices();
        public HomeController()
        {
            _services = new ProductServices();
        }

        public IActionResult Index()
        {
            return View(); // Trỏ đến View cùng tên với action
        }

        public IActionResult Privacy()
        {
            return View();
        }

        // Tạo thử 1 Action
        public IActionResult Test() // tạo thử
        {
            // return View();// trỏ tới view cùng tên
            return View("Thu"); // trỏ tới view cụ thể
        }
        public IActionResult ChangeDirection()
        {
            return RedirectToAction("Test");
        }

        public IActionResult GetAllProduct()
        {
            // Gen view tự đông 
            // Chuột phải: Chọn add View => Razor View
            // Thiết lập: Tên giữ nguyên, Chọn template là List
            // CHọn Model là Model mình muốn
            // Faked List
            //List<Product> products = new List<Product>()
            //{
            //    new Product{ Name = "Thầy Việt", Id = Guid.NewGuid() },
            //    new Product{ Name = "Thầy Khánh", Id = Guid.NewGuid() },
            //    new Product{ Name = "Thầy Dũng", Id = Guid.NewGuid() },
            //    new Product{ Name = "Thầy Tiến", Id = Guid.NewGuid() },
            //    new Product{ Name = "Thầy Đan", Id = Guid.NewGuid() },
            //};
            var products = _services.GetAllProducts().ToList();

            return View(products); // Truyền thẳng Models vào View
            // Mỗi View chỉ có duy nhất 1 Model đại diện
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}