using System.ComponentModel.DataAnnotations;

namespace AutomapperExample.DTOs
{
    public class OrderItemCreateDTO
    {
        [Required]
        public int ProductId { get; set; }
        [Required]
        public int Quantity { get; set; }
    }
}
