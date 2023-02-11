using System.ComponentModel.DataAnnotations;

namespace DyplomAPI.Models
{
    public class OrganizationMember
    {
        [Key]
        public int ID { get; set; }
        
        public int OrganizationID { get; set; }
        
        public int VolonteerID { get; set; }
    }
}