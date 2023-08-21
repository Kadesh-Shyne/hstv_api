using System.ComponentModel.DataAnnotations;

namespace HSTV_Api.Models
{
    public class Amount
    {
        [Key]
        public int AmountId { get;set; }
        public DateTime Offering_Given { get; set; }
    }
}
