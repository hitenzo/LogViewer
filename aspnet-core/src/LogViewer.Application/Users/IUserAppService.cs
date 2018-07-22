using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using LogViewer.Roles.Dto;
using LogViewer.Users.Dto;

namespace LogViewer.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
