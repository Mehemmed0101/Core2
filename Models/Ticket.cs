using Core.Models;

namespace CinemaConsoleProjectNew.Models
{
    internal class Ticket : Entity
    {
        internal Seans[] seans = new Seans[4];
        internal decimal Price { get; set; }

        public override string ToString()
        {
            return $"Id:{Id}\nBilet Sayi: {1}\nBilet qiymeti:{Price}";
        }
    }
}
