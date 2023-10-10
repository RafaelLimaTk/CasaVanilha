using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CasaVanilha.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class InsertProductTableProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var currentTime = DateTime.Now;
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name", "Description", "UnitPrice", "StockQuantity", "CreatedAt", "UpdatedAt" },
                values: new object[,]
                {
                                { Guid.NewGuid(), "Cupcake de Baunilha", "Delicioso cupcake de baunilha com cobertura de chocolate.", 3.50m, 50, currentTime, currentTime },
                                { Guid.NewGuid(), "Cupcake de Chocolate", "Cupcake de chocolate rico com cobertura de baunilha.", 3.50m, 40, currentTime, currentTime },
                                {Guid.NewGuid(), "Brownie", "Brownie de chocolate denso e rico.", 2.50m, 30, currentTime, currentTime},
                                {Guid.NewGuid(), "Bolo de Cenoura", "Bolo de cenoura úmido com cobertura de chocolate.", 15.00m, 20, currentTime, currentTime},
                                {Guid.NewGuid(), "Torta de Limão", "Torta de limão refrescante com uma crosta crocante.", 12.00m, 15, currentTime, currentTime},
                                {Guid.NewGuid(), "Torta de Maçã", "Torta de maçã clássica com uma crosta escamosa.", 14.00m, 15, currentTime, currentTime},
                                {Guid.NewGuid(), "Cookie de Chocolate", "Cookie crocante com pedaços de chocolate.", 1.50m, 80, currentTime, currentTime},
                                {Guid.NewGuid(), "Muffin de Blueberry", "Muffin de blueberry úmido e doce.", 2.00m, 60, currentTime, currentTime},
                                {Guid.NewGuid(), "Donut Glaceado", "Donut macio com uma cobertura doce e brilhante.", 2.00m, 70, currentTime, currentTime},
                                {Guid.NewGuid(), "Eclair de Chocolate", "Eclair recheado com creme e coberto com chocolate.", 3.00m, 40, currentTime, currentTime},
                                {Guid.NewGuid(), "Cheesecake de Morango", "Cheesecake rico com cobertura de morango.", 4.50m, 30, currentTime, currentTime},
                                {Guid.NewGuid(), "Bolo de Chocolate", "Bolo de chocolate úmido com cobertura de chocolate.", 18.00m, 20, currentTime, currentTime},
                                {Guid.NewGuid(), "Bolo de Veludo Vermelho", "Bolo de veludo vermelho com cobertura de cream cheese.", 20.00m, 20, currentTime, currentTime},
                                {Guid.NewGuid(), "Macaron", "Macaron francês leve e crocante.", 2.50m, 50, currentTime, currentTime},
                                {Guid.NewGuid(), "Tiramisu", "Tiramisu italiano clássico com um toque de café.", 4.50m, 25, currentTime, currentTime},
                                {Guid.NewGuid(), "Pudim de Leite", "Pudim de leite cremoso com uma camada de caramelo.", 3.00m, 30, currentTime, currentTime},
                                {Guid.NewGuid(), "Bolo de Fubá", "Bolo de fubá clássico e confortável.", 10.00m, 20, currentTime, currentTime},
                                {Guid.NewGuid(), "Bolo de Laranja", "Bolo de laranja cítrico com uma cobertura doce.", 15.00m, 20, currentTime, currentTime},
                                {Guid.NewGuid(), "Biscoitos Amanteigados", "Biscoitos amanteigados clássicos e crocantes.", 2.00m, 90, currentTime, currentTime},
                                {Guid.NewGuid(), "Torta de Nozes", "Torta de nozes doce e pegajosa.", 16.00m, 15, currentTime, currentTime}
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Name",
                keyValues: new object[]
                {
                                "Cupcake de Baunilha",
                                "Cupcake de Chocolate",
                                "Brownie",
                                "Bolo de Cenoura",
                                "Torta de Limão",
                                "Torta de Maçã",
                                "Cookie de Chocolate",
                                "Muffin de Blueberry",
                                "Donut Glaceado",
                                "Eclair de Chocolate",
                                "Cheesecake de Morango",
                                "Bolo de Chocolate",
                                "Bolo de Veludo Vermelho",
                                "Macaron",
                                "Tiramisu",
                                "Pudim de Leite",
                                "Bolo de Fubá",
                                "Bolo de Laranja",
                                "Biscoitos Amanteigados",
                                "Torta de Nozes"
                });
        }
    }
}
