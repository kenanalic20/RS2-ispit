using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eCommerce.Services.Migrations
{
    /// <inheritdoc />
    public partial class Initial22 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "hasDiscount",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

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
                columns: new[] { "CreatedAt", "hasDiscount" },
                values: new object[] { new DateTime(2026, 2, 3, 18, 19, 47, 328, DateTimeKind.Utc).AddTicks(5974), false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "hasDiscount" },
                values: new object[] { new DateTime(2026, 2, 3, 18, 19, 47, 328, DateTimeKind.Utc).AddTicks(6013), false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "hasDiscount" },
                values: new object[] { new DateTime(2026, 2, 3, 18, 19, 47, 328, DateTimeKind.Utc).AddTicks(6046), false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "hasDiscount" },
                values: new object[] { new DateTime(2026, 2, 3, 18, 19, 47, 328, DateTimeKind.Utc).AddTicks(6078), false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "hasDiscount" },
                values: new object[] { new DateTime(2026, 2, 3, 18, 19, 47, 328, DateTimeKind.Utc).AddTicks(6111), false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "hasDiscount" },
                values: new object[] { new DateTime(2026, 2, 3, 18, 19, 47, 328, DateTimeKind.Utc).AddTicks(6145), false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "hasDiscount" },
                values: new object[] { new DateTime(2026, 2, 3, 18, 19, 47, 328, DateTimeKind.Utc).AddTicks(6178), false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "hasDiscount" },
                values: new object[] { new DateTime(2026, 2, 3, 18, 19, 47, 328, DateTimeKind.Utc).AddTicks(6212), false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "hasDiscount" },
                values: new object[] { new DateTime(2026, 2, 3, 18, 19, 47, 328, DateTimeKind.Utc).AddTicks(6245), false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "hasDiscount" },
                values: new object[] { new DateTime(2026, 2, 3, 18, 19, 47, 328, DateTimeKind.Utc).AddTicks(6279), false });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "hasDiscount",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 17, 50, 56, 414, DateTimeKind.Utc).AddTicks(4441));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 17, 50, 56, 414, DateTimeKind.Utc).AddTicks(4469));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 17, 50, 56, 414, DateTimeKind.Utc).AddTicks(4498));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 17, 50, 56, 414, DateTimeKind.Utc).AddTicks(4531));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 17, 50, 56, 414, DateTimeKind.Utc).AddTicks(4560));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 17, 50, 56, 414, DateTimeKind.Utc).AddTicks(4589));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 17, 50, 56, 414, DateTimeKind.Utc).AddTicks(4618));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 17, 50, 56, 414, DateTimeKind.Utc).AddTicks(4647));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 17, 50, 56, 414, DateTimeKind.Utc).AddTicks(4675));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 17, 50, 56, 414, DateTimeKind.Utc).AddTicks(4704));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedAt",
                value: new DateTime(2026, 2, 3, 17, 50, 56, 414, DateTimeKind.Utc).AddTicks(4980));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedAt",
                value: new DateTime(2026, 2, 3, 17, 50, 56, 414, DateTimeKind.Utc).AddTicks(5009));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 17, 50, 56, 414, DateTimeKind.Utc).AddTicks(4889));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 17, 50, 56, 414, DateTimeKind.Utc).AddTicks(4923));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 17, 50, 56, 414, DateTimeKind.Utc).AddTicks(3359));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 17, 50, 56, 414, DateTimeKind.Utc).AddTicks(3392));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 17, 50, 56, 414, DateTimeKind.Utc).AddTicks(3426));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 17, 50, 56, 414, DateTimeKind.Utc).AddTicks(3454));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2026, 2, 3, 17, 50, 56, 414, DateTimeKind.Utc).AddTicks(5060));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2026, 2, 3, 17, 50, 56, 414, DateTimeKind.Utc).AddTicks(5098));

            migrationBuilder.UpdateData(
                table: "ProductReviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 17, 50, 56, 414, DateTimeKind.Utc).AddTicks(4808));

            migrationBuilder.UpdateData(
                table: "ProductReviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 17, 50, 56, 414, DateTimeKind.Utc).AddTicks(4837));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 17, 50, 56, 414, DateTimeKind.Utc).AddTicks(3621));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 17, 50, 56, 414, DateTimeKind.Utc).AddTicks(3649));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 17, 50, 56, 414, DateTimeKind.Utc).AddTicks(3998));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 17, 50, 56, 414, DateTimeKind.Utc).AddTicks(4036));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 17, 50, 56, 414, DateTimeKind.Utc).AddTicks(4069));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 17, 50, 56, 414, DateTimeKind.Utc).AddTicks(4173));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 17, 50, 56, 414, DateTimeKind.Utc).AddTicks(4207));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 17, 50, 56, 414, DateTimeKind.Utc).AddTicks(4240));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 17, 50, 56, 414, DateTimeKind.Utc).AddTicks(4274));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 17, 50, 56, 414, DateTimeKind.Utc).AddTicks(4308));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 17, 50, 56, 414, DateTimeKind.Utc).AddTicks(4341));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 17, 50, 56, 414, DateTimeKind.Utc).AddTicks(4374));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 17, 50, 56, 414, DateTimeKind.Utc).AddTicks(3802));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 17, 50, 56, 414, DateTimeKind.Utc).AddTicks(3835));

            migrationBuilder.UpdateData(
                table: "UnitsOfMeasure",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 17, 50, 56, 414, DateTimeKind.Utc).AddTicks(3716));

            migrationBuilder.UpdateData(
                table: "UnitsOfMeasure",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 17, 50, 56, 414, DateTimeKind.Utc).AddTicks(3750));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAssigned",
                value: new DateTime(2026, 2, 3, 17, 50, 56, 414, DateTimeKind.Utc).AddTicks(5175));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAssigned",
                value: new DateTime(2026, 2, 3, 17, 50, 56, 414, DateTimeKind.Utc).AddTicks(5204));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 17, 50, 56, 414, DateTimeKind.Utc).AddTicks(3896));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 17, 50, 56, 414, DateTimeKind.Utc).AddTicks(3930));
        }
    }
}
