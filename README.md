# Book Management System

This is a simple ASP.NET Core MVC application to manage books using CRUD (Create, Read, Update, Delete) operations with Entity Framework Core.

## Features

- **Add New Books**: Create new entries for books by providing details such as title, author, price, and genre.
- **View Book List**: Display a list of all available books.
- **Edit Books**: Update existing book details.
- **Delete Books**: Remove books from the system.
- **Book Details**: View detailed information about a specific book.
- **Search** (Stretch Goal): Filter books by title or author on the Index page.

## Technologies Used

- **ASP.NET Core MVC**
- **Entity Framework Core**
- **Razor Views**
- **SQL Server** (or another database provider)
- **HTML, CSS, Bootstrap** (for styling and layout)

## Book Model

The `Book` model represents books in the system with the following properties:

- **Title** (required, max length: 100)
- **Author** (required, max length: 100)
- **Price** (required, range: 0.01 to 1000.00)
- **Genre** (required)

## BooksController

The `BooksController` handles the main CRUD operations:

- **Index**: Lists all books with an optional search feature.
- **Create**: Displays a form for adding a new book.
- **Edit**: Displays a form for editing an existing book.
- **Delete**: Confirms and deletes a book.
- **Details**: Shows detailed information for a specific book.

## Razor Views

The following Razor views are implemented for the CRUD operations:

- **Index**: Displays a list of books, with a search feature to filter by title or author.
- **Create**: Form to add a new book.
- **Edit**: Form to edit book details.
- **Delete**: Confirm and delete a book.
- **Details**: View detailed information about a specific book.

## Validation

Validation is handled using ASP.NET Core's validation system. The following validations are applied:

- Required fields for Title, Author, Price, and Genre.
- Maximum length for Title and Author (100 characters).
- Price must be between 0.01 and 1000.00.
- Validation errors are displayed on the form when invalid data is provided.

## Search Feature (Stretch Goal)

The search feature on the Index page allows users to filter books by title or author. A search box is available to enter the search criteria, and the results update dynamically.
