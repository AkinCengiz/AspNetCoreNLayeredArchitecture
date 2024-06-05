using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AspNetCoreNLayeredArchitecture.Repository.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductFeatures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Color = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Height = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    Width = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductFeatures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductFeatures_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreateAt", "IsActive", "IsDeleted", "Name", "UpdateAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 5, 13, 53, 56, 288, DateTimeKind.Local).AddTicks(4402), true, false, "Kalemler", null },
                    { 2, new DateTime(2024, 6, 5, 13, 53, 56, 288, DateTimeKind.Local).AddTicks(4404), true, false, "Defterler", null },
                    { 3, new DateTime(2024, 6, 5, 13, 53, 56, 288, DateTimeKind.Local).AddTicks(4405), true, false, "Kitaplar", null },
                    { 4, new DateTime(2024, 6, 5, 13, 53, 56, 288, DateTimeKind.Local).AddTicks(4407), true, false, "Çantalar", null },
                    { 5, new DateTime(2024, 6, 5, 13, 53, 56, 288, DateTimeKind.Local).AddTicks(4408), true, false, "Kırtasiye", null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreateAt", "IsActive", "IsDeleted", "Name", "Price", "Stock", "UpdateAt" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 6, 5, 13, 53, 56, 288, DateTimeKind.Local).AddTicks(4711), true, false, "Pilot Kalem", 12.50m, 100, null },
                    { 2, 1, new DateTime(2024, 6, 5, 13, 53, 56, 288, DateTimeKind.Local).AddTicks(4713), true, false, "Kurşun Kalem", 5.50m, 200, null },
                    { 3, 1, new DateTime(2024, 6, 5, 13, 53, 56, 288, DateTimeKind.Local).AddTicks(4715), true, false, "Tükenmez Kalem", 15.50m, 300, null },
                    { 4, 2, new DateTime(2024, 6, 5, 13, 53, 56, 288, DateTimeKind.Local).AddTicks(4717), true, false, "Kareli Defter", 7.50m, 400, null },
                    { 5, 2, new DateTime(2024, 6, 5, 13, 53, 56, 288, DateTimeKind.Local).AddTicks(4718), true, false, "Çizgili Defter", 7.50m, 300, null },
                    { 6, 2, new DateTime(2024, 6, 5, 13, 53, 56, 288, DateTimeKind.Local).AddTicks(4720), true, false, "A5 Defter", 12.50m, 150, null },
                    { 7, 2, new DateTime(2024, 6, 5, 13, 53, 56, 288, DateTimeKind.Local).AddTicks(4722), true, false, "A4 Defter", 15.50m, 250, null },
                    { 8, 2, new DateTime(2024, 6, 5, 13, 53, 56, 288, DateTimeKind.Local).AddTicks(4723), true, false, "Düz Yazı Defter", 10.50m, 350, null },
                    { 9, 2, new DateTime(2024, 6, 5, 13, 53, 56, 288, DateTimeKind.Local).AddTicks(4725), true, false, "Harita Metot Defter", 10.50m, 350, null },
                    { 10, 3, new DateTime(2024, 6, 5, 13, 53, 56, 288, DateTimeKind.Local).AddTicks(4726), true, false, "Matematik 1", 10.50m, 350, null },
                    { 11, 3, new DateTime(2024, 6, 5, 13, 53, 56, 288, DateTimeKind.Local).AddTicks(4729), true, false, "Matematik 2", 10.50m, 350, null },
                    { 12, 3, new DateTime(2024, 6, 5, 13, 53, 56, 288, DateTimeKind.Local).AddTicks(4730), true, false, "Matematik 3", 10.50m, 350, null },
                    { 13, 3, new DateTime(2024, 6, 5, 13, 53, 56, 288, DateTimeKind.Local).AddTicks(4732), true, false, "Fizik 1", 10.50m, 350, null },
                    { 14, 3, new DateTime(2024, 6, 5, 13, 53, 56, 288, DateTimeKind.Local).AddTicks(4734), true, false, "Fizik 2", 10.50m, 350, null },
                    { 15, 3, new DateTime(2024, 6, 5, 13, 53, 56, 288, DateTimeKind.Local).AddTicks(4735), true, false, "Fizik 3", 10.50m, 350, null },
                    { 16, 3, new DateTime(2024, 6, 5, 13, 53, 56, 288, DateTimeKind.Local).AddTicks(4737), true, false, "Kimya 1", 10.50m, 350, null },
                    { 17, 3, new DateTime(2024, 6, 5, 13, 53, 56, 288, DateTimeKind.Local).AddTicks(4738), true, false, "Kimya 2", 10.50m, 350, null },
                    { 18, 3, new DateTime(2024, 6, 5, 13, 53, 56, 288, DateTimeKind.Local).AddTicks(4740), true, false, "Kimya 3", 10.50m, 350, null },
                    { 19, 4, new DateTime(2024, 6, 5, 13, 53, 56, 288, DateTimeKind.Local).AddTicks(4741), true, false, "Sırt Çantası", 10.50m, 350, null },
                    { 20, 4, new DateTime(2024, 6, 5, 13, 53, 56, 288, DateTimeKind.Local).AddTicks(4743), true, false, "Bilgisayar Çantası", 10.50m, 350, null },
                    { 21, 4, new DateTime(2024, 6, 5, 13, 53, 56, 288, DateTimeKind.Local).AddTicks(4744), true, false, "Spor Çantası", 10.50m, 350, null },
                    { 22, 4, new DateTime(2024, 6, 5, 13, 53, 56, 288, DateTimeKind.Local).AddTicks(4746), true, false, "Beslenme Çantası", 10.50m, 350, null },
                    { 23, 5, new DateTime(2024, 6, 5, 13, 53, 56, 288, DateTimeKind.Local).AddTicks(4747), true, false, "Kalem Kutusu", 10.50m, 350, null },
                    { 24, 5, new DateTime(2024, 6, 5, 13, 53, 56, 288, DateTimeKind.Local).AddTicks(4749), true, false, "Silgi", 10.50m, 350, null },
                    { 25, 5, new DateTime(2024, 6, 5, 13, 53, 56, 288, DateTimeKind.Local).AddTicks(4750), true, false, "Kalemtraş", 10.50m, 350, null },
                    { 26, 5, new DateTime(2024, 6, 5, 13, 53, 56, 288, DateTimeKind.Local).AddTicks(4752), true, false, "Kurşun", 10.50m, 350, null }
                });

            migrationBuilder.InsertData(
                table: "ProductFeatures",
                columns: new[] { "Id", "Color", "CreateAt", "Height", "IsActive", "IsDeleted", "ProductId", "UpdateAt", "Width" },
                values: new object[,]
                {
                    { 1, "Kırmızı", new DateTime(2024, 6, 5, 13, 53, 56, 288, DateTimeKind.Local).AddTicks(4590), 100, true, false, 1, null, 50 },
                    { 2, "Mavi", new DateTime(2024, 6, 5, 13, 53, 56, 288, DateTimeKind.Local).AddTicks(4592), 150, true, false, 2, null, 60 },
                    { 3, "Yeşil", new DateTime(2024, 6, 5, 13, 53, 56, 288, DateTimeKind.Local).AddTicks(4594), 200, true, false, 3, null, 70 },
                    { 4, "Siyah", new DateTime(2024, 6, 5, 13, 53, 56, 288, DateTimeKind.Local).AddTicks(4596), 250, true, false, 4, null, 80 },
                    { 5, "Beyaz", new DateTime(2024, 6, 5, 13, 53, 56, 288, DateTimeKind.Local).AddTicks(4597), 300, true, false, 5, null, 90 },
                    { 6, "Sarı", new DateTime(2024, 6, 5, 13, 53, 56, 288, DateTimeKind.Local).AddTicks(4599), 350, true, false, 6, null, 100 },
                    { 7, "Pembe", new DateTime(2024, 6, 5, 13, 53, 56, 288, DateTimeKind.Local).AddTicks(4600), 400, true, false, 7, null, 110 },
                    { 8, "Mor", new DateTime(2024, 6, 5, 13, 53, 56, 288, DateTimeKind.Local).AddTicks(4601), 450, true, false, 8, null, 120 },
                    { 9, "Turuncu", new DateTime(2024, 6, 5, 13, 53, 56, 288, DateTimeKind.Local).AddTicks(4603), 500, true, false, 9, null, 130 },
                    { 10, "Gri", new DateTime(2024, 6, 5, 13, 53, 56, 288, DateTimeKind.Local).AddTicks(4604), 550, true, false, 10, null, 140 },
                    { 11, "Kahverengi", new DateTime(2024, 6, 5, 13, 53, 56, 288, DateTimeKind.Local).AddTicks(4607), 600, true, false, 11, null, 150 },
                    { 12, "Lacivert", new DateTime(2024, 6, 5, 13, 53, 56, 288, DateTimeKind.Local).AddTicks(4608), 650, true, false, 12, null, 160 },
                    { 13, "Bordo", new DateTime(2024, 6, 5, 13, 53, 56, 288, DateTimeKind.Local).AddTicks(4610), 700, true, false, 13, null, 170 },
                    { 14, "Pembe", new DateTime(2024, 6, 5, 13, 53, 56, 288, DateTimeKind.Local).AddTicks(4611), 750, true, false, 14, null, 180 },
                    { 15, "Siyah", new DateTime(2024, 6, 5, 13, 53, 56, 288, DateTimeKind.Local).AddTicks(4613), 800, true, false, 15, null, 190 },
                    { 16, "Beyaz", new DateTime(2024, 6, 5, 13, 53, 56, 288, DateTimeKind.Local).AddTicks(4614), 850, true, false, 16, null, 200 },
                    { 17, "Sarı", new DateTime(2024, 6, 5, 13, 53, 56, 288, DateTimeKind.Local).AddTicks(4615), 900, true, false, 17, null, 210 },
                    { 18, "Pembe", new DateTime(2024, 6, 5, 13, 53, 56, 288, DateTimeKind.Local).AddTicks(4617), 950, true, false, 18, null, 220 },
                    { 19, "Mor", new DateTime(2024, 6, 5, 13, 53, 56, 288, DateTimeKind.Local).AddTicks(4618), 1000, true, false, 19, null, 230 },
                    { 20, "Turuncu", new DateTime(2024, 6, 5, 13, 53, 56, 288, DateTimeKind.Local).AddTicks(4620), 1050, true, false, 20, null, 240 },
                    { 21, "Gri", new DateTime(2024, 6, 5, 13, 53, 56, 288, DateTimeKind.Local).AddTicks(4621), 1100, true, false, 21, null, 250 },
                    { 22, "Kahverengi", new DateTime(2024, 6, 5, 13, 53, 56, 288, DateTimeKind.Local).AddTicks(4623), 1150, true, false, 22, null, 260 },
                    { 23, "Lacivert", new DateTime(2024, 6, 5, 13, 53, 56, 288, DateTimeKind.Local).AddTicks(4624), 1200, true, false, 23, null, 270 },
                    { 24, "Bordo", new DateTime(2024, 6, 5, 13, 53, 56, 288, DateTimeKind.Local).AddTicks(4626), 1250, true, false, 24, null, 280 },
                    { 25, "Pembe", new DateTime(2024, 6, 5, 13, 53, 56, 288, DateTimeKind.Local).AddTicks(4627), 1300, true, false, 25, null, 290 },
                    { 26, "Siyah", new DateTime(2024, 6, 5, 13, 53, 56, 288, DateTimeKind.Local).AddTicks(4628), 1350, true, false, 26, null, 300 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductFeatures_ProductId",
                table: "ProductFeatures",
                column: "ProductId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductFeatures");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
