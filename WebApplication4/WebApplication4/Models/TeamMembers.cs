using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models
{
    public class TeamMembers
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
    }
}
