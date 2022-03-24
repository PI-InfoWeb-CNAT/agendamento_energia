namespace AgendamentoEnergia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AjeitandoVirtualDoSistema2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Sistema", "Usuario_UsuarioID", "dbo.Usuario");
            DropIndex("dbo.Sistema", new[] { "Usuario_UsuarioID" });
            AlterColumn("dbo.Sistema", "Usuario_UsuarioID", c => c.Long(nullable: false));
            CreateIndex("dbo.Sistema", "Usuario_UsuarioID");
            AddForeignKey("dbo.Sistema", "Usuario_UsuarioID", "dbo.Usuario", "UsuarioID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sistema", "Usuario_UsuarioID", "dbo.Usuario");
            DropIndex("dbo.Sistema", new[] { "Usuario_UsuarioID" });
            AlterColumn("dbo.Sistema", "Usuario_UsuarioID", c => c.Long());
            CreateIndex("dbo.Sistema", "Usuario_UsuarioID");
            AddForeignKey("dbo.Sistema", "Usuario_UsuarioID", "dbo.Usuario", "UsuarioID");
        }
    }
}
