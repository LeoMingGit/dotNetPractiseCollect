using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfCoreTest.Migrations
{
    public partial class TbDeliveryModifyOrderCodeRef : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "T_Delivery");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "OrderId",
                table: "T_Delivery",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }
    }
}
