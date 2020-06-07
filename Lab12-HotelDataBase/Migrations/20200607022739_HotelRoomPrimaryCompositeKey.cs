using Microsoft.EntityFrameworkCore.Migrations;

namespace Lab12_HotelDataBase.Migrations
{
    public partial class HotelRoomPrimaryCompositeKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Amenities_Rooms_RoomId",
                table: "Amenities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HotelRooms",
                table: "HotelRooms");

            migrationBuilder.DropIndex(
                name: "IX_Amenities_RoomId",
                table: "Amenities");

            migrationBuilder.DropColumn(
                name: "RoomId",
                table: "Amenities");

            migrationBuilder.AlterColumn<decimal>(
                name: "Rate",
                table: "HotelRooms",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HotelRooms",
                table: "HotelRooms",
                columns: new[] { "HotelId", "RoomNumber" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_HotelRooms",
                table: "HotelRooms");

            migrationBuilder.AlterColumn<decimal>(
                name: "Rate",
                table: "HotelRooms",
                type: "decimal(18,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<int>(
                name: "RoomId",
                table: "Amenities",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_HotelRooms",
                table: "HotelRooms",
                columns: new[] { "HotelId", "RoomId" });

            migrationBuilder.CreateIndex(
                name: "IX_Amenities_RoomId",
                table: "Amenities",
                column: "RoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_Amenities_Rooms_RoomId",
                table: "Amenities",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
