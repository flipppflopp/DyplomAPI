using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace DB.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public bool IsVolonteer { get; set; }
        
        [AllowNull]
        public int VolonteerInfoID { get; set; }
    }
}