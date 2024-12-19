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
        }
    }
}
