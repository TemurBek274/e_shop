using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ProductTag : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_product_categorie_categories_category_id",
                table: "product_categorie");

            migrationBuilder.DropForeignKey(
                name: "fk_product_categorie_products_producr_id",
                table: "product_categorie");

            migrationBuilder.DropPrimaryKey(
                name: "pk_product_categorie",
                table: "product_categorie");

            migrationBuilder.RenameTable(
                name: "product_categorie",
                newName: "product_categories");

            migrationBuilder.RenameIndex(
                name: "ix_product_categorie_category_id",
                table: "product_categories",
                newName: "ix_product_categories_category_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_product_categories",
                table: "product_categories",
                column: "producr_id");

            migrationBuilder.CreateTable(
                name: "tags",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    tag_name = table.Column<string>(type: "text", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    created_by = table.Column<int>(type: "integer", nullable: false),
                    updated_by = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tags", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "product_tags",
                columns: table => new
                {
                    tag_id = table.Column<int>(type: "integer", nullable: false),
                    product_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_product_tags", x => new { x.tag_id, x.product_id });
                    table.ForeignKey(
                        name: "fk_product_tags_products_product_id",
                        column: x => x.product_id,
                        principalTable: "products",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_product_tags_tags_tag_id",
                        column: x => x.tag_id,
                        principalTable: "tags",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "ix_product_tags_product_id",
                table: "product_tags",
                column: "product_id");

            migrationBuilder.AddForeignKey(
                name: "fk_product_categories_categories_category_id",
                table: "product_categories",
                column: "category_id",
                principalTable: "categories",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_product_categories_products_producr_id",
                table: "product_categories",
                column: "producr_id",
                principalTable: "products",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_product_categories_categories_category_id",
                table: "product_categories");

            migrationBuilder.DropForeignKey(
                name: "fk_product_categories_products_producr_id",
                table: "product_categories");

            migrationBuilder.DropTable(
                name: "product_tags");

            migrationBuilder.DropTable(
                name: "tags");

            migrationBuilder.DropPrimaryKey(
                name: "pk_product_categories",
                table: "product_categories");

            migrationBuilder.RenameTable(
                name: "product_categories",
                newName: "product_categorie");

            migrationBuilder.RenameIndex(
                name: "ix_product_categories_category_id",
                table: "product_categorie",
                newName: "ix_product_categorie_category_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_product_categorie",
                table: "product_categorie",
                column: "producr_id");

            migrationBuilder.AddForeignKey(
                name: "fk_product_categorie_categories_category_id",
                table: "product_categorie",
                column: "category_id",
                principalTable: "categories",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_product_categorie_products_producr_id",
                table: "product_categorie",
                column: "producr_id",
                principalTable: "products",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
