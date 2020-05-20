using Microsoft.EntityFrameworkCore.Migrations;

namespace Lab12_HotelDataBase.Migrations
{
    public partial class AddedNavProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_RoomAmenities_RoomId",
                table: "RoomAmenities");

            migrationBuilder.DropIndex(
                name: "IX_HotelRooms_RoomId",
                table: "HotelRooms");

            migrationBuilder.AlterColumn<decimal>(
                name: "Rate",
                table: "HotelRooms",
                type: "decimal(18,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.CreateIndex(
                name: "IX_RoomAmenities_RoomId",
                table: "RoomAmenities",
                column: "RoomId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HotelRooms_HotelId",
                table: "HotelRooms",
                column: "HotelId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HotelRooms_RoomId",
                table: "HotelRooms",
                column: "RoomId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_RoomAmenities_RoomId",
                table: "RoomAmenities");

            migrationBuilder.DropIndex(
                name: "IX_HotelRooms_HotelId",
                table: "HotelRooms");

            migrationBuilder.DropIndex(
                name: "IX_HotelRooms_RoomId",
                table: "HotelRooms");

            migrationBuilder.AlterColumn<decimal>(
                name: "Rate",
                table: "HotelRooms",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)");

            migrationBuilder.CreateIndex(
                name: "IX_RoomAmenities_RoomId",
                table: "RoomAmenities",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_HotelRooms_RoomId",
                table: "HotelRooms",
                column: "RoomId");
        }
    }
}
