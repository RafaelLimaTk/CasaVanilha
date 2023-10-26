using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CasaVanilha.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class Drop_Register_Table_Product_Add_New_Register : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Products");

            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Agua', 'Bebidas', 3.0, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Agua c/ Gás', 'Bebidas', 3.5, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Coca cola 220ml', 'Bebidas', 4.5, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Coca cola ZERO', 'Bebidas', 5.0, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Copo p/ levar', 'Bebidas', 1.5, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Drink Mel de Cacau', 'Bebidas', 9.5, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Guaraná 269ml', 'Bebidas', 4.5, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'H2O 500ml', 'Bebidas', 5.0, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'H2O limoneto 500ml', 'Bebidas', 5.0, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Pepsi 269ml', 'Bebidas', 4.5, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Pepsi black zero 350ml', 'Bebidas', 5.0, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Soda Italiana Limão 330ml', 'Bebidas', 9.5, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Soda Italiana Morango 330ml', 'Bebidas', 9.5, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Soda Italiana Tangerina 330ml', 'Bebidas', 9.5, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Sprite 220ml', 'Bebidas', 4.5, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Suco de Cacau', 'Bebidas', 6.5, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Suco de Cupuaçu', 'Bebidas', 8.5, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Suco de morango', 'Bebidas', 8.5, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Batom garoto', 'Bombons', 2.0, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Halls', 'Bombons', 2.0, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Paçoca zero açucar', 'Bombons', 1.5, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Cafe Drip Coffee', 'Cafés', 6.0, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Café Expresso', 'Cafés', 5.0, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Café Expresso com leite', 'Cafés', 6.0, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Café Expresso com leite p/ LEVAR', 'Cafés', 7.5, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Café expresso p/ LEVAR', 'Cafés', 6.5, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Cafe Vergato pacote 250g', 'Cafés', 25.0, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Capuccino', 'Cafés', 8.0, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Capuccino p/ LEVAR', 'Cafés', 9.5, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Capuccino Vergato 200g', 'Cafés', 22.0, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Chocolate Quente c/ Marshmallow 80ml', 'Cafés', 8.0, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Drip Coffee', 'Cafés', 20.0, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Ice Capuccino', 'Cafés', 12.5, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Ice Capuccino p/ LEVAR', 'Cafés', 14.0, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Brigadeiro com Uva', 'Doces', 3.0, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Brigadeiro Gorgonzola', 'Doces', 3.0, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Brigadeiro Quejo do Reino', 'Doces', 3.0, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Brigadeiro vegano', 'Doces', 3.5, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Coxinha de Morango', 'Doces', 4.0, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Pão de Mel', 'Doces', 6.0, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Bauru folhado', 'Lanches', 6.0, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Bolode rolo', 'Lanches', 6.0, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Brigadeiro Casadinho', 'Lanches', 3.0, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Brigadeiro ninho c/ nutella', 'Lanches', 3.0, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Brigadeiro Tradicional Meio Amargo', 'Lanches', 3.0, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Brownie', 'Lanches', 4.0, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Brownie pequeno', 'Lanches', 3.0, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Cookies', 'Lanches', 4.0, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Coxinha', 'Lanches', 8.0, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Croissant', 'Lanches', 10.0, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Croissant de frango', 'Lanches', 9.0, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Croissant de Frango med.', 'Lanches', 8.0, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Croissant Peito de Peru med.', 'Lanches', 8.0, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Croissant peq.', 'Lanches', 6.5, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Croissant Presunto de Peru', 'Lanches', 9.0, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Croissant Ricota', 'Lanches', 8.0, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Croissant Ricota c/ Tomate Seco', 'Lanches', 9.0, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Croissant s/ recheio', 'Lanches', 8.0, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Croquete', 'Lanches', 8.0, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Cupcake', 'Lanches', 6.0, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Donuts Branco', 'Lanches', 9.0, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Donuts Chocolate', 'Lanches', 9.0, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Donuts coberto', 'Lanches', 8.0, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Donuts Red Velvet', 'Lanches', 9.0, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Embalagem med.', 'Lanches', 1.5, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Embalagem peq.', 'Lanches', 1.0, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Empada', 'Lanches', 5.0, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Empada doce', 'Lanches', 4.5, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Folhado Banana Imperial', 'Lanches', 3.5, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Folhado de frango med.', 'Lanches', 8.0, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Folhado de frango peq.', 'Lanches', 6.5, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Folhado de Maça', 'Lanches', 5.0, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Folhado de ricota', 'Lanches', 4.0, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Folhado pequeno', 'Lanches', 3.0, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Kibe', 'Lanches', 6.0, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Maria Mole', 'Lanches', 2.0, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Mini coxinha', 'Lanches', 4.5, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'mini donut', 'Lanches', 4.0, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Mini pudim', 'Lanches', 4.0, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Palmier', 'Lanches', 3.0, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Pao Delicia', 'Lanches', 6.5, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Paozinho de queijo trad.', 'Lanches', 2.5, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Pãozinho Delicia Tradicional', 'Lanches', 5.5, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Pastel de Belem', 'Lanches', 5.0, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Pastel folhado queijo e presunto', 'Lanches', 8.0, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Pastel Folhado Ricota', 'Lanches', 5.0, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Pipoca doce', 'Lanches', 3.0, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Pudim', 'Lanches', 7.0, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Pudim de Chocolate', 'Lanches', 7.0, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Pudim Pistache', 'Lanches', 8.0, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Quiche Cogumelo', 'Lanches', 10.0, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Quiche de Frango', 'Lanches', 10.0, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Quiche Tomate Seco c/ Queijo', 'Lanches', 10.0, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Sanduiche de frango', 'Lanches', 6.5, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Sequilho Doce', 'Lanches', 4.0, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Suspiro', 'Lanches', 4.0, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Tartalete de Chocolate c/ Caramelo Salgado', 'Lanches', 8.0, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Tartalete Limão', 'Lanches', 7.0, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Tartalete Morango', 'Lanches', 7.0, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Tartalete Uva', 'Lanches', 7.0, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Torta Folhada de Morango', 'Lanches', 19.0, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Trio pão de queijo', 'Lanches', 10.5, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Quindim de maracuja', 'Porções', 7.0, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Banoffe', 'Tortas/Bolos', 16.0, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Bolo de Laranja c/ Amendoas', 'Tortas/Bolos', 17.5, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Bolo de Tapioca', 'Tortas/Bolos', 17.5, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Bolo de Tapioca (Inteiro)', 'Tortas/Bolos', 22.0, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Bolo no pote', 'Tortas/Bolos', 8.0, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Bolo Surpresa de Morango', 'Tortas/Bolos', 8.0, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Bolo Surpresa de Uva', 'Tortas/Bolos', 8.0, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Cheesecake', 'Tortas/Bolos', 16.0, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Torta Abacaxi c/ Coco', 'Tortas/Bolos', 17.5, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Torta Bulgara c/ Sequilhos', 'Tortas/Bolos', 19.0, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Torta de Café c/ Leite', 'Tortas/Bolos', 17.5, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Torta de Chocolate', 'Tortas/Bolos', 17.5, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Torta de Chocolate c/ Crocante Amendoim', 'Tortas/Bolos', 17.5, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Torta de Chocolate c/ Cupuaçu', 'Tortas/Bolos', 17.5, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Torta de Chocolate c/ Morango', 'Tortas/Bolos', 17.5, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Torta de Chocolate MATILDA', 'Tortas/Bolos', 17.5, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Torta de Limão', 'Tortas/Bolos', 17.5, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Torta de Limão Siciliano c/ Frutas Vermelhas', 'Tortas/Bolos', 19.0, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Torta de Maracuja', 'Tortas/Bolos', 17.5, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Torta de Nozes', 'Tortas/Bolos', 17.5, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Torta Dois Amores', 'Tortas/Bolos', 17.5, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Torta Mousse Chocolate c/ Maracuja', 'Tortas/Bolos', 17.5, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Torta Ninho c/ Morango', 'Tortas/Bolos', 17.5, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Torta Prestígio', 'Tortas/Bolos', 17.5, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Torta Red Velvet', 'Tortas/Bolos', 19.0, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Torta Surpresa de Uva', 'Tortas/Bolos', 17.5, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Torta Três Chocolates', 'Tortas/Bolos', 17.5, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Torta Três Chocolates.', 'Tortas/Bolos', 16.0, 1000, GETDATE(), GETDATE())");
            migrationBuilder.Sql("INSERT INTO Products (Id, Name, Description, UnitPrice, StockQuantity, CreatedAt, UpdatedAt) VALUES (NEWID(), 'Torta Vegana', 'Tortas/Bolos', 19.0, 1000, GETDATE(), GETDATE())");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
