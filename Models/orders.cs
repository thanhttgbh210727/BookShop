using System.ComponentModel.DataAnnotations;

namespace Shop.Models
{
    public class orders
    {
        [Display(Name ="Order ID")]
        public int Id { get; set; }
        [Display(Name = "Book ID")]
        public int bookId { get; set; }
        [Display(Name = "User ID")]
        public int userid { get; set; }
        [Display(Name = "Quantity")]
        public int quantity { get; set; }
        [Display(Name = "Order Date")]
        public DateTime orderdate { get; set; }

    }
}
