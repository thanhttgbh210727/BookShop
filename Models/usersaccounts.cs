using System.ComponentModel.DataAnnotations;

namespace Shop.Models
{
    public class usersaccounts
    {
        [Display(Name = "ID")]
        public int Id { get; set; }
        [Display(Name = "User Name")]
        public string? name { get; set; }
        [Display(Name = "Password")]
        public string? pass { get; set; }
        [Display(Name = "Role")]
        public string? role { get; set; }
        [Display(Name = "Email")]
        public string? email { get; set; }

    }
}
