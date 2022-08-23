namespace SaniatsCakeShop.ViewModels
{
    public class AddUserRoleViewModel
    {
        public string UserId { get; set; }
        public string RoleId { get; set; }

        public Controllers.AdminController AdminController
        {
            get => default;
            set
            {
            }
        }
    }
}