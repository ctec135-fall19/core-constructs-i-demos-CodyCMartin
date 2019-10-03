using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            SportsCar myCar = new SportsCar();
            myCar.PetName = "my beat up sienna";
            Console.WriteLine("My car: {0}", myCar.getPetName());
        }
    }
}
