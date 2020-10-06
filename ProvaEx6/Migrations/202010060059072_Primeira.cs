namespace ProvaEx6.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Primeira : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Aluno",
                c => new
                    {
                        Nome = c.String(nullable: false, maxLength: 128),
                        Id = c.Int(nullable: false),
                        Filiacao = c.String(nullable: false),
                        Curso = c.String(nullable: false),
                        Endereco = c.String(nullable: false),
                        Telefone = c.String(nullable: false),
                        Email = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Nome);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Aluno");
        }
    }
}
