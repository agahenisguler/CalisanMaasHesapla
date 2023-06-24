using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalisanMaasHesapla.Lib
{
    public class SozlesmeliPersonel : PersonelBase
    {
        #region Fields

        private int gun;
        private int gunluk;


        #endregion

        #region Properties

        public int Gun { get => gun; set => gun = Math.Abs(value); }
        public int Gunluk { get => gunluk; set => gunluk = Math.Abs(value); }

        #endregion

        #region Constructors

        public SozlesmeliPersonel(int sicilnumarasi, string isim, string soyad, int gun, int gunluk)
            : base(sicilnumarasi, isim, soyad)
        {
            Gun = gun;
            Gunluk = gunluk;
        }

        #endregion

        #region Metods

        public override string AdSoyadGetir()
        {
            return base.AdSoyadGetir();
        }

        public override int AylikHesapla()
        {
            return

                Gun * Gunluk;

        }
        #endregion





    }
}