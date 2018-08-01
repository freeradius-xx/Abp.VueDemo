using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.VueDemo.Authorization.Accounts.Dto;

namespace Abp.VueDemo.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
