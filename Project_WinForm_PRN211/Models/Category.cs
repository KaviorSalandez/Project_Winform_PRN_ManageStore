using System;
using System.Collections.Generic;

namespace Project_WinForm_PRN211.Models;

public partial class Category
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Product> Products { get; } = new List<Product>();
}
