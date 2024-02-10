

namespace Destructor.Models
{
    public class Araba
    {
        public Araba()
        {
            Console.WriteLine("Araba olusturuldu.");
        }


        ~Araba()
        {
            Console.WriteLine("İş bitti");
        }

    }
}
