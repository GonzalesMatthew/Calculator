using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plese enter comma separated integers: e.g. 2,4,5");
            string userInput = Console.ReadLine();

            Console.WriteLine("Do you want to return the product, quotient, sum, average, or return the array of squares? (Enter '*', '/', '+', 'avg', or '^'.)");
            var request = Console.ReadLine();


            // convert string of numbers to string array
            string[] stringArray = userInput.Split(',', StringSplitOptions.RemoveEmptyEntries);
            // declare int array
            int[] numbers = new int[stringArray.Length];
            // convert string array to int array
            for (int i = 0; i < stringArray.Length; i++)
            {
                numbers[i] = int.Parse(stringArray[i]);
            }

            

            switch (request.ToLower())
            {
                case "*":
                    // multiple the int array elements together:
                    int product = numbers[0];

                    for (int i = 1; i < numbers.Length; i++)
                    {
                        product = product * numbers[i];
                    }
                    Console.WriteLine($"The product of your submitted values is {product}.");
                    break;
                case "^":
                    // square each element of the int array, then build a new int array with the squared values:
                    // first, create new array to store squared values in
                    int[] squaredArray = new int[numbers.Length];

                    // next, calculate the square of each element and push them into squaredArray
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        int square = numbers[i] * numbers[i];
                        squaredArray[i] = square;
                        Console.Write("{0}, ", square);
                    }
                    Console.WriteLine();
                    Console.WriteLine($"Here are your original values squared.");
                    break;
                case "/":
                    float quotient = numbers[0];
                    for (int i = 1; i < numbers.Length; i++)
                    {
                        quotient = quotient / numbers[i];
                    }
                    Console.WriteLine($"The quotient of your array is {quotient}.");
                    break;
                case "+":
                    int sum = numbers[0];
                    for (int i =1; i < numbers.Length; i++)
                    {
                        sum += numbers[i];
                    }
                    Console.WriteLine($"The sum of your array is {sum}.");
                    break;
                case "avg":
                    int sumForAvg = numbers[0];
                    for (int i = 1; i < numbers.Length; i++)
                    {
                        sumForAvg += numbers[i];
                    }
                    float avg = sumForAvg / (numbers.Length);
                    Console.WriteLine($"The average is {avg}.");
                    break;
                default:
                    Console.WriteLine("Sorry, not a valid request.");
                    break;
            }

        }
    }
}
