using BookstoreManagement.Models;
using Microsoft.EntityFrameworkCore;

public class BookstoreContext : DbContext
{
    public BookstoreContext(DbContextOptions<BookstoreContext> options)
        : base(options)
    {
    }

    public DbSet<Book> Books { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>().HasData(
            new Book { Id = 1, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Price = 10.99, Genre = "Fiction" },
            new Book { Id = 2, Title = "To Kill a Mockingbird", Author = "Harper Lee", Price = 12.99, Genre = "Fiction" },
            new Book { Id = 3, Title = "1984", Author = "George Orwell", Price = 14.99, Genre = "Dystopian" },
            new Book { Id = 4, Title = "Pride and Prejudice", Author = "Jane Austen", Price = 9.99, Genre = "Romance" },
            new Book { Id = 5, Title = "The Catcher in the Rye", Author = "J.D. Salinger", Price = 11.99, Genre = "Fiction" },
            new Book { Id = 6, Title = "Moby Dick", Author = "Herman Melville", Price = 13.50, Genre = "Adventure" },
            new Book { Id = 7, Title = "War and Peace", Author = "Leo Tolstoy", Price = 15.99, Genre = "Historical Fiction" },
            new Book { Id = 8, Title = "The Odyssey", Author = "Homer", Price = 8.99, Genre = "Classic" },
            new Book { Id = 9, Title = "Brave New World", Author = "Aldous Huxley", Price = 12.50, Genre = "Dystopian" },
            new Book { Id = 10, Title = "The Lord of the Rings", Author = "J.R.R. Tolkien", Price = 19.99, Genre = "Fantasy" },
            new Book { Id = 11, Title = "The Alchemist", Author = "Paulo Coelho", Price = 10.50, Genre = "Fiction" },
            new Book { Id = 12, Title = "The Picture of Dorian Gray", Author = "Oscar Wilde", Price = 9.50, Genre = "Fiction" },
            new Book { Id = 13, Title = "Crime and Punishment", Author = "Fyodor Dostoevsky", Price = 14.99, Genre = "Fiction" },
            new Book { Id = 14, Title = "The Hobbit", Author = "J.R.R. Tolkien", Price = 10.99, Genre = "Fantasy" },
            new Book { Id = 15, Title = "Fahrenheit 451", Author = "Ray Bradbury", Price = 11.50, Genre = "Dystopian" },
            new Book { Id = 16, Title = "The Chronicles of Narnia", Author = "C.S. Lewis", Price = 15.00, Genre = "Fantasy" },
            new Book { Id = 17, Title = "The Handmaid's Tale", Author = "Margaret Atwood", Price = 13.50, Genre = "Dystopian" },
            new Book { Id = 18, Title = "The Grapes of Wrath", Author = "John Steinbeck", Price = 14.00, Genre = "Fiction" },
            new Book { Id = 19, Title = "A Tale of Two Cities", Author = "Charles Dickens", Price = 12.00, Genre = "Historical Fiction" },
            new Book { Id = 20, Title = "The Bell Jar", Author = "Sylvia Plath", Price = 10.00, Genre = "Fiction" },
            new Book { Id = 21, Title = "Sapiens: A Brief History of Humankind", Author = "Yuval Noah Harari", Price = 16.99, Genre = "Non-fiction" },
            new Book { Id = 22, Title = "Becoming", Author = "Michelle Obama", Price = 20.00, Genre = "Biography" },
            new Book { Id = 23, Title = "The Immortal Life of Henrietta Lacks", Author = "Rebecca Skloot", Price = 15.00, Genre = "Non-fiction" },
            new Book { Id = 24, Title = "Educated", Author = "Tara Westover", Price = 17.50, Genre = "Biography" },
            new Book { Id = 25, Title = "The Power of Habit", Author = "Charles Duhigg", Price = 16.50, Genre = "Self-help" },
            new Book { Id = 26, Title = "The Subtle Art of Not Giving a F*ck", Author = "Mark Manson", Price = 18.99, Genre = "Self-help" },
            new Book { Id = 27, Title = "You Are a Badass", Author = "Jen Sincero", Price = 16.99, Genre = "Self-help" },
            new Book { Id = 28, Title = "The 7 Habits of Highly Effective People", Author = "Stephen R. Covey", Price = 17.99, Genre = "Self-help" }
        );
    }
}
