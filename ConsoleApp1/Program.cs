using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime time = DateTime.Now;
            string format = "ddd d MMM HH:mm:ff yyyy";
            Console.WriteLine(time.ToString(format));
            Console.WriteLine("");


            int[] numbers;

            bool newcalcmaster = true;
            bool isvalid1 = false;
            bool isvalid3 = false;
            bool isvalid4 = false;
            bool isvalid5 = false;
            bool isvalidlast = false;

            Console.WriteLine("WELCOME TO THE slightly BREAKABLE CALCULATOR");
            Console.WriteLine("");

            while (newcalcmaster == true)
            {

                Console.WriteLine("Type {1} for add,minus,multipy and divide.");
                Console.WriteLine("Type {2} for square root");
                Console.WriteLine("Type {3} for exponents");
                var userdecision1 = Console.ReadLine();
                if (userdecision1 == "1")
                {
                    isvalid1 = false;
                    isvalid3 = false;
                    isvalid4 = true;
                    isvalid5 = true;
                    isvalidlast = false;
                }
                else if (userdecision1 == "2")
                {
                    isvalid1 = true;
                    isvalid3 = true;
                    isvalid4 = false;
                    isvalid5 = true;
                    isvalidlast = false;
                }
                else if (userdecision1 == "3")
                {
                    isvalid1 = true;
                    isvalid3 = true;
                    isvalid4 = true;
                    isvalid5 = false;
                    isvalidlast = false;
                }
                else
                {
                    isvalid1 = true;
                    isvalid3 = true;
                    isvalid4 = true;
                    isvalid5 = true;
                    isvalidlast = true;
                    Console.WriteLine("This is an invalid number/letter");
                }




                while (isvalid1 == false)
                {
                    try
                    {
                        Console.WriteLine("How many numbers do you want to use in this calculation?");
                        var numberchosen = Console.ReadLine();
                        int numberchosen1 = Int32.Parse(numberchosen);


                        numbers = new int[numberchosen1];
                        for (int i = 0; i < numberchosen1; i = i + 1)
                        {
                            Console.WriteLine("Write your " + (i + 1) + " number");
                            numbers[i] = Int32.Parse(Console.ReadLine());
                        }
                        isvalid1 = true;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Number is not valid");
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("Number is not valid");
                    }

                }

                var answer = 0;
                var answer1 = 0;

                while (isvalid3 == false)
                {
                    Console.WriteLine("Choose which operator you want to use from the following: ");
                    Console.WriteLine("");
                    Console.WriteLine("add|+, minus|-, multiply|*, divide|/");
                    Console.WriteLine("");
                    Console.WriteLine("Enter your operator here: ");
                    var c = Console.ReadLine();

                    

                    switch (c)
                    {
                        case "add":
                        case "+":
                            foreach (int element in numbers)
                            {
                                answer = answer + element;
                            }
                            isvalid3 = true;
                            break;

                        case "minus":
                        case "-":
                            foreach (int element in numbers)
                            {
                                answer = numbers[0] - element;
                            }
                            isvalid3 = true;
                            break;

                        case "multiply":
                        case "*":
                            foreach (int element in numbers)
                            {
                                answer1 = answer1 * element;
                            }
                            isvalid3 = true;
                            break;

                        case "divide":
                        case "/":                      
                            foreach (int element in numbers)
                            {
                                answer = numbers[0] / element;
                            }
                            isvalid3 = true;
                            break;

                        default:
                            isvalid3 = false;
                            break;

                    }


                }

                Console.WriteLine("Your answer to your calculation is: " + answer);


                double sqrtanswer = 0;
                double finalsqrtanswer = 0.0;
                double estimate1 = 0;
                double stepsize = 10;

                while (isvalid4 == false)
                {

                    try
                    {
                        Console.WriteLine("Enter the number you want the square root of:");
                        var sqrt = Console.ReadLine();
                        Console.WriteLine("Enter how many digits you want the answer to");
                        var estimate = Console.ReadLine();
                        estimate1 = double.Parse(estimate);
                        sqrtanswer = double.Parse(sqrt);

                        for (double sqrttest1 = 1; sqrttest1 <= estimate1; sqrttest1 = sqrttest1++)
                        {
                            for (double sqrttest2 = 1; sqrttest2 <= sqrttest1; sqrttest2++)
                            {
                                stepsize /= 10;
                            }
                            for (double sqrttest = 0.0; sqrttest * sqrttest <= sqrtanswer; sqrttest = sqrttest + stepsize)
                            {

                                finalsqrtanswer = sqrttest;

                            }

                        }
                        if (sqrtanswer < 0)
                        {
                            Console.WriteLine("This a not a valid number to square root");
                            isvalid4 = false;
                        }
                        else
                        {
                            isvalid4 = true;
                            Console.WriteLine("The answer to your calculation is:" + finalsqrtanswer);
                        }

                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Number/Letter is not valid");
                        isvalid4 = false;
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("Number is not valid");
                        isvalid4 = false;
                    }

                }

                double baseanswer = 0;
                double exponentanswer = 0;
                double finalsqreanswer = 1;

                while (isvalid5 == false)
                {
                    try
                    {
                        Console.WriteLine("Enter the base:");
                        var userbase = Console.ReadLine();
                        baseanswer = double.Parse(userbase);

                        Console.WriteLine("Enter the exponent");
                        var userexponent = Console.ReadLine();
                        exponentanswer = double.Parse(userexponent);

                        finalsqreanswer = baseanswer;

                        for (int sqreanswer1 = 1; sqreanswer1 < exponentanswer; sqreanswer1++)
                        {
                            finalsqreanswer = finalsqreanswer * baseanswer;
                        }

                        if (exponentanswer < 0)
                        {
                            Console.WriteLine("This is not valid");
                            isvalid5 = false;
                        }
                        else
                        {
                            Console.WriteLine("The answer to your calculation is: " + finalsqreanswer);
                            isvalid5 = true;
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Number/Letter is not valid");
                        isvalid5 = false;
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("Number is not valid");
                        isvalid5 = false;
                    }

                }

                while (isvalidlast == false)
                {

                    Console.WriteLine("Do you want to complete another calculation: Yes or No");
                    var newcalc = Console.ReadLine();

                    if (newcalc == "yes")
                    {
                        Console.WriteLine("STARTING NEW CALCULATION");
                        isvalidlast = true;
                        newcalcmaster = true;
                    }
                    else if (newcalc == "no")
                    {
                        isvalidlast = true;
                        newcalcmaster = false;
                    }
                    else
                    {
                        Console.WriteLine("You did not choose between Yes or No");
                        isvalidlast = false;
                    }

                }


            }





            Console.ReadKey();

        }
    }
}
