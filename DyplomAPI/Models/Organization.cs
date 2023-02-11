using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DyplomAPI.Models
{
    public class Organization
    {
        [Key]
        public int ID { get; set; }
        
        public string Name { get; set; }
        
        public string Resource { get; set; }
        
        public List<OrganizationMember> OrganizationMember { get; set; }
    }
}