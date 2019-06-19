using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using MyCore.BaseProject.Authorization.Roles;
using MyCore.BaseProject.Authorization.Users;
using MyCore.BaseProject.BasicData.Teachers;
using MyCore.BaseProject.MultiTenancy;

namespace MyCore.BaseProject.EntityFrameworkCore
{
    public class BaseProjectDbContext : AbpZeroDbContext<Tenant, Role, User, BaseProjectDbContext>
    {
        /* Define a DbSet for each entity of the application */

        /// <summary>
        /// 教师信息
        /// </summary>
        public virtual DbSet<Teachers> Teachers { get; set; }
        
        public BaseProjectDbContext(DbContextOptions<BaseProjectDbContext> options)
            : base(options)
        {
        }
    }
}
