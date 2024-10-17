namespace HackathonVidlaci.Classes
{

    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    public class Zamky
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? OBJECTID { get; set; } // Nullable int

        [MaxLength(255)]
        public string? nazev { get; set; } // Nullable string

        [MaxLength(255)]
        public string? popis { get; set; } // Nullable string

        [MaxLength(255)]
        public string? nazev_vusc { get; set; } // Nullable string

        [MaxLength(255)]
        public string? kod_vusc { get; set; } // Nullable string

        [MaxLength(255)]
        public string? nazev_okresu { get; set; } // Nullable string

        [MaxLength(255)]
        public string? kod_okresu { get; set; } // Nullable string

        [MaxLength(255)]
        public string? nazev_orp { get; set; } // Nullable string

        [MaxLength(255)]
        public string? kod_orp { get; set; } // Nullable string

        [MaxLength(255)]
        public string? nazev_obce { get; set; } // Nullable string

        [MaxLength(255)]
        public string? kod_obce { get; set; } // Nullable string

        [MaxLength(255)]
        public string? nazev_ulice { get; set; } // Nullable string

        [MaxLength(255)]
        public string? cislo_domovni { get; set; } // Nullable string

        [MaxLength(255)]
        public string? typ_cisla_domovniho { get; set; } // Nullable string

        [MaxLength(255)]
        public string? cislo_orientacni { get; set; } // Nullable string

        [MaxLength(255)]
        public string? psc { get; set; } // Nullable string

        [MaxLength(255)]
        public string? www { get; set; } // Nullable string

        [MaxLength(255)]
        public string? wkt { get; set; } // Nullable string

        public double? x { get; set; } // Nullable double

        public double? y { get; set; } // Nullable double

        [MaxLength(255)]
        public string? dp_id { get; set; } // Nullable string

        [MaxLength(255)]
        public string? ds_id { get; set; } // Nullable string
    }

}
