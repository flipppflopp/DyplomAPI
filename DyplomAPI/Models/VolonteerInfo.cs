using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DyplomAPI.Models
{
    public class VolonteerInfo
    {
        [Key]
        public int ID { get; set; }
        
        public int UserID { get; set; }
        public User User { get; set; }
        
        public string Status { get; set; }
        
        public List<Expense> Expenses { get; set; }
        
        public List<Advertisement> Advertisements { get; set; }
        
        public OrganizationMember OrganizationMember { get; set; }
    }
}