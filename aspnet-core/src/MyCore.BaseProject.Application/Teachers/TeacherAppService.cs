using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using Abp.Domain.Uow; 
using MyCore.BaseProject.Teachers.Dto;
using MyCore.BaseProject.BasicData.Teachers;

namespace MyCore.BaseProject.Teachers
{
    /// <summary>
    /// 教师数据服务类
    /// by yahui.li at 2019-06-19
    /// </summary>
    public class TeacherAppService : BaseProjectAppServiceBase, ITeacherAppService
    {
        #region 仓储实现
        private readonly IRepository<BasicData.Teachers.Teachers> _teachersReppository;
        private readonly IUnitOfWorkManager _unitOfWorkManager;

        public TeacherAppService(IRepository<BasicData.Teachers.Teachers> teachersReppository, IUnitOfWorkManager unitOfWorkManager)
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
            List<BasicData.Teachers.Teachers> teachersDtos = new List<BasicData.Teachers.Teachers>();
            try
            {
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
        public async Task<BasicData.Teachers.Teachers> CreateTeacher(TeacherInfo info)
        {
            try
            { 
                BasicData.Teachers.Teachers entity = info.MapTo<BasicData.Teachers.Teachers>();
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
                BasicData.Teachers.Teachers entity = info.MapTo<BasicData.Teachers.Teachers>();
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
