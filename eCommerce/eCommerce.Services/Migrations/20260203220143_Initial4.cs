using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eCommerce.Services.Migrations
{
    /// <inheritdoc />
    public partial class Initial4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 22, 1, 43, 294, DateTimeKind.Utc).AddTicks(6177));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 22, 1, 43, 294, DateTimeKind.Utc).AddTicks(6211));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 22, 1, 43, 294, DateTimeKind.Utc).AddTicks(6240));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 22, 1, 43, 294, DateTimeKind.Utc).AddTicks(6268));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 22, 1, 43, 294, DateTimeKind.Utc).AddTicks(6297));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 22, 1, 43, 294, DateTimeKind.Utc).AddTicks(6325));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 22, 1, 43, 294, DateTimeKind.Utc).AddTicks(6358));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 22, 1, 43, 294, DateTimeKind.Utc).AddTicks(6386));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 22, 1, 43, 294, DateTimeKind.Utc).AddTicks(6415));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 22, 1, 43, 294, DateTimeKind.Utc).AddTicks(6444));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedAt",
                value: new DateTime(2026, 2, 3, 22, 1, 43, 294, DateTimeKind.Utc).AddTicks(6697));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedAt",
                value: new DateTime(2026, 2, 3, 22, 1, 43, 294, DateTimeKind.Utc).AddTicks(6724));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 22, 1, 43, 294, DateTimeKind.Utc).AddTicks(6612));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 22, 1, 43, 294, DateTimeKind.Utc).AddTicks(6640));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 22, 1, 43, 294, DateTimeKind.Utc).AddTicks(5128));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 22, 1, 43, 294, DateTimeKind.Utc).AddTicks(5161));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 22, 1, 43, 294, DateTimeKind.Utc).AddTicks(5194));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 22, 1, 43, 294, DateTimeKind.Utc).AddTicks(5228));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2026, 2, 3, 22, 1, 43, 294, DateTimeKind.Utc).AddTicks(6782));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2026, 2, 3, 22, 1, 43, 294, DateTimeKind.Utc).AddTicks(6816));

            migrationBuilder.UpdateData(
                table: "ProductDiscountIB200116s",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BeganAt", "ValidUntil" },
                values: new object[] { new DateTime(2026, 2, 3, 22, 1, 43, 294, DateTimeKind.Utc).AddTicks(6946), new DateTime(2026, 3, 5, 22, 1, 43, 294, DateTimeKind.Utc).AddTicks(7058) });

            migrationBuilder.UpdateData(
                table: "ProductDiscountIB200116s",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BeganAt", "ValidUntil" },
                values: new object[] { new DateTime(2026, 2, 3, 22, 1, 43, 294, DateTimeKind.Utc).AddTicks(7081), new DateTime(2026, 3, 5, 22, 1, 43, 294, DateTimeKind.Utc).AddTicks(7096) });

            migrationBuilder.UpdateData(
                table: "ProductDiscountIB200116s",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BeganAt", "ValidUntil" },
                values: new object[] { new DateTime(2026, 2, 3, 22, 1, 43, 294, DateTimeKind.Utc).AddTicks(7115), new DateTime(2026, 3, 5, 22, 1, 43, 294, DateTimeKind.Utc).AddTicks(7134) });

            migrationBuilder.InsertData(
                table: "ProductDiscountIB200116s",
                columns: new[] { "Id", "BeganAt", "Discount", "ProductId", "ValidUntil" },
                values: new object[] { 67, new DateTime(2026, 2, 3, 22, 1, 43, 294, DateTimeKind.Utc).AddTicks(7153), 0m, 5, new DateTime(2026, 3, 5, 22, 1, 43, 294, DateTimeKind.Utc).AddTicks(7167) });

            migrationBuilder.UpdateData(
                table: "ProductReviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 22, 1, 43, 294, DateTimeKind.Utc).AddTicks(6530));

            migrationBuilder.UpdateData(
                table: "ProductReviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 22, 1, 43, 294, DateTimeKind.Utc).AddTicks(6560));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 22, 1, 43, 294, DateTimeKind.Utc).AddTicks(5395));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 22, 1, 43, 294, DateTimeKind.Utc).AddTicks(5428));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 22, 1, 43, 294, DateTimeKind.Utc).AddTicks(5762));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 22, 1, 43, 294, DateTimeKind.Utc).AddTicks(5800));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 22, 1, 43, 294, DateTimeKind.Utc).AddTicks(5833));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 22, 1, 43, 294, DateTimeKind.Utc).AddTicks(5867));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 22, 1, 43, 294, DateTimeKind.Utc).AddTicks(5901));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 22, 1, 43, 294, DateTimeKind.Utc).AddTicks(5935));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 22, 1, 43, 294, DateTimeKind.Utc).AddTicks(5968));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 22, 1, 43, 294, DateTimeKind.Utc).AddTicks(6001));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 22, 1, 43, 294, DateTimeKind.Utc).AddTicks(6034));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 22, 1, 43, 294, DateTimeKind.Utc).AddTicks(6068));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 22, 1, 43, 294, DateTimeKind.Utc).AddTicks(5576));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 22, 1, 43, 294, DateTimeKind.Utc).AddTicks(5610));

            migrationBuilder.UpdateData(
                table: "UnitsOfMeasure",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 22, 1, 43, 294, DateTimeKind.Utc).AddTicks(5490));

            migrationBuilder.UpdateData(
                table: "UnitsOfMeasure",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 22, 1, 43, 294, DateTimeKind.Utc).AddTicks(5523));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAssigned",
                value: new DateTime(2026, 2, 3, 22, 1, 43, 294, DateTimeKind.Utc).AddTicks(6879));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAssigned",
                value: new DateTime(2026, 2, 3, 22, 1, 43, 294, DateTimeKind.Utc).AddTicks(6903));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 22, 1, 43, 294, DateTimeKind.Utc).AddTicks(5667));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 22, 1, 43, 294, DateTimeKind.Utc).AddTicks(5696));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductDiscountIB200116s",
                keyColumn: "Id",
                keyValue: 67);

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

            migrationBuilder.UpdateData(
                table: "ProductDiscountIB200116s",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BeganAt", "ValidUntil" },
                values: new object[] { new DateTime(2026, 2, 3, 21, 54, 11, 740, DateTimeKind.Utc).AddTicks(4942), new DateTime(2026, 3, 5, 21, 54, 11, 740, DateTimeKind.Utc).AddTicks(4961) });

            migrationBuilder.UpdateData(
                table: "ProductDiscountIB200116s",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BeganAt", "ValidUntil" },
                values: new object[] { new DateTime(2026, 2, 3, 21, 54, 11, 740, DateTimeKind.Utc).AddTicks(4981), new DateTime(2026, 3, 5, 21, 54, 11, 740, DateTimeKind.Utc).AddTicks(4996) });

            migrationBuilder.UpdateData(
                table: "ProductDiscountIB200116s",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BeganAt", "ValidUntil" },
                values: new object[] { new DateTime(2026, 2, 3, 21, 54, 11, 740, DateTimeKind.Utc).AddTicks(5014), new DateTime(2026, 3, 5, 21, 54, 11, 740, DateTimeKind.Utc).AddTicks(5029) });

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
    }
}
