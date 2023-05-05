using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagerWeb.BusinessObject;

public partial class Account
{
    public int AccountId { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

	[Required]
	public string Email { get; set; }

    public int RoleId { get; set; }

    public DateTime? CreatedTime { get; set; }

    public DateTime? UpdateTime { get; set; }

    public string Phone { get; set; }

    public string Address { get; set; }

    public bool Gender { get; set; }

    public bool? Status { get; set; }

	[Required]
	public string Password { get; set; }

    public virtual ICollection<BooksBorrow> BooksBorrows { get; } = new List<BooksBorrow>();

    public virtual Role Role { get; set; }
}
