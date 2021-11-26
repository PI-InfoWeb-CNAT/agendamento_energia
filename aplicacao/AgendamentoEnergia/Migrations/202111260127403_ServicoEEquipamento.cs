namespace AgendamentoEnergia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ServicoEEquipamento : DbMigration
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
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Serviço");
            DropTable("dbo.Equipamento");
        }
    }
}
