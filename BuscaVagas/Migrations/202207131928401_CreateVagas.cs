namespace BuscaVagas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateVagas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Empresas",
                c => new
                    {
                        Cnpj = c.String(nullable: false, maxLength: 128),
                        Nome = c.String(),
                        Telefone = c.String(),
                        Email = c.String(),
                        Senha = c.String(),
                        Endereco = c.String(),
                        Bairro = c.String(),
                        Cidade = c.String(),
                        Estado = c.String(),
                        CEP = c.String(),
                        Representante = c.String(),
                    })
                .PrimaryKey(t => t.Cnpj);
            
            CreateTable(
                "dbo.Vagas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Cnpj = c.String(),
                        Cargo = c.String(),
                        Nivel = c.String(),
                        Tecnologia = c.String(),
                        Cidade = c.String(),
                        Estado = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Vagas");
            DropTable("dbo.Empresas");
        }
    }
}
