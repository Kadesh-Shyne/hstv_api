using System.ComponentModel.DataAnnotations;

namespace HSTV_Api.Models
{
    public class Country
    {
        [Key]
        public int CountryId { get; set; }  
        public string CountryName { get; set; }   
        public string City { get; set; }    
        public string State { get; set; }  
        public string PostalCode { get; set; }  
        public string CountryCode { get; set; } 
   
    }
}
