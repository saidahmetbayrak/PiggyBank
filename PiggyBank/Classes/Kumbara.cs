using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank.Classes
{
    class Kumbara:ISallanabilirlik
    {
        Random random = new Random();
        
       // private double _paraninFazlaHacmi = 0;
        
        public double ParaninFazlaHacmi { get; set; }
        private decimal _birikmisPara = 0;
        public double Hacim { get; set; }
        private KumbaraDurumu _durum = KumbaraDurumu.Sifir;
        public KumbaraDurumu Durum
        {   get
            {
                return _durum;
            }
            set
            {
                _durum = value;
                if (_durum==KumbaraDurumu.Yapistirilmis)
                {
                    System.Windows.Forms.MessageBox.Show(UyariKutuphanesi.KumbaraYapistirildi());      
                }
            }
        }
        public Kumbara()
        {
            Hacim = 500;
        }
        public decimal Break()
        {
            decimal tumPara = _birikmisPara;
            _birikmisPara = 0;
            Durum = KumbaraDurumu.Kirik;
            System.Windows.Forms.MessageBox.Show(UyariKutuphanesi.KumbaraKirildi());
            return tumPara;
        }
        public double Shake(double fazladanKaplananHacim)
        {
            return fazladanKaplananHacim * 0.25;
        }
        public void ParaEkle(Para para)
        {
            if (Durum==KumbaraDurumu.Kirik)
            {
                System.Windows.Forms.MessageBox.Show(UyariKutuphanesi.KumbaraKirik());
            }
            switch (para.isim)
            {
                case ParaCesitleri.BirKurus:
                    para.Degeri = BozukPara.birKurus;
                    ((BozukPara)para).YariCap = 0.85;
                    break;
                case ParaCesitleri.BesKurus:
                    para.Degeri = BozukPara.besKurus;
                    ((BozukPara)para).YariCap = 0.85;
                    break;
                case ParaCesitleri.OnKurus:
                    para.Degeri = BozukPara.onKurus;
                    ((BozukPara)para).YariCap = 0.96;
                    break;
                case ParaCesitleri.YirmibesKurus:
                    para.Degeri = BozukPara.yirmibesKurus;
                    ((BozukPara)para).YariCap = 1.075;
                    break;
                case ParaCesitleri.ElliKurus:
                    para.Degeri = BozukPara.elliKurus;
                    ((BozukPara)para).YariCap = 1.19;
                    break;
                case ParaCesitleri.BirLira:
                    para.Degeri = BozukPara.birLira;
                    ((BozukPara)para).YariCap = 1.30;
                    break;
                case ParaCesitleri.BesLira:
                    para.Degeri = KagitPara.besLira;
                    break;
                case ParaCesitleri.OnLira:
                    para.Degeri = KagitPara.onLira;
                    break;
                case ParaCesitleri.YirmiLira:
                    para.Degeri = KagitPara.yirmiLira;
                    break;
                case ParaCesitleri.ElliLira:
                    para.Degeri = KagitPara.elliLira;
                    break;
                case ParaCesitleri.YuzLira:
                    para.Degeri = KagitPara.yuzLira;
                    break;
                case ParaCesitleri.İkiyuzLira:
                    para.Degeri = KagitPara.ikiyuzLira;
                    break;
                default:
                    System.Windows.Forms.MessageBox.Show(UyariKutuphanesi.SecimYapilmadi());
                    break;
            }
            _birikmisPara += para.Degeri;
           ParaninFazlaHacmi = para.HacimHesapla() * random.Next(25,  75)/100;
        }
    }
}
