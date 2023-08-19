using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_Commerce_Website.Migrations
{
    public partial class order : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_order",
                columns: table => new
                {
                    order_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cart_id = table.Column<int>(type: "int", nullable: false),
                    order_status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_order", x => x.order_id);
                });

            //migrationBuilder.CreateIndex(
            //    name: "IX_tbl_cart_cust_id",
            //    table: "tbl_cart",
            //    column: "cust_id");

            //migrationBuilder.CreateIndex(
            //    name: "IX_tbl_cart_prod_id",
            //    table: "tbl_cart",
            //    column: "prod_id");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_tbl_cart_tbl_customer_cust_id",
            //    table: "tbl_cart",
            //    column: "cust_id",
            //    principalTable: "tbl_customer",
            //    principalColumn: "customer_id",
            //    onDelete: ReferentialAction.Cascade);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_tbl_cart_tbl_product_prod_id",
            //    table: "tbl_cart",
            //    column: "prod_id",
            //    principalTable: "tbl_product",
            //    principalColumn: "product_id",
            //    onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_tbl_cart_tbl_customer_cust_id",
            //    table: "tbl_cart");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_tbl_cart_tbl_product_prod_id",
            //    table: "tbl_cart");

            migrationBuilder.DropTable(
                name: "tbl_order");

            //migrationBuilder.DropIndex(
            //    name: "IX_tbl_cart_cust_id",
            //    table: "tbl_cart");

            //migrationBuilder.DropIndex(
            //    name: "IX_tbl_cart_prod_id",
            //    table: "tbl_cart");
        }
    }
}
