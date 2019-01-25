using System;

namespace Assignment1_S19_Final
{
    class Program
    {
        public static void Main()
        {
            int a = 0, b = 100;
            printPrimeNumbers(a, b);


            int n1 = 5;
            double r1 = getSeriesResult(n1);
            Console.WriteLine("The sum of the series is: " + r1);
            Console.WriteLine();
            Console.WriteLine();


            long n2 = 15;
            long r2 = decimalToBinary(n2);
            Console.WriteLine("Binary conversion of the decimal number " + n2 + " is: " + r2);
            Console.WriteLine();
            Console.WriteLine();


            long n3 = 1111;
            long r3 = binaryToDecimal(n3);
            Console.WriteLine("Decimal conversion of the binary number " + n3 + " is: " + r3);
            Console.WriteLine();
            Console.WriteLine();


            int n4 = 5;
            printTriangle(n4);
            Console.WriteLine();
            Console.WriteLine();
            

            int[] arr = new int[] { 1, 2, 3, 2, 2, 1, 3, 2 };
            computeFrequency(arr);
            Console.ReadKey();

            // write your self-reflection here as a comment

        }

        public static void printPrimeNumbers(int x, int y)
        {
            try
            {
                // Write your code here
                Console.WriteLine("Prime numbers between " + x + " and " + y + " are :");
                bool flag=false;
                //first for loop for iterating over the range x to y
                for (int i = x; i <= y; i++)
                {
                    //check for only even prime number 2
                    if (i==2)
                    {
                        Console.Write(i+" ");
                    }
                    for (int j = 2; j < i ; j++)
                    {
                        //for example: number is 9, it won't be divisible by 2, so at first flag will be true, but it is not divisible by next numbers and so final flag will be false
                        if (i % j == 0)
                        {
                            flag = false;
                            //if divisible by atleast one number other than 1 and number itself, it will not be a prime number, hence break the loop and go to next number
                            break;
                        }
                        else
                        {
                            flag = true;
                        }
                    }
                    if (flag)
                    {
                        Console.Write(i+" ");
                    }
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printPrimeNumbers()");
            }
        }

        public static double getSeriesResult(int n)
        {
            double ans = 0;
            try
            {
                // Write your code here
                double oddterms = 0;
                double eventerms = 0;
                for (int i = 1; i <= n;)
                {
                    oddterms = oddterms + (factorial(i) / (i + 1));
                    i += 2;
                }
                for (int i = 2; i <= n;)
                {
                    eventerms = eventerms + (factorial(i) / (i + 1));
                    i += 2;
                }
                ans = oddterms - eventerms;
            }
            catch
            {
                Console.WriteLine("Exception occured while computing getSeriesResult()");
            }

            return Math.Round(ans,2);
        }
        public static double factorial(int n)
        {
            double ans = 1;
            try
            {
                for (int i = 1; i <= n; i++)
                {
                    ans = ans * i;
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing factorial()");
            }
            return ans;
        }
       

        public static long decimalToBinary(long n)
        {
            string binary = "";
            string reverse = "";
            try
            {
                // Write your code here
                long remainder = 1;
                while (n > 0)
                {
                    remainder = n % 2;                    
                    binary = binary + remainder.ToString();
                    n = n / 2;
                }
                char[] array = binary.ToCharArray();

                for (int i = array.Length - 1; i > -1; i--)
                {
                    reverse += array[i];
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing decimalToBinary()");
            }

            return Convert.ToInt64(reverse);
        }

        public static long binaryToDecimal(long n)
        {
            long num = 0;
            try
            {
                string str = n.ToString();
                char[] array = str.ToCharArray();
                for (int i = str.Length - 1, j = 0; i >= 0; i--, j++)
                {
                    long sum = Convert.ToInt64(Char.GetNumericValue(array[i])) * Convert.ToInt64(Math.Pow(2, j));
                    num = num + sum;

                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing binaryToDecimal()");
            }

            return num;
        }

        public static void printTriangle(int n)
        {
            try
            {
                // Write your code here
                for (int i = 1; i <= n; i++)
                {
                    for (int j = n; j > i; j--)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 1; k <= (2 * i) - 1; k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine("");

                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printTriangle()");
            }
        }

        public static void computeFrequency(int[] a)
        {
            try
            {
                // Write your code here
                Console.WriteLine("Number"+"    "+"Frequency");
                int ctr = 1;
                bool flag = true;
                int[] arr = new int[a.Length];
                for (int i = 0; i < a.Length - 1; i++)
                {
                    //check if the number has already been counted
                    for (int k = 0; k <= i; k++)
                    {
                        if (Convert.ToInt32(arr.GetValue(k)) == a[i])
                        {
                            flag = false;
                        }
                    }
                    if (flag)
                    {
                        for (int j = i + 1; j < a.Length; j++)
                        {
                            if (a[i] == a[j])
                            {
                                ctr = ctr + 1;
                            }
                        }
                        Console.WriteLine(a[i] + "         " + ctr);
                        ctr = 1;
                        arr.SetValue(a[i], i);

                    }
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing computeFrequency()");
            }
        }
    }

}
