using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.VueDemo.Sessions.Dto;

namespace Abp.VueDemo.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
