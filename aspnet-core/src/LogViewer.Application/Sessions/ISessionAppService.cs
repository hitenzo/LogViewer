using System.Threading.Tasks;
using Abp.Application.Services;
using LogViewer.Sessions.Dto;

namespace LogViewer.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
