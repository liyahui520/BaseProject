using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.AutoMapper;
using Abp.Domain.Uow;
using MyCore.BaseProject.Teachers.Dto;

namespace MyCore.BaseProject.Teachers
{
    /// <summary>
    /// 教师服务接口
    /// by yahui.li at 2019-06-19
    /// </summary>
     interface ITeacherAppService : IApplicationService
    {
        /// <summary>
        /// 查询全部教师信息
        /// </summary>
        /// <returns></returns>
        Task<List<TeachersDto>> QueryTeachers();

        /// <summary>
        /// 创建教师
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        Task<BasicData.Teachers.Teachers> CreateTeacher(TeacherInfo info);

        /// <summary>
        /// 删除教师信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        Task DeleteTeachers(List<long> ids);

        /// <summary>
        /// 修改教师信息
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
         Task UpdateTeacher(TeacherInfo info);
    }
}
