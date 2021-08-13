using SIPOS.Entities.User;

namespace SIPOS.Services
{
    public interface ISiposUserService
    {
        SiposUser Login(string userName, string password);
    }
}