using System;

namespace Assignment1_S19_Final
{
    class Program
    {
        public static void Main()
        {
            int a = 5, b = 15;
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
           

            //This assignment was really helpful as it helped me to think on my own and make use of different loops and conditional statements.
            //It also made me use breakpoints for debugging which helped me to understand when my output was not correct.
            //As it did not allow to make use of inbuilt functions, it made me think and make use of logic !
            //This assigment was a great hands on experience.
            //Also the part of creating repository on GitHub and synchronizing our code on it was useful.
            //I think this assignment was really good so I do not have any recommendations to make it better.

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
                    //first check if number is a natural number and then call the method isPrime to decide whether number is prime or not
                    if (i>0)
                    {
                        flag = isPrime(i);
                    }
                    //if flag is true we print the number as it is prime number
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

        public static bool isPrime(int i)
        {
            bool flag= false;
            try
            {
                //check for only even prime number 2
                if (i == 2)
                {
                    Console.Write(i + " ");
                }
                //the number will be prime if it is not divisible by numbers from 2 till the given number
                for (int j = 2; j < i; j++)
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
            }
            catch
            {
                Console.WriteLine("Exception occured while computing isPrime()");
            }
            return flag;
        }

        public static double getSeriesResult(int n)
        {
            double ans = 0;
            try
            {
                // Write your code here
                //oddterms are those whose sign is positive
                double oddterms = 0;
                //eventerms are those whose sign is negative
                double eventerms = 0;
                //calculate sum of all oddterms
                for (int i = 1; i <= n;)
                {
                    oddterms = oddterms + (factorial(i) / (i + 1));
                    i += 2;
                }
                //calculate sum of all eventerms
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

            return Math.Round(ans,3);
        }
        public static double factorial(int n)
        {
            double ans = 1;
            try
            {
                //to calculate factorial multiply the number by all numbers from 1 till the number itself
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
                //iterate as long as quotient is greater than zero i.e keep dividing by 2 to get the next dividend and store remainder to form the binary number
                while (n >0)
                {
                    remainder = n % 2;                    
                    binary = binary + remainder.ToString();
                    n = n / 2;
                }
                char[] array = binary.ToCharArray();
                //to get the final bunary number we need to reverse the order in which remainders are stored
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
                //multiply each digit starting from the right/unit's place by power of 2 where the power will keep increasing by 1 starting from zero
                for (int i = str.Length - 1, j = 0; i >= 0; i--, j++)
                {
                    //multiplying each digit by power of 2 by calling the method power()
                    long sum = Convert.ToInt64(Char.GetNumericValue(array[i])) * power(j);
                    num = num + sum;

                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing binaryToDecimal()");
            }

            return num;
        }

        public static long power(int j)
        {
            long ans =1;
            try
            {
                //depending on value of j, power of 2 will be calculated by iterating in for loop
                for (int i=1;i<=j ;i++)
                {
                    ans = ans*2;
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing power()");
            }
            return ans;
            
        }

        public static void printTriangle(int n)
        {
            try
            {
                // Write your code here
                //iterating first for loop for number of lines the pattern will have
                for (int i = 1; i <= n; i++)
                {
                    //this for loop will print spaces before the stars in the lines, the spaces will keep increasing for each new line in the main for loop
                    for (int j = n; j > i; j--)
                    {
                        Console.Write(" ");
                    }
                    //this for loop will print odd number of stars in increasing manner on each new lines in the main for loop
                    for (int k = 1; k <= (2 * i) - 1; k++)
                    {
                        Console.Write("*");
                    }
                    //this will move the cursor to new line after printing spaces and stars
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
                //ctr variable to keep a check of the frequency
                int ctr = 1;
                //flag to check if number has been already counted
                bool flag = true;
                int[] arr = new int[a.Length];
                //iterating over the array's length
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
                    //if the number has not been already counted then compare with remaining numbers in array to find it's frequency
                    if (flag)
                    {
                        for (int j = i + 1; j < a.Length; j++)
                        {
                            //if the numbers are same increment the counter
                            if (a[i] == a[j])
                            {
                                ctr = ctr + 1;
                            }
                        }
                        Console.WriteLine(a[i] + "         " + ctr);
                        //intialze the counter back to 1 once outside for loop
                        ctr = 1;
                        //store the number whose frequency was just counted to check later
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

