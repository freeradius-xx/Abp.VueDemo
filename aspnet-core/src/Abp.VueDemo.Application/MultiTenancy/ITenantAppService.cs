using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.VueDemo.MultiTenancy.Dto;

namespace Abp.VueDemo.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
