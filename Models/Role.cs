using System.ComponentModel.DataAnnotations;

namespace VseTShirts.Models
{
    public class Role
    {
        [Required(ErrorMessage ="Обязательное поле")]
        [MinLength(3, ErrorMessage = "Минимум 3 символа!!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Обязательное поле")]
        public string Description { get; set; }
    }
}
