using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProiectWEB.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Author { get; set; }

        [Display(Name = "BookTitle")]
        public string Title { get; set; }
        public string PublishingHouse { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public string Code { get; set; }
        public string Text { get; set; }
    }
}