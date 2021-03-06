using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2_SE140281_Library
{
    public class Validation
    {
        public static string CheckEmpty()
        {
            string n;
            while (true)
            {
                try
                {
                    n = Console.ReadLine();
                    if (n == null || n == "")
                    {
                        Console.WriteLine("Cannot be Empty!");
                        Console.Write("Try Again: ");
                    }
                    else
                    {
                        break;
                    }
                }
                catch (Exception e)
                {
                    e.ToString();
                    Console.WriteLine("Please Try Again!");
                }
            }
            return n;
        }

        public static int CheckInput()
        {
            int n;
            while (true)
            {
                try
                {
                    n = Convert.ToInt32(Console.ReadLine());
                    if (n < 1 || n > 5)
                    {
                        Console.WriteLine("Choice range must be from 1 to 5");
                        Console.Write("Try Again: ");
                    }
                    else
                    {
                        break;
                    }
                }
                catch (FormatException e)
                {
                    e.ToString();
                    Console.WriteLine("Input Number Only !");
                }
            }
            return n;
        }

        public static int CheckNumber()
        {
            int n;
            while (true)
            {
                try
                {
                    n = Convert.ToInt32(Console.ReadLine());
                    if (n < 0)
                    {
                        Console.WriteLine("Invalid Price (Price must be >0)");
                        Console.Write("Try Again: ");
                    }
                    else
                    {
                        break;
                    }
                }
                catch (FormatException e)
                {
                    e.ToString();
                    Console.WriteLine("Input Number Only !");
                }
            }
            return n;
        }
        public static string CheckConfirm()
        {
            string n;
            while (true)
            {
                try
                {
                    n = Console.ReadLine();
                    if (!n.Equals("yes") && !n.Equals("no"))
                    {
                        Console.WriteLine("Invalid choice!");
                        Console.Write("Try Again: ");
                    }
                    else
                    {
                        break;
                    }
                }
                catch (Exception e)
                {
                    e.ToString();
                    Console.WriteLine("Please Try Again!");
                }
            }
            return n;
        }
    }
}
