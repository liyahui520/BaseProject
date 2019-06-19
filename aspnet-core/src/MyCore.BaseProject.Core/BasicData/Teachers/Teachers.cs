using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

namespace MyCore.BaseProject.BasicData.Teachers
{
    /// <summary>
    /// 教师信息表
    /// </summary>
    [Table("DIM_Teachers")]
    public class Teachers : FullAuditedEntity,IMayHaveTenant
    {
        public int? TenantId { get; set; }

        /// <summary>
        /// 教师id
        /// </summary> 
        public long TeacherId { get; set; }

        /// <summary>
        /// 教师名称
        /// </summary>
        [Required]
        [StringLength(50)] 
        public string TeacherName { get; set; }

        /// <summary>
        /// 性别 0男 1女
        /// </summary> 
        public bool Sexy { get; set; }

        /// <summary>
        /// 住址
        /// </summary> 
        [StringLength(1000)]
        public string Address { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [StringLength(11)] 
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
