namespace CalisanMaasHesapla.Lib
{
    public abstract class PersonelBase
    {
        #region Fields

        private int sicilnumarasi;
        private string isim;
        private string soyad;


        #endregion

        #region Properties

        public int Sicilnumarasi { get => sicilnumarasi; set => sicilnumarasi = value; }
        public string Isim { get => isim; set => isim = value; }
        public string Soyad { get => soyad; set => soyad = value; }

        #endregion

        #region Constructors

        protected PersonelBase(int sicilnumarasi, string isim, string soyad)
        {
            Sicilnumarasi = sicilnumarasi;
            Isim = isim;    
            Soyad = soyad;
        }
        public PersonelBase()
        {

        }

        #endregion

        #region Metods

        public virtual string AdSoyadGetir()
        {
            return $"SicilNumarasi : {Sicilnumarasi}\nIsim : {Isim}\nSoyad : {Soyad}";
        }

        public virtual int AylikHesapla()
        {
            return 0;
        }
        #endregion
    }
}