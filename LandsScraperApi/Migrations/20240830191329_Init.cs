using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LandsScraperApi.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Lands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    County = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Origin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAtMonth = table.Column<int>(type: "int", nullable: false),
                    CreatedAtYear = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<float>(type: "real", nullable: false),
                    PricePerAcre = table.Column<float>(type: "real", nullable: false),
                    Area = table.Column<float>(type: "real", nullable: false),
                    Acre = table.Column<float>(type: "real", nullable: false),
                    Bedrooms = table.Column<int>(type: "int", nullable: false),
                    Bathrooms = table.Column<int>(type: "int", nullable: false),
                    Electricity = table.Column<bool>(type: "bit", nullable: false),
                    Waterfront = table.Column<bool>(type: "bit", nullable: false),
                    Mineral = table.Column<bool>(type: "bit", nullable: false),
                    Well = table.Column<bool>(type: "bit", nullable: false),
                    AgExempt = table.Column<bool>(type: "bit", nullable: false),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lands", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lands");
        }
    }
}
