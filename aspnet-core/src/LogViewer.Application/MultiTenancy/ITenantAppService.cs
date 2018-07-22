using Abp.Application.Services;
using Abp.Application.Services.Dto;
using LogViewer.MultiTenancy.Dto;

namespace LogViewer.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
