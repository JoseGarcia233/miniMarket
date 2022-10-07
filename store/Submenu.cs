using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace store
{
    internal class Submenu
    {
        public void submenu()
        {
            bool exit = false;
            int Choose;

            while (!exit)
            {
                Console.WriteLine("*******    meat section       *********");
                Console.WriteLine("**********      Menu          **********");
                Console.WriteLine("*********      1-List of meat     ***********");
                Console.WriteLine("*********      2- exit     ***********");
                Choose = Convert.ToInt32(Console.ReadLine());


                switch (Choose)
                {
                    case 1:
                        meat<string> mt = new meat<string>();
                        Console.WriteLine("How many packs do you want?");
                        break;

                    case 2:
                        exit = true;
                        break;

                    case 3:

                        break;
                    case 4:

                      
                        break;
                    default:
                        Console.WriteLine("Please choose one of the list");
                        break;
                }

            }


        }
    }
}
