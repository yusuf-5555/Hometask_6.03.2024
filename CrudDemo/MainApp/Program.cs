using Domain;
using Infrastructure;

var  author1 = new Author();
author1.Id = 1;
author1.FirstName = "Sadriddin";
author1.LastName = "Ayni";
author1.Nationality = "Tajik";
author1.BirthDate = 1855;
author1.Books=new List<Book>();

var  author2 = new Author();
author2.Id = 2;
author2.FirstName = "Rob";
author2.LastName = "Jonson";
author2.Nationality = "American";
author2.BirthDate = 1852;
author2.Books=new List<Book>();

var  author3 = new Author();
author3.Id = 3;
author3.FirstName = "Robert";
author3.LastName = "Kiyosaki";
author3.Nationality = "American";
author3.BirthDate = 1852;
author3.Books=new List<Book>();

var book1 = new Book(); 
book1.Id=1; 
book1.Title="Rich dad, Poor dad"; 
book1.Description="Bestseller"; 
book1.PublicationYear=2010;
book1.PageSize=200; 
book1.Price=120; 
book1.AuthorId=3; 

var book2 = new Book(); 
book2.Id=2; 
book2.Title="Reachest person"; 
book2.Description="Bestseller"; 
book2.PublicationYear=2012;
book2.PageSize=200; 
book2.Price=80; 
book2.AuthorId=3;  

var book3 = new Book(); 
book3.Id=3; 
book3.Title="Maktabi kuhna"; 
book3.Description="The best book"; 
book3.PublicationYear=1970;
book3.PageSize=110; 
book3.Price=25; 
book3.AuthorId=1; 

var book4 = new Book(); 
book4.Id=4; 
book4.Title="Margi sudxur"; 
book4.Description="Historical book"; 
book4.PublicationYear=1968;
book4.PageSize=150; 
book4.Price=100; 
book4.AuthorId=1;  

author1.Books.Add(book1);
author2.Books.Add(book2); 
author3.Books.Add(book3); 
author3.Books.Add(book4);  

var authorservice = new AuthorService();  
authorservice.AddAuthor(author1); 
authorservice.AddAuthor(author2); 
authorservice.AddAuthor(author3);  
System.Console.WriteLine();


var bookService = new BookService(); 
bookService.AddBook(book1);  
bookService.AddBook(book2); 
bookService.AddBook(book3); 
bookService.AddBook(book4);  
System.Console.WriteLine(); 

var authorFilters = new AuthorFilter();
authorFilters.FullName="Rob"; 
authorFilters.BirthYear=1852; 
authorFilters.Nationality="American";

foreach (var item in authorservice.GetAuthors(authorFilters))
{
  System.Console.WriteLine(item.Id);
  System.Console.WriteLine(item.BirthDate);
  System.Console.WriteLine(item.FirstName);
  System.Console.WriteLine(item.LastName);
  System.Console.WriteLine(item.Nationality);
}


