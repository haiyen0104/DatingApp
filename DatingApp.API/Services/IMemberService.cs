
using DatingApp.API.DTOs;

namespace DatingApp.API.Services
{
    public interface IMemberService
    {
        List<MemberDto> GetMembers();
        MemberDto GetMemberDtoByUserName(string username);
        
    }
}