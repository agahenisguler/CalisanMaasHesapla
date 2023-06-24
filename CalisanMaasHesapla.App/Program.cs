using CalisanMaasHesapla.Lib;

namespace CalisanMaasHesapla.App
{
    public class Program
    {
        static void Main()
        {
            PersonelBase _agah = new KadroluPersonel(10529036, "agah", "guler", 6, 25000);

            PersonelBase _begum = new SozlesmeliPersonel(15920328, "begum", "guler", 29, 375);

            PersonelBase _alp = new StajyerPersonel(12346785, "alp", "guler", 150, 60);

            Console.WriteLine(_agah.AdSoyadGetir()+"\n" + "Maas : "+ _agah.AylikHesapla().ToString());
            Console.WriteLine("-------------------");
            Console.WriteLine(_begum.AdSoyadGetir() + "\n" + "Maas : " + _begum.AylikHesapla().ToString());
            Console.WriteLine("-------------------");
            Console.WriteLine(_alp.AdSoyadGetir() + "\n" + "Maas : " + _alp.AylikHesapla().ToString());
        }
    }
}
