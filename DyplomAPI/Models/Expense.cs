using System.ComponentModel.DataAnnotations;
using System.Dynamic;

namespace DyplomAPI.Models
{
    public class Expense
    {
        [Key]
        public int ID { get; set; }
        
        public int Volonteer_ID { get; set; }
        
        public string Name { get; set; }
        
        public int ExpenseNumber { get; set; }
    }
}