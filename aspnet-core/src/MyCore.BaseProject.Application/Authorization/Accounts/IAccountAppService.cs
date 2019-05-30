using System.Threading.Tasks;
using Abp.Application.Services;
using MyCore.BaseProject.Authorization.Accounts.Dto;

namespace MyCore.BaseProject.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
