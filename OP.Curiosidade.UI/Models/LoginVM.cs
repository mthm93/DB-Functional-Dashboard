using System.ComponentModel.DataAnnotations;

namespace OP.Curiosidade.UI.Models
{
    public class LoginVM
    {
        [Required(ErrorMessage = "O {0} � obrigat�rio")]
        [StringLength(80, ErrorMessage ="Limite excedido")]
        [RegularExpression (@"([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)", ErrorMessage ="Email inv�lido")]
        public string Email { get; set; }

        [Required (ErrorMessage = "A (0) � obrigat�ria")]
        public string Senha { get; set; }
        public bool PermanecerLogado { get; set; }
        public bool ReturnURL { get; set; }
    }
}