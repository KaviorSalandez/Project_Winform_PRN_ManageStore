using System;
using System.Collections.Generic;

namespace Project_WinForm_PRN211.Models;

public partial class Role
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Account> Accounts { get; } = new List<Account>();
}
