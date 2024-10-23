using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookstoreManagement.Migrations
{
    /// <inheritdoc />
    public partial class BookDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Author = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "Genre", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "F. Scott Fitzgerald", "Fiction", 10.99, "The Great Gatsby" },
                    { 2, "Harper Lee", "Fiction", 12.99, "To Kill a Mockingbird" },
                    { 3, "George Orwell", "Dystopian", 14.99, "1984" },
                    { 4, "Jane Austen", "Romance", 9.9900000000000002, "Pride and Prejudice" },
                    { 5, "J.D. Salinger", "Fiction", 11.99, "The Catcher in the Rye" },
                    { 6, "Herman Melville", "Adventure", 13.5, "Moby Dick" },
                    { 7, "Leo Tolstoy", "Historical Fiction", 15.99, "War and Peace" },
                    { 8, "Homer", "Classic", 8.9900000000000002, "The Odyssey" },
                    { 9, "Aldous Huxley", "Dystopian", 12.5, "Brave New World" },
                    { 10, "J.R.R. Tolkien", "Fantasy", 19.989999999999998, "The Lord of the Rings" },
                    { 11, "Paulo Coelho", "Fiction", 10.5, "The Alchemist" },
                    { 12, "Oscar Wilde", "Fiction", 9.5, "The Picture of Dorian Gray" },
                    { 13, "Fyodor Dostoevsky", "Fiction", 14.99, "Crime and Punishment" },
                    { 14, "J.R.R. Tolkien", "Fantasy", 10.99, "The Hobbit" },
                    { 15, "Ray Bradbury", "Dystopian", 11.5, "Fahrenheit 451" },
                    { 16, "C.S. Lewis", "Fantasy", 15.0, "The Chronicles of Narnia" },
                    { 17, "Margaret Atwood", "Dystopian", 13.5, "The Handmaid's Tale" },
                    { 18, "John Steinbeck", "Fiction", 14.0, "The Grapes of Wrath" },
                    { 19, "Charles Dickens", "Historical Fiction", 12.0, "A Tale of Two Cities" },
                    { 20, "Sylvia Plath", "Fiction", 10.0, "The Bell Jar" },
                    { 21, "Yuval Noah Harari", "Non-fiction", 16.989999999999998, "Sapiens: A Brief History of Humankind" },
                    { 22, "Michelle Obama", "Biography", 20.0, "Becoming" },
                    { 23, "Rebecca Skloot", "Non-fiction", 15.0, "The Immortal Life of Henrietta Lacks" },
                    { 24, "Tara Westover", "Biography", 17.5, "Educated" },
                    { 25, "Charles Duhigg", "Self-help", 16.5, "The Power of Habit" },
                    { 26, "Mark Manson", "Self-help", 18.989999999999998, "The Subtle Art of Not Giving a F*ck" },
                    { 27, "Jen Sincero", "Self-help", 16.989999999999998, "You Are a Badass" },
                    { 28, "Stephen R. Covey", "Self-help", 17.989999999999998, "The 7 Habits of Highly Effective People" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
