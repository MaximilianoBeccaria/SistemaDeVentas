using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaDeVentas.Migrations
{
    /// <inheritdoc />
    public partial class VersionFinal6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetalleOrden_Orden_DetalleId",
                table: "DetalleOrden");

            migrationBuilder.DropForeignKey(
                name: "FK_Orden_Cliente_ClienteId",
                table: "Orden");

            migrationBuilder.DropIndex(
                name: "IX_Orden_ClienteId",
                table: "Orden");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DetalleOrden",
                table: "DetalleOrden");

            migrationBuilder.RenameColumn(
                name: "ClienteId",
                table: "Orden",
                newName: "IdCliente");

            migrationBuilder.RenameColumn(
                name: "DetalleId",
                table: "DetalleOrden",
                newName: "ProductoId1");

            migrationBuilder.AddColumn<int>(
                name: "ClienteIdCliente",
                table: "Orden",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DetalleOrdenId",
                table: "DetalleOrden",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OrdenId",
                table: "DetalleOrden",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_DetalleOrden",
                table: "DetalleOrden",
                columns: new[] { "DetalleOrdenId", "ProductoId" });

            migrationBuilder.CreateIndex(
                name: "IX_Orden_ClienteIdCliente",
                table: "Orden",
                column: "ClienteIdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleOrden_OrdenId",
                table: "DetalleOrden",
                column: "OrdenId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleOrden_ProductoId1",
                table: "DetalleOrden",
                column: "ProductoId1");

            migrationBuilder.AddForeignKey(
                name: "FK_DetalleOrden_Orden_DetalleOrdenId",
                table: "DetalleOrden",
                column: "DetalleOrdenId",
                principalTable: "Orden",
                principalColumn: "OrdenId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DetalleOrden_Orden_OrdenId",
                table: "DetalleOrden",
                column: "OrdenId",
                principalTable: "Orden",
                principalColumn: "OrdenId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DetalleOrden_Producto_ProductoId1",
                table: "DetalleOrden",
                column: "ProductoId1",
                principalTable: "Producto",
                principalColumn: "ProductoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orden_Cliente_ClienteIdCliente",
                table: "Orden",
                column: "ClienteIdCliente",
                principalTable: "Cliente",
                principalColumn: "IdCliente",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetalleOrden_Orden_DetalleOrdenId",
                table: "DetalleOrden");

            migrationBuilder.DropForeignKey(
                name: "FK_DetalleOrden_Orden_OrdenId",
                table: "DetalleOrden");

            migrationBuilder.DropForeignKey(
                name: "FK_DetalleOrden_Producto_ProductoId1",
                table: "DetalleOrden");

            migrationBuilder.DropForeignKey(
                name: "FK_Orden_Cliente_ClienteIdCliente",
                table: "Orden");

            migrationBuilder.DropIndex(
                name: "IX_Orden_ClienteIdCliente",
                table: "Orden");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DetalleOrden",
                table: "DetalleOrden");

            migrationBuilder.DropIndex(
                name: "IX_DetalleOrden_OrdenId",
                table: "DetalleOrden");

            migrationBuilder.DropIndex(
                name: "IX_DetalleOrden_ProductoId1",
                table: "DetalleOrden");

            migrationBuilder.DropColumn(
                name: "ClienteIdCliente",
                table: "Orden");

            migrationBuilder.DropColumn(
                name: "DetalleOrdenId",
                table: "DetalleOrden");

            migrationBuilder.DropColumn(
                name: "OrdenId",
                table: "DetalleOrden");

            migrationBuilder.RenameColumn(
                name: "IdCliente",
                table: "Orden",
                newName: "ClienteId");

            migrationBuilder.RenameColumn(
                name: "ProductoId1",
                table: "DetalleOrden",
                newName: "DetalleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DetalleOrden",
                table: "DetalleOrden",
                columns: new[] { "DetalleId", "ProductoId" });

            migrationBuilder.CreateIndex(
                name: "IX_Orden_ClienteId",
                table: "Orden",
                column: "ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_DetalleOrden_Orden_DetalleId",
                table: "DetalleOrden",
                column: "DetalleId",
                principalTable: "Orden",
                principalColumn: "OrdenId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orden_Cliente_ClienteId",
                table: "Orden",
                column: "ClienteId",
                principalTable: "Cliente",
                principalColumn: "IdCliente",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
