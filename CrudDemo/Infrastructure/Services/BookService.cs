using Domain;

namespace Infrastructure;

public class BookService
{
    List<Book> _books = new List<Book>();

    public List<Book> GetBooks(BookFilter bookFilter)
    {
        List<Book> _filteredBooks = _books;

        if(bookFilter.Title  != null)
        {
            _filteredBooks = _filteredBooks.Where(x => x.Title.ToLower().Trim().Contains(bookFilter.Title.ToLower().Trim())).ToList();
        }
        if(bookFilter.Price  != null)
        {
            _filteredBooks = _filteredBooks.Where(x => x.Price>=bookFilter.Price).ToList();
        }
        if(bookFilter.PubYear  != null)
        {
            _filteredBooks = _filteredBooks.Where(x => x.PublicationYear==bookFilter.PubYear).ToList();
        }
        return _filteredBooks;
    }

    public List<Book> GetBooksByAuthorId(int authorId)
    {
        var book =  _books.FirstOrDefault(x=>x.AuthorId==authorId);
    if(book==null)
    {
        System.Console.WriteLine("Book not found by AuthorId");

    }
    return _books.Where(a=>a.AuthorId==authorId).ToList();

    }
    public Book GetBookById(int id)
    {
        var bookId = _books.FirstOrDefault(x=>x.Id == id);
          if(bookId==null)
    {
        System.Console.WriteLine("Book not found");
    }
    return bookId;
    }

    public void AddBook(Book book)
    {
        _books.Add(book);
        System.Console.WriteLine("Book successfully added");
    }

    public void UpdateAuthor(Book book)
    {
        var model = _books.FirstOrDefault(a=>a.Id == book.Id);
        if (model == null)
        {
            Console.WriteLine("Author not found");
            return;
        }

        model.Title = book.Title;
        model.Description = book.Description;
        model.PublicationYear = book.PublicationYear;
        model.AuthorId = book.AuthorId;
        model.PageSize = book.PageSize;
        model.Price = book.Price;
        Console.WriteLine("Book successfully updated");
        return;
    }

    public void DeleteAuthor(int id)
    {
        var delbook = _books.FirstOrDefault(x => x.Id==id);
          if (delbook == null)
        {
            Console.WriteLine("Author not found");
            return;
        }

        _books.Remove(delbook);
        Console.WriteLine("Book deleted successfully");
    }

}
