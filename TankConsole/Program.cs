using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tanks.WordOfTanks;

namespace TankConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            List<Tank> t34 = new List<Tank>();
            List<Tank> panters = new List<Tank>();

            for (int i = 0; i < 5; i++)
            {
                int x = rnd.Next(100), y = rnd.Next(100), z = rnd.Next(100);
                Tank t = new Tank("T-34", x, y, z);
                t34.Add(t);
            }
            for (int i = 0; i < 5; i++)
            {
                int x = rnd.Next(100), y = rnd.Next(100), z = rnd.Next(100);
                Tank t = new Tank("Pantera", x, y, z);
                panters.Add(t);
            }
                
            

            for (int i = 0; i < 5; i++)
            {
                if (t34[i] * panters[i] == true)
                    Console.WriteLine("Победил T-34: {0} vs {1}", t34[i].ToString(), panters[i].ToString());
                else
                    Console.WriteLine("Победил Pantera: {1} vs {0}", t34[i].ToString(), panters[i].ToString());
            }
        }
    }
}
