using System;
using System.Collections.Generic;
using System.Text;
using Abp.AutoMapper;

namespace MyCore.BaseProject.Teachers.Dto
{
    [AutoMapFrom(typeof(BasicData.Teachers.Teachers))]
    public class TeachersDto
    {

        public long Id { get; set; }
        /// <summary>
        /// 教师id
        /// </summary> 
        public long TeacherId { get; set; }

        /// <summary>
        /// 教师名称
        /// </summary> 
        public string TeacherName { get; set; }

        /// <summary>
        /// 性别 0男 1女
        /// </summary> 
        public bool Sexy { get; set; }

        /// <summary>
        /// 住址
        /// </summary>  
        public string Address { get; set; }

        /// <summary>
        /// 手机号
        /// </summary> 
        public string CellPhone { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary> 
        public string Email { get; set; }


        /// <summary>
        /// 个人简介
        /// </summary> 
        public string Personal { get; set; }

        /// <summary>
        /// 备注
        /// </summary> 
        public string Memark { get; set; }
    }
}
