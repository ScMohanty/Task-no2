using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voating
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime dob;
            DateTime today = DateTime.Now;

            Console.WriteLine("ENTER DATE OF BIRTH PLEASE");
            dob = Convert.ToDateTime(Console.ReadLine());

            int age = today.Year - dob.Year;

            if (age >= 18)
            {
                Console.WriteLine("The persion is eligible for voating");
            }
            else
            {
                Console.WriteLine("the persion is not eligible for voating");
            }
        }
    }
}
