using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api.Migrations
{
    /// <inheritdoc />
    public partial class reservations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_RestaurantTable",
                table: "RestaurantTable");

            migrationBuilder.RenameTable(
                name: "RestaurantTable",
                newName: "RestaurantTables");

            migrationBuilder.RenameColumn(
                name: "SeatNumber",
                table: "RestaurantTables",
                newName: "TableNumber");

            migrationBuilder.RenameColumn(
                name: "IsReservate",
                table: "RestaurantTables",
                newName: "HasReservation");

            migrationBuilder.AddColumn<int>(
                name: "SeatCount",
                table: "RestaurantTables",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_RestaurantTables",
                table: "RestaurantTables",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "TableReservations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ClientName = table.Column<string>(type: "text", nullable: false),
                    TableId = table.Column<Guid>(type: "uuid", nullable: false),
                    StartTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EndTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TableReservations", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TableReservations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RestaurantTables",
                table: "RestaurantTables");

            migrationBuilder.DropColumn(
                name: "SeatCount",
                table: "RestaurantTables");

            migrationBuilder.RenameTable(
                name: "RestaurantTables",
                newName: "RestaurantTable");

            migrationBuilder.RenameColumn(
                name: "TableNumber",
                table: "RestaurantTable",
                newName: "SeatNumber");

            migrationBuilder.RenameColumn(
                name: "HasReservation",
                table: "RestaurantTable",
                newName: "IsReservate");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RestaurantTable",
                table: "RestaurantTable",
                column: "Id");
        }
    }
}
