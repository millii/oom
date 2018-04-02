using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    interface IBike
    {
        void Printinfo();

    }
    class MTB : IBike
    {

        private string name, type, Sab;




        public MTB(string newname, string newtype, string newSab)
        {
            if (string.IsNullOrEmpty(newname)) throw new ArgumentOutOfRangeException("name must not be empty or null. ");
            if (string.IsNullOrEmpty(newtype)) throw new ArgumentOutOfRangeException("type must not be empty or null.");

            name = newname;
            type = newtype;
            Sab = newSab;
        }

        public void Printinfo()
        {
            Console.WriteLine($"Name: {name}, Type: {type}, extras : {Sab}");
        }

        public string newname { get; private set; }
        public string newtype { get; private set; }
        public int newSab { get; private set; }
    }
    class RB : IBike
    {
        private string name, type;



        public RB(string newname, string newtype)
        {
            if (string.IsNullOrEmpty(newname)) throw new ArgumentOutOfRangeException("name must not be empty or null. ");
            if (string.IsNullOrEmpty(newtype)) throw new ArgumentOutOfRangeException("type must not be empty or null.");

            name = newname;
            type = newtype;
        }







        public void Printinfo()
        {
            Console.WriteLine($"Name: {name}, Type: {type}");



        }
        public string newname { get; private set; }
        public string newtype { get; private set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            var Bikes = new IBike[]
            {
                new MTB("KTM", "mountainbike","with 1 shockabsorber"),
                new MTB("CUBE", "mountainbike","with 2 shockabsorber"),
                new RB("scoot", "racerbike"),
                new RB("BMC", "racerbike"),

            };




            foreach (var x in Bikes)
                x.Printinfo();
        }

    }
}
