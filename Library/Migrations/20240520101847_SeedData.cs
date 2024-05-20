using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Library.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                table: "Books",
                columns: new[] { "Id", "Author", "Count", "Title", "Year" },
                values: new object[,]
                {
                    { new Guid("0b671bcc-40eb-441f-a828-e2a6227eccf9"), "Jane Austen", 12, "Pride and Prejudice", 1813 },
                    { new Guid("190acb3b-a3da-4850-bb81-3e3b9b549250"), "Yuval Noah Harari", 11, "Sapiens: A Brief History of Humankind", 2011 },
                    { new Guid("19ff0e8d-55df-499b-a87c-7e9764d50c72"), "Aldous Huxley", 10, "Brave New World", 1932 },
                    { new Guid("21d6ba4d-0564-43b2-9293-83dd5d4717ba"), "George Orwell", 15, "1984", 1949 },
                    { new Guid("2366f76a-0349-4fcf-a709-549f2a4800a7"), "J.R.R. Tolkien", 14, "The Hobbit", 1937 },
                    { new Guid("3faed062-a4b4-45d1-99f1-65efcc386be3"), "F. Scott Fitzgerald", 8, "The Great Gatsby", 1925 },
                    { new Guid("42a0d63a-5e6d-43d6-803d-134638384e92"), "Harper Lee", 10, "To Kill a Mockingbird", 1960 },
                    { new Guid("53542bb7-8eea-4061-9fb7-33c3df5ce77c"), "Leo Tolstoy", 7, "War and Peace", 1869 },
                    { new Guid("8d50cd9f-6c6e-4a9f-80b3-7af9b859e1a4"), "James Joyce", 4, "Ulysses", 1922 },
                    { new Guid("91c778a0-100d-4ecb-a047-e9ef7f6e39c2"), "Herman Melville", 5, "Moby-Dick", 1851 },
                    { new Guid("98c15ce1-a358-46ca-a071-eb4b7eac1ba9"), "Fyodor Dostoevsky", 6, "Crime and Punishment", 1866 },
                    { new Guid("a4c15cbe-b1e0-4eba-b70b-ad832f7d292d"), "Fyodor Dostoevsky", 8, "The Brothers Karamazov", 1880 },
                    { new Guid("d416e549-54ea-40ce-bc3f-a181339530b8"), "J.D. Salinger", 9, "The Catcher in the Rye", 1951 }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0f0148d3-67e3-4f84-b1be-3beb0c6dc13d"), "Fantasy" },
                    { new Guid("2190cec8-57b2-432e-8cc7-1713f3921848"), "Biography" },
                    { new Guid("25d39c10-8058-42e0-9dfc-65729221468a"), "Children's Books" },
                    { new Guid("3e8bcc48-e6f5-4cbc-9daf-d87c6092e8d5"), "Non-Fiction" },
                    { new Guid("3f462fbf-7051-48e5-9344-4d63e8f93177"), "Thriller" },
                    { new Guid("410f7dd9-2561-49db-8674-58123ed4f966"), "Graphic Novels" },
                    { new Guid("558407e5-f2ad-4adf-96f7-46cb21f0f9ad"), "Poetry" },
                    { new Guid("57ce5297-bdd7-4f7a-97b5-daf63201109a"), "Young Adult" },
                    { new Guid("5e60ded5-8916-463c-a394-ceb49dcc2ff0"), "Mystery" },
                    { new Guid("604c6170-234b-4eae-a3bc-07103caa06a1"), "Science Fiction" },
                    { new Guid("7d7f5b15-3643-448e-aff6-81735ec207a8"), "Adventure" },
                    { new Guid("a05881d5-cc79-40d1-a0ba-316cfaf2768b"), "Historical Fiction" },
                    { new Guid("d1dc20a5-81ec-42bf-bfb3-98fb8468257a"), "Self - Help" },
                    { new Guid("efcc8aa6-ef70-431f-a0ff-4769f8b6cd3f"), "Romance" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "PasswordHash", "PasswordSalt", "Username" },
                values: new object[,]
                {
                    { new Guid("33587ca1-f612-4eed-bf29-612b392ca62e"), "RvZfVzyCCb/taoPRSTaqL6JTQziAoc1FiiOg0Hv0q3v0JgfOtJm8r10ZgnUIhG7bqcMq33rc9bHnAXw5c5p71A==", "QSh9Y8uf1obiYNphf5Dq1Pb5zWCs/jiK1T0V7kyIhMEOSmLLiUUQlyqI2B1casXFn1dx/Y+SnPLUCk5LiEHW4Q==", "admin" },
                    { new Guid("37434f41-8df2-4e41-b575-a07e3ca25fac"), "EWPTwsqy+EAolDweAzSOWuz5vaLo7pZeSO+xow/14nojfETf04S3wO1fqxsrxwb3rEiyq56/dd011D2U3Y5MYw==", "SDhOjqpx2zNLOlTjzOf9ZOrWCe83JIO8SrxkAlI8RwjnIy+AfNas+ezCZV2Dpm+dbhOp/MPebWcvlyrVOHZGTw==", "user1" },
                    { new Guid("413ddc6a-212d-45ab-ae2a-100e8074a24a"), "gJhzAsejHP1OIgNdnAX3sueJMWhFPU5OktnT+DtsR9c2uDBstOUMztLhnhqWuO5bjIHMfUXp65m5rB/DQs7hMg==", "NTMBNQtgTrb/rOZtaNriTdsldmuI9VccKI0UjiGI5MHnuPo0vy3Lsg/uf6FaZ6+ipjmJfbdPus06NfakZO7GHw==", "user2" }
                });

            migrationBuilder.InsertData(
                table: "BookCategory",
                columns: new[] { "BooksId", "CategoriesId" },
                values: new object[,]
                {
                    { new Guid("0b671bcc-40eb-441f-a828-e2a6227eccf9"), new Guid("efcc8aa6-ef70-431f-a0ff-4769f8b6cd3f") },
                    { new Guid("190acb3b-a3da-4850-bb81-3e3b9b549250"), new Guid("3e8bcc48-e6f5-4cbc-9daf-d87c6092e8d5") },
                    { new Guid("19ff0e8d-55df-499b-a87c-7e9764d50c72"), new Guid("604c6170-234b-4eae-a3bc-07103caa06a1") },
                    { new Guid("21d6ba4d-0564-43b2-9293-83dd5d4717ba"), new Guid("3f462fbf-7051-48e5-9344-4d63e8f93177") },
                    { new Guid("21d6ba4d-0564-43b2-9293-83dd5d4717ba"), new Guid("604c6170-234b-4eae-a3bc-07103caa06a1") },
                    { new Guid("2366f76a-0349-4fcf-a709-549f2a4800a7"), new Guid("0f0148d3-67e3-4f84-b1be-3beb0c6dc13d") },
                    { new Guid("2366f76a-0349-4fcf-a709-549f2a4800a7"), new Guid("7d7f5b15-3643-448e-aff6-81735ec207a8") },
                    { new Guid("3faed062-a4b4-45d1-99f1-65efcc386be3"), new Guid("efcc8aa6-ef70-431f-a0ff-4769f8b6cd3f") },
                    { new Guid("42a0d63a-5e6d-43d6-803d-134638384e92"), new Guid("a05881d5-cc79-40d1-a0ba-316cfaf2768b") },
                    { new Guid("42a0d63a-5e6d-43d6-803d-134638384e92"), new Guid("efcc8aa6-ef70-431f-a0ff-4769f8b6cd3f") },
                    { new Guid("53542bb7-8eea-4061-9fb7-33c3df5ce77c"), new Guid("a05881d5-cc79-40d1-a0ba-316cfaf2768b") },
                    { new Guid("8d50cd9f-6c6e-4a9f-80b3-7af9b859e1a4"), new Guid("57ce5297-bdd7-4f7a-97b5-daf63201109a") },
                    { new Guid("91c778a0-100d-4ecb-a047-e9ef7f6e39c2"), new Guid("7d7f5b15-3643-448e-aff6-81735ec207a8") },
                    { new Guid("98c15ce1-a358-46ca-a071-eb4b7eac1ba9"), new Guid("3f462fbf-7051-48e5-9344-4d63e8f93177") },
                    { new Guid("a4c15cbe-b1e0-4eba-b70b-ad832f7d292d"), new Guid("57ce5297-bdd7-4f7a-97b5-daf63201109a") },
                    { new Guid("d416e549-54ea-40ce-bc3f-a181339530b8"), new Guid("57ce5297-bdd7-4f7a-97b5-daf63201109a") }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Assessment", "BookId", "Comment", "UserId" },
                values: new object[,]
                {
                    { new Guid("0091eba6-59d9-4c9e-aa26-11c524295c60"), "5", new Guid("d416e549-54ea-40ce-bc3f-a181339530b8"), "So good!", new Guid("413ddc6a-212d-45ab-ae2a-100e8074a24a") },
                    { new Guid("0e43412d-62c3-44ba-a69f-a6cdd73459f9"), "4", new Guid("21d6ba4d-0564-43b2-9293-83dd5d4717ba"), "A timeless classic!", new Guid("37434f41-8df2-4e41-b575-a07e3ca25fac") },
                    { new Guid("67d85093-28c8-4306-84b2-9b001f1702d2"), "5", new Guid("0b671bcc-40eb-441f-a828-e2a6227eccf9"), "Amazing!", new Guid("37434f41-8df2-4e41-b575-a07e3ca25fac") },
                    { new Guid("7e8e49dc-0667-40e3-a55f-93a26db9be8a"), "5", new Guid("0b671bcc-40eb-441f-a828-e2a6227eccf9"), "Really liked it!", new Guid("413ddc6a-212d-45ab-ae2a-100e8074a24a") },
                    { new Guid("842b2707-a827-4e79-bd11-596f5109ffda"), "4", new Guid("3faed062-a4b4-45d1-99f1-65efcc386be3"), "Highly recommend!", new Guid("37434f41-8df2-4e41-b575-a07e3ca25fac") },
                    { new Guid("a85d779a-843a-4d6d-a19a-b683e09868f7"), "4", new Guid("3faed062-a4b4-45d1-99f1-65efcc386be3"), "A must-read!", new Guid("413ddc6a-212d-45ab-ae2a-100e8074a24a") },
                    { new Guid("cfde827e-df3b-4068-b83b-4cd5b825b9ca"), "5", new Guid("42a0d63a-5e6d-43d6-803d-134638384e92"), "A masterpiece!", new Guid("413ddc6a-212d-45ab-ae2a-100e8074a24a") },
                    { new Guid("d1aaa52a-67b8-450c-a125-cebe89cc940f"), "5", new Guid("42a0d63a-5e6d-43d6-803d-134638384e92"), "Best book I have ever read!", new Guid("37434f41-8df2-4e41-b575-a07e3ca25fac") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BookCategory",
                keyColumns: new[] { "BooksId", "CategoriesId" },
                keyValues: new object[] { new Guid("0b671bcc-40eb-441f-a828-e2a6227eccf9"), new Guid("efcc8aa6-ef70-431f-a0ff-4769f8b6cd3f") });

            migrationBuilder.DeleteData(
                table: "BookCategory",
                keyColumns: new[] { "BooksId", "CategoriesId" },
                keyValues: new object[] { new Guid("190acb3b-a3da-4850-bb81-3e3b9b549250"), new Guid("3e8bcc48-e6f5-4cbc-9daf-d87c6092e8d5") });

            migrationBuilder.DeleteData(
                table: "BookCategory",
                keyColumns: new[] { "BooksId", "CategoriesId" },
                keyValues: new object[] { new Guid("19ff0e8d-55df-499b-a87c-7e9764d50c72"), new Guid("604c6170-234b-4eae-a3bc-07103caa06a1") });

            migrationBuilder.DeleteData(
                table: "BookCategory",
                keyColumns: new[] { "BooksId", "CategoriesId" },
                keyValues: new object[] { new Guid("21d6ba4d-0564-43b2-9293-83dd5d4717ba"), new Guid("3f462fbf-7051-48e5-9344-4d63e8f93177") });

            migrationBuilder.DeleteData(
                table: "BookCategory",
                keyColumns: new[] { "BooksId", "CategoriesId" },
                keyValues: new object[] { new Guid("21d6ba4d-0564-43b2-9293-83dd5d4717ba"), new Guid("604c6170-234b-4eae-a3bc-07103caa06a1") });

            migrationBuilder.DeleteData(
                table: "BookCategory",
                keyColumns: new[] { "BooksId", "CategoriesId" },
                keyValues: new object[] { new Guid("2366f76a-0349-4fcf-a709-549f2a4800a7"), new Guid("0f0148d3-67e3-4f84-b1be-3beb0c6dc13d") });

            migrationBuilder.DeleteData(
                table: "BookCategory",
                keyColumns: new[] { "BooksId", "CategoriesId" },
                keyValues: new object[] { new Guid("2366f76a-0349-4fcf-a709-549f2a4800a7"), new Guid("7d7f5b15-3643-448e-aff6-81735ec207a8") });

            migrationBuilder.DeleteData(
                table: "BookCategory",
                keyColumns: new[] { "BooksId", "CategoriesId" },
                keyValues: new object[] { new Guid("3faed062-a4b4-45d1-99f1-65efcc386be3"), new Guid("efcc8aa6-ef70-431f-a0ff-4769f8b6cd3f") });

            migrationBuilder.DeleteData(
                table: "BookCategory",
                keyColumns: new[] { "BooksId", "CategoriesId" },
                keyValues: new object[] { new Guid("42a0d63a-5e6d-43d6-803d-134638384e92"), new Guid("a05881d5-cc79-40d1-a0ba-316cfaf2768b") });

            migrationBuilder.DeleteData(
                table: "BookCategory",
                keyColumns: new[] { "BooksId", "CategoriesId" },
                keyValues: new object[] { new Guid("42a0d63a-5e6d-43d6-803d-134638384e92"), new Guid("efcc8aa6-ef70-431f-a0ff-4769f8b6cd3f") });

            migrationBuilder.DeleteData(
                table: "BookCategory",
                keyColumns: new[] { "BooksId", "CategoriesId" },
                keyValues: new object[] { new Guid("53542bb7-8eea-4061-9fb7-33c3df5ce77c"), new Guid("a05881d5-cc79-40d1-a0ba-316cfaf2768b") });

            migrationBuilder.DeleteData(
                table: "BookCategory",
                keyColumns: new[] { "BooksId", "CategoriesId" },
                keyValues: new object[] { new Guid("8d50cd9f-6c6e-4a9f-80b3-7af9b859e1a4"), new Guid("57ce5297-bdd7-4f7a-97b5-daf63201109a") });

            migrationBuilder.DeleteData(
                table: "BookCategory",
                keyColumns: new[] { "BooksId", "CategoriesId" },
                keyValues: new object[] { new Guid("91c778a0-100d-4ecb-a047-e9ef7f6e39c2"), new Guid("7d7f5b15-3643-448e-aff6-81735ec207a8") });

            migrationBuilder.DeleteData(
                table: "BookCategory",
                keyColumns: new[] { "BooksId", "CategoriesId" },
                keyValues: new object[] { new Guid("98c15ce1-a358-46ca-a071-eb4b7eac1ba9"), new Guid("3f462fbf-7051-48e5-9344-4d63e8f93177") });

            migrationBuilder.DeleteData(
                table: "BookCategory",
                keyColumns: new[] { "BooksId", "CategoriesId" },
                keyValues: new object[] { new Guid("a4c15cbe-b1e0-4eba-b70b-ad832f7d292d"), new Guid("57ce5297-bdd7-4f7a-97b5-daf63201109a") });

            migrationBuilder.DeleteData(
                table: "BookCategory",
                keyColumns: new[] { "BooksId", "CategoriesId" },
                keyValues: new object[] { new Guid("d416e549-54ea-40ce-bc3f-a181339530b8"), new Guid("57ce5297-bdd7-4f7a-97b5-daf63201109a") });

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2190cec8-57b2-432e-8cc7-1713f3921848"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("25d39c10-8058-42e0-9dfc-65729221468a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("410f7dd9-2561-49db-8674-58123ed4f966"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("558407e5-f2ad-4adf-96f7-46cb21f0f9ad"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5e60ded5-8916-463c-a394-ceb49dcc2ff0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d1dc20a5-81ec-42bf-bfb3-98fb8468257a"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("0091eba6-59d9-4c9e-aa26-11c524295c60"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("0e43412d-62c3-44ba-a69f-a6cdd73459f9"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("67d85093-28c8-4306-84b2-9b001f1702d2"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("7e8e49dc-0667-40e3-a55f-93a26db9be8a"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("842b2707-a827-4e79-bd11-596f5109ffda"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("a85d779a-843a-4d6d-a19a-b683e09868f7"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("cfde827e-df3b-4068-b83b-4cd5b825b9ca"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("d1aaa52a-67b8-450c-a125-cebe89cc940f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33587ca1-f612-4eed-bf29-612b392ca62e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0b671bcc-40eb-441f-a828-e2a6227eccf9"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("190acb3b-a3da-4850-bb81-3e3b9b549250"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("19ff0e8d-55df-499b-a87c-7e9764d50c72"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("21d6ba4d-0564-43b2-9293-83dd5d4717ba"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2366f76a-0349-4fcf-a709-549f2a4800a7"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("3faed062-a4b4-45d1-99f1-65efcc386be3"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("42a0d63a-5e6d-43d6-803d-134638384e92"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("53542bb7-8eea-4061-9fb7-33c3df5ce77c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("8d50cd9f-6c6e-4a9f-80b3-7af9b859e1a4"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("91c778a0-100d-4ecb-a047-e9ef7f6e39c2"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("98c15ce1-a358-46ca-a071-eb4b7eac1ba9"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a4c15cbe-b1e0-4eba-b70b-ad832f7d292d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d416e549-54ea-40ce-bc3f-a181339530b8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0f0148d3-67e3-4f84-b1be-3beb0c6dc13d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3e8bcc48-e6f5-4cbc-9daf-d87c6092e8d5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3f462fbf-7051-48e5-9344-4d63e8f93177"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("57ce5297-bdd7-4f7a-97b5-daf63201109a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("604c6170-234b-4eae-a3bc-07103caa06a1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7d7f5b15-3643-448e-aff6-81735ec207a8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a05881d5-cc79-40d1-a0ba-316cfaf2768b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("efcc8aa6-ef70-431f-a0ff-4769f8b6cd3f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("37434f41-8df2-4e41-b575-a07e3ca25fac"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("413ddc6a-212d-45ab-ae2a-100e8074a24a"));

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
    }
}
