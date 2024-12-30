using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models
{
    public class Taasks
    {
        [Key]
        public int Id { get; set; } 
        public string Task_Name { get; set; }
        public string Description { get; set; }
        public string status { get; set; }
        public string priority { get; set; }

    }
}
