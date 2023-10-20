using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW2023_Tursim.Classes
{
    public class Tranzactie : AbsGenerareCodUnic, IComparable<Tranzactie>
    {
        private int codTranzactie;
        private DateTime dataTranzactie;
        private float valoareTranzactie;
        private int codClientAsociat;
        private int codServiciuAsociat;

        public Tranzactie()
        {
            this.codTranzactie = 0;
            this.dataTranzactie = DateTime.Now;
            this.valoareTranzactie = 0;
            this.codClientAsociat = 0;
            this.codServiciuAsociat = 0;
        }

        public Tranzactie(int codTranzactie, float valoareTranzactie, int codClientAsociat, int codServiciuAsociat ,DateTime dataTranzactie)
        {
            this.codTranzactie = codTranzactie;
            this.dataTranzactie = dataTranzactie;
            this.valoareTranzactie = valoareTranzactie;
            this.codClientAsociat = codClientAsociat;
            this.codServiciuAsociat = codServiciuAsociat;
        }

        public int CodTranzactie { get { return codTranzactie; } set { if (value >0) { codTranzactie = value; } } }
        public DateTime DataTranzactie { get { return dataTranzactie; } set { dataTranzactie = value; } }
        public float ValoareTranzactie { get { return valoareTranzactie; } set { if(value > 0){ valoareTranzactie = value; } } }
   
        public int CodClientAsociat { get { return codClientAsociat; } set { if (value > 0) { codClientAsociat = value; } } }
    
        public int CodServiciuAsociat { get { return codServiciuAsociat; } set { if (value > 0) { codServiciuAsociat = value; } } }

        public int CompareTo(Tranzactie other)
        {
           return this.CodTranzactie.CompareTo(other.CodTranzactie);
        }

        //metoda abstracta
        public override string GenerareCodUnic()
        {
            return $"{CodTranzactie}-{dataTranzactie.ToString("yyyyMMdd")}";
        }
    }

}
