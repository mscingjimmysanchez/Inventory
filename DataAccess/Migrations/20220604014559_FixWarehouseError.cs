using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class FixWarehouseError : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Storages_Warehouses_WarehousesWarehouseId",
                table: "Storages");

            migrationBuilder.DropIndex(
                name: "IX_Storages_WarehousesWarehouseId",
                table: "Storages");

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "2fb6d98b-ec81-4cde-8f42-8fb294fc71ce");

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "310670a6-6f67-4d24-8286-51a61001b251");

            migrationBuilder.DropColumn(
                name: "WarehousesWarehouseId",
                table: "Storages");

            migrationBuilder.AlterColumn<string>(
                name: "WarehouseId",
                table: "Storages",
                type: "nvarchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "WarehouseId", "WarehouseAddress", "WarehouseName" },
                values: new object[] { "ad79c4df-74dd-4298-a1c8-212f4e390c42", "Calle 8 con 23", "Bodega Central" });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "WarehouseId", "WarehouseAddress", "WarehouseName" },
                values: new object[] { "e0eb7f98-e9dd-48ef-b471-954f13ebda49", "Calle norte con occidente", "Bodega Norte" });

            migrationBuilder.CreateIndex(
                name: "IX_Storages_WarehouseId",
                table: "Storages",
                column: "WarehouseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Storages_Warehouses_WarehouseId",
                table: "Storages",
                column: "WarehouseId",
                principalTable: "Warehouses",
                principalColumn: "WarehouseId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Storages_Warehouses_WarehouseId",
                table: "Storages");

            migrationBuilder.DropIndex(
                name: "IX_Storages_WarehouseId",
                table: "Storages");

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "ad79c4df-74dd-4298-a1c8-212f4e390c42");

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "e0eb7f98-e9dd-48ef-b471-954f13ebda49");

            migrationBuilder.AlterColumn<string>(
                name: "WarehouseId",
                table: "Storages",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)");

            migrationBuilder.AddColumn<string>(
                name: "WarehousesWarehouseId",
                table: "Storages",
                type: "nvarchar(50)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "WarehouseId", "WarehouseAddress", "WarehouseName" },
                values: new object[] { "2fb6d98b-ec81-4cde-8f42-8fb294fc71ce", "Calle norte con occidente", "Bodega Norte" });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "WarehouseId", "WarehouseAddress", "WarehouseName" },
                values: new object[] { "310670a6-6f67-4d24-8286-51a61001b251", "Calle 8 con 23", "Bodega Central" });

            migrationBuilder.CreateIndex(
                name: "IX_Storages_WarehousesWarehouseId",
                table: "Storages",
                column: "WarehousesWarehouseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Storages_Warehouses_WarehousesWarehouseId",
                table: "Storages",
                column: "WarehousesWarehouseId",
                principalTable: "Warehouses",
                principalColumn: "WarehouseId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
