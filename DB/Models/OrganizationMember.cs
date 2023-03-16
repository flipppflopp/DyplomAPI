using System.ComponentModel.DataAnnotations;

namespace DyplomAPI.Models
{
    public class OrganizationMember
    {
        [Key]
        public int ID { get; set; }
        
        public Organization Organization { get; set; }
        
        public int VolonteerInfoID { get; set; }
        
        public VolonteerInfo VolonteerInfo { get; set; }
    }
}