using System.ComponentModel.DataAnnotations;

namespace ManagEvent.WebAPI.Dtos
{
    public class RedeSocialDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo URL é obrigatório")]
        public string URL { get; set; } 
    }
}