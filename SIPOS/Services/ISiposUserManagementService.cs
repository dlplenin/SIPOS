using SIPOS.Entities.User;

namespace SIPOS.Services
{
    public interface ISiposUserManagementService
    {
        SiposUser Login(string userName, string password);
        IQueryable<SiposRol> Rol();
        IQueryable<SiposUser> GetAllUsers();
        void Update(SiposUser userToUpdate);
        SiposUser GetUser(string id);
    }
}