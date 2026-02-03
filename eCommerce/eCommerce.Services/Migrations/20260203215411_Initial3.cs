using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace eCommerce.Services.Migrations
{
    /// <inheritdoc />
    public partial class Initial3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 21, 54, 11, 740, DateTimeKind.Utc).AddTicks(4151));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 21, 54, 11, 740, DateTimeKind.Utc).AddTicks(4179));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 21, 54, 11, 740, DateTimeKind.Utc).AddTicks(4213));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 21, 54, 11, 740, DateTimeKind.Utc).AddTicks(4241));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 21, 54, 11, 740, DateTimeKind.Utc).AddTicks(4269));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 21, 54, 11, 740, DateTimeKind.Utc).AddTicks(4298));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 21, 54, 11, 740, DateTimeKind.Utc).AddTicks(4327));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 21, 54, 11, 740, DateTimeKind.Utc).AddTicks(4351));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 21, 54, 11, 740, DateTimeKind.Utc).AddTicks(4380));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 21, 54, 11, 740, DateTimeKind.Utc).AddTicks(4409));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedAt",
                value: new DateTime(2026, 2, 3, 21, 54, 11, 740, DateTimeKind.Utc).AddTicks(4676));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedAt",
                value: new DateTime(2026, 2, 3, 21, 54, 11, 740, DateTimeKind.Utc).AddTicks(4705));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 21, 54, 11, 740, DateTimeKind.Utc).AddTicks(4584));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 21, 54, 11, 740, DateTimeKind.Utc).AddTicks(4613));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 21, 54, 11, 740, DateTimeKind.Utc).AddTicks(3104));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 21, 54, 11, 740, DateTimeKind.Utc).AddTicks(3137));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 21, 54, 11, 740, DateTimeKind.Utc).AddTicks(3171));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 21, 54, 11, 740, DateTimeKind.Utc).AddTicks(3203));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2026, 2, 3, 21, 54, 11, 740, DateTimeKind.Utc).AddTicks(4762));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2026, 2, 3, 21, 54, 11, 740, DateTimeKind.Utc).AddTicks(4799));

            migrationBuilder.InsertData(
                table: "ProductDiscountIB200116s",
                columns: new[] { "Id", "BeganAt", "Discount", "ProductId", "ValidUntil" },
                values: new object[,]
                {
                    { 3, new DateTime(2026, 2, 3, 21, 54, 11, 740, DateTimeKind.Utc).AddTicks(4942), 0.15m, 1, new DateTime(2026, 3, 5, 21, 54, 11, 740, DateTimeKind.Utc).AddTicks(4961) },
                    { 4, new DateTime(2026, 2, 3, 21, 54, 11, 740, DateTimeKind.Utc).AddTicks(4981), 0.20m, 3, new DateTime(2026, 3, 5, 21, 54, 11, 740, DateTimeKind.Utc).AddTicks(4996) },
                    { 5, new DateTime(2026, 2, 3, 21, 54, 11, 740, DateTimeKind.Utc).AddTicks(5014), 0.59m, 2, new DateTime(2026, 3, 5, 21, 54, 11, 740, DateTimeKind.Utc).AddTicks(5029) }
                });

            migrationBuilder.UpdateData(
                table: "ProductReviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 21, 54, 11, 740, DateTimeKind.Utc).AddTicks(4503));

            migrationBuilder.UpdateData(
                table: "ProductReviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 21, 54, 11, 740, DateTimeKind.Utc).AddTicks(4533));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 21, 54, 11, 740, DateTimeKind.Utc).AddTicks(3363));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 21, 54, 11, 740, DateTimeKind.Utc).AddTicks(3397));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 21, 54, 11, 740, DateTimeKind.Utc).AddTicks(3736));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 21, 54, 11, 740, DateTimeKind.Utc).AddTicks(3775));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 21, 54, 11, 740, DateTimeKind.Utc).AddTicks(3808));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 21, 54, 11, 740, DateTimeKind.Utc).AddTicks(3841));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 21, 54, 11, 740, DateTimeKind.Utc).AddTicks(3875));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 21, 54, 11, 740, DateTimeKind.Utc).AddTicks(3907));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 21, 54, 11, 740, DateTimeKind.Utc).AddTicks(3940));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 21, 54, 11, 740, DateTimeKind.Utc).AddTicks(3974));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 21, 54, 11, 740, DateTimeKind.Utc).AddTicks(4007));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 21, 54, 11, 740, DateTimeKind.Utc).AddTicks(4085));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 21, 54, 11, 740, DateTimeKind.Utc).AddTicks(3542));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 21, 54, 11, 740, DateTimeKind.Utc).AddTicks(3574));

            migrationBuilder.UpdateData(
                table: "UnitsOfMeasure",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 21, 54, 11, 740, DateTimeKind.Utc).AddTicks(3456));

            migrationBuilder.UpdateData(
                table: "UnitsOfMeasure",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 21, 54, 11, 740, DateTimeKind.Utc).AddTicks(3484));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAssigned",
                value: new DateTime(2026, 2, 3, 21, 54, 11, 740, DateTimeKind.Utc).AddTicks(4875));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAssigned",
                value: new DateTime(2026, 2, 3, 21, 54, 11, 740, DateTimeKind.Utc).AddTicks(4909));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 21, 54, 11, 740, DateTimeKind.Utc).AddTicks(3635));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 21, 54, 11, 740, DateTimeKind.Utc).AddTicks(3669));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductDiscountIB200116s",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductDiscountIB200116s",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductDiscountIB200116s",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 18, 19, 47, 328, DateTimeKind.Utc).AddTicks(6351));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 18, 19, 47, 328, DateTimeKind.Utc).AddTicks(6379));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 18, 19, 47, 328, DateTimeKind.Utc).AddTicks(6412));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 18, 19, 47, 328, DateTimeKind.Utc).AddTicks(6440));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 18, 19, 47, 328, DateTimeKind.Utc).AddTicks(6469));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 18, 19, 47, 328, DateTimeKind.Utc).AddTicks(6497));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 18, 19, 47, 328, DateTimeKind.Utc).AddTicks(6526));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 18, 19, 47, 328, DateTimeKind.Utc).AddTicks(6584));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 18, 19, 47, 328, DateTimeKind.Utc).AddTicks(6613));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 18, 19, 47, 328, DateTimeKind.Utc).AddTicks(6642));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedAt",
                value: new DateTime(2026, 2, 3, 18, 19, 47, 328, DateTimeKind.Utc).AddTicks(6916));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedAt",
                value: new DateTime(2026, 2, 3, 18, 19, 47, 328, DateTimeKind.Utc).AddTicks(7067));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 18, 19, 47, 328, DateTimeKind.Utc).AddTicks(6830));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 18, 19, 47, 328, DateTimeKind.Utc).AddTicks(6863));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 18, 19, 47, 328, DateTimeKind.Utc).AddTicks(5354));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 18, 19, 47, 328, DateTimeKind.Utc).AddTicks(5388));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 18, 19, 47, 328, DateTimeKind.Utc).AddTicks(5416));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 18, 19, 47, 328, DateTimeKind.Utc).AddTicks(5449));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2026, 2, 3, 18, 19, 47, 328, DateTimeKind.Utc).AddTicks(7138));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2026, 2, 3, 18, 19, 47, 328, DateTimeKind.Utc).AddTicks(7162));

            migrationBuilder.UpdateData(
                table: "ProductReviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 18, 19, 47, 328, DateTimeKind.Utc).AddTicks(6746));

            migrationBuilder.UpdateData(
                table: "ProductReviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 18, 19, 47, 328, DateTimeKind.Utc).AddTicks(6778));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 18, 19, 47, 328, DateTimeKind.Utc).AddTicks(5610));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 18, 19, 47, 328, DateTimeKind.Utc).AddTicks(5640));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 18, 19, 47, 328, DateTimeKind.Utc).AddTicks(5974));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 18, 19, 47, 328, DateTimeKind.Utc).AddTicks(6013));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 18, 19, 47, 328, DateTimeKind.Utc).AddTicks(6046));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 18, 19, 47, 328, DateTimeKind.Utc).AddTicks(6078));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 18, 19, 47, 328, DateTimeKind.Utc).AddTicks(6111));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 18, 19, 47, 328, DateTimeKind.Utc).AddTicks(6145));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 18, 19, 47, 328, DateTimeKind.Utc).AddTicks(6178));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 18, 19, 47, 328, DateTimeKind.Utc).AddTicks(6212));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 18, 19, 47, 328, DateTimeKind.Utc).AddTicks(6245));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 18, 19, 47, 328, DateTimeKind.Utc).AddTicks(6279));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 18, 19, 47, 328, DateTimeKind.Utc).AddTicks(5787));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 18, 19, 47, 328, DateTimeKind.Utc).AddTicks(5816));

            migrationBuilder.UpdateData(
                table: "UnitsOfMeasure",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 18, 19, 47, 328, DateTimeKind.Utc).AddTicks(5698));

            migrationBuilder.UpdateData(
                table: "UnitsOfMeasure",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 18, 19, 47, 328, DateTimeKind.Utc).AddTicks(5731));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAssigned",
                value: new DateTime(2026, 2, 3, 18, 19, 47, 328, DateTimeKind.Utc).AddTicks(7243));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAssigned",
                value: new DateTime(2026, 2, 3, 18, 19, 47, 328, DateTimeKind.Utc).AddTicks(7277));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 18, 19, 47, 328, DateTimeKind.Utc).AddTicks(5878));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 18, 19, 47, 328, DateTimeKind.Utc).AddTicks(5911));
        }
    }
}
