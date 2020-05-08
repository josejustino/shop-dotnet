using System.ComponentModel.DataAnnotations;

namespace shop.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(20, ErrorMessage = "Este campo deve conter no máximo 20 caracteres")]
        [MinLength(3, ErrorMessage = "Este campo deve conter no mínimo 3 caracteres")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(20, ErrorMessage = "Este campo deve conter no máximo 60 caracteres")]
        [MinLength(3, ErrorMessage = "Este campo deve conter no mínimo 3 caracteres")]
        public string Password { get; set; }
        public string Role { get; set; }
    }
}