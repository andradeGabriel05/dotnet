using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DesafioStefanini.Migrations
{
    /// <inheritdoc />
    public partial class OtherEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItensPedido_Produto_ProdutoId",
                table: "ItensPedido");

            migrationBuilder.AlterColumn<bool>(
                name: "Pago",
                table: "Pedido",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_ItensPedido_Produto_ProdutoId",
                table: "ItensPedido",
                column: "ProdutoId",
                principalTable: "Produto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItensPedido_Produto_ProdutoId",
                table: "ItensPedido");

            migrationBuilder.AlterColumn<int>(
                name: "Pago",
                table: "Pedido",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddForeignKey(
                name: "FK_ItensPedido_Produto_ProdutoId",
                table: "ItensPedido",
                column: "ProdutoId",
                principalTable: "Produto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
