using DeploymentSlots.Models;

namespace DeploymentSlots.ViewModels
{
    public class UserViewModel
    {
        public IEnumerable<User> Users { get; set; } = null!;

        public string ExceptionName { get; set; } = null!;
    }
}
