namespace ProyectoFinal_RentCar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        Id_Cliente = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Cedula = c.String(),
                        No_Tarjeta_CR = c.String(),
                        Límite_Credito = c.String(),
                        Tipo_Persona = c.String(),
                        Estado = c.String(),
                    })
                .PrimaryKey(t => t.Id_Cliente);
            
            CreateTable(
                "dbo.Combustibles",
                c => new
                    {
                        Id_Combustible = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                        Estado = c.String(),
                    })
                .PrimaryKey(t => t.Id_Combustible);
            
            CreateTable(
                "dbo.Empleadoes",
                c => new
                    {
                        Id_Empleado = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Cedula = c.String(),
                        Tanda_Labor = c.String(),
                        Porciento_Comision = c.String(),
                        Fecha_Ingreso = c.DateTime(nullable: false),
                        Estado = c.String(),
                    })
                .PrimaryKey(t => t.Id_Empleado);
            
            CreateTable(
                "dbo.Inspeccions",
                c => new
                    {
                        Id_Transacción = c.Int(nullable: false, identity: true),
                        Vehículo = c.String(),
                        Cedula = c.String(),
                        Id_Cliente = c.String(),
                        Tiene_Ralladuras = c.String(),
                        Cantidad_Combustible = c.String(),
                        Goma_respuesta = c.String(),
                        Tiene_Gato = c.String(),
                        roturas_cristal = c.String(),
                        Estado_gomas = c.String(),
                        Etc = c.String(),
                        Fecha = c.DateTime(nullable: false),
                        Empleado_inspección = c.String(),
                        Estado = c.String(),
                    })
                .PrimaryKey(t => t.Id_Transacción);
            
            CreateTable(
                "dbo.Marcas",
                c => new
                    {
                        Id_Marca = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                        Estado = c.String(),
                    })
                .PrimaryKey(t => t.Id_Marca);
            
            CreateTable(
                "dbo.Modelos",
                c => new
                    {
                        Id_Modelo = c.Int(nullable: false, identity: true),
                        Id_Marca = c.Int(nullable: false),
                        Descripcion = c.String(),
                        Estado = c.String(),
                    })
                .PrimaryKey(t => t.Id_Modelo);
            
            CreateTable(
                "dbo.Renta_Devolucion",
                c => new
                    {
                        No_Renta = c.Int(nullable: false, identity: true),
                        Id_Empleado = c.String(),
                        Empleado = c.String(),
                        Id_Vehiculo = c.String(),
                        Vehículo = c.String(),
                        Id_Cliente = c.String(),
                        Cliente = c.String(),
                        Fecha_Renta = c.DateTime(nullable: false),
                        Fecha_Devolucion = c.DateTime(nullable: false),
                        Monto_Día = c.String(),
                        Cantidad_días = c.Int(nullable: false),
                        Comentario = c.String(),
                        Estado = c.String(),
                    })
                .PrimaryKey(t => t.No_Renta);
            
            CreateTable(
                "dbo.Tipo_Vehiculo",
                c => new
                    {
                        Id_Tipo_Vehiculo = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                        Estado = c.String(),
                    })
                .PrimaryKey(t => t.Id_Tipo_Vehiculo);
            
            CreateTable(
                "dbo.Vehiculoes",
                c => new
                    {
                        Id_Vehiculo = c.Int(nullable: false, identity: true),
                        Descripción = c.String(),
                        No_Chasis = c.String(),
                        No_Motor = c.String(),
                        No_Placa = c.String(),
                        Id_Tipo_Vehiculo = c.String(),
                        Tipo_Vehiculo = c.String(),
                        Id_Marca = c.String(),
                        Marca = c.String(),
                        Id_Modelo = c.String(),
                        Modelo = c.String(),
                        Id_Combustible = c.String(),
                        Tipo_Combustible = c.String(),
                        Estado = c.String(),
                    })
                .PrimaryKey(t => t.Id_Vehiculo);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Vehiculoes");
            DropTable("dbo.Tipo_Vehiculo");
            DropTable("dbo.Renta_Devolucion");
            DropTable("dbo.Modelos");
            DropTable("dbo.Marcas");
            DropTable("dbo.Inspeccions");
            DropTable("dbo.Empleadoes");
            DropTable("dbo.Combustibles");
            DropTable("dbo.Clientes");
        }
    }
}
