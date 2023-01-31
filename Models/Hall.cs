using Core.Models;

namespace CinemaConsoleProjectNew.Models
{
    internal class Hall : Entity
    {
        internal string Name { get; set; }
        internal int Row { get; set; }
        internal int Column { get; set; }


        public override string ToString()
        {
            return $"{Id} Zal adi: {Name}\nZal olcusu:{Row} x {Column}\nTutumu {Row * Column} nefer\n";
        }
    }
}
