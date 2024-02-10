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

            Erisim erisim = new Erisim();
            erisim.Internal = "";
            erisim.Public = "";
            erisim.ProtectedInternal = "";

            
          

        }
    }
}