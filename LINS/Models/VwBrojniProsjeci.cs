using System;
using System.Collections.Generic;

namespace LINS.Models;

public partial class VwBrojniProsjeci
{
    public int? KoeficijentZestineSaobNezgode { get; set; }

    public int? BrojLaksePovrijedjenihOsobaAvg { get; set; }

    public int? BrojTezePovrijedjenihOsobaAvg { get; set; }

    public TimeSpan? VrijemeAvg { get; set; }

    public int? BrojPjesakaAvg { get; set; }
}
