using System.ComponentModel.DataAnnotations;

namespace ProjetoWindowsForms___Senac.Classes
{
    public class Usuario
    {
        public int UsuarioID { get; set; }

        [Required(ErrorMessage = "Insira seu nome.")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Preencha seu nome com no mínimo 6 caracteres.")]
        public string Nome { get; set; }

        [RegularExpression(@"^\d{11}$", ErrorMessage = "O CPF deve conter apenas dígitos e ter 11 caracteres.")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "Digite seu Email.")]
        [EmailAddress(ErrorMessage = "Email inválido, tente novamente.")]
        public string Email { get; set; }

        [RegularExpression(@"^\d{11}$", ErrorMessage = "O número de telefone deve conter apenas dígitos e ter 11 caracteres.")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Insira sua data de nascimento.")]
        public DateTime DataNascimento { get; set; }
    }
}
