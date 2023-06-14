using System;
using System.Collections.Generic;

namespace LINS.Models;

public partial class VwPolicijskaNadleznost
{
    public string PolicijskaNadleznost { get; set; } = null!;

    public int? Kolicina { get; set; }
}
