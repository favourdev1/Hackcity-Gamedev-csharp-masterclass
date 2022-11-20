using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
namespace Library {
  class Program {
    public static void Main(string[] args) {
      Library b = new Library();
      b.AddBook("Amaka the mad woman", "Favour", "Favour okechwukwu", 2020, 123345678);

      b.AddBook("The girl and the snake", "Favour", "Favour okechwukwu", 2020, 123345678);

      b.AddBook("The girl and the snake", "Favour", "Favour okechwukwu", 2020, 123345678);

      // foreach (var bookInfo in b.Books){
      //   b.BookInfo(bookInfo);
      // }

      var search = b.SearchBook("The girl and the snake", "name");
      Console.WriteLine(search.Count + " " + search[0].Name);

      foreach(var a in search) {
        Console.WriteLine(a.Name);

      }

    }
  }

  class Book {
    public string Name;
    public string Author;
    public string Publisher;
    public int Publishyear;
    public int Isbn;
  }

  class Library {

    public List < Book > Books = new List < Book > ();

    public void AddBook(string name, string author, string publisher, int publishyear, int Isbn) {

      Book myBook = new Book {
        Name = name,
        Author = author,

        Publisher = publisher,
        Publishyear = publishyear,
        Isbn = Isbn,

      };

      Books.Add(myBook);

    }
    /*
* @params searchParam
* gets the search parameter
*/

    public List < Book > SearchBook(string searchString, string searchParam) {

      if (searchParam.ToLower() == "name") {
        return Books.Where(x =>x.Name == searchString).ToList();
      } else if (searchParam.ToLower() == "author") {
        return Books.Where(x =>x.Author == searchString).ToList();
      } else if (searchParam.ToLower() == "isbn") {
        return Books.Where(x =>x.Isbn == searchString).ToList();
      } else {
        return Books.Where(x =>x.Publisher == searchString).ToList();
      }

    }

  }

  public void DeleteBook(Book book) {
    Books.Remove(book);
  }

  public void BookInfo(Book book) {
    Console.WriteLine($ "Title-{book.Name}, Author-{book.Author}, ISBNnumber-{book.Isbn}");
  }

  // constructor 

  public Library() {

}

  public Library(string name, string author, string publisher, int publishyear, int Isbn) {

}

}
}
