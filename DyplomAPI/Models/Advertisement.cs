using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;

namespace DyplomAPI.Models
{
    public class Advertisement
    {
        [Key]
        public int ID { get; set; }
        
        public string Cathegory { get; set; }
        
        public string Header { get; set; }

        public string Text { get; set; }

        public int ImageID { get; set; }

        public VolonteerInfo VolonteerInfo { get; set; }
        
        public List<Expense> Expenses { get; set; }
    }
}