using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models
{
    public class Projects
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(100)]
        public string Description { get; set; }
        public DateTime Startdate { get; set; }
        public DateTime Enddate { get; set; }

    }
}
