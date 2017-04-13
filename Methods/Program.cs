using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args) //this Project was created specifically for methods created that can be placed in new programs
        {

        }   
            
        public static int GetValidInteger()
        {
            int input;

            Console.WriteLine("Please enter an Integer: ");

            while (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("The input is not an integer! Please enter an integer! ");
            }

            return input;
        }


        public static char GetValidChar()
        {
            char Letter;

            while (!char.TryParse(Console.ReadLine(), out Letter))
            {
                Console.WriteLine("The input is not 'y' or 'n'!");
            }
            return Letter;
        }

    }
    }

