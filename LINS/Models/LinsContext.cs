using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace LINS.Models;

public partial class LinsContext : DbContext
{
    public LinsContext()
    {
    }

    public LinsContext(DbContextOptions<LinsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Sudari> Sudaris { get; set; }

    public virtual DbSet<VwAmbijentalnePrilike> VwAmbijentalnePrilikes { get; set; }

    public virtual DbSet<VwBrojniProsjeci> VwBrojniProsjecis { get; set; }

    public virtual DbSet<VwDaniUsedmici> VwDaniUsedmicis { get; set; }

    public virtual DbSet<VwIzvorPodataka> VwIzvorPodatakas { get; set; }

    public virtual DbSet<VwKategorijaSaobracajnice> VwKategorijaSaobracajnices { get; set; }

    public virtual DbSet<VwNazivMikrolokacije> VwNazivMikrolokacijes { get; set; }

    public virtual DbSet<VwNazivUlice> VwNazivUlices { get; set; }

    public virtual DbSet<VwOznakaSaobracajnice> VwOznakaSaobracajnices { get; set; }

    public virtual DbSet<VwPadavine> VwPadavines { get; set; }

    public virtual DbSet<VwPeriodDana> VwPeriodDanas { get; set; }

    public virtual DbSet<VwPolicijskaNadleznost> VwPolicijskaNadleznosts { get; set; }

    public virtual DbSet<VwStanjeKolovoza> VwStanjeKolovozas { get; set; }

    public virtual DbSet<VwVidljivost> VwVidljivosts { get; set; }

    public virtual DbSet<VwVrstaSaobracajneNezgode> VwVrstaSaobracajneNezgodes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=RICCI\\SQLEXPRESS;Database=LINS;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Sudari>(entity =>
        {
            entity.HasKey(e => e.Fid);

            entity.ToTable("sudari");

            entity.Property(e => e.Fid)
                .ValueGeneratedNever()
                .HasColumnName("fid");
            entity.Property(e => e.AmbijentalnePrilike)
                .HasMaxLength(150)
                .HasColumnName("Ambijentalne_prilike");
            entity.Property(e => e.AutobusUcesnikSaobracajneNezgode).HasColumnName("Autobus_ucesnik_saobracajne_nezgode");
            entity.Property(e => e.BiciklUcesnikSaobracajneNezgode).HasColumnName("Bicikl_ucesnik_saobracajne_nezgode");
            entity.Property(e => e.BrojLaksePovrijedjenihOsoba).HasColumnName("Broj_lakse_povrijedjenih_osoba");
            entity.Property(e => e.BrojPoginulihOsoba)
                .HasMaxLength(1)
                .HasColumnName("Broj_poginulih_osoba");
            entity.Property(e => e.BrojTeskoPovrijedjenihOsoba).HasColumnName("Broj_tesko_povrijedjenih_osoba");
            entity.Property(e => e.DanUSedmiciNastanakSn)
                .HasMaxLength(150)
                .HasColumnName("Dan_u_sedmici_nastanak_SN");
            entity.Property(e => e.DatumIVrijemeNastankaSaobracajneNezgode).HasColumnName("Datum_i_vrijeme_nastanka_saobracajne_nezgode");
            entity.Property(e => e.DatumNastankaSaobracajneNezgode)
                .HasColumnType("date")
                .HasColumnName("Datum_nastanka_saobracajne_nezgode");
            entity.Property(e => e.DrugiUcesnikSaobracajneNezgode)
                .HasMaxLength(150)
                .HasColumnName("Drugi_ucesnik_saobracajne_nezgode");
            entity.Property(e => e.IzvorPodatakaZaLokaciju)
                .HasMaxLength(150)
                .HasColumnName("Izvor_podataka_za_lokaciju");
            entity.Property(e => e.KategorijaSaobracajnice)
                .HasMaxLength(150)
                .HasColumnName("Kategorija_saobracajnice");
            entity.Property(e => e.KoeficijentZestineSaobracajneNezgode).HasColumnName("Koeficijent_zestine_saobracajne_nezgode");
            entity.Property(e => e.LahkoTeretnoVoziloUcesnikSaobracajneNezgode).HasColumnName("Lahko_teretno_vozilo_ucesnik_saobracajne_nezgode");
            entity.Property(e => e.LatidudaILongitudaIzvornoMup)
                .HasMaxLength(150)
                .HasColumnName("Latiduda_i_longituda_izvorno_MUP");
            entity.Property(e => e.MjestoMikrolokcija)
                .HasMaxLength(150)
                .HasColumnName("Mjesto_mikrolokcija");
            entity.Property(e => e.MotociklUcesnikSaobracajneNezgode).HasColumnName("Motocikl_ucesnik_saobracajne_nezgode");
            entity.Property(e => e.NazivSaobracajniceUlice)
                .HasMaxLength(150)
                .HasColumnName("Naziv_saobracajnice_ulice");
            entity.Property(e => e.ObradioLa)
                .HasMaxLength(150)
                .HasColumnName("Obradio_la");
            entity.Property(e => e.OznakaSaobracajnice)
                .HasMaxLength(150)
                .HasColumnName("Oznaka_saobracajnice");
            entity.Property(e => e.Padavine).HasMaxLength(150);
            entity.Property(e => e.PeriodDana)
                .HasMaxLength(150)
                .HasColumnName("Period_dana");
            entity.Property(e => e.PjesakUcesnikSaobracajneNezgode).HasColumnName("Pjesak_ucesnik_saobracajne_nezgode");
            entity.Property(e => e.PolicijskaNadleznost)
                .HasMaxLength(150)
                .HasColumnName("Policijska_nadleznost");
            entity.Property(e => e.PutnickiAutomobilUcesnikSaobracajneNezgode).HasColumnName("Putnicki_automobil_ucesnik_saobracajne_nezgode");
            entity.Property(e => e.RBr).HasColumnName("R_br");
            entity.Property(e => e.RomobilUcesnikSaobracajneNezgode).HasColumnName("Romobil_ucesnik_saobracajne_nezgode");
            entity.Property(e => e.Stacionaza).HasMaxLength(1);
            entity.Property(e => e.StanjeKolovoza)
                .HasMaxLength(150)
                .HasColumnName("Stanje_kolovoza");
            entity.Property(e => e.TeskoTeretnoVoziloUcesnikSaobracajneNezgode).HasColumnName("Tesko_teretno_vozilo_ucesnik_saobracajne_nezgode");
            entity.Property(e => e.TraktorUcesnikSaobracajneNezgode)
                .HasMaxLength(1)
                .HasColumnName("Traktor_ucesnik_saobracajne_nezgode");
            entity.Property(e => e.Vidljivost).HasMaxLength(150);
            entity.Property(e => e.VremenskeIAmbijentalnePrilikeIUslovi)
                .HasMaxLength(150)
                .HasColumnName("Vremenske_i_ambijentalne_prilike_i_uslovi");
            entity.Property(e => e.VrijemeNastankaSaobracajneNezgode).HasColumnName("Vrijeme_nastanka_saobracajne_nezgode");
            entity.Property(e => e.VrstaTipSaobracajneNezgode)
                .HasMaxLength(150)
                .HasColumnName("Vrsta_tip_saobracajne_nezgode");
            entity.Property(e => e.VrstaTipSaobracajneNezgodeIzvornoIzZapisnikaMupA)
                .HasMaxLength(150)
                .HasColumnName("Vrsta_tip_saobracajne_nezgode_izvorno_iz_zapisnika_MUP_a");
        });

        modelBuilder.Entity<VwAmbijentalnePrilike>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VwAmbijentalnePrilike");

            entity.Property(e => e.AmbijentalnePrilike)
                .HasMaxLength(150)
                .HasColumnName("Ambijentalne_prilike");
            entity.Property(e => e.Kolicina).HasColumnName("kolicina");
        });

        modelBuilder.Entity<VwBrojniProsjeci>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VwBrojniProsjeci");
        });

        modelBuilder.Entity<VwDaniUsedmici>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VwDaniUSedmici");

            entity.Property(e => e.DanUSedmiciNastanakSn)
                .HasMaxLength(150)
                .HasColumnName("Dan_u_sedmici_nastanak_SN");
            entity.Property(e => e.Kolicina).HasColumnName("kolicina");
        });

        modelBuilder.Entity<VwIzvorPodataka>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VwIzvorPodataka");

            entity.Property(e => e.IzvorPodatakaZaLokaciju)
                .HasMaxLength(150)
                .HasColumnName("Izvor_podataka_za_lokaciju");
            entity.Property(e => e.Kolicina).HasColumnName("kolicina");
        });

        modelBuilder.Entity<VwKategorijaSaobracajnice>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VwKategorijaSaobracajnice");

            entity.Property(e => e.KategorijaSaobracajnice)
                .HasMaxLength(150)
                .HasColumnName("Kategorija_saobracajnice");
            entity.Property(e => e.Kolicina).HasColumnName("kolicina");
        });

        modelBuilder.Entity<VwNazivMikrolokacije>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VwNazivMikrolokacije");

            entity.Property(e => e.Kolicina).HasColumnName("kolicina");
            entity.Property(e => e.MjestoMikrolokcija)
                .HasMaxLength(150)
                .HasColumnName("Mjesto_mikrolokcija");
        });

        modelBuilder.Entity<VwNazivUlice>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VwNazivUlice");

            entity.Property(e => e.Kolicina).HasColumnName("kolicina");
            entity.Property(e => e.NazivSaobracajniceUlice)
                .HasMaxLength(150)
                .HasColumnName("Naziv_saobracajnice_ulice");
        });

        modelBuilder.Entity<VwOznakaSaobracajnice>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VwOznakaSaobracajnice");

            entity.Property(e => e.Kolicina).HasColumnName("kolicina");
            entity.Property(e => e.OznakaSaobracajnice)
                .HasMaxLength(150)
                .HasColumnName("Oznaka_saobracajnice");
        });

        modelBuilder.Entity<VwPadavine>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VwPadavine");

            entity.Property(e => e.Kolicina).HasColumnName("kolicina");
            entity.Property(e => e.Padavine).HasMaxLength(150);
        });

        modelBuilder.Entity<VwPeriodDana>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VwPeriodDana");

            entity.Property(e => e.Kolicina).HasColumnName("kolicina");
            entity.Property(e => e.PeriodDana)
                .HasMaxLength(150)
                .HasColumnName("Period_dana");
        });

        modelBuilder.Entity<VwPolicijskaNadleznost>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VwPolicijskaNadleznost");

            entity.Property(e => e.Kolicina).HasColumnName("kolicina");
            entity.Property(e => e.PolicijskaNadleznost)
                .HasMaxLength(150)
                .HasColumnName("Policijska_nadleznost");
        });

        modelBuilder.Entity<VwStanjeKolovoza>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VwStanjeKolovoza");

            entity.Property(e => e.Kolicina).HasColumnName("kolicina");
            entity.Property(e => e.StanjeKolovoza)
                .HasMaxLength(150)
                .HasColumnName("Stanje_kolovoza");
        });

        modelBuilder.Entity<VwVidljivost>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VwVidljivost");

            entity.Property(e => e.Kolicina).HasColumnName("kolicina");
            entity.Property(e => e.Vidljivost).HasMaxLength(150);
        });

        modelBuilder.Entity<VwVrstaSaobracajneNezgode>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VwVrstaSaobracajneNezgode");

            entity.Property(e => e.Kolicina).HasColumnName("kolicina");
            entity.Property(e => e.VrstaTipSaobracajneNezgode)
                .HasMaxLength(150)
                .HasColumnName("Vrsta_tip_saobracajne_nezgode");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
