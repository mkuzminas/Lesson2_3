using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_3
{
    public class GameLeague<T>
    {
        private List<T> Teams { get; set; }

        public GameLeague()
        { 
         Teams = new List<T>();  
        }
        public void AddTeam(T team)
        {
            Teams.Add(team);
        }
        public void PrintAllTeams()
        {
            foreach (var team in Teams)
            {
                Console.WriteLine(team);
            }
        }


    }
}
