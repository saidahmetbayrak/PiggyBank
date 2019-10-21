using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank.Classes
{
    public abstract class Para
    {
        public decimal Degeri { get; set; }
        public double Yukseklik { get; set; }
        
        public double Hacim { get; set; }
        public ParaCesitleri isim { get; set; }

        public abstract double HacimHesapla();
    }
}
