using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiInmoto.Model.Domain
{
    public class Sklep : Entity
    {
        public bool Aktualny { get; set; }
        public string Nazwa { get; set; }
        public string Alias { get; set; }
        public int ProduktOfertaSklepID { get; set; }
        public bool CzyPrzeliczanieCen { get; set; }
        public string Kategoria { get; set; }
        public string Telefon { get; set; }
        public string Telefon2 { get; set; }
        public string Email { get; set; }
        public string GodzinyPracyTydzien { get; set; }
        public string GodzinyPracyWeekend { get; set; }
        public bool CzySklepWlasny { get; set; }
        public string Regulamin { get; set; }
        public int AktualnySezon { get; set; }
        public int KrajID { get; set; }
        public string AdresStrony { get; set; }
        public decimal StawkaVat { get; set; }
        public int StaryDOTRok { get; set; }
    }
}
