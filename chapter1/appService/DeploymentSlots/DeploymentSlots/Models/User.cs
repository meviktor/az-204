using System.ComponentModel.DataAnnotations;

namespace DeploymentSlots.Models
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; } = null!;

        public string  Division { get; set; } = null!;
    }
}
