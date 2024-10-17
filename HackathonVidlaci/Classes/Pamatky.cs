
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HackathonVidlaci.Classes
{
 
    public class Pamatky
    {
      
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int OBJECTID { get; set; }

            [MaxLength(255)]
            public string nazev { get; set; }

            [MaxLength(255)]
            public string objekt { get; set; }

            [MaxLength(255)]
            public string ico { get; set; }

            [MaxLength(255)]
            public string pravni_forma { get; set; }

            [MaxLength(255)]
            public string uskp { get; set; }

            [MaxLength(255)]
            public string nazev_vusc { get; set; }

            [MaxLength(255)]
            public string kod_vusc { get; set; }

            [MaxLength(255)]
            public string nazev_okresu { get; set; }

            [MaxLength(255)]
            public string kod_okresu { get; set; }

            [MaxLength(255)]
            public string nazev_orp { get; set; }

            [MaxLength(255)]
            public string kod_orp { get; set; }

            [MaxLength(255)]
            public string nazev_obce { get; set; }

            [MaxLength(255)]
            public string kod_obce { get; set; }

            [MaxLength(255)]
            public string nazev_ulice { get; set; }

            [MaxLength(255)]
            public string cislo_domovni { get; set; }

            [MaxLength(255)]
            public string typ_cisla_domovniho { get; set; }

            [MaxLength(255)]
            public string cislo_orientacni { get; set; }

            [MaxLength(255)]
            public string psc { get; set; }

            [MaxLength(255)]
            public string www { get; set; }

            [MaxLength(255)]
            public string wkt { get; set; }

            public double? x { get; set; }

            public double? y { get; set; }

            [MaxLength(255)]
            public string dp_id { get; set; }
        
    }
}
