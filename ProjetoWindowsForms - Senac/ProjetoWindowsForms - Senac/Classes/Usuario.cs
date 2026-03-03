using System.ComponentModel.DataAnnotations;

namespace ProjetoWindowsForms___Senac.Classes
{
    public class Usuario
    {
        public int UsuarioID { get; set; }

        [Required(ErrorMessage = "Não consegue enxergar que tem que colocar o nome?")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Preencha o espaço em branco com no mínimo 6 dígitos.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Digite seu CPF.")]
        [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$", ErrorMessage = "CPF inválido, tente novamente.")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "Digite seu Email.")]
        [EmailAddress(ErrorMessage = "Email inválido, tente novamente.")]
        public string Email { get; set; }

        [Required (ErrorMessage = "Digite seu Telefone.")]
        [RegularExpression(@"^\(\d{2}\) \d{4,5}-\d{4}$", ErrorMessage = "Telefone inválido, tente novamente.")]
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
