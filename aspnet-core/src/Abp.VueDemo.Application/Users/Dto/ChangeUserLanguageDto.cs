using System.ComponentModel.DataAnnotations;

namespace Abp.VueDemo.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}