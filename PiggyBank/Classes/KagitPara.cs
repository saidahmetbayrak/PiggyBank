using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank.Classes
{
    class KagitPara : Para
    {
      
        public KagitPara()
        {

        }

        private double _boy;
        public double Boy
        {
            get
            {
                switch (isim)
                {
                    case ParaCesitleri.BesLira:
                        _boy = 13;
                        break;
                    case ParaCesitleri.OnLira:
                        _boy = 13.6;
                        break;
                    case ParaCesitleri.YirmiLira:
                        _boy = 14.2;
                        break;
                    case ParaCesitleri.ElliLira:
                        _boy = 14.8;
                        break;
                    case ParaCesitleri.YuzLira:
                        _boy = 15.4;
                        break;
                    case ParaCesitleri.İkiyuzLira:
                        _boy = 16;
                        break;   
                }
                return _boy;
            }
        }
        private double _en;
        public double En
        {
            get
            {
                switch (isim)
                {
                    case ParaCesitleri.BesLira:
                        break;
                    case ParaCesitleri.OnLira:
                        _en = 6.4;
                        break;
                    case ParaCesitleri.YirmiLira:
                        break;
                    case ParaCesitleri.ElliLira:
                        _en = 6.8;
                        break;
                    case ParaCesitleri.YuzLira:
                        break;
                    case ParaCesitleri.İkiyuzLira:
                        _en = 7.2;
                        break;
                }
                return _en;
            } 
        }

        // public bool KatlanmisMi { get; set; }

        public const double yukseklik = 0.25;
        public const decimal besLira = 5.00m;
        public const decimal onLira = 10.00m;
        public const decimal yirmiLira = 20.00m;
        public const decimal elliLira = 50.00m;
        public const decimal yuzLira = 100.00m;
        public const decimal ikiyuzLira = 200.00m;
        
        
        public override double HacimHesapla()
        {
            return En * Boy * yukseklik;
        }
    }
}
