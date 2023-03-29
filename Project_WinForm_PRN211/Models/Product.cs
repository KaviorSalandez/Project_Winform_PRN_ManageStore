using System;
using System.Collections.Generic;

namespace Project_WinForm_PRN211.Models;

public partial class Product
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public double? Price { get; set; }

    public string? Descrip { get; set; }

    public int? Bid { get; set; }

    public int? Cid { get; set; }

    public int? Stock { get; set; }

    public virtual Brand? BidNavigation { get; set; }

    public virtual Category? CidNavigation { get; set; }
}
