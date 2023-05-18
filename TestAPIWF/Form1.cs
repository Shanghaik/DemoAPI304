using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace TestAPIWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void btn_Calculate_Click(object sender, EventArgs e)
        {
            // Tạo URL của API
            // Lấy dữ liệu từ form
            double fe = Convert.ToDouble(tbt_FE.Text);
            double be = Convert.ToDouble(tbt_BE.Text);
            double alg = Convert.ToDouble(tbt_Algo.Text);
            // Gán dữ liệu mình vừa lấy được vào API URL
            //https://localhost:7011/WeatherForecast/evaluate-study?fe=1&be=1&alg=1
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
            btn_Result.Text = show;
        }
    }
}