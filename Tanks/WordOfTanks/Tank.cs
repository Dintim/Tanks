using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanks.WordOfTanks
{
    //public static Random rnd = new Random();
    public class Tank
    {
        Random rnd = new Random();
        public string Name { get; set; }
        private int Ammunition;
        private int Armor;
        private int Mobility;

        public Tank()
        {
            Ammunition = rnd.Next(100);
            Armor = rnd.Next(100);
            Mobility = rnd.Next(100);
        }
        public Tank(string name)
        {
            this.Name = name;
            this.Ammunition = rnd.Next(100);
            this.Armor = rnd.Next(100);
            this.Mobility = rnd.Next(100);           
        }
        public Tank(string name, int ammunition, int armor, int mobility)
        {
            this.Name = name;
            this.Ammunition = ammunition;
            this.Armor = armor;
            this.Mobility = mobility;
        }
        public static bool operator * (Tank a, Tank b)
        {
            return (a.Ammunition > b.Ammunition && a.Armor > b.Armor) || (a.Ammunition>b.Ammunition && a.Mobility>b.Mobility)
                || (a.Armor>b.Armor && a.Mobility>b.Mobility); 
        }

        public override string ToString()
        {
            return (Name + ";" + Ammunition.ToString() + ";" + Armor.ToString() + ";" + Mobility.ToString());
        }

    }
}
