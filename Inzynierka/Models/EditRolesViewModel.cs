namespace Inzynierka.Models
{
    public class EditRolesViewModel
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public List<RoleAssignmentViewModel> Roles { get; set; }
    }
}
