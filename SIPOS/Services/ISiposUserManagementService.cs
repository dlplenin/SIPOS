using SIPOS.Entities.User;

namespace SIPOS.Services
{
    public interface ISiposUserManagementService
    {
        SiposUser Login(string userName, string password);
    }
}