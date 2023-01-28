using System.ComponentModel.DataAnnotations;

namespace Traversal_Rezervasyon_Asp.Net_Core_5._0.Models
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage ="Lütfen kullanıcı adını giriniz !")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen parolanızı giriniz !")]
        public string Password { get; set; }
    }
}
