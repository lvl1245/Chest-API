using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chest.Domain;

namespace Chest.Domain
{
    public class Chest
    {
        public string Name { get; set; }
        public double Size { get; set; }
        public int Id { get; set; }

        public Color Color { get; set; }

        public int CountOfStuff  { get; set; }
        public double CurrentSpase { get; set; }
        public ICollection<Stuff> StuffCollection { get; set; }

        public ICollection<ChestType> ChestTypeCollection { get; set; }


    }

    public enum Color
    {
        Black,
        White,
        Green,
        Red,
        Blue,
        Yellow,
    }
}
