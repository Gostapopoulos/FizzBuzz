class Program
{
    // The exercise was to write a console app that counts up from 1 to 100.
    // But every line where the number is evenly divisable by 3 should say "Fizz" instead of the number,
    // and where it's evenly divisable by 5 it should say "Buzz" instead.
    // If the number is both divisable by 3 and 5, the line should say "FizzBuzz".
    private static void Main(string[] args)
    {
        for (int i = 1; i <= 100; i++) // A for-loop to count from 1 to 100
        {
            string output = i.ToString(); // Save the current number into a string variable (for the output)

            if (i % 3 == 0) // Checking if the current number is evenly divisable by 3
            {
                output = "Fizz"; // If it is, change output to "Fizz" instead of current number
            } 
            
            if (i % 5 == 0) // Then also check it's divisable by 5
            {
                if (output == "Fizz") // If it is, check if previous if-statement found the current number to be divisable by 3 as well
                {
                    output += "Buzz"; // If so, concat "Buzz" to "Fizz" to form "FizzBuzz" in the output
                }
                else
                output = "Buzz"; // Otherwise just change it to "Buzz"
            } 
            
            Console.WriteLine(output); // Spit out the result of this elaborate scheme to the Console!

        }
    }
}