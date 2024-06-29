using System;

class Program
{
    static void Main(string[] args)
    {
       List<int> numbers = new List<int>();
        int number;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (true)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            if (number == 0)
            {
                break;
            }
            numbers.Add(number);
        }

        if (numbers.Count > 0)
        {
            int sum = 0;
            int largest = numbers[0];
            int smallestPositive = int.MaxValue;

            foreach (int num in numbers)
            {
                sum += num;
                if (num > largest)
                {
                    largest = num;
                }
                if (num > 0 && num < smallestPositive)
                {
                    smallestPositive = num;
                }
            }

            double average = (double)sum / numbers.Count;

            numbers.Sort();

            Console.WriteLine("The sum is: " + sum);
            Console.WriteLine("The average is: " + average);
            Console.WriteLine("The largest number is: " + largest);

            if (smallestPositive == int.MaxValue)
            {
                Console.WriteLine("There is no positive number.");
            }
            else
            {
                Console.WriteLine("The smallest positive number is: " + smallestPositive);
            }

            Console.WriteLine("The sorted list is:");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
    }
    }
}

   