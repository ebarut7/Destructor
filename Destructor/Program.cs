using AccessModifiers;
using Destructor.Models;

namespace Destructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Constructor : Yapici metot anlamina gelmektedir. Sinif insa edilirken yani olusturlurken calisan metotdur. 

            for (int i = 0; i < 100; i++)
            {
                new Araba();
                GC.Collect();
            }
            // Destructor : Yikici metot sinifin isi bittiginde calisacak metodudur. Gc temizleyecegi anda artik nesnenin isis bitmis demektir ve temzilenmeden once destructor sayesinde son islemlerini gerceklestirir.

            
        }
    }
}