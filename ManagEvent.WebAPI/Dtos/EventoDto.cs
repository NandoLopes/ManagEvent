using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ManagEvent.WebAPI.Dtos
{
    public class EventoDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "O campo Local deve ter entre 3 e 100 caracteres")]
        public string Local { get; set; }
        public string DataEvento { get; set; }

        [Required(ErrorMessage ="O tema é obrigatório")]
        public string Tema { get; set; }

        [Range(1, 120000, ErrorMessage = "A quantidade de pessoas deve ser entre 1 e 120000")]
        public int QtdPessoas { get; set; }
        public string ImagemURL { get; set; }
        public string  Telefone { get; set; }

        [EmailAddress]
        public string Email { get; set; }
        public List<LoteDto> Lotes { get; set; }
        public List<RedeSocialDto> RedesSociais { get; set; }
        public List<PalestranteDto> Palestrantes { get; set; }
    }
}