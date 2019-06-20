using System;
using System.Collections.Generic; 
using System.Threading.Tasks;
using Abp.Authorization;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using Abp.Domain.Uow;
using MyCore.BaseProject.Authorization;
using MyCore.BaseProject.Teachers.Dto; 

namespace MyCore.BaseProject.BasicData.Teachers
{
    /// <summary>
    /// 教师数据服务类
    /// by yahui.li at 2019-06-19
    /// </summary>
    [AbpAuthorize(PermissionNames.Page_Teachers)]
    public class TeacherAppService : BaseProjectAppServiceBase, ITeacherAppService
    {
        #region 仓储实现
        private readonly IRepository<Teachers> _teachersReppository;
        private readonly IUnitOfWorkManager _unitOfWorkManager;

        public TeacherAppService(IRepository<Teachers> teachersReppository, IUnitOfWorkManager unitOfWorkManager)
        {
            _teachersReppository = teachersReppository;
            _unitOfWorkManager = unitOfWorkManager;
        }
        #endregion

        #region 逻辑实现

        /// <summary>
        /// 查询全部教师信息
        /// </summary>
        /// <returns></returns>
        public async Task<List<TeachersDto>> QueryTeachers()
        {
            try
            { 
                List<Teachers> teachersDtos;
                if (AbpSession.TenantId == null)
                {
                    using (_unitOfWorkManager.Current.DisableFilter(AbpDataFilters.MayHaveTenant))
                    {
                        teachersDtos = await _teachersReppository.GetAllListAsync();
                    }
                }
                else
                {
                    teachersDtos = await _teachersReppository.GetAllListAsync();
                }

                return teachersDtos.MapTo<List<TeachersDto>>();
            }
            catch (Exception e)
            {
                throw e;
            }
            
        }

        /// <summary>
        /// 创建教师
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public async Task<Teachers> CreateTeacher(TeacherInfo info)
        {
            try
            { 
                Teachers entity = info.MapTo<Teachers>();
                if (await _teachersReppository.CountAsync(s=>s.TeacherName==info.TeacherName)>0)
                {
                    throw new Exception("该教师名称已存在!");
                }
                return await _teachersReppository.InsertAsync(entity);  
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// 删除教师信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public async Task DeleteTeachers(List<long> ids)
        {
            try
            {
               await _teachersReppository.DeleteAsync(s => ids.Contains(s.Id));
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// 修改教师信息
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public async Task UpdateTeacher(TeacherInfo info)
        {
            try
            {
                Teachers entity = info.MapTo<Teachers>();
                await _teachersReppository.UpdateAsync(entity);
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        #endregion
    }
}
