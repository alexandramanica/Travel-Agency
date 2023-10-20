using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW2023_Tursim.Classes
{
    public delegate void SchimbareDePretDelegate(float pretVechi, float pretNou);
    public class Serviciu: IComparable<Serviciu>
    {
        private int idServiciu;
        private string numeDestinatie;
        private float pretZi;
        private int nrZile;
        private int nrPers;
        private string hotel;
        private string[] activitati;
        private DateTime dataInceput;

        public int IdServiciu { get { return idServiciu; } set { if (value > 0) { idServiciu = value; } } }
        public string NumeDestinatie { get { return numeDestinatie; } set { numeDestinatie = value; } }
        public int NrZile { get { return nrZile; } set { if (value > 0) { nrZile = value; } } }

        public int NrPers { get { return nrPers; } set { if (value > 0) { nrPers = value; } } }
        public string Hotel { get { return hotel; } set { hotel = value; } }
        private string[] Activitati { get { return activitati; } set {
                for (int i = 0; i < value.Length; i++)
                { this.activitati[i] = value[i]; } } }
        public DateTime DataInceput { get { return dataInceput; } set { dataInceput = value; } }

        //proprietati + event + delegate

        public event SchimbareDePretDelegate schimbareDePret;
        public float PretZi { 
            get { return pretZi; }
            set {
                if (pretZi == value) return;
                else
                {  float pretVechi = pretZi;
                   pretZi = value;
                    if (schimbareDePret != null)
                    { schimbareDePret(pretVechi, pretZi); }
                }
            } 
        }


        public Serviciu(int idServiciu,string numeDestinatie, float pretZi, int nrZile, int nrPers, string hotel, string[] activitati, DateTime dataInceput)
        {
            this.idServiciu = idServiciu;
            this.numeDestinatie = numeDestinatie;
            this.pretZi = pretZi;
            this.nrZile = nrZile;
            this.nrPers = nrPers;
            this.hotel = hotel;
            this.dataInceput = dataInceput;
            this.activitati = new string[activitati.Length];
            for (int i = 0; i < activitati.Length; i++)
            { this.activitati[i] = activitati[i]; }
        }

        public Serviciu()
        {
            this.idServiciu = 0;
            this.numeDestinatie = "N/A";
            this.pretZi = 0;
            this.nrZile = 0;
            this.nrPers = 0;
            this.hotel = "N/A";
            this.dataInceput = DateTime.Now;
        }

        //metoda de prelucrare a datelor - valoare totala serviciu
        public float calculeazaPretTotal()
        {
            float s = 1;
            s = (float)(pretZi * nrZile);
            return s;
        }

        //metoda de prelucrare a datelor - cost serviciu per persoana
        public float calculPretPersoana()
        {
            float p = 1;
            p = (float)(pretZi * nrZile)/nrPers;
            return p;
        }
        //metoda de prelucrare a datelor - calcularea datei de final al serviciului
        private DateTime CalculareDataSfarsit()
        {
            return dataInceput.AddDays(nrZile);
        }

        public int CompareTo(Serviciu other)
        {
            return this.idServiciu.CompareTo(other.idServiciu);
        }

        //operatori

        //adaugarea unei noi activitati aferente unui serviciu - operator+
        public static Serviciu operator +(Serviciu s, string activitateNoua)
        {
            string[] act_nou = new string[s.activitati.Length + 1];
            for (int i = 0; i < s.activitati.Length; i++)
            {
                act_nou[i] = s.activitati[i];
            }

            act_nou[act_nou.Length - 1] = activitateNoua;

            s.activitati = act_nou;

            return s;
        }

        //stergerea unei activitati aferente unui serviciu, activitatea fiind specifacata - operator+
        public static Serviciu operator -(Serviciu s, string activitateStergere)
        {
            int poz = -1;
            for (int i = 0; i < s.activitati.Length; i++)
            {
                if (s.activitati[i] == activitateStergere)
                {
                    poz = i;
                }
            }

            if (poz != -1)
            {
                string[] act_nou = new string[s.activitati.Length - 1];
                int index = 0;
                for (int i = 0; i < s.activitati.Length; i++)
                {
                    if (i != poz)
                    {
                        act_nou[index] = s.activitati[i];
                        index++;
                    }
                }

                s.activitati = act_nou;
            }

            return s;
        }


        //cautarea unei activitati aferente unui serviciu
        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < activitati.Length)
                {
                    return activitati[index];
                }
                else
                { return "Pozitia ceruta nu corespunda niciunei activitati"; }
            }
        }

     
    }
}
