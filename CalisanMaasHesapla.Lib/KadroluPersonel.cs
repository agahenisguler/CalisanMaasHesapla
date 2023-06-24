using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalisanMaasHesapla.Lib
{
    public class KadroluPersonel : PersonelBase
    {
        #region Fields

        private int raporlugunsayisi;
        private int aylik;

        #endregion

        #region Properties

        public int Raporlugunsayisi { get => raporlugunsayisi; set => raporlugunsayisi =Math.Abs(value); }
        public int Aylik { get => aylik; set => aylik =Math.Abs(value); }

        #endregion

        #region Constructors

        public KadroluPersonel(int sicilnumarasi, string isim, string soyad, int raporlugunsayisi, int aylik)
            :base(sicilnumarasi, isim, soyad)
        {
            Raporlugunsayisi=raporlugunsayisi;
            Aylik=aylik;
        }

        public KadroluPersonel()
        {

        }

        #endregion

        #region Methots


        public override string AdSoyadGetir()
        {
            return base.AdSoyadGetir();
        }

        public override int AylikHesapla()
        {
            if (Raporlugunsayisi <= 5)
                return Aylik;
            else
                return Aylik - (Aylik / 30) * Raporlugunsayisi;

        }
        #endregion




    }
}
