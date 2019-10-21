using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank.Classes
{
    class BozukPara : Para
    {
        public BozukPara(double yaricap, double yukseklik)
        {
            Yukseklik = yukseklik;
            YariCap = yaricap;
        }
        public BozukPara()
        {

        }
        public double YariCap { get; set; }
        private double _kalinlik;
        public double Kalinlik
        {
            get
            {
                switch (isim)
                {
                    case ParaCesitleri.BirKurus:
                        _kalinlik = 0.165;
                        break;
                    case ParaCesitleri.BesKurus:
                        _kalinlik = 0.17;
                        break;
                    case ParaCesitleri.OnKurus:
                        _kalinlik = 0.17;
                        break;
                    case ParaCesitleri.YirmibesKurus:
                        _kalinlik = 0.19;
                        break;
                    case ParaCesitleri.ElliKurus:
                        _kalinlik = 0.195;
                        break;
                    case ParaCesitleri.BirLira:
                        _kalinlik = 0.195;
                        break;
                    default:
                        break;
                }
                return _kalinlik;
            }
        }

        public const double PI = 3.14;
        public const decimal birKurus = 0.01m;
        public const decimal besKurus = 0.05m;
        public const decimal onKurus = 0.1m;
        public const decimal yirmibesKurus = 0.25m;
        public const decimal elliKurus = 0.5m;
        public const decimal birLira = 1.00m;
        

        public override double HacimHesapla()
        {
            double hacim= PI * YariCap * YariCap * Kalinlik;
            Hacim = hacim;
            return Hacim;
        }
    }
}
