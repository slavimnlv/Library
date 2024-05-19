using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Library.Migrations
{
    /// <inheritdoc />
    public partial class AddCategoriesSeeder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("1a6766c9-5a5c-4ef8-8c39-d0100ea28bbb"), "Fantasy" },
                    { new Guid("1f6521dd-7582-4b51-93af-60e9e106a349"), "Science Fiction" },
                    { new Guid("2d07f3fd-1265-4fa3-9d93-c701ce16bbf7"), "Thriller" },
                    { new Guid("369085a3-4397-4c18-a10f-c365c2e763b4"), "Biography" },
                    { new Guid("39456098-aa40-4285-800f-db1fa68f4f9e"), "Non-Fiction" },
                    { new Guid("407fdec1-46e8-48cf-936f-e0855f063d48"), "Poetry" },
                    { new Guid("4af98cd0-38b3-4f95-97ae-bd479059ffb5"), "Young Adult" },
                    { new Guid("9addd4ab-0e79-4326-8ec0-0bfacaeacfcd"), "Historical Fiction" },
                    { new Guid("a9481404-28cd-48ba-bf85-4c36aaedc356"), "Mystery" },
                    { new Guid("b5b2a224-b6b4-4abe-869d-eb98128ef2d3"), "Graphic Novels" },
                    { new Guid("ca11f830-5067-4cef-8a90-7936b3bcf5fb"), "Self - Help" },
                    { new Guid("e0a196d6-3c04-41af-b8d4-6b9b6e1cd203"), "Children's Books" },
                    { new Guid("e9957962-4853-4504-98b0-77e10dfa71b4"), "Romance" },
                    { new Guid("efe99c6c-da21-4400-b652-1819129e30e6"), "Adventure" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1a6766c9-5a5c-4ef8-8c39-d0100ea28bbb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1f6521dd-7582-4b51-93af-60e9e106a349"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2d07f3fd-1265-4fa3-9d93-c701ce16bbf7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("369085a3-4397-4c18-a10f-c365c2e763b4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("39456098-aa40-4285-800f-db1fa68f4f9e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("407fdec1-46e8-48cf-936f-e0855f063d48"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4af98cd0-38b3-4f95-97ae-bd479059ffb5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9addd4ab-0e79-4326-8ec0-0bfacaeacfcd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a9481404-28cd-48ba-bf85-4c36aaedc356"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b5b2a224-b6b4-4abe-869d-eb98128ef2d3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ca11f830-5067-4cef-8a90-7936b3bcf5fb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e0a196d6-3c04-41af-b8d4-6b9b6e1cd203"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e9957962-4853-4504-98b0-77e10dfa71b4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("efe99c6c-da21-4400-b652-1819129e30e6"));
        }
    }
}
