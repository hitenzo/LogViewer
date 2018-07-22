using System.ComponentModel.DataAnnotations;

namespace LogViewer.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}