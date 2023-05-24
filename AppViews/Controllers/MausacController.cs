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
        /* 
         * Bất đồng bộ: Là một cơ chế vô cùng quan trọng trong lập trình web
         * cho phép xử lý nhiều luồng mà không phải chờ. Khi phía client send
         * 1 request (luồng chính) thì từ request đó có thể sinh ra nhiều tác 
         * vụ, khi đó các tác vụ sẽ không thực hiện một cách tuần tự mà sẽ thực hiện đan
         * xen cho đến khi tác vụ cuối cùng được hoàn thành thì mới kết thúc
         * luồng chính. Luồng chính cũng sẽ bị block cho đến khi các luồng con
         * hoàn thành. VD: Khi thực hiện việc thanh toán thì sẽ có các tác vụ
         * > Tạo hóa đơn (Bao gồm cả HĐ chi tiết)
         * > Trừ sản phẩm
         * > Cập nhật giỏ hàng
         * > Trừ tiền của Khách hàng (nếu tt online)
         * > Tính tiền (sp + ship + vat)
         * Các luồng này sẽ không chờ nhau mà thực hiện đan xen, kết quả của 
         * luồng này có thể là input của luồng khác.
         * Xử lý bất đồng bộ cho phép tăng hiệu năng một cách đáng kể
         * Có nhiều cách để xử lý bất đồng bộ, trong cơ chế xử lý với thread
         * pool, thì mỗi thread sẽ thực thi một công việc khác nhau và không
         * bao giờ một thread rảnh nếu số lượng công việc > số lượng thread
         * khi đó các công việc sẽ được xếp vào hàng chờ và xử lý tuần tự đan 
         * xen. Một thread không chờ cho đến khi các tác vụ tuàn tự hoàn toàn
         * hoàn thành mà có thể nhận thêm các tác vụ khác.
         */
    }
}
