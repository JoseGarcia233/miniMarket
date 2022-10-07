using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace store
{
    internal class Menu
    {
        public void menu()
        {

            int Choose;
            bool exit = false;

            while (!exit) {

                Console.WriteLine("******* Welcome to Mini Market the carero *******");
                Console.WriteLine("**********      Menu          **********");
                Console.WriteLine("*********      1-Meats       ***********");
                Console.WriteLine("*********      2-Vegetables  ***********");
                Console.WriteLine("*********      3-Soda        ***********");
                Console.WriteLine("*********      4-Exit        ***********");
                Choose = Convert.ToInt32(Console.ReadLine());
                

                switch (Choose)
                {
                    case 1:
                        
                        Submenu SUB = new Submenu();

                        SUB.submenu();
                        
                        break;

                    case 2:
                        
                        break;

                    case 3:
                        
                        break;
                    case 4:
                        
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Please choose one of the list");
                        break;
                }

            }
          

        }
    }
}
