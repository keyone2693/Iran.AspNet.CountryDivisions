using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Iran.CountryDivisions.AspNet.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abadis",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    AbadiType = table.Column<string>(type: "TEXT", nullable: true),
                    AmarCode = table.Column<string>(type: "TEXT", nullable: true),
                    BakhshId = table.Column<string>(type: "TEXT", nullable: true),
                    DehestanId = table.Column<string>(type: "TEXT", nullable: true),
                    Diag = table.Column<string>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    OstanId = table.Column<string>(type: "TEXT", nullable: true),
                    ShahrestanId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abadis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bakhshs",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    AmarCode = table.Column<string>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    OstanId = table.Column<string>(type: "TEXT", nullable: true),
                    ShahrestanId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bakhshs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dehestans",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    AmarCode = table.Column<string>(type: "TEXT", nullable: true),
                    BakhshId = table.Column<string>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    OstanId = table.Column<string>(type: "TEXT", nullable: true),
                    ShahrestanId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dehestans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ostans",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    AmarCode = table.Column<string>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ostans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Shahrestans",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    AmarCode = table.Column<string>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    OstanId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shahrestans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Shahrs",
                columns: table => new
                {
                    id = table.Column<string>(type: "TEXT", nullable: false),
                    AmarCode = table.Column<string>(type: "TEXT", nullable: true),
                    BakhshId = table.Column<string>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    OstanId = table.Column<string>(type: "TEXT", nullable: true),
                    ShahrType = table.Column<string>(type: "TEXT", nullable: true),
                    ShahrestanId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shahrs", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abadis");

            migrationBuilder.DropTable(
                name: "Bakhshs");

            migrationBuilder.DropTable(
                name: "Dehestans");

            migrationBuilder.DropTable(
                name: "Ostans");

            migrationBuilder.DropTable(
                name: "Shahrestans");

            migrationBuilder.DropTable(
                name: "Shahrs");
        }
    }
}
