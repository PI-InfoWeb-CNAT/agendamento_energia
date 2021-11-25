namespace AgendamentoEnergia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Tabela : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        UsuarioID = c.Long(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        Endereço = c.String(nullable: false),
                        Celular = c.String(nullable: false),
                        Senha = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.UsuarioID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Usuario");
        }
    }
}
