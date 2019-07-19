using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelSample.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hotel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    Description = table.Column<string>(unicode: false, maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HotelContactType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelContactType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoomType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TypeName = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    EmailAddress = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Password = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HotelAddress",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    HotelId = table.Column<int>(nullable: true),
                    AddressText = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    CityId = table.Column<int>(nullable: true),
                    PostalCode = table.Column<string>(unicode: false, maxLength: 5, nullable: true),
                    LocationLatitude = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    LocationLongtitude = table.Column<string>(unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelAddress", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HotelAddress_Hotel",
                        column: x => x.HotelId,
                        principalTable: "Hotel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HotelImage",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    HotelId = table.Column<int>(nullable: true),
                    ImagePath = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Description = table.Column<string>(unicode: false, maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelImage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HotelImage_Hotel",
                        column: x => x.HotelId,
                        principalTable: "Hotel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HotelScore",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    HotelId = table.Column<int>(nullable: true),
                    HotelScoreTypeId = table.Column<int>(nullable: true),
                    ScoreValue = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelScore", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HotelScore_Hotel",
                        column: x => x.HotelId,
                        principalTable: "Hotel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HotelContact",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    HotelId = table.Column<int>(nullable: false),
                    ContactValue = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    HotelContactTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelContact", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HotelContact_HotelContactType",
                        column: x => x.HotelContactTypeId,
                        principalTable: "HotelContactType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HotelContact_Hotel",
                        column: x => x.HotelId,
                        principalTable: "Hotel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HotelRoom",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    HotelId = table.Column<int>(nullable: true),
                    RoomTypeId = table.Column<int>(nullable: true),
                    RoomSummary = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    RoomDetail = table.Column<string>(unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelRoom", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HotelRoom_Hotel",
                        column: x => x.HotelId,
                        principalTable: "Hotel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HotelRoom_RoomType",
                        column: x => x.RoomTypeId,
                        principalTable: "RoomType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HotelComment",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    HotelId = table.Column<int>(nullable: true),
                    UserId = table.Column<int>(nullable: true),
                    Comment = table.Column<string>(unicode: false, maxLength: 1000, nullable: true),
                    Score = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelComment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HotelComment_Hotel",
                        column: x => x.HotelId,
                        principalTable: "Hotel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HotelComment_User",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HotelRoomPrice",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    HotelRoomId = table.Column<int>(nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Price = table.Column<decimal>(type: "money", nullable: true),
                    IsAvailable = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelRoomPrice", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HotelRoomPrice_HotelRoom",
                        column: x => x.HotelRoomId,
                        principalTable: "HotelRoom",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HotelAddress_HotelId",
                table: "HotelAddress",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_HotelComment_HotelId",
                table: "HotelComment",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_HotelComment_UserId",
                table: "HotelComment",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_HotelContact_HotelContactTypeId",
                table: "HotelContact",
                column: "HotelContactTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_HotelContact_HotelId",
                table: "HotelContact",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_HotelImage_HotelId",
                table: "HotelImage",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_HotelRoom_HotelId",
                table: "HotelRoom",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_HotelRoom_RoomTypeId",
                table: "HotelRoom",
                column: "RoomTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_HotelRoomPrice_HotelRoomId",
                table: "HotelRoomPrice",
                column: "HotelRoomId");

            migrationBuilder.CreateIndex(
                name: "IX_HotelScore_HotelId",
                table: "HotelScore",
                column: "HotelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HotelAddress");

            migrationBuilder.DropTable(
                name: "HotelComment");

            migrationBuilder.DropTable(
                name: "HotelContact");

            migrationBuilder.DropTable(
                name: "HotelImage");

            migrationBuilder.DropTable(
                name: "HotelRoomPrice");

            migrationBuilder.DropTable(
                name: "HotelScore");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "HotelContactType");

            migrationBuilder.DropTable(
                name: "HotelRoom");

            migrationBuilder.DropTable(
                name: "Hotel");

            migrationBuilder.DropTable(
                name: "RoomType");
        }
    }
}
