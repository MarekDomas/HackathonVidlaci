using HackathonVidlaci.Classes;
using System.Diagnostics;

namespace HackathonVidlaci.Components.Pages
{
    public partial class Home
    {
        public List<string> msg = [];

        protected override void OnInitialized()
        {
            #region debug
          //  var data = technickePamatkyContext.Technické_památky.ToList();

            //foreach (var entry in data)
            //{
            //    msg.Add($"Name: {entry.nazev}, " +
            //            $"Description: {entry.popis}, " +
            //            $"VUSC Name: {entry.nazev_vusc}, " +
            //            $"VUSC Code: {entry.kod_vusc}, " +
            //            $"District Name: {entry.nazev_okresu}, " +
            //            $"District Code: {entry.kod_okresu}, " +
            //            $"ORP Name: {entry.nazev_orp}, " +
            //            $"ORP Code: {entry.kod_orp}, " +
            //            $"Municipality Name: {entry.nazev_obce}, " +
            //            $"Municipality Code: {entry.kod_obce}, " +
            //            $"Street Name: {entry.nazev_ulice}, " +
            //            $"House Number: {entry.cislo_domovni}, " +
            //            $"House Number Type: {entry.typ_cisla_domovniho}, " +
            //            $"Orientation Number: {entry.cislo_orientacni}, " +
            //            $"Postal Code: {entry.psc}, " +
            //            $"Website: {entry.www}, " +
            //            $"Phone: {entry.telefon}, " +
            //            $"WKT: {entry.wkt}, " +
            //            $"Longitude: {entry.x}, " +
            //            $"Latitude: {entry.y}, " +
            //            $"DP ID: {entry.dp_id}, " +
            //            $"DS ID: {entry.ds_id}, " +
            //            $"Object ID: {entry.OBJECTID}");
            //}

            //foreach (var entry in data)
            //{
            //    msg.Add($"Počet hrobů: {entry.pocet_hrobu}, " +
            //            $"Počet pohřbených: {entry.počet_pohrbenych}, " +
            //            $"Název VUSC: {entry.nazev_vusc}, " +
            //            $"Kód VUSC: {entry.kod_vusc}, " +
            //            $"Název okresu: {entry.nazev_okresu}, " +
            //            $"Kód okresu: {entry.kod_okresu}, " +
            //            $"Název ORP: {entry.nazev_orp}, " +
            //            $"Kód ORP: {entry.kod_orp}, " +
            //            $"Název obce: {entry.nazev_obce}, " +
            //            $"Kód obce: {entry.kod_obce}, " +
            //            $"Katastrální území: {entry.katastr}, " +
            //            $"Číslo parcely: {entry.cislo_parcely}, " +
            //            $"WKT: {entry.wkt}, " +
            //            $"Zeměpisná délka (X): {entry.x}, " +
            //            $"Zeměpisná šířka (Y): {entry.y}, " +
            //            $"DP ID: {entry.dp_id}, " +
            //            $"ID: {entry.id}, " +
            //            $"OBJECTID: {entry.OBJECTID}");
            //}

            //foreach (var entry in data)
            //{
            //    // Construct a message string with all fields
            //    msg.Add($"Název: {entry.nazev}, " +
            //              $"IČO: {entry.ico}, " +
            //              $"Popis: {entry.popis}, " +
            //              $"Typ zařízení: {entry.typ_zarizeni}, " +
            //              $"Zřizovatel: {entry.zrizovatel}, " +
            //              $"Kapacita: {entry.kapacita}, " +
            //              $"Bezbariérovost: {entry.bezbarierovost}, " +
            //              $"Typ bezbariérovosti: {entry.typ_bezbarierovosti}, " +
            //              $"Název vyššího územního samosprávného celku: {entry.nazev_vusc}, " +
            //              $"Kód vyššího územního samosprávného celku: {entry.kod_vusc}, " +
            //              $"Název okresu: {entry.nazev_okresu}, " +
            //              $"Kód okresu: {entry.kod_okresu}, " +
            //              $"Název správního obvodu: {entry.nazev_orp}, " +
            //              $"Kód správního obvodu: {entry.kod_orp}, " +
            //              $"Název obce: {entry.nazev_obce}, " +
            //              $"Kód obce: {entry.kod_obce}, " +
            //              $"Název ulice: {entry.nazev_ulice}, " +
            //              $"Číslo domovní: {entry.cislo_domovni}, " +
            //              $"Typ čísla domovního: {entry.typ_cisla_domovniho}, " +
            //              $"Číslo orientační: {entry.cislo_orientacni}, " +
            //              $"PSČ: {entry.psc}, " +
            //              $"Webové stránky: {entry.www}, " +
            //              $"Telefon: {entry.telefon}, " +
            //              $"Email: {entry.email}, " +
            //              $"WKT: {entry.wkt}, " +
            //              $"Zeměpisná délka: {entry.x}, " +
            //              $"Zeměpisná šířka: {entry.y}, " +
            //              $"Jedinečný identifikátor v katalogu: {entry.dp_id}, " +
            //              $"ID: {entry.OBJECTID}");

            //    //Console.WriteLine(msg); // Output the message
            //}

            //foreach (var entry in data)
            //{
            //    // Construct a message string with all fields
            //    msg.Add($"ID: {entry.OBJECTID}, " +
            //              $"Název: {entry.nazev}, " +
            //              $"Popis: {entry.popis}, " +
            //              $"Název vyššího územního samosprávného celku: {entry.nazev_vusc}, " +
            //              $"Kód vyššího územního samosprávného celku: {entry.kod_vusc}, " +
            //              $"Název okresu: {entry.nazev_okresu}, " +
            //              $"Kód okresu: {entry.kod_okresu}, " +
            //              $"Název správního obvodu: {entry.nazev_orp}, " +
            //              $"Kód správního obvodu: {entry.kod_orp}, " +
            //              $"Název obce: {entry.nazev_obce}, " +
            //              $"Kód obce: {entry.kod_obce}, " +
            //              $"Název ulice: {entry.nazev_ulice}, " +
            //              $"Číslo domovní: {entry.cislo_domovni}, " +
            //              $"Typ čísla domovního: {entry.typ_cisla_domovniho}, " +
            //              $"Číslo orientační: {entry.cislo_orientacni}, " +
            //              $"PSČ: {entry.psc}, " +
            //              $"Webové stránky: {entry.www}, " +
            //              $"WKT: {entry.wkt}, " +
            //              $"Zeměpisná délka: {entry.x}, " +
            //              $"Zeměpisná šířka: {entry.y}, " +
            //              $"Jedinečný identifikátor v katalogu: {entry.dp_id}, " +
            //              $"DS ID: {entry.ds_id}");

            //    //Console.WriteLine(msg); // Output the message
            //}

            //foreach (var entry in data)
            //{
            //    // Construct a message string with all fields
            //    msg.Add($"Název: {entry.nazev}, " +
            //              $"Provozovatel nebo zřizovatel: {entry.provozovatel_zrizovatel}, " +
            //              $"IČO: {entry.ico}, " +
            //              $"Bezbariérovost: {entry.bezbarierovost}, " +
            //              $"Poznámka k bezbariérovosti: {entry.pozn_bezbarierovost}, " +
            //              $"Technická vybavenost: {entry.technicka_vybavenost}, " +
            //              $"Pořádané akce: {entry.poradane_akce}, " +
            //              $"Počet míst k sezení: {entry.pocet_mist_k_sezeni}, " +
            //              $"Poznámka ke kapacitě: {entry.pozn_ke_kapacite}, " +
            //              $"Název vyššího územního samosprávného celku: {entry.nazev_vusc}, " +
            //              $"Kód vyššího územního samosprávného celku: {entry.kod_vusc}, " +
            //              $"Název okresu: {entry.nazev_okresu}, " +
            //              $"Kód okresu: {entry.kod_okresu}, " +
            //              $"Název správního obvodu: {entry.nazev_orp}, " +
            //              $"Kód správního obvodu: {entry.kod_orp}, " +
            //              $"Název obce: {entry.nazev_obce}, " +
            //              $"Kód obce: {entry.kod_obce}, " +
            //              $"Název ulice: {entry.nazev_ulice}, " +
            //              $"Číslo domovní: {entry.cislo_domovni}, " +
            //              $"Typ čísla domovního: {entry.typ_cisla_domovniho}, " +
            //              $"Číslo orientační: {entry.cislo_orientacni}, " +
            //              $"PSČ: {entry.psc}, " +
            //              $"Webové stránky: {entry.www}, " +
            //              $"Zápis vektorové geometrie: {entry.wkt}, " +
            //              $"Zeměpisná délka: {entry.x}, " +
            //              $"Zeměpisná šířka: {entry.y}, " +
            //              $"Jedinečný identifikátor v katalogu: {entry.dp_id}, " +
            //              $"ID: {entry.OBJECTID}");

            //    //Console.WriteLine(msg); // Output the message
            //}
            //foreach (var entry in data)
            //{
            //    // Construct a message string with all fields
            //    msg.Add($"Název: {entry.nazev}, " +
            //             $"Popis: {entry.popis}, " +
            //             $"Název vyššího územního samosprávného celku: {entry.nazev_vusc}, " +
            //             $"Kód vyššího územního samosprávného celku: {entry.kod_vusc}, " +
            //             $"Název okresu: {entry.nazev_okresu}, " +
            //             $"Kód okresu: {entry.kod_okresu}, " +
            //             $"Název správního obvodu: {entry.nazev_orp}, " +
            //             $"Kód správního obvodu: {entry.kod_orp}, " +
            //             $"Název obce: {entry.nazev_obce}, " +
            //             $"Kód obce: {entry.kod_obce}, " +
            //             $"Název ulice: {entry.nazev_ulice}, " +
            //             $"Číslo domovní: {entry.cislo_domovni}, " +
            //             $"Typ čísla domovního: {entry.typ_cisla_domovniho}, " +
            //             $"Číslo orientační: {entry.cislo_orientacni}, " +
            //             $"PSČ: {entry.psc}, " +
            //             $"Webové stránky: {entry.www}, " +
            //             $"Telefon: {entry.telefon}, " +
            //             $"Zápis vektorové geometrie: {entry.wkt}, " +
            //             $"Zeměpisná délka: {entry.x}, " +
            //             $"Zeměpisná šířka: {entry.y}, " +
            //             $"Jedinečný identifikátor v katalogu: {entry.dp_id}, " +
            //             $"Jedinečný identifikátor v datovém skladu: {entry.ds_id}, " +
            //             $"ID: {entry.OBJECTID}");

            //    // Uncomment the following line to output the message
            //    // Console.WriteLine(msg); // Output the message
            //}
            #endregion


            base.OnInitialized();
        }

        private void klik()
        {
            Debug.Print("s");
        }

    }
}
