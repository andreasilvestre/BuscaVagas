using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BuscaVagas.Models
{
    [Table("Vaga")]
    public class Vaga
    {
        [Key()] //forçando que Id é chave primária
        public int Id { get; set; }

        [ForeignKey("Empresa")] //informando que o Cnpj vem da tabela/classe Empresa
        public string Cnpj { get; set; }
        //atenção, para garantir uma associação em tempo de execução, cria-se um objeto Modelo virtual
        public virtual Empresa Empresa { get; set; } //lazy load

        public string Cargo { get; set; } //Analista programador, Analista de sistemas,
                                          //DBA, Analista de Testes, Analista de Redes,
                                          //Analista de suporte

        public string Nivel { get; set; }
        public string Tecnologia { get; set; } // seelcionar uma apenas - combo, a master - dotNet, Java, Python, PHP, Oracle, SQL Server, etc
        public string Cidade { get; set; } // Cidade ou HomeOffice
        public string Estado { get; set; } 

    }
}
