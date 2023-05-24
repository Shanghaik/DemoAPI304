using AppData.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace AppViews.Controllers
{
    public class MausacController : Controller
    {
        public MausacController() { 
        }
        public async Task<IActionResult> ShowAllColor()
        {
            string apiURL = 
                "https://localhost:7179/api/Mausac/get-all-color";
            // Sau khi có URL thì thực hiện việc lấy dữ liệu trả về từ nó
            var httpClient = new HttpClient(); // Tại 1 httpClient để call API
            var response = await httpClient.GetAsync(apiURL); // Lấy kết quả
                                                              // Đọc ra string Json
            string apiData = await response.Content.ReadAsStringAsync();
            // Lấy kết quả thu được bằng cách bóc dữ liệu Json
            var result = JsonConvert.DeserializeObject<List<MauSac>>(apiData);
            return View(result);
        }
    }
}
