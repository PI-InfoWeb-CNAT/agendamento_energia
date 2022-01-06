namespace AgendamentoEnergia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Agorasim : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Sistema", name: "Usuario_UsuarioID", newName: "UsuarioID");
            RenameIndex(table: "dbo.Sistema", name: "IX_Usuario_UsuarioID", newName: "IX_UsuarioID");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Sistema", name: "IX_UsuarioID", newName: "IX_Usuario_UsuarioID");
            RenameColumn(table: "dbo.Sistema", name: "UsuarioID", newName: "Usuario_UsuarioID");
        }
    }
}
