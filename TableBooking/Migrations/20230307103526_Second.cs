using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TableBooking.Migrations
{
    /// <inheritdoc />
    public partial class Second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateTimeBooked",
                table: "Tables",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "GuestEmail",
                table: "Tables",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GuestName",
                table: "Tables",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateTimeBooked", "GuestEmail", "GuestName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateTimeBooked", "GuestEmail", "GuestName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateTimeBooked", "GuestEmail", "GuestName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateTimeBooked", "GuestEmail", "GuestName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateTimeBooked", "GuestEmail", "GuestName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateTimeBooked", "GuestEmail", "GuestName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateTimeBooked",
                table: "Tables");

            migrationBuilder.DropColumn(
                name: "GuestEmail",
                table: "Tables");

            migrationBuilder.DropColumn(
                name: "GuestName",
                table: "Tables");
        }
    }
}
