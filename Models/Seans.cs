using Core.Models;

namespace CinemaConsoleProjectNew.Models
{
    internal class Seans : Entity
    {
        public string Price { get; set; }
        internal string DateTime { get; set; }
        internal string Hall { get; set; }
        internal string Film { get; set; }

        public override string ToString()
        {
            return $"{Id} Film:{Film}\nZal:{Hall}\nVaxti:{DateTime}\nQiymet:{Price}";
        }
    }
}
