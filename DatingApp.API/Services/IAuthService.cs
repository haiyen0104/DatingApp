using DatingApp.API.DTOs;

namespace DatingApp.API.Services
{
    public interface IAuthService
    {
        string Login(AuthUserDTOs authUserDto);
        string Register(RegisterUserDto registerUserDto);
    }
}
