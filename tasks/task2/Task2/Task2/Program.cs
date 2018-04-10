using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Bicycle
    {
        public int speed;
        public int gear;
        private int m_production_year;


        public Bicycle(string newname, string newtype)
        {
            if (string.IsNullOrEmpty(newname)) throw new ArgumentOutOfRangeException("name must not be empty or null.");
            if (string.IsNullOrEmpty(newtype)) throw new ArgumentOutOfRangeException("type must not be empty or null.");

            name = newname;
            type = newtype;
        }

        public int producyear
        {
            get
            {
                return m_production_year;
            }
            set
            {
                m_production_year = value;
            }
        }

        public void speedup(int increase)
        {
            speed = speed + increase;

        }
        public void changegear(int newvalue)
        {
            gear = newvalue;

        }

        public void printinfo()
        {
            Console.WriteLine($"Name: {name}, Type: {type}");
            Console.WriteLine("Gear: {0}", gear);
            Console.WriteLine("Speed: {0}", speed);
            Console.WriteLine("year of construction : {0}", m_production_year);
            Console.WriteLine("------------------------------################################################------------------------------");
        }
        public string name { get; private set; }
        public string type { get; private set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Bicycle bicycle1 = new Bicycle("cube", "crossbike");
            Bicycle bicycle2 = new Bicycle("scott", "racer");

            bicycle1.producyear = 2018;
            bicycle1.gear = 1;
            bicycle1.speed = 0;
            bicycle1.printinfo();

            bicycle2.producyear = 2017;
            bicycle2.gear = 5;
            bicycle2.speed = 10;
            bicycle2.printinfo();

            bicycle1.speedup(23);
            bicycle1.changegear(17);
            bicycle1.printinfo();

            bicycle2.speedup(15);
            bicycle2.changegear(13);
            bicycle2.printinfo();
        }

    }
}