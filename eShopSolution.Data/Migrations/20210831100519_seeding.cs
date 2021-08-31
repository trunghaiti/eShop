using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryTranslation_Language_LanguageId1",
                table: "CategoryTranslation");

            migrationBuilder.DropIndex(
                name: "IX_CategoryTranslation_LanguageId1",
                table: "CategoryTranslation");

            migrationBuilder.DropColumn(
                name: "SeoAlias",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "LanguageId1",
                table: "CategoryTranslation");

            migrationBuilder.AlterColumn<string>(
                name: "SeoDescription",
                table: "ProductTranslation",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AddColumn<string>(
                name: "SeoAlias",
                table: "ProductTranslation",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Product",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 31, 17, 5, 19, 350, DateTimeKind.Local).AddTicks(7404),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 8, 31, 15, 34, 28, 799, DateTimeKind.Local).AddTicks(6772));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Order",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 31, 17, 5, 19, 343, DateTimeKind.Local).AddTicks(1801),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 8, 31, 15, 34, 28, 792, DateTimeKind.Local).AddTicks(290));

            migrationBuilder.AlterColumn<bool>(
                name: "IsDefault",
                table: "Language",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 1);

            migrationBuilder.AlterColumn<string>(
                name: "SeoTitle",
                table: "CategoryTranslation",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "LanguageId",
                table: "CategoryTranslation",
                type: "varchar(5)",
                unicode: false,
                maxLength: 5,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "AppConfig",
                columns: new[] { "Key", "Value" },
                values: new object[,]
                {
                    { "HomeTitle", "This is home page of eShopSolution" },
                    { "HomeKeyword", "This is keyword of eShopSolution" },
                    { "HomeDescription", "This is description page of eShopSolution" }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "IsShowOnHome", "ParentId", "ShortOrder", "Status" },
                values: new object[,]
                {
                    { 1, true, null, 1, 1 },
                    { 2, true, null, 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "Language",
                columns: new[] { "Id", "IsDefault", "Name" },
                values: new object[] { "vi-VN", true, "Tiếng Việt" });

            migrationBuilder.InsertData(
                table: "Language",
                columns: new[] { "Id", "Name" },
                values: new object[] { "en-US", "English" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CreatedDate", "IsFeatured", "OriginalPrice", "Price" },
                values: new object[] { 1, new DateTime(2021, 8, 31, 17, 5, 19, 360, DateTimeKind.Local).AddTicks(8626), null, 100000m, 200000m });

            migrationBuilder.InsertData(
                table: "CategoryTranslation",
                columns: new[] { "Id", "CategoryId", "LanguageId", "Name", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[,]
                {
                    { 1, 1, "vi-VN", "Áo nam", "ao-nam", "Sản phẩm áo thời trang nam", "Sản phẩm áo thời trang nam" },
                    { 3, 2, "vi-VN", "Áo nữ", "ao-nu", "Sản phẩm áo thời trang nữ", "Sản phẩm áo thời trang nữ" },
                    { 2, 1, "en-US", "Men shirt", "ao-nam", "The shirt product for men", "The shirt product for men" },
                    { 4, 2, "en-US", "Women shirt", "ao-nu", "The shirt product for women", "The shirt product for women" }
                });

            migrationBuilder.InsertData(
                table: "ProductInCategory",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "ProductTranslation",
                columns: new[] { "Id", "Description", "Detail", "LanguageId", "Name", "ProductId", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[,]
                {
                    { 1, "", "Mô tả sản phẩm", "vi-VN", "Áo sơ mi nam trắng", 1, "ao-so-mi-nam-trang", "Áo sơ mi nam trắng", "Áo sơ mi nam trắng" },
                    { 2, "", "Description of product", "en-US", "Men T-shirt", 1, "men-t-shirt", "The shirt product for men", "The shirt product for men" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryTranslation_LanguageId",
                table: "CategoryTranslation",
                column: "LanguageId");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryTranslation_Language_LanguageId",
                table: "CategoryTranslation",
                column: "LanguageId",
                principalTable: "Language",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryTranslation_Language_LanguageId",
                table: "CategoryTranslation");

            migrationBuilder.DropIndex(
                name: "IX_CategoryTranslation_LanguageId",
                table: "CategoryTranslation");

            migrationBuilder.DeleteData(
                table: "AppConfig",
                keyColumn: "Key",
                keyValue: "HomeDescription");

            migrationBuilder.DeleteData(
                table: "AppConfig",
                keyColumn: "Key",
                keyValue: "HomeKeyword");

            migrationBuilder.DeleteData(
                table: "AppConfig",
                keyColumn: "Key",
                keyValue: "HomeTitle");

            migrationBuilder.DeleteData(
                table: "CategoryTranslation",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CategoryTranslation",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CategoryTranslation",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CategoryTranslation",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductInCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ProductTranslation",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductTranslation",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Id",
                keyValue: "en-US");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Id",
                keyValue: "vi-VN");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "SeoAlias",
                table: "ProductTranslation");

            migrationBuilder.AlterColumn<string>(
                name: "SeoDescription",
                table: "ProductTranslation",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Product",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 31, 15, 34, 28, 799, DateTimeKind.Local).AddTicks(6772),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 8, 31, 17, 5, 19, 350, DateTimeKind.Local).AddTicks(7404));

            migrationBuilder.AddColumn<string>(
                name: "SeoAlias",
                table: "Product",
                type: "varchar(2250)",
                unicode: false,
                maxLength: 2250,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Order",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 31, 15, 34, 28, 792, DateTimeKind.Local).AddTicks(290),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 8, 31, 17, 5, 19, 343, DateTimeKind.Local).AddTicks(1801));

            migrationBuilder.AlterColumn<int>(
                name: "IsDefault",
                table: "Language",
                type: "int",
                nullable: false,
                defaultValue: 1,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<int>(
                name: "SeoTitle",
                table: "CategoryTranslation",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "LanguageId",
                table: "CategoryTranslation",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(5)",
                oldUnicode: false,
                oldMaxLength: 5);

            migrationBuilder.AddColumn<string>(
                name: "LanguageId1",
                table: "CategoryTranslation",
                type: "varchar(5)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CategoryTranslation_LanguageId1",
                table: "CategoryTranslation",
                column: "LanguageId1");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryTranslation_Language_LanguageId1",
                table: "CategoryTranslation",
                column: "LanguageId1",
                principalTable: "Language",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
