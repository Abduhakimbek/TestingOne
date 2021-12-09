using System;

namespace TestingOne
{
    class Program
    {
        static void Main(string[] args)
        {
            noteee:
            int a;
            int b=1;
            bool bo = true;
            Console.Write("Input Number: ");
            try
            {
                a = Convert.ToInt32(Console.ReadLine());

                if (a > 1)
                {
                    for (int i = 2; i < Math.Sqrt(a) + 1; i++)
                    {
                        if (a % i == 0)
                        {
                            Console.WriteLine("It is not prime number");
                            bo = false;
                            break;
                        }
                    }
                    if (bo == true)
                    {
                        b = a + 1;
                        while (b>1)
                        {
                            if (b % 2 == 0)
                            {
                                b = b / 2;
                            }
                            else
                            {
                                bo = false;
                                break;
                            }
                        }
                        if (bo == false)
                        {
                            bo = true;
                            b = a - 1;
                            while (b > 1)
                            {
                                if (b % 2 == 0)
                                {
                                    b = b / 2;
                                }
                                else
                                {
                                    bo = false;
                                    break;
                                }
                            }
                        }
                        if (bo == true)
                        {
                            Console.WriteLine("It is Mersenne prime number");
                        }
                        else
                        {
                            Console.WriteLine("It is Regular prime number");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("It is not prime number");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid Number");
                goto noteee;
            }
        }
    }
}
