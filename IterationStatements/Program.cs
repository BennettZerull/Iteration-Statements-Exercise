namespace IterationStatements
{
    public class Program
    {
        // LukeWarm Section: Implement the following methods        
        // 1. Write a method that prints all numbers from 1000 down to -1000 to the console.
        //    - Method Signature: void PrintNumbers()
        public static void PrintNumbers()
        {
            for (int num = 1000; num > +-1001; num--)
            {
                Console.WriteLine(num);
            }
        }
        // 2. Write a method that prints every third number from 3 to 999 to the console.
        //    - Method Signature: void PrintEveryThirdNumber()
        public static void PrintEveryThirdNumber()
        {
            for (int num = 3; num <= 999; num +=3)
            {
                Console.WriteLine(num);
            }
        }
        // 3. Write a method that accepts two integers as parameters and checks whether they are equal.
        //    - Method Signature: bool AreNumbersEqual(int num1, int num2)
        //    - Returns true if the numbers are equal, false otherwise.
        public static void AreNumbersEqual(int num1, int num2)
        {
            if (num1 == num2)
            {
                Console.WriteLine($"True: {num1} is equal to {num2}.");
            }
            else Console.WriteLine($"False: {num1} is not equal to {num2}.");
        }
        // 4. Write a method that checks if a given number is even or odd.
        //    - Method Signature: bool IsEven(int number)
        //    - Returns true if the number is even, false if odd.
        public static void IsEven(int num)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine($"{num} is an even number");
            }
            else Console.WriteLine($"{num} is not an evan number");
        }
        // 5. Write a method that checks if a given number is positive or negative.
        //    - Method Signature: bool IsPositive(int number)
        //    - Returns true if the number is positive, false if negative.
        public static void IsPositive(int num)
        {
            if (num > 0)
            {
                Console.WriteLine($"{num} is a positive number.");
            }
            else if (num == 0)
            {
                Console.WriteLine("0 is not positive or negative.");
            }
            else Console.WriteLine($"{num} is a negative number.");
        }
        // 6. Write a method that reads the age of a candidate and determines if they are eligible to vote.
        //    - Method Signature: bool CanVote(int age)
        //    - Returns true if the candidate can vote, false otherwise.
        //    - Hint: Use `int.Parse()` or the safer `int.TryParse()` for extra practice in handling user input.
        public static void CanVote()
        {
            Console.WriteLine("Please enter your age:");
            var canParse = int.TryParse(Console.ReadLine(), out int userAge);
            while (canParse == false)
            {
                Console.WriteLine("Please enter a Valid Age:");
                canParse = int.TryParse(Console.ReadLine(), out userAge);
            }
            if (userAge >= 18)
            {
                Console.WriteLine("Congratulations, You are eligible to vote.");
            }
            else Console.WriteLine("Unfortunately, you are not eligible to vote");
        }
        // Heatin' Up Section:
        // 1. Write a method that checks if an integer (provided by the user) is within the range of -10 to 10.
        //    - Method Signature: bool IsInRange(int number)
        //    - Returns true if the number is within the range, false otherwise.
        public static void IsInRange()
        {
            Console.WriteLine("Please enter a number:");
            var canParse = int.TryParse(Console.ReadLine(), out int userNumber);
            while (canParse == false)
            {
                Console.WriteLine("Please enter a valid number:");
                canParse = int.TryParse(Console.ReadLine(), out userNumber);
            }
            if (userNumber >= -10 && userNumber <= 10)
            {
                Console.WriteLine($"{userNumber} is within range.");
            }
            else Console.WriteLine($"{userNumber} is not within rage.");
        }
        // 2. Write a method that displays the multiplication table (from 1 to 12) for a given integer.
        //    - Method Signature: void DisplayMultiplicationTable(int number)
        //    - Should print each line in the format: "1 * number = result"
        public static void DisplayMultiplicationTable()
        {
            Console.WriteLine("Please enter a number:");
            var canParse = int.TryParse(Console.ReadLine(), out int multNum);
            while (canParse == false)
            {
                Console.WriteLine("Please enter a valid number:");
                canParse = int.TryParse(Console.ReadLine(), out multNum);
            }
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{i} x {multNum} = {i * multNum}");
            }
        }
        // In the Main method below, call each of your methods to test them.
        // Use various test cases to ensure they work as expected.        
        static void Main(string[] args)
        {
            //PrintNumbers();
            //PrintEveryThirdNumber();
            //AreNumbersEqual(5, 7);
            //IsEven(18);
            //IsPositive(0);
            //CanVote();
            //IsInRange();
            DisplayMultiplicationTable();
        }
    }
}
