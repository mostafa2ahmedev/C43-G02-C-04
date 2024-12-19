using System;
using System.Text;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q13)Write a program to allow the user to enter a string and print the REVERSE of it.
            //string userInput;
            //do
            //{
            //    Console.WriteLine("Enter a string please");
            //    userInput = Console.ReadLine();
            //} while (string.IsNullOrEmpty(userInput));

            //StringBuilder result = new StringBuilder();
            //for (int i = userInput.Length - 1; i >= 0; i--)
            //{
            //    result.Append(userInput[i]);
            //}

            //Console.WriteLine(result.ToString());
            #endregion

            #region Q14) Write a program to allow the user to enter int and print the REVERSED of it.
            //int Number;
            //do
            //{
            //    int.TryParse(Console.ReadLine(), out Number);


            //}
            //while (typeof(int) != Number.GetType());

            //StringBuilder result= new StringBuilder();

            //int mod;

            //while (Number > 0)
            //{  //

            //    mod = Number % 10;
            //    Number = Number / 10;
            //    result.Append(mod);

            //}
            //Console.WriteLine(result);


            #endregion

            #region Q15)Write a program in C# Sharp to find prime numbers within a range of numbers.
            //int FNumberRange;
            //int SNumberRange;
            //do
            //{
            //    Console.WriteLine("Please Enter First Range Integer Number");
            //    int.TryParse(Console.ReadLine(), out FNumberRange);
            //    Console.WriteLine("Please Enter Second Range Integer Number");
            //    int.TryParse(Console.ReadLine(), out SNumberRange);


            //}
            //while (FNumberRange < 1 || SNumberRange < FNumberRange);
            //StringBuilder result = new StringBuilder();
            //bool flag;

            //for (int i = FNumberRange; i <= SNumberRange; i++)
            //{
            //    flag = true; 
            //    if (i < 2) 
            //        flag = false;

            //    else
            //    {
            //        for (int j = 2; j < i; j++)
            //        {
            //            if (i % j == 0)
            //            {
            //                flag = false;
            //                break; 
            //            }
            //        }
            //    }
            //    if (flag)
            //    {
            //        result.Append(i);
            //        result.Append(" ");
            //    }
            //}
            //Console.WriteLine(result.ToString());
            #endregion

            #region Q16) Write a program in C# Sharp to convert a decimal number into binary without using an array.
            //Console.WriteLine("Enter a number:");
            //int Number = int.Parse(Console.ReadLine());

            //string result = "";

            //while (Number > 0)
            //{
            //    result = (Number % 2) + result;
            //    Number /= 2;

            //    if (result == "")
            //        result = "0";



            //}
            //Console.WriteLine(result);
            #endregion

            #region Q17)17- Create a program that asks the user to input three points (x1, y1),(x2, y2), and(x3, y3), and determines whether these points lie on a single straight line.
            //int x1,y1,x2,y2,x3,y3;
            //Console.WriteLine("Enter x1");
            //x1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter y1");
            //y1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter x2");
            //x2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter y2");
            //y2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter x3");
            //x3 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter y3");
            //y3 = int.Parse(Console.ReadLine());


            //if (y2 - y1 / x2 - x1 == y3 - y2 / x3 - x2) {
            //    Console.WriteLine("these points lie on a single straight line.");
            //}
            //else
            //    Console.WriteLine("Doesn't lie on a single straight line.");

            #endregion

            #region Q18)
            //Console.WriteLine("Enter Time");
            //int Time = int.Parse(Console.ReadLine());

            //if(Time>=2&&Time<3)
            //    Console.WriteLine("Highly Efficient");
            //else if(Time>=3&&Time<4)
            //    Console.WriteLine("Increase your speed");
            //else if(Time >= 4 && Time < 5)
            //    Console.WriteLine("Train to enhance your speed");
            //else if (Time > 5)
            //    Console.WriteLine("Leave the company");
            //else
            //    Console.WriteLine("Enter a valid Number");


            #endregion
        }
    }
}


