using System.ComponentModel.DataAnnotations;

namespace DyplomAPI.Models
{
    public class VolonteerInfo
    {
        [Key]
        public int ID { get; set; }
        
        public int UserID { get; set; }
        
        public string Status { get; set; }
    }
}