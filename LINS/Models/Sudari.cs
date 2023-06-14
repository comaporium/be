using System;
using System.Collections.Generic;

namespace LINS.Models;

public partial class Sudari
{
    public short Fid { get; set; }

    public short RBr { get; set; }

    public string? LatidudaILongitudaIzvornoMup { get; set; }

    public double Latituda { get; set; }

    public double Longituda { get; set; }

    public string? Stacionaza { get; set; }

    public string IzvorPodatakaZaLokaciju { get; set; } = null!;

    public string MjestoMikrolokcija { get; set; } = null!;

    public string KategorijaSaobracajnice { get; set; } = null!;

    public string? OznakaSaobracajnice { get; set; }

    public string NazivSaobracajniceUlice { get; set; } = null!;

    public DateTime DatumNastankaSaobracajneNezgode { get; set; }

    public TimeSpan VrijemeNastankaSaobracajneNezgode { get; set; }

    public DateTime DatumIVrijemeNastankaSaobracajneNezgode { get; set; }

    public string DanUSedmiciNastanakSn { get; set; } = null!;

    public string VremenskeIAmbijentalnePrilikeIUslovi { get; set; } = null!;

    public string PeriodDana { get; set; } = null!;

    public string Vidljivost { get; set; } = null!;

    public string AmbijentalnePrilike { get; set; } = null!;

    public string Padavine { get; set; } = null!;

    public string StanjeKolovoza { get; set; } = null!;

    public byte? PutnickiAutomobilUcesnikSaobracajneNezgode { get; set; }

    public byte? PjesakUcesnikSaobracajneNezgode { get; set; }

    public byte? RomobilUcesnikSaobracajneNezgode { get; set; }

    public byte? BiciklUcesnikSaobracajneNezgode { get; set; }

    public byte? MotociklUcesnikSaobracajneNezgode { get; set; }

    public byte? LahkoTeretnoVoziloUcesnikSaobracajneNezgode { get; set; }

    public byte? TeskoTeretnoVoziloUcesnikSaobracajneNezgode { get; set; }

    public byte? AutobusUcesnikSaobracajneNezgode { get; set; }

    public string? TraktorUcesnikSaobracajneNezgode { get; set; }

    public string? DrugiUcesnikSaobracajneNezgode { get; set; }

    public string? BrojPoginulihOsoba { get; set; }

    public byte? BrojTeskoPovrijedjenihOsoba { get; set; }

    public byte? BrojLaksePovrijedjenihOsoba { get; set; }

    public byte KoeficijentZestineSaobracajneNezgode { get; set; }

    public string VrstaTipSaobracajneNezgodeIzvornoIzZapisnikaMupA { get; set; } = null!;

    public string VrstaTipSaobracajneNezgode { get; set; } = null!;

    public string PolicijskaNadleznost { get; set; } = null!;

    public string ObradioLa { get; set; } = null!;
}
