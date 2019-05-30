using System.ComponentModel.DataAnnotations;

namespace MyCore.BaseProject.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}