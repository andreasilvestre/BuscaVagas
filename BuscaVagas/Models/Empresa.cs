using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BuscaVagas.Models
{
    [Table("Empresa")]
    public class Empresa
    {
        [Key()]
        public string Cnpj { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; } //email será login
        public string Senha { get; set; } 

        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string CEP { get; set; }
        public string Representante { get; set; }

    }
}
