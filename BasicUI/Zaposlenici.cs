using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicUI
{
    public class Zaposlenici
    {
        

        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Kontakt { get; set; }
        public string Odjel { get; set; }
        public string Zanimanje { get; set; }

        public Zaposlenici(int id, string ime, string prezime, string kontakt, string odjel, string zanimanje)
        {
            this.Id = id;
            this.Ime = ime;
            this.Prezime = prezime;
            this.Kontakt = kontakt;
            this.Odjel = odjel;
            this.Zanimanje = zanimanje;
        }

        public Zaposlenici(string ime)
        {
            this.Ime = ime;
        }

        public string FullName()
        {
            return $"dfaojfhdaij";
        }

        

    }
}
