using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiron.LojaVirtual.Dominio.Entidades
{
   public class Pedido
    {
        [Required(ErrorMessage = "Informe seu nome")]
        [Display(Name = "Nome do Cliente:")]
        public string NomeCliente { get; set; }

        [Display(Name = "Cep:")]
       public string Cep { get; set; }

        [Required(ErrorMessage = "Informe o seu endereço")]
        [Display(Name = "Endereço:")]
       public string Endereco { get; set; }

        [Display(Name = "Complemento:")]
        public string Complemento { get; set; }

        [Required(ErrorMessage = "Informe o seu estado")]
        [Display(Name = "Estado:")]
        public string Estado { get; set; }

        [Required(ErrorMessage = "Informe a sua cidade")]
        [Display(Name = "Cidade:")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Informe o seu bairro")]
        [Display(Name = "Bairro:")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "Informe o seu e-mail")]
        [Display(Name = "E-mail:")]
        [EmailAddress(ErrorMessage = "Email Inválido")]
        public string Email { get; set; }

        public bool EmbrulhaPresente { get; set; }

    }
}
