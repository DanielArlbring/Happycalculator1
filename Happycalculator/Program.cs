using System;
using System.Collections.Generic;
using System.Linq;

namespace Happycalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Happycalculator 1";

            Console.WriteLine("Välkommen till Happycalculator");
            string userOperator;
            string userOperator1;
            double term1, term2, term3, sum = 0;
            List<double> totalSum = new List<double>();
            while (true)
            {

                Console.WriteLine("Skriv första operatorn (+, -, / or *): ");
                userOperator = Console.ReadLine();
                Console.WriteLine("Skriv den andra operatorn (+, -, / or *): ");
                userOperator1 = Console.ReadLine();
                Console.WriteLine("Skriv första termen");
                term1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Skriv den andra termen");
                term2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Skriv den tredje termen");
                term3 = Convert.ToInt32(Console.ReadLine());

                


                if (userOperator == "+")
                {
                    if (userOperator1 == "+")
                    {
                        sum = term1 + term2 + term3;

                    }
                    else if (userOperator1 == "-")
                    {
                        sum = term1 + term2 - term3;
                    }

                    else if (userOperator1 == "/")
                    {
                        sum = term1 + term2 / term3;
                    }
                    else if (userOperator1 == "*")
                    {
                        sum = term1 + term2 * term3;
                    }





                }
                if (userOperator == "-")
                {
                    if (userOperator1 == "+")
                    {
                        sum = term1 - term2 + term3;

                    }
                    else if (userOperator1 == "-")
                    {
                        sum = term1 - term2 - term3;
                    }

                    else if (userOperator1 == "/")
                    {
                        sum = term1 - term2 / term3;
                    }
                    else if (userOperator1 == "*")
                    {
                        sum = term1 - term2 * term3;
                    }
                }

                if (userOperator == "/")
                {
                    if (userOperator1 == "+")
                    {
                        sum = term1 / term2 + term3;

                    }
                    else if (userOperator1 == "-")
                    {
                        sum = term1 / term2 - term3;
                    }

                    else if (userOperator1 == "/")
                    {
                        sum = term1 / term2 / term3;
                    }
                    else if (userOperator1 == "*")
                    {
                        sum = term1 / term2 * term3;
                    }
                }

                if (userOperator == "*")
                {
                    if (userOperator1 == "+")
                    {
                        sum = term1 * term2 + term3;

                    }
                    else if (userOperator1 == "-")
                    {
                        sum = term1 * term2 - term3;
                    }

                    else if (userOperator1 == "/")
                    {
                        sum = term1 * term2 / term3;
                    }
                    else if (userOperator1 == "*")
                    {
                        sum = term1 * term2 * term3;
                    }
                }




                Console.WriteLine($"{term1} {userOperator} {term2} {userOperator1} {term3} = {sum}");
                totalSum.Add(sum);


                if (sum < 100)
                {
                    Console.WriteLine("Under 100");

                }
                else if (sum > 100)
                {
                    Console.WriteLine("Över 100");

                }
                else if (sum == 100)
                {
                    Console.WriteLine("Bra, 100 prick!");

                }

                Console.WriteLine("Ett till försök? Tryck 'n' för att avsluta eller tryck på valfri tangent för att fortsätta");
                string no = Console.ReadLine();

                if (no == "n" || no == "N")
                {
                    Console.WriteLine("Den totala summan är: " + totalSum.Sum());
                    Console.WriteLine("Tack för nu");
                    break;
                }
                else
                {
                    continue;
                }
            }
        }
    }
}










