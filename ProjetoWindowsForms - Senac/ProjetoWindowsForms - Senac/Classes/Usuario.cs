using System.ComponentModel.DataAnnotations;

namespace ProjetoWindowsForms___Senac.Classes
{
    public class Usuario
    {
        public int UsuarioID { get; set; }

        [Required(ErrorMessage = "Insira seu nome.")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Preencha seu nome com no mínimo 6 caracteres.")]
        public string Nome { get; set; }

<<<<<<< HEAD
        [Required(ErrorMessage = "Digite seu CPF.")]
        [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$", ErrorMessage = "CPF inválido, tente novamente.")]
=======
        [RegularExpression(@"^\d{11}$", ErrorMessage = "O CPF deve conter apenas dígitos e ter 11 caracteres.")]
>>>>>>> 2efed7a3422679c4ff045b85d23a0cfbb2c076a4
        public string CPF { get; set; }

        [Required(ErrorMessage = "Digite seu Email.")]
        [EmailAddress(ErrorMessage = "Email inválido, tente novamente.")]
        public string Email { get; set; }

<<<<<<< HEAD
        [Required (ErrorMessage = "Digite seu Telefone.")]
        [RegularExpression(@"^\(\d{2}\) \d{4,5}-\d{4}$", ErrorMessage = "Telefone inválido, tente novamente.")]
=======
        [RegularExpression(@"^\d{11}$", ErrorMessage = "O número de telefone deve conter apenas dígitos e ter 11 caracteres.")]
>>>>>>> 2efed7a3422679c4ff045b85d23a0cfbb2c076a4
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Insira sua data de nascimento.")]
        public DateTime DataNascimento { get; set; }
    }
}
