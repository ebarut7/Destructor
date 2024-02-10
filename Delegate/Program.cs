namespace Delegate
{
    internal class Program
    {
        delegate void TemsilEtYaz();
        delegate void MatematikselIslem(int sayi1, int sayi2);
        delegate int SayisalTemsilci();
        delegate string IfadelerTemsilEt(string p);


        static void Main(string[] args)
        {
            #region

            TemsilEtYaz temsilEtYaz = new TemsilEtYaz(MesajYaz);
            temsilEtYaz += OzurDile;
            temsilEtYaz();

            MatematikselIslem matematikselIslem = new MatematikselIslem(Topla);
            matematikselIslem += Cikar;
            matematikselIslem(5, 5);

            Console.Clear();

            SayisalTemsilci sayisalTemsilci = new SayisalTemsilci(SayiVer);
            sayisalTemsilci += SayiVer2;
            int sayi = sayisalTemsilci();
            Console.WriteLine(sayi);

            IfadelerTemsilEt ifadeler = new IfadelerTemsilEt(GeleniGonder);
            Console.WriteLine(ifadeler("Merhaba"));



            Func<int> sayiFunc = SayiVer;
            sayiFunc();

            // Parametre alsin veya almasin geriye deger donduren metotlari saklar
            // In : parametreleri temsil eder. Out donus tipini temsil eder.

            Func<int, int, string> ifadeFunc = SayiVerMesajAl;
            Console.WriteLine(ifadeFunc(1, 2));

            // Parametre alsin veya almasin geriye deger dondurmeyen metotlari saklar.
            Action action = OzurDile;
            action();


            // Predicate : Sadece bool deger donduren metotlari temsil eder.

            Predicate<string> predicate = Mantik;
            Console.WriteLine(predicate(""));
            #endregion

            Func<string, bool> funcTest = x => x.Length > 0;
            funcTest.Invoke("a");

            List<string> metinler = new List<string>()
            {
                "aaa","aa","a","aaaa"
            };

            metinler.Where(x => x.Length > 0);

        }

        static bool Mantik(string b)
        {
            return b.Length > 0;
        }


        static string GeleniGonder(string ifade) => ifade;
        static string SayiVerMesajAl(int sayi,int sayi2)
        {
            return sayi.ToString();
        }
        static int SayiVer()
        {
            return 5;
        }
        static int SayiVer2()
        {
            return 10;
        }
        static void Topla(int s1, int s2)
        {
            Console.WriteLine(s2+s1);
        }
        static void Cikar(int s1,int s2)
        {
            Console.WriteLine(s1-s2);
        }

        static void MesajYaz()
        {
            Console.WriteLine("Mesaj yazdim");
        }
        static void OzurDile()
        {
            Console.WriteLine("Özür dilerim");
        }

    }
}