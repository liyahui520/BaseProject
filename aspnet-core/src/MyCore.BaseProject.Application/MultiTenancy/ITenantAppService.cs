using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MyCore.BaseProject.MultiTenancy.Dto;

namespace MyCore.BaseProject.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

