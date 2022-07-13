namespace BuscaVagas.Models
{
    public class Vaga
    {
        public string Cnpj { get; set; }
        public string Cargo { get; set; } //Analista programador, Analista de sistemas,
                                         //DBA, Analista de Testes, Analista de Redes,
                                         //Analista de suporte
        public string Nivel { get; set; } // junior, pleno, senior ou lider

        //public string Area { get; set; } //  Desenvolvimento, Testes, Redes, Banco de Dados, etc
        public string Tecnologia { get; set; } // uma apenas, a master - dotNet, Java, Python, PHP, Oracle, SQL Server, etc
        public string Cidade { get; set; } // Cidade ou HomeOffice
        public string Estado { get; set; } 


    }
}
