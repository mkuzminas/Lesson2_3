using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_3
{
    public class FootballTeam
    {
        private string Name { get; set; }
        public FootballTeam(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return $"Komandos pavadinimas: {Name}";
        }
    }
}
