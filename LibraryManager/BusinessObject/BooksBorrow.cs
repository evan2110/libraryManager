using System;
using System.Collections.Generic;

namespace LibraryManagerWeb.BusinessObject;

public partial class BooksBorrow
{
    public int BookBorrowId { get; set; }

    public int AccountId { get; set; }

    public int BookId { get; set; }

    public DateTime DateBorrowed { get; set; }

    public DateTime DueDate { get; set; }

    public bool? Status { get; set; }

    public DateTime? DateReturn { get; set; }

    public string ReceivedBy { get; set; }

    public virtual Account Account { get; set; }

    public virtual Book Book { get; set; }
}
