using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW2023_Tursim.Classes
{
    public class Turist : IComparable<Turist>, ICloneable
    {
        private int codTurist;
        private string nume;
        private string prenume;
        private string email;
        private string telefon;
        private DateTime dataNastere;
       
        public int CodTurist { get { return codTurist; } set { if (value > 0) { codTurist =value; } } }
        public string Nume { get { return nume; } set { nume = value; } }
        public string Prenume { get { return prenume; } set { prenume = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string Telefon { get { return telefon; } set { telefon = value; } }
        public DateTime DataNastere { get { return dataNastere; } set { dataNastere = value; } }

        public Turist(int codTurist, string nume, string prenume, string email, string telefon, DateTime dataNastere)
        {
            this.codTurist = codTurist;
            this.nume = nume;
            this.prenume = prenume;
            this.email = email;
            this.telefon = telefon;
            this.dataNastere = dataNastere;
           
        }

        public Turist()
        {
            this.codTurist = 0;
            this.nume = "N/A";
            this.prenume = "N/A";
            this.email = "N/A";
            this.telefon = "N/A";
            this.dataNastere = DateTime.Now;
        }

        public int CompareTo(Turist other)
        {
            Turist t2 = other as Turist;
            return this.nume.CompareTo(t2.nume);
        }

        public Turist(Turist copyTurist)
        {
            this.codTurist = copyTurist.codTurist;
            this.nume = copyTurist.nume;
            this.prenume = copyTurist.prenume;
            this.email = copyTurist.email;
            this.telefon = copyTurist.telefon;
            this.dataNastere = copyTurist.dataNastere;
        }

        public object Clone()
        {
            return new Turist(this);
        }
    }
}
