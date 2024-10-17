using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HackathonVidlaci.Classes
{
    public class KulturniDomy
    {
        [Column("nazev")]
        [MaxLength(255)]
        public string? nazev { get; set; } // Nullable string

        [Column("provozovatel_zrizovatel")]
        [MaxLength(255)]
        public string? provozovatel_zrizovatel { get; set; } // Nullable string

        [Column("ico")]
        [MaxLength(255)]
        public string? ico { get; set; } // Nullable string

        [Column("bezbarierovost")]
        [MaxLength(255)]
        public string? bezbarierovost { get; set; } // Nullable string

        [Column("pozn_bezbarierovost")]
        [MaxLength(255)]
        public string? pozn_bezbarierovost { get; set; } // Nullable string

        [Column("technicka_vybavenost")]
        [MaxLength(255)]
        public string? technicka_vybavenost { get; set; } // Nullable string

        [Column("poradane_akce")]
        [MaxLength(32767)]
        public string? poradane_akce { get; set; } // Nullable string

        [Column("pocet_mist_k_sezeni")]
        public double? pocet_mist_k_sezeni { get; set; } // Nullable double

        [Column("pozn_ke_kapacite")]
        [MaxLength(255)]
        public string? pozn_ke_kapacite { get; set; } // Nullable string

        [Column("nazev_vusc")]
        [MaxLength(255)]
        public string? nazev_vusc { get; set; } // Nullable string

        [Column("kod_vusc")]
        [MaxLength(255)]
        public string? kod_vusc { get; set; } // Nullable string

        [Column("nazev_okresu")]
        [MaxLength(255)]
        public string? nazev_okresu { get; set; } // Nullable string

        [Column("kod_okresu")]
        [MaxLength(255)]
        public string? kod_okresu { get; set; } // Nullable string

        [Column("nazev_orp")]
        [MaxLength(255)]
        public string? nazev_orp { get; set; } // Nullable string

        [Column("kod_orp")]
        [MaxLength(255)]
        public string? kod_orp { get; set; } // Nullable string

        [Column("nazev_obce")]
        [MaxLength(255)]
        public string? nazev_obce { get; set; } // Nullable string

        [Column("kod_obce")]
        [MaxLength(255)]
        public string? kod_obce { get; set; } // Nullable string

        [Column("nazev_ulice")]
        [MaxLength(255)]
        public string? nazev_ulice { get; set; } // Nullable string

        [Column("cislo_domovni")]
        [MaxLength(255)]
        public string? cislo_domovni { get; set; } // Nullable string

        [Column("typ_cisla_domovniho")]
        [MaxLength(255)]
        public string? typ_cisla_domovniho { get; set; } // Nullable string

        [Column("cislo_orientacni")]
        [MaxLength(255)]
        public string? cislo_orientacni { get; set; } // Nullable string

        [Column("psc")]
        [MaxLength(255)]
        public string? psc { get; set; } // Nullable string

        [Column("www")]
        [MaxLength(255)]
        public string? www { get; set; } // Nullable string

        [Column("wkt")]
        [MaxLength(255)]
        public string? wkt { get; set; } // Nullable string

        [Column("x")]
        public double? x { get; set; } // Nullable double

        [Column("y")]
        public double? y { get; set; } // Nullable double

        [Column("dp_id")]
        [MaxLength(255)]
        public string? dp_id { get; set; } // Nullable string

        [Key]
        [Column("OBJECTID")]
        public int OBJECTID { get; set; }
    }
}
