using System;
using System.Collections.Generic;

namespace BusinessObject.Models;

public partial class Hraccount
{
    public string Email { get; set; }

    public string Password { get; set; }

    public string FullName { get; set; }

    public string MemberRole { get; set; }
}
