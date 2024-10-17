using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HackathonVidlaci.Classes;

public class ValHroby
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int OBJECTID { get; set; } // ID field

    public double? pocet_hrobu { get; set; } // Počet hrobů

    public double? počet_pohrbenych { get; set; } // Počet pohřbených

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
    public string? kod_obce { get; set; } // Kód obce

    [MaxLength(255)]
    public string? katastr { get; set; } // Katastrální území

    [MaxLength(255)]
    public string? cislo_parcely { get; set; } // Číslo parcely

    [MaxLength(255)]
    public string? wkt { get; set; } // Zápis vektorové geometrie

    public double? x { get; set; } // Zeměpisná délka v souřadnicovém systému WGS84

    public double? y { get; set; } // Zeměpisná šířka v souřadnicovém systému WGS84

    [MaxLength(255)]
    public string? dp_id { get; set; } // Jedinečný identifikátor v katalogu otevřených dat Data KHK

    [MaxLength(255)]
    public string? id { get; set; }
}
