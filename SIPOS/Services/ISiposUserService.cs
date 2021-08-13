using SIPOS.Entities;

namespace SIPOS.Services
{
    public interface ISiposUserService
    {
        SiposUser Login(string user, string password);
    }
}