using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Library.Migrations
{
    /// <inheritdoc />
    public partial class AddedSuperUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0974122a-76f9-492f-a99f-8c13884e6886"), "Graphic Novels" },
                    { new Guid("2feaeb9f-6d7e-48d7-a822-e6287fb40c63"), "Thriller" },
                    { new Guid("3555b5af-1b48-4834-bf4d-9f0f4506c491"), "Young Adult" },
                    { new Guid("4f9aecb1-d99a-49c2-b74d-5ffd17f77e88"), "Science Fiction" },
                    { new Guid("673f0962-cbc8-42d9-bf70-d68494ecd66a"), "Historical Fiction" },
                    { new Guid("9988dac7-b6a8-4f6d-a47f-78f57e765970"), "Mystery" },
                    { new Guid("9d52853b-e718-4be1-a2d0-e232f5d57d36"), "Fantasy" },
                    { new Guid("a687bbac-9216-448c-a9e2-5da1b820f7bc"), "Romance" },
                    { new Guid("a969dc49-d8c5-4907-baab-aa72b4fbd193"), "Poetry" },
                    { new Guid("c0826288-0176-40ce-9d29-9ad1fb9fa809"), "Biography" },
                    { new Guid("cca4268d-5c5e-4ef0-8fce-cc37a1e633e0"), "Adventure" },
                    { new Guid("e1ac7b41-309a-471c-a939-363afc97b192"), "Children's Books" },
                    { new Guid("e53381c8-6d47-4702-bb82-b7ff2323161d"), "Non-Fiction" },
                    { new Guid("f1e7e51e-3a5e-4714-bf08-3477a121b9ca"), "Self - Help" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "PasswordHash", "PasswordSalt", "Username" },
                values: new object[] { new Guid("53a67e16-b115-452a-b0af-c6c0ca95c4c5"), "9cNjbwLa5KYruacYRycXxgRF/CjfHp4YDn+PBfO7kPjtUEoDN+rM5m6/AOTC49rw6j+m9UCGGCKrFpgMzzrjWA==", "xWHjjdhHjY7Up1TbNvu11FiN/UJfjru3Ax/piQlGPDcw5Yqiyb2Se+tdl3iu/aQV5417hLdPkdLcaFhVO2UYjQ==", "admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0974122a-76f9-492f-a99f-8c13884e6886"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2feaeb9f-6d7e-48d7-a822-e6287fb40c63"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3555b5af-1b48-4834-bf4d-9f0f4506c491"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4f9aecb1-d99a-49c2-b74d-5ffd17f77e88"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("673f0962-cbc8-42d9-bf70-d68494ecd66a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9988dac7-b6a8-4f6d-a47f-78f57e765970"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9d52853b-e718-4be1-a2d0-e232f5d57d36"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a687bbac-9216-448c-a9e2-5da1b820f7bc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a969dc49-d8c5-4907-baab-aa72b4fbd193"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c0826288-0176-40ce-9d29-9ad1fb9fa809"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cca4268d-5c5e-4ef0-8fce-cc37a1e633e0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e1ac7b41-309a-471c-a939-363afc97b192"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e53381c8-6d47-4702-bb82-b7ff2323161d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f1e7e51e-3a5e-4714-bf08-3477a121b9ca"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("53a67e16-b115-452a-b0af-c6c0ca95c4c5"));

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
    }
}
