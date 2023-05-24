// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;

//Console.WriteLine("Enter FE marks");
//double fe = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Enter BE marks");
//double be = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Enter Algo marks");
//double alg = Convert.ToDouble(Console.ReadLine());
//// Gán dữ liệu mình vừa lấy được vào API URL
////https://localhost:7011/WeatherForecast/evaluate-study?fe=1&be=1&alg=1
//string apiURL = $"https://localhost:7011/WeatherForecast/" +
//    $"evaluate-study?fe={fe}&be={be}&alg={alg}";
//// Sau khi có URL thì thực hiện việc lấy dữ liệu trả về từ nó
//var httpClient = new HttpClient(); // Tại 1 httpClient để call API
//var response = await httpClient.GetAsync(apiURL); // Lấy kết quả
//                                                  // Đọc ra string Json
//string apiData = await response.Content.ReadAsStringAsync();
//// Lấy kết quả thu được bằng cách bóc dữ liệu Json
//string result = JsonConvert.DeserializeObject<string>(apiData);
//string show = "";
//// Logic code 
//double avg = Convert.ToDouble(result);
//if (avg < 5) show = "Học lại";
//else if (avg < 6.5) show = "Quite good";
//else if (avg < 8) show = "Excellent";
//else if (avg < 9.5) show = "Good";
//else show = "Perfect";
// Console.WriteLine(show);
A a = new A();
a.Id = 1;
A aa = a;
a.InTT(); aa.InTT();
// Check xem liệu nó có là 2 thằng khác nhau không?
a.Id = 10;
aa.InTT();
Console.ReadKey();
class A
{
    public int Id { get; set; }
    public void InTT()
    {
        Console.WriteLine("Id là " + Id);
    }
}
