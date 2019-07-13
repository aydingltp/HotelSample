using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelSample.Migrations
{
    public partial class MyFirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HotelContents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RoomTypes",
                table: "RoomTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HotelScores",
                table: "HotelScores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Hotels",
                table: "Hotels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HotelRooms",
                table: "HotelRooms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HotelRoomPrices",
                table: "HotelRoomPrices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HotelImages",
                table: "HotelImages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HotelContactTypes",
                table: "HotelContactTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HotelComments",
                table: "HotelComments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HotelAddresses",
                table: "HotelAddresses");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "User");

            migrationBuilder.RenameTable(
                name: "RoomTypes",
                newName: "RoomType");

            migrationBuilder.RenameTable(
                name: "HotelScores",
                newName: "HotelScore");

            migrationBuilder.RenameTable(
                name: "Hotels",
                newName: "Hotel");

            migrationBuilder.RenameTable(
                name: "HotelRooms",
                newName: "HotelRoom");

            migrationBuilder.RenameTable(
                name: "HotelRoomPrices",
                newName: "HotelRoomPrice");

            migrationBuilder.RenameTable(
                name: "HotelImages",
                newName: "HotelImage");

            migrationBuilder.RenameTable(
                name: "HotelContactTypes",
                newName: "HotelContactType");

            migrationBuilder.RenameTable(
                name: "HotelComments",
                newName: "HotelComment");

            migrationBuilder.RenameTable(
                name: "HotelAddresses",
                newName: "HotelAddress");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RoomType",
                table: "RoomType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HotelScore",
                table: "HotelScore",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Hotel",
                table: "Hotel",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HotelRoom",
                table: "HotelRoom",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HotelRoomPrice",
                table: "HotelRoomPrice",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HotelImage",
                table: "HotelImage",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HotelContactType",
                table: "HotelContactType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HotelComment",
                table: "HotelComment",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HotelAddress",
                table: "HotelAddress",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "HotelContent",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    HotelId = table.Column<int>(nullable: false),
                    ContactValue = table.Column<string>(nullable: true),
                    HotelContactTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelContent", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HotelContent");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RoomType",
                table: "RoomType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HotelScore",
                table: "HotelScore");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HotelRoomPrice",
                table: "HotelRoomPrice");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HotelRoom",
                table: "HotelRoom");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HotelImage",
                table: "HotelImage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HotelContactType",
                table: "HotelContactType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HotelComment",
                table: "HotelComment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HotelAddress",
                table: "HotelAddress");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Hotel",
                table: "Hotel");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "RoomType",
                newName: "RoomTypes");

            migrationBuilder.RenameTable(
                name: "HotelScore",
                newName: "HotelScores");

            migrationBuilder.RenameTable(
                name: "HotelRoomPrice",
                newName: "HotelRoomPrices");

            migrationBuilder.RenameTable(
                name: "HotelRoom",
                newName: "HotelRooms");

            migrationBuilder.RenameTable(
                name: "HotelImage",
                newName: "HotelImages");

            migrationBuilder.RenameTable(
                name: "HotelContactType",
                newName: "HotelContactTypes");

            migrationBuilder.RenameTable(
                name: "HotelComment",
                newName: "HotelComments");

            migrationBuilder.RenameTable(
                name: "HotelAddress",
                newName: "HotelAddresses");

            migrationBuilder.RenameTable(
                name: "Hotel",
                newName: "Hotels");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RoomTypes",
                table: "RoomTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HotelScores",
                table: "HotelScores",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HotelRoomPrices",
                table: "HotelRoomPrices",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HotelRooms",
                table: "HotelRooms",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HotelImages",
                table: "HotelImages",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HotelContactTypes",
                table: "HotelContactTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HotelComments",
                table: "HotelComments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HotelAddresses",
                table: "HotelAddresses",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Hotels",
                table: "Hotels",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "HotelContents",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ContactValue = table.Column<string>(nullable: true),
                    HotelContactTypeId = table.Column<int>(nullable: false),
                    HotelId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelContents", x => x.Id);
                });
        }
    }
}
