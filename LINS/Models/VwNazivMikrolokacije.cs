using System;
using System.Collections.Generic;

namespace LINS.Models;

public partial class VwNazivMikrolokacije
{
    public string MjestoMikrolokcija { get; set; } = null!;

    public int? Kolicina { get; set; }
}
