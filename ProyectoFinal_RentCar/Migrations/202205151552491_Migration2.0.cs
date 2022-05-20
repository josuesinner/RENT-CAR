namespace ProyectoFinal_RentCar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration20 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Inspeccions", "VehículoId", c => c.Int(nullable: false));
            AddColumn("dbo.Inspeccions", "ClienteId", c => c.Int(nullable: false));
            AddColumn("dbo.Inspeccions", "EmpleadoId", c => c.Int(nullable: false));
            AddColumn("dbo.Inspeccions", "Cliente_Id_Cliente", c => c.Int());
            AddColumn("dbo.Inspeccions", "Empleado_Id_Empleado", c => c.Int());
            AddColumn("dbo.Inspeccions", "Vehículo_Id_Vehiculo", c => c.Int());
            AddColumn("dbo.Modelos", "MarcaId", c => c.Int(nullable: false));
            AddColumn("dbo.Modelos", "Marca_Id_Marca", c => c.Int());
            AddColumn("dbo.Renta_Devolucion", "EmpleadoId", c => c.Int(nullable: false));
            AddColumn("dbo.Renta_Devolucion", "VehiculoId", c => c.Int(nullable: false));
            AddColumn("dbo.Renta_Devolucion", "ClienteId", c => c.Int(nullable: false));
            AddColumn("dbo.Renta_Devolucion", "Cliente_Id_Cliente", c => c.Int());
            AddColumn("dbo.Renta_Devolucion", "Empleado_Id_Empleado", c => c.Int());
            AddColumn("dbo.Renta_Devolucion", "Vehículo_Id_Vehiculo", c => c.Int());
            AddColumn("dbo.Vehiculoes", "Tipo_VehiculoId", c => c.Int(nullable: false));
            AddColumn("dbo.Vehiculoes", "MarcaId", c => c.Int(nullable: false));
            AddColumn("dbo.Vehiculoes", "ModeloId", c => c.Int(nullable: false));
            AddColumn("dbo.Vehiculoes", "CombustibleId", c => c.Int(nullable: false));
            AddColumn("dbo.Vehiculoes", "Marca_Id_Marca", c => c.Int());
            AddColumn("dbo.Vehiculoes", "Modelo_Id_Modelo", c => c.Int());
            AddColumn("dbo.Vehiculoes", "Tipo_Combustible_Id_Combustible", c => c.Int());
            AddColumn("dbo.Vehiculoes", "Tipo_Vehiculo_Id_Tipo_Vehiculo", c => c.Int());
            CreateIndex("dbo.Inspeccions", "Cliente_Id_Cliente");
            CreateIndex("dbo.Inspeccions", "Empleado_Id_Empleado");
            CreateIndex("dbo.Inspeccions", "Vehículo_Id_Vehiculo");
            CreateIndex("dbo.Vehiculoes", "Marca_Id_Marca");
            CreateIndex("dbo.Vehiculoes", "Modelo_Id_Modelo");
            CreateIndex("dbo.Vehiculoes", "Tipo_Combustible_Id_Combustible");
            CreateIndex("dbo.Vehiculoes", "Tipo_Vehiculo_Id_Tipo_Vehiculo");
            CreateIndex("dbo.Modelos", "Marca_Id_Marca");
            CreateIndex("dbo.Renta_Devolucion", "Cliente_Id_Cliente");
            CreateIndex("dbo.Renta_Devolucion", "Empleado_Id_Empleado");
            CreateIndex("dbo.Renta_Devolucion", "Vehículo_Id_Vehiculo");
            AddForeignKey("dbo.Inspeccions", "Cliente_Id_Cliente", "dbo.Clientes", "Id_Cliente");
            AddForeignKey("dbo.Inspeccions", "Empleado_Id_Empleado", "dbo.Empleadoes", "Id_Empleado");
            AddForeignKey("dbo.Vehiculoes", "Marca_Id_Marca", "dbo.Marcas", "Id_Marca");
            AddForeignKey("dbo.Modelos", "Marca_Id_Marca", "dbo.Marcas", "Id_Marca");
            AddForeignKey("dbo.Vehiculoes", "Modelo_Id_Modelo", "dbo.Modelos", "Id_Modelo");
            AddForeignKey("dbo.Vehiculoes", "Tipo_Combustible_Id_Combustible", "dbo.Combustibles", "Id_Combustible");
            AddForeignKey("dbo.Vehiculoes", "Tipo_Vehiculo_Id_Tipo_Vehiculo", "dbo.Tipo_Vehiculo", "Id_Tipo_Vehiculo");
            AddForeignKey("dbo.Inspeccions", "Vehículo_Id_Vehiculo", "dbo.Vehiculoes", "Id_Vehiculo");
            AddForeignKey("dbo.Renta_Devolucion", "Cliente_Id_Cliente", "dbo.Clientes", "Id_Cliente");
            AddForeignKey("dbo.Renta_Devolucion", "Empleado_Id_Empleado", "dbo.Empleadoes", "Id_Empleado");
            AddForeignKey("dbo.Renta_Devolucion", "Vehículo_Id_Vehiculo", "dbo.Vehiculoes", "Id_Vehiculo");
            DropColumn("dbo.Inspeccions", "Vehículo");
            DropColumn("dbo.Inspeccions", "Id_Cliente");
            DropColumn("dbo.Inspeccions", "Empleado_inspección");
            DropColumn("dbo.Modelos", "Id_Marca");
            DropColumn("dbo.Renta_Devolucion", "Id_Empleado");
            DropColumn("dbo.Renta_Devolucion", "Empleado");
            DropColumn("dbo.Renta_Devolucion", "Id_Vehiculo");
            DropColumn("dbo.Renta_Devolucion", "Vehículo");
            DropColumn("dbo.Renta_Devolucion", "Id_Cliente");
            DropColumn("dbo.Renta_Devolucion", "Cliente");
            DropColumn("dbo.Vehiculoes", "Id_Tipo_Vehiculo");
            DropColumn("dbo.Vehiculoes", "Tipo_Vehiculo");
            DropColumn("dbo.Vehiculoes", "Id_Marca");
            DropColumn("dbo.Vehiculoes", "Marca");
            DropColumn("dbo.Vehiculoes", "Id_Modelo");
            DropColumn("dbo.Vehiculoes", "Modelo");
            DropColumn("dbo.Vehiculoes", "Id_Combustible");
            DropColumn("dbo.Vehiculoes", "Tipo_Combustible");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Vehiculoes", "Tipo_Combustible", c => c.String());
            AddColumn("dbo.Vehiculoes", "Id_Combustible", c => c.String());
            AddColumn("dbo.Vehiculoes", "Modelo", c => c.String());
            AddColumn("dbo.Vehiculoes", "Id_Modelo", c => c.String());
            AddColumn("dbo.Vehiculoes", "Marca", c => c.String());
            AddColumn("dbo.Vehiculoes", "Id_Marca", c => c.String());
            AddColumn("dbo.Vehiculoes", "Tipo_Vehiculo", c => c.String());
            AddColumn("dbo.Vehiculoes", "Id_Tipo_Vehiculo", c => c.String());
            AddColumn("dbo.Renta_Devolucion", "Cliente", c => c.String());
            AddColumn("dbo.Renta_Devolucion", "Id_Cliente", c => c.String());
            AddColumn("dbo.Renta_Devolucion", "Vehículo", c => c.String());
            AddColumn("dbo.Renta_Devolucion", "Id_Vehiculo", c => c.String());
            AddColumn("dbo.Renta_Devolucion", "Empleado", c => c.String());
            AddColumn("dbo.Renta_Devolucion", "Id_Empleado", c => c.String());
            AddColumn("dbo.Modelos", "Id_Marca", c => c.Int(nullable: false));
            AddColumn("dbo.Inspeccions", "Empleado_inspección", c => c.String());
            AddColumn("dbo.Inspeccions", "Id_Cliente", c => c.String());
            AddColumn("dbo.Inspeccions", "Vehículo", c => c.String());
            DropForeignKey("dbo.Renta_Devolucion", "Vehículo_Id_Vehiculo", "dbo.Vehiculoes");
            DropForeignKey("dbo.Renta_Devolucion", "Empleado_Id_Empleado", "dbo.Empleadoes");
            DropForeignKey("dbo.Renta_Devolucion", "Cliente_Id_Cliente", "dbo.Clientes");
            DropForeignKey("dbo.Inspeccions", "Vehículo_Id_Vehiculo", "dbo.Vehiculoes");
            DropForeignKey("dbo.Vehiculoes", "Tipo_Vehiculo_Id_Tipo_Vehiculo", "dbo.Tipo_Vehiculo");
            DropForeignKey("dbo.Vehiculoes", "Tipo_Combustible_Id_Combustible", "dbo.Combustibles");
            DropForeignKey("dbo.Vehiculoes", "Modelo_Id_Modelo", "dbo.Modelos");
            DropForeignKey("dbo.Modelos", "Marca_Id_Marca", "dbo.Marcas");
            DropForeignKey("dbo.Vehiculoes", "Marca_Id_Marca", "dbo.Marcas");
            DropForeignKey("dbo.Inspeccions", "Empleado_Id_Empleado", "dbo.Empleadoes");
            DropForeignKey("dbo.Inspeccions", "Cliente_Id_Cliente", "dbo.Clientes");
            DropIndex("dbo.Renta_Devolucion", new[] { "Vehículo_Id_Vehiculo" });
            DropIndex("dbo.Renta_Devolucion", new[] { "Empleado_Id_Empleado" });
            DropIndex("dbo.Renta_Devolucion", new[] { "Cliente_Id_Cliente" });
            DropIndex("dbo.Modelos", new[] { "Marca_Id_Marca" });
            DropIndex("dbo.Vehiculoes", new[] { "Tipo_Vehiculo_Id_Tipo_Vehiculo" });
            DropIndex("dbo.Vehiculoes", new[] { "Tipo_Combustible_Id_Combustible" });
            DropIndex("dbo.Vehiculoes", new[] { "Modelo_Id_Modelo" });
            DropIndex("dbo.Vehiculoes", new[] { "Marca_Id_Marca" });
            DropIndex("dbo.Inspeccions", new[] { "Vehículo_Id_Vehiculo" });
            DropIndex("dbo.Inspeccions", new[] { "Empleado_Id_Empleado" });
            DropIndex("dbo.Inspeccions", new[] { "Cliente_Id_Cliente" });
            DropColumn("dbo.Vehiculoes", "Tipo_Vehiculo_Id_Tipo_Vehiculo");
            DropColumn("dbo.Vehiculoes", "Tipo_Combustible_Id_Combustible");
            DropColumn("dbo.Vehiculoes", "Modelo_Id_Modelo");
            DropColumn("dbo.Vehiculoes", "Marca_Id_Marca");
            DropColumn("dbo.Vehiculoes", "CombustibleId");
            DropColumn("dbo.Vehiculoes", "ModeloId");
            DropColumn("dbo.Vehiculoes", "MarcaId");
            DropColumn("dbo.Vehiculoes", "Tipo_VehiculoId");
            DropColumn("dbo.Renta_Devolucion", "Vehículo_Id_Vehiculo");
            DropColumn("dbo.Renta_Devolucion", "Empleado_Id_Empleado");
            DropColumn("dbo.Renta_Devolucion", "Cliente_Id_Cliente");
            DropColumn("dbo.Renta_Devolucion", "ClienteId");
            DropColumn("dbo.Renta_Devolucion", "VehiculoId");
            DropColumn("dbo.Renta_Devolucion", "EmpleadoId");
            DropColumn("dbo.Modelos", "Marca_Id_Marca");
            DropColumn("dbo.Modelos", "MarcaId");
            DropColumn("dbo.Inspeccions", "Vehículo_Id_Vehiculo");
            DropColumn("dbo.Inspeccions", "Empleado_Id_Empleado");
            DropColumn("dbo.Inspeccions", "Cliente_Id_Cliente");
            DropColumn("dbo.Inspeccions", "EmpleadoId");
            DropColumn("dbo.Inspeccions", "ClienteId");
            DropColumn("dbo.Inspeccions", "VehículoId");
        }
    }
}
