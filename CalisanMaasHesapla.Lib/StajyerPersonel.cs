using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalisanMaasHesapla.Lib
{
    public class StajyerPersonel : PersonelBase

    {
        #region Fields

        private int saat;
        private int saatlikucret;



        #endregion

        #region Properties

        public int Saat { get => saat; set => saat =Math.Abs(value); }
        public int Saatlikucret { get => saatlikucret; set => saatlikucret =Math.Abs(value); }

        #endregion

        #region Constructors

        public StajyerPersonel(int sicilnumarasi, string isim, string soyad, int saat, int saatlikucret)
            :base(sicilnumarasi,isim, soyad)
        {
            Saat = saat;
            Saatlikucret=saatlikucret;

        }
        #endregion

        #region Methods

        public override string AdSoyadGetir()
        {
            return base.AdSoyadGetir();
        }

        public override int AylikHesapla()
        {
            return

                   Saat * Saatlikucret;
        }

        #endregion






    }
}
