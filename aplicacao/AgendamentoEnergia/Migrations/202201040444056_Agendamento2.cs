namespace AgendamentoEnergia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Agendamento2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Agendamento",
                c => new
                    {
                        AgendamentoID = c.Long(nullable: false, identity: true),
                        dataExecucao = c.DateTime(),
                        dataCriacao = c.DateTime(nullable: false),
                        dataAgendamento = c.DateTime(),
                        Descricao = c.String(),
                        Executado = c.Boolean(nullable: false),
                        BemSucedido = c.Boolean(nullable: false),
                        Confirmado = c.Boolean(nullable: false),
                        UsuarioID = c.Long(nullable: false),
                        ServiçoID = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.AgendamentoID)
                .ForeignKey("dbo.Serviço", t => t.ServiçoID, cascadeDelete: true)
                .ForeignKey("dbo.Usuario", t => t.UsuarioID, cascadeDelete: true)
                .Index(t => t.UsuarioID)
                .Index(t => t.ServiçoID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Agendamento", "UsuarioID", "dbo.Usuario");
            DropForeignKey("dbo.Agendamento", "ServiçoID", "dbo.Serviço");
            DropIndex("dbo.Agendamento", new[] { "ServiçoID" });
            DropIndex("dbo.Agendamento", new[] { "UsuarioID" });
            DropTable("dbo.Agendamento");
        }
    }
}
