using System.ComponentModel.DataAnnotations;

namespace Shop.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required, Display(Name ="Title")]
        public string? title { get; set; }
        [Required, Display(Name = "Description")]
        public string? info { get; set; }
        [Required, Display(Name = "Quantity"), Range(0,int.MaxValue)]
        public int bookquantity { get; set; }
        [Required, Display(Name = "Price"), Range(0, int.MaxValue)]
        public int price { get; set; }
        [Required, Display(Name = "Category")]
        public int cataid { get; set; }
        [Required, Display(Name = "Author")]
        public string? author { get; set; }
        [Required, Display(Name = "Image")]
        public string? imgfile { get; set; }

    }
}
