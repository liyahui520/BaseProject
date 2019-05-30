using Abp.Application.Services.Dto;

namespace MyCore.BaseProject.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

