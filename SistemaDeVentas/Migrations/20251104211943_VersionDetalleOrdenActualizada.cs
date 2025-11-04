using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaDeVentas.Migrations
{
    /// <inheritdoc />
    public partial class VersionDetalleOrdenActualizada : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetalleOrden_Orden_OrdenId",
                table: "DetalleOrden");

            migrationBuilder.DropColumn(
                name: "Total",
                table: "Orden");

            migrationBuilder.DropColumn(
                name: "Subtotal",
                table: "DetalleOrden");

            migrationBuilder.RenameColumn(
                name: "OrdenId",
                table: "DetalleOrden",
                newName: "DetalleId");

            migrationBuilder.AddColumn<string>(
                name: "Nombre",
                table: "DetalleOrden",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_DetalleOrden_Orden_DetalleId",
                table: "DetalleOrden",
                column: "DetalleId",
                principalTable: "Orden",
                principalColumn: "OrdenId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetalleOrden_Orden_DetalleId",
                table: "DetalleOrden");

            migrationBuilder.DropColumn(
                name: "Nombre",
                table: "DetalleOrden");

            migrationBuilder.RenameColumn(
                name: "DetalleId",
                table: "DetalleOrden",
                newName: "OrdenId");

            migrationBuilder.AddColumn<decimal>(
                name: "Total",
                table: "Orden",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Subtotal",
                table: "DetalleOrden",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddForeignKey(
                name: "FK_DetalleOrden_Orden_OrdenId",
                table: "DetalleOrden",
                column: "OrdenId",
                principalTable: "Orden",
                principalColumn: "OrdenId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
