using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfCoreTest.Migrations
{
    public partial class OrderDiliveryTb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "T_Orders",
                columns: table => new
                {
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Orders", x => x.Code);
                });

            //migrationBuilder.CreateTable(
            //    name: "T_Users",
            //    columns: table => new
            //    {
            //        ID = table.Column<long>(type: "bigint", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        JobTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        FirstNameLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Newcolumn = table.Column<string>(type: "nvarchar(max)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_T_Users", x => x.ID);
            //    });

            migrationBuilder.CreateTable(
                name: "T_Delivery",
                columns: table => new
                {
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    OrderCodeRef = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Delivery", x => x.Code);
                    table.ForeignKey(
                        name: "FK_T_Delivery_T_Orders_OrderCodeRef",
                        column: x => x.OrderCodeRef,
                        principalTable: "T_Orders",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_T_Delivery_OrderCodeRef",
                table: "T_Delivery",
                column: "OrderCodeRef",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "T_Delivery");

            //migrationBuilder.DropTable(
            //    name: "T_Users");

            migrationBuilder.DropTable(
                name: "T_Orders");
        }
    }
}
