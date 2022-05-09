namespace Activity_9___Methods
{
    public class MethodStubs
    {
        // 1. create a method that takes two integers and displays the sum
        public static void Sum(int a, int b)
        {
            int sum = a + b;
            Console.WriteLine(sum);

        }

        // 2. create a method that takes 5 doubles and returns the average
        public static double Average(double a, double b, double c, double d, double e)
        {
            double average = (a + b + c + d + e) / 5;
            return average;

        }

        // 3. create a method that returns the sum of two randomly generated integers
        public static int RandomSum()
        {
            Random random = new Random();

            int a = random.Next(1, 100);

            int b = random.Next(1, 100);

            int sum = a + b;

            return sum;

        }

        // 4. method that takes three integers and returns true if theire sum is divisible by 3, false otherwise
        public static bool DivisibleBy3(int a, int b, int c)
        {
            int sum = a + b + c;
            if (sum % 3 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        // 5. method that takes two strings and displays the string that has the fewest characters
        public static string StringLength(string a, string b)
        {
            if (a.Length < b.Length)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        // 6. method that takes an array of doubles and returns the largest value in the array
        public static double LargestValue(double[] a)
        {
            double largest = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > largest)
                {
                    largest = a[i];
                }
            }
            return largest;

        }

        // 7. method that generates and returns an array of fifty integer values
        public static int[] FiftyValues()
        {
            int[] fifty = new int[50];

            for (int i = 0; i < fifty.Length; i++)
            {
                fifty[i] = i + 1;
            }

            return fifty;
        }

        // 8. method that takes two bool values and returns true if they are the same, false otherwise
        public static bool SameBool(bool a, bool b)
        {
            if (a == b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // 9. method that takes an int and a double and returns their product
        public static double Product(int a, double b)
        {
            double product = a * b;
            return product;
        }

        // 10. method that takes a two dimensional array and returns the average of the entries
        public static double Average2D(double[,] a)
        {
            double sum = 0;

            for (int i = 0; i < a.GetLength(0); i++) 
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    sum += a[i, j];
                }
            }

            double average = sum / (a.GetLength(0) * a.GetLength(1)); 

            return average;

        }

        // test the methods
        public static void Main(string[] args)
        {


            Console.WriteLine("Sum of 2 and 3 is: ");
            Sum(2, 3);

            Console.WriteLine("Average of 5, 6, 7, 8, 9 is: ");
            Console.WriteLine(Average(5, 6, 7, 8, 9));

            Console.WriteLine("Sum of two random numbers is: ");
            Console.WriteLine(RandomSum());

            Console.WriteLine("Is the sum of (123, 456, 789) divisible by 3? ");
            Console.WriteLine(DivisibleBy3(123, 456, 789));

            Console.WriteLine("The string with the fewest characters between 'Hi' and 'Hello' is: ");
            Console.WriteLine(StringLength("Hi", "Hello"));

            Console.WriteLine("The largest value in { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }  array is: ");
            Console.WriteLine(LargestValue(new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }));

            Console.WriteLine("A 50 value array generated from FiftyValues(): " + FiftyValues());

            Console.WriteLine("Are 'true' and 'false' the same? ");
            Console.WriteLine(SameBool(true, false));

            Console.WriteLine("The product of 5 and 6 is: ");
            Console.WriteLine(Product(5, 6));

            Console.WriteLine("The average of the values in the array { 1.564562, 2.01, 3.38, 4.94, 5.12, 6.99, 7.123, 8.324, 9.7, 10.5 } is: ");
            Console.WriteLine(Average2D(new double[,] { { 1.564562, 2.01, 3.38, 4.94, 5.12, 6.99, 7.123, 8.324, 9.7, 10.5 } }));


        }
    }

}


