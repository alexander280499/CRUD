namespace datospersonales.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Validaciones : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.datospersonalesmodeloes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false),
                        Apellido = c.String(nullable: false),
                        Direccion = c.String(nullable: false),
                        Telefono = c.String(nullable: false),
                        Email = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.datospersonalesmodeloes");
        }
    }
}
