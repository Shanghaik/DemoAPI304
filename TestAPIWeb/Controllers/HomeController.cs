using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;
using TestAPIWeb.Models;

namespace TestAPIWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Privacy() // Hiển thị form thôi
        {
            return View();
        }
        public async Task<IActionResult> Privacy(double fe, double be, double alg) // Tính toán
        {
            string apiURL = $"https://localhost:7011/WeatherForecast/" +
                $"evaluate-study?fe={fe}&be={be}&alg={alg}";
            // Sau khi có URL thì thực hiện việc lấy dữ liệu trả về từ nó
            var httpClient = new HttpClient(); // Tại 1 httpClient để call API
            var response = await httpClient.GetAsync(apiURL); // Lấy kết quả
            // Đọc ra string Json
            string apiData = await response.Content.ReadAsStringAsync();
            // Lấy kết quả thu được bằng cách bóc dữ liệu Json
            string result = JsonConvert.DeserializeObject<string>(apiData);
            string show = "";
            // Logic code 
            double avg = Convert.ToDouble(result);
            if (avg < 5) show = "Học lại";
            else if (avg < 6.5) show = "Quite good";
            else if (avg < 8) show = "Excellent";
            else if (avg < 9.5) show = "Good";
            else show = "Perfect";
            ViewData["result"] = "Kết quả học tập của bạn là: " + show;
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}