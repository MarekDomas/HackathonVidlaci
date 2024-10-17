using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace HackathonVidlaci.Classes;

public class Hrady
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Automatically generated primary key
    public int OBJECTID { get; set; } // ID field

    [MaxLength(255)]
    public string? nazev { get; set; } // Název

    [MaxLength(255)]
    public string? popis { get; set; } // Popis

    [MaxLength(255)]
    public string? nazev_vusc { get; set; } // Název vyššího územního samosprávného celku

    [MaxLength(255)]
    public string? kod_vusc { get; set; } // Kód vyššího územního samosprávného celku dle číselníku ČSÚ

    [MaxLength(255)]
    public string? nazev_okresu { get; set; } // Název okresu

    [MaxLength(255)]
    public string? kod_okresu { get; set; } // Kód okresu dle číselníku ČSÚ

    [MaxLength(255)]
    public string? nazev_orp { get; set; } // Název správního obvodu obce s rozšířenou působností

    [MaxLength(255)]
    public string? kod_orp { get; set; } // Kód správního obvodu obce s rozšířenou působností dle číselníku ČSÚ

    [MaxLength(255)]
    public string? nazev_obce { get; set; } // Název obce

    [MaxLength(255)]
    public string? kod_obce { get; set; } // Kód obce dle číselníku ČSÚ

    [MaxLength(255)]
    public string? nazev_ulice { get; set; } // Název ulice

    [MaxLength(255)]
    public string? cislo_domovni { get; set; } // Číslo popisné nebo evidenční podle typu čísla domovního

    [MaxLength(255)]
    public string? typ_cisla_domovniho { get; set; } // Typ čísla domovního

    [MaxLength(255)]
    public string? cislo_orientacni { get; set; } // Číslo orientační

    [MaxLength(255)]
    public string? psc { get; set; } // PSČ

    [MaxLength(255)]
    public string? www { get; set; } // Webové stránky

    [MaxLength(255)]
    public string? telefon { get; set; } // Telefon

    [MaxLength(255)]
    public string? wkt { get; set; } // Zápis vektorové geometrie

    public double? x { get; set; } // Zeměpisná délka v souřadnicovém systému WGS84

    public double? y { get; set; } // Zeměpisná šířka v souřadnicovém systému WGS84

    [MaxLength(255)]
    public string? dp_id { get; set; } // Jedinečný identifikátor v katalogu otevřených dat Data KHK

    [MaxLength(255)]
    public string? ds_id { get; set; }
}
