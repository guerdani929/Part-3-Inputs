using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_3_Inputs
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            //string response;
            //string age;
            //string year;

            //Console.WriteLine("What's your name?");
            //response = Console.ReadLine();

            //Console.WriteLine("How old are you?" );
            //age = Console.ReadLine();
            //int old = Convert.ToInt32(age);

            //Console.WriteLine("What year is it?");
            //year = Console.ReadLine();
            // int now = Convert.ToInt32(year);


            //Console.WriteLine($"You're name is {response}, you're {old} years old in the year {now}");
            //Console.ReadLine();

            //2
            //string Num0;
            //string Num1;
            //string Num2;

            //Console.WriteLine("Give me a number");
            //Num0 = Console.ReadLine();
            //double dNum1 = Convert.ToDouble(Num0);

            //Console.WriteLine("Give me a number");
            //Num1 = Console.ReadLine();
            //double dNum2 = Convert.ToDouble(Num1);

            //Console.WriteLine("Give me a number");
            //Num2 = Console.ReadLine();
            //double dNum3 = Convert.ToDouble(Num2);

            //Console.WriteLine("The sum of your numbers is " + (dNum1 + dNum2 + dNum3));
            //Console.ReadLine();

            //3
            string dis1;
            string dis2;
            string dis3;
            double dAvg = 3;
            Console.WriteLine("Please enter a distance in km");
            dis1 = Console.ReadLine();
            double dCal1 = Convert.ToDouble(dis1);

            Console.WriteLine("Please enter another distance in km");
            dis2 = Console.ReadLine();
            double dCal2 = Convert.ToDouble(dis2);

            Console.WriteLine("Please enter a final distance in km");
            dis3 = Console.ReadLine();
            double dCal3 = Convert.ToDouble(dis2);

            Console.WriteLine("Your average distance is " + (dCal1 +  dCal2 +  dCal3)/dAvg);
            Console.ReadLine();











        }
    }
}
