using System;
using System.Collections.Generic;

namespace CustomerLibrary.Models;

public partial class Customer
{
    public string CustomerId { get; set; }

    public string CustomerName { get; set; }

    public string CustomerDesc { get; set; }

    public virtual ICollection<CustomerAccount> CustomerAccounts { get; } = new List<CustomerAccount>();
}
