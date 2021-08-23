using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ManagEvent.WebAPI.Dtos
{
    public class PalestranteDto
    {
        public int Id { get; set; }

        [Required (ErrorMessage = "O campo Nome é obrigatório")]
        public string Nome { get; set; }
        public string MiniCurriculo { get; set; }
        public string ImagemURL { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public List<RedeSocialDto> RedesSociais { get; set; }
        public List<EventoDto> Eventos { get; set; }
    }
}