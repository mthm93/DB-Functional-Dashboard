using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OP.Curiosidade.UI.Models
{
    [Table("Colaboradores")]
    public class Colaborador
    {
        [Key]
        public int Id_Usuario { get; set; }

        public string Nome { get; set; }

        public DateTime? Data_Inicio { get; set; } = DateTime.Now;

        public DateTime? Data_Saida { get; set; } = DateTime.Now;

        public string Email { get; set; }

        public string Senha { get; set; }

        public string Endereco { get; set; }

        public string Outras_Informacoes { get; set; }

        public string Interesses { get; set; }

        public string Sentimentos { get; set; }

        public string Valores { get; set; }
    }
}