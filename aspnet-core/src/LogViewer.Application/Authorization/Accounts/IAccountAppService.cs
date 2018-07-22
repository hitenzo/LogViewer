using System.Threading.Tasks;
using Abp.Application.Services;
using LogViewer.Authorization.Accounts.Dto;

namespace LogViewer.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
