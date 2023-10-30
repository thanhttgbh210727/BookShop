using System.ComponentModel.DataAnnotations;

namespace Shop.Models
{
    public class report
    {
        [Display(Name = "Report ID")]
        public int Id { get; set; }
        [Display(Name = "Customer Name")]
        public string? customername { get; set; }
        [Display(Name = "Total ($)")]
        public int total { get; set; }

    }
}
