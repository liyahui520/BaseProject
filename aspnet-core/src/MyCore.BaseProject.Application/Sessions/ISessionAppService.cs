using System.Threading.Tasks;
using Abp.Application.Services;
using MyCore.BaseProject.Sessions.Dto;

namespace MyCore.BaseProject.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
