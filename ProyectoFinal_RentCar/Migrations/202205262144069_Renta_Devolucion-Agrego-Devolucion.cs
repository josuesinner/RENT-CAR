namespace ProyectoFinal_RentCar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Renta_DevolucionAgregoDevolucion : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Renta_Devolucion", "Devolucion", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Renta_Devolucion", "Devolucion");
        }
    }
}
