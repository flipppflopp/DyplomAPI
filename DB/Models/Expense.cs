using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;

namespace DyplomAPI.Models
{
    public class Expense
    {
        [Key]
        public int ID { get; set; }
        
        public int Amount { get; set; }
        
        public VolonteerInfo VolonteerInfo { get; set; }
        
        public string Name { get; set; }
        
        public int ExpenseNumber { get; set; }
        
        public List<Advertisement> Advertisements { get; set; }
    }
}