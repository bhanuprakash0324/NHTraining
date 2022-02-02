using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_NBA_Players
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<NBA_Players> players = new List<NBA_Players>()
            {
                new NBA_Players(){name="Lebron",games=1346,championships=4,careerpoints=36414},
                new NBA_Players(){name="Kobe",games=1346,championships=5,careerpoints=33643},
                new NBA_Players(){name="KD",games=920,championships=2,careerpoints=24936},
                new NBA_Players(){name="Iverson",games=914,championships=0,careerpoints=24368},
                new NBA_Players(){name="Shaq",games=1207,championships=4,careerpoints=28596}
            };

            //For loop
            for (int i = 0; i < players.Count; i++)
            {
                if (players[i].careerpoints > 25000)
                    Console.WriteLine($"Player Name: {players[i].name}, Player Championships: {players[i].championships}");
            }
           
            //For Each Loop

            foreach (var p in players)
            {
                if (p.careerpoints > 25000)
                    Console.WriteLine($"Player Name: {p.name}, Player championships: {p.championships}");
            }

            //Lambda Expression

            players.Where(p => p.careerpoints > 25000).ToList().ForEach(p => Console.WriteLine($"Player Name : {p.name}, Player Championships: {p.championships}"));

            //Linq query

            var result = from p in players
                         where p.careerpoints > 25000
                         select p;
            result.ToList().ForEach(p => Console.WriteLine($"Player Name: {p.name}, Player Championships: {p.championships}"));

            Console.ReadLine();
        }
    }
}
