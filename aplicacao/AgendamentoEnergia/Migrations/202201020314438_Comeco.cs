namespace AgendamentoEnergia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Comeco : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Equipamento",
                c => new
                    {
                        EquipamentoID = c.Long(nullable: false, identity: true),
                        Tipo = c.String(nullable: false),
                        DataSheet = c.String(nullable: false),
                        Potencia = c.Single(nullable: false),
                        Detalhes = c.String(),
                    })
                .PrimaryKey(t => t.EquipamentoID);
            
            CreateTable(
                "dbo.Serviço",
                c => new
                    {
                        ServiçoID = c.Long(nullable: false, identity: true),
                        Descrição = c.String(nullable: false),
                        Valor = c.Single(nullable: false),
                        Duração = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ServiçoID);
            
            CreateTable(
                "dbo.Sistema",
                c => new
                    {
                        SistemaID = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Potencia = c.Single(nullable: false),
                        dataInstalação = c.DateTime(nullable: false),
                        Usuario_UsuarioID = c.Long(),
                    })
                .PrimaryKey(t => t.SistemaID)
                .ForeignKey("dbo.Usuario", t => t.Usuario_UsuarioID)
                .Index(t => t.Usuario_UsuarioID);
            
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
            DropForeignKey("dbo.Sistema", "Usuario_UsuarioID", "dbo.Usuario");
            DropIndex("dbo.Sistema", new[] { "Usuario_UsuarioID" });
            DropTable("dbo.Usuario");
            DropTable("dbo.Sistema");
            DropTable("dbo.Serviço");
            DropTable("dbo.Equipamento");
        }
    }
}
