using System.ComponentModel.DataAnnotations;
namespace AppViews.Models
{
    public class TestValidate
    {
        /*
         * Trong Asp.net core chúng ta có thể thực hiện việc validate
         * dữ liệu thông qua DA. Bên cạnh việc kiểm tra trên FE, thì
         * cách kiểm tra này sẽ ở phía BE. Khi áp dụng việc kiểm tra
         * chúng ta sử dụng ModelState.IsValid. Cách này thường được
         * gọi là sử dụng Validate Atribute
         */
        [Required] // Bắt buộc phải có
        public int Code { get; set; }
        [StringLength(20)]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [RegularExpression("^(\\+\\d{1,2}\\s)?\\(?\\d{3}\\)?" +
            "[\\s.-]\\d{3}[\\s.-]\\d{4}$", 
            ErrorMessage ="Bạn cần nhập định dạng xxx-xxx-xxxx")]
        public string Phone { get; set; }
        [Range(0, 1500000, ErrorMessage = 
            "Trợ cấp phải nằm trong khoảng 0 đến triệu rưởi")] // Trong khoảng
        public int SocialSubsidize { get; set; }
        [Range(18, 65, ErrorMessage = "Tuổi này nằm ngoài khung trợ cấp")]
        public int Age { get; set; }
        [EmailAddress(ErrorMessage = "Sai định dạng Email")]
        public string Email { get; set; }
    }
}
