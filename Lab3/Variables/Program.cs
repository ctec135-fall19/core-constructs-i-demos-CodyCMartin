using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            #region variable declarations 
            int myInt;
            long myLongInt = 0;
            double myDouble = 0.0;
            string myStr = "some text";
            #endregion

            #region printing p. 63-67
            //build error and warnings
            //Console.WriteLine("myInt: {0}', myInt);
            Console.WriteLine("myLong:  {0}", myLongInt);
            Console.WriteLine("myLong c:  {0:c}", myLongInt);
            Console.WriteLine("myLong d6:  {0:d6}", myLongInt);
            Console.WriteLine("myLong x:  {0:x}", 31);
            Console.WriteLine();


            #endregion

            #region casting p.88-90
            byte myByte = 255;
            byte myByte2 = (byte)(myByte + 1);
            Console.WriteLine("myByte: {0} + 1 = {1}", myByte, myByte2);
            Console.WriteLine();

            #endregion

            #region strings p. 79-88
            string hello = "hello";
            string world = "world";
            string str;
            Console.WriteLine("length of hello: {0}", hello.Length);
            Console.WriteLine("test ==: {0}", hello == "hello2");
            Console.WriteLine("test ==: {0}", hello.Equals("Hello"));

            Console.WriteLine("Compare: {0}", hello.CompareTo(world));
            Console.WriteLine("Compare: {0}", hello.CompareTo(hello));
            Console.WriteLine();


            // concatination
            str = hello + " " + world;
            Console.WriteLine(str);

            // verbatim
            str = @"c:\MyApp\bin\debug";
            string str2 = "c:\\MyApp\\bin\\debug";
            Console.WriteLine(str);
            Console.WriteLine(str2);
            #endregion
        }
    }
}
