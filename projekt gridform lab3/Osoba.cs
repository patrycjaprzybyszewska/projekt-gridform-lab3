using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace projekt_gridform_lab3
{
    [Serializable]
    public class Osoba
    {
        
        public string name { get; set; }
        public string last { get; set; }
        public string stan { get; set; }
        public string age { get; set; }
        public int id { get; set; }

        public Osoba(string Imie, string Nazwisko, string Stanowisko, string Wiek, int ID) {
            name = Imie;
            last = Nazwisko;
            stan = Stanowisko;
            age = Wiek;
            id = ID;

        
        }

        public Osoba() { }
    }

}
