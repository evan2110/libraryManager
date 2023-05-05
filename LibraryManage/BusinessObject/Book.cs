using System;
using System.Collections.Generic;

namespace LibraryManage.BusinessObject;

public partial class Book
{
    public int BookId { get; set; }

    public string Title { get; set; }

    public string Author { get; set; }

    public DateTime PublicationDate { get; set; }

    public int AvailableCopies { get; set; }

    public int TotalCopies { get; set; }

    public string ShelfLocation { get; set; }

    public virtual ICollection<BooksBorrow> BooksBorrows { get; } = new List<BooksBorrow>();

    public Book(int bookId, string title, string author, DateTime publicationDate, int availableCopies, int totalCopies, string shelfLocation)
    {
        BookId = bookId;
        Title = title;
        Author = author;
        PublicationDate = publicationDate;
        AvailableCopies = availableCopies;
        TotalCopies = totalCopies;
        ShelfLocation = shelfLocation;
    }

    public Book()
    {
    }
}
