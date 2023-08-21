using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HSTV_Api.Migrations
{
    /// <inheritdoc />
    public partial class M1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Amounts",
                columns: table => new
                {
                    AmountId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Offering_Given = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Amounts", x => x.AmountId);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    CountryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountryCode = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.CountryId);
                });

            migrationBuilder.CreateTable(
                name: "Subscribers",
                columns: table => new
                {
                    SubscriberId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Firstname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lastname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone_Number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kc_phone_number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Is_kc_confirmed = table.Column<bool>(type: "bit", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    Ip_address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Language = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Birthday_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Participants = table.Column<int>(type: "int", nullable: false),
                    ZoneId = table.Column<int>(type: "int", nullable: false),
                    FamilyId = table.Column<int>(type: "int", nullable: false),
                    Vc_Id = table.Column<int>(type: "int", nullable: false),
                    Login_time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CurrentTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Is_valid_email = table.Column<bool>(type: "bit", nullable: false),
                    Seen = table.Column<int>(type: "int", nullable: false),
                    Presubscribed = table.Column<int>(type: "int", nullable: false),
                    Gmfs_registered = table.Column<int>(type: "int", nullable: false),
                    Previous_student = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Financial_partner = table.Column<int>(type: "int", nullable: false),
                    Partner = table.Column<int>(type: "int", nullable: false),
                    Donation_categories = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Partner_regdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Translator = table.Column<int>(type: "int", nullable: false),
                    Httnlive = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Exhibition = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hsopc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hsopc_moved = table.Column<int>(type: "int", nullable: false),
                    Hslhs = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gdop = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ylw = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    View_lang = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Db_moved = table.Column<int>(type: "int", nullable: false),
                    Unsubscribed = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscribers", x => x.SubscriberId);
                    table.ForeignKey(
                        name: "FK_Subscribers_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Subscribers_CountryId",
                table: "Subscribers",
                column: "CountryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Amounts");

            migrationBuilder.DropTable(
                name: "Subscribers");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
