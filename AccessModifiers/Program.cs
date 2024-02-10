namespace AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Private : Bu erisim belirteci en kisitlayici belirtectir. Nerede ne uzerinde verildiyse o sey oranin özel erisimine sahip objesidir.

            // Protected : Sadece miras verildigi yerlerden erisim saglanir.

            // Public : Referans alan her projeden / katmandan erisilebilir olmasini saglar.

            // Internal : Bu erisim belirteci sadece olusturuldugu proje icerisinde kullilacak ifadelerin erisimi belirtir.
            
            // Protected Internal : Ayni katmanda miras verilen nesneler arasinda erisim saglanir.

            //Erisim erisim = new Erisim();
            //erisim.Internal = "";
            //erisim.Public = "";
            //erisim.ProtectedInternal = "";


            int sayi = 5;
            int sayi2 = sayi;
            sayi2 = 4;
            Console.WriteLine(sayi2);

            int[] sayilar = new int[] { 1, 2, 3, 4, 5, 3 };
            int[] sayilar2 = sayilar;
            sayilar2[0] = 5;

            Console.WriteLine(sayilar[0]);

            Console.Clear();

            string ifade = "bardak";
            string ifade2 = ifade;

            //ifade2[0] = "c";

            Console.WriteLine(ifade2[0]);


        }
    }
}