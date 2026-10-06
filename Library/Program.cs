using Library;

Book book = new Book();

// this is info for the book class 
book.Title = "C# for beginners";
book.Author = "John Doe";
book.ISBN = 12345678;
book.DisplayInfo();

//add another book
Book book1 = new Book();

book1.Title = "C# for advanced";
book1.Author = "Jane Smith";
book1.ISBN = 87654321;
book1.DisplayInfo();