using System;
using System.Collections.Generic;

namespace LINS.Models;

public partial class VwIzvorPodataka
{
    public string IzvorPodatakaZaLokaciju { get; set; } = null!;

    public int? Kolicina { get; set; }
}
